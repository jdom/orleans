using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using Orleans.CodeGeneration;
using Orleans.Concurrency;
using Orleans.Runtime;

namespace Orleans.Serialization.Registration
{
    /// <summary>
    /// Discovers serializers from a list of types.
    /// </summary>
    public class OrleansSerializationFeatureProvider //: IApplicationFeatureProvider<OrleansSerializationFeature>
    {
        private readonly Logger logger;
        private static readonly string[] safeFailSerializers = { "Orleans.FSharp" };
        private HashSet<Type> registeredTypes = new HashSet<Type>();
        private List<IExternalSerializer> externalSerializers = new List<IExternalSerializer>();
        private ConcurrentDictionary<Type, IExternalSerializer> typeToExternalSerializerDictionary = new ConcurrentDictionary<Type, IExternalSerializer>();
        private Dictionary<string, Type> types = new Dictionary<string, Type>();
        private Dictionary<RuntimeTypeHandle, DeepCopier> copiers = new Dictionary<RuntimeTypeHandle, DeepCopier>();
        private Dictionary<RuntimeTypeHandle, Serializer> serializers = new Dictionary<RuntimeTypeHandle, Serializer>();
        private Dictionary<RuntimeTypeHandle, Deserializer> deserializers = new Dictionary<RuntimeTypeHandle, Deserializer>();
        private ConcurrentDictionary<Type, Func<GrainReference, GrainReference>> grainRefConstructorDictionary = new ConcurrentDictionary<Type, Func<GrainReference, GrainReference>>();
        private bool IsBuiltInSerializersRegistered;
        private readonly object registerBuiltInSerializerLockObj = new object();

        public OrleansSerializationFeatureProvider()
        {
            this.logger = LogManager.GetLogger(nameof(OrleansSerializationFeatureProvider));
        }

        ///// <inheritdoc />
        //public void PopulateFeature(IEnumerable<ApplicationPart> parts, OrleansSerializationFeature feature)
        //{
        //    PopulateFeature(parts.OfType<IApplicationPartTypeProvider>().SelectMany(part => part.Types), feature);
        //}

        /// <summary>
        /// Updates the <paramref name="feature"/> instance.
        /// </summary>
        /// <param name="types">The list of types of the application</param>
        /// <param name="feature">The feature instance to populate.</param>
        public void PopulateFeature(IEnumerable<TypeInfo> types, OrleansSerializationFeature feature)
        {
            RegisterBuiltInSerializers();

            foreach (var type in types)
            {
                FindSerializationInfo(type);
            }
        }

        /// <summary>
        /// Looks for types with marked serializer and deserializer methods, and registers them if necessary.
        /// </summary>
        internal void FindSerializationInfo(Type type)
        {
            TypeInfo typeInfo = type.GetTypeInfo();
            var assembly = typeInfo.Assembly;
            bool systemAssembly = !assembly.IsDynamic
                                  && (assembly.FullName.StartsWith("mscorlib", StringComparison.OrdinalIgnoreCase)
                                      || assembly.FullName.StartsWith("System.", StringComparison.Ordinal));
            IExternalSerializer externalSerializer;

            if (logger.IsVerbose2) logger.Verbose2("Scanning assembly {0} for serialization info", assembly.GetLocationSafe());

            try
            {
                if (typeInfo.IsEnum)
                {
                    Register(type);
                }
                else if (!systemAssembly)
                {
                    if (!typeInfo.IsInterface && !typeInfo.IsAbstract
                        && (typeInfo.Namespace == null
                            || (!typeInfo.Namespace.Equals("System", StringComparison.Ordinal)
                                && !typeInfo.Namespace.StartsWith("System.", StringComparison.Ordinal))))
                    {
                        if (typeInfo.GetCustomAttributes(typeof(RegisterSerializerAttribute), false).Any())
                        {
                            // Call the static Register method on the type
                            if (logger.IsVerbose3)
                                logger.Verbose3(
                                    "Running register method for type {0} from assembly {1}",
                                    typeInfo.Name,
                                    assembly.GetName().Name);

                            var register = typeInfo.GetMethod("Register", Type.EmptyTypes);
                            if (register != null)
                            {
                                try
                                {
                                    if (register.ContainsGenericParameters) throw new OrleansException("Type serializer '" + register.GetType().FullName + "' contains generic parameters and can not be registered. Did you mean to provide a split your type serializer into a combination of nongeneric RegisterSerializerAttribute and generic SerializableAttribute classes?");
                                    register.Invoke(null, Type.EmptyTypes);
                                }
                                catch (OrleansException ex)
                                {
                                    logger.Error(
                                        ErrorCode.SerMgr_TypeRegistrationFailure,
                                        "Failure registering type " + type.OrleansTypeName() + " from assembly "
                                        + assembly.GetLocationSafe(),
                                        ex);
                                    throw;
                                }
                                catch (Exception)
                                {
                                    // Ignore failures to load our own serializers, such as the F# ones in case F# isn't installed.
                                    if (safeFailSerializers.Contains(assembly.GetName().Name))
                                        logger.Warn(
                                            ErrorCode.SerMgr_TypeRegistrationFailureIgnore,
                                            "Failure registering type " + type.OrleansTypeName() + " from assembly "
                                            + assembly.GetLocationSafe() + ". Ignoring it.");
                                    else throw;
                                }
                            }
                            else
                            {
                                logger.Warn(
                                    ErrorCode.SerMgr_MissingRegisterMethod,
                                    "Type {0} from assembly {1} has the RegisterSerializer attribute but no public static void Register method",
                                    type.Name,
                                    assembly.GetName().Name);
                            }
                        }
                        else if (IsGeneratedGrainReference(typeInfo))
                        {
                            RegisterGrainReferenceSerializers(type);
                        }
                        else
                        {
                            MethodInfo copier;
                            MethodInfo serializer;
                            MethodInfo deserializer;
                            GetSerializationMethods(type, out copier, out serializer, out deserializer);
                            if ((serializer != null) && (deserializer != null) && (copier != null))
                            {
                                // Register type as a serializer for type.
                                Register(type, type);
                                if (logger.IsVerbose3)
                                    logger.Verbose3(
                                        "Loaded serialization info for type {0} from assembly {1}",
                                        type.Name,
                                        assembly.GetName().Name);
                            }
                            else if ((serializer != null) && (deserializer != null))
                            {
                                try
                                {
                                    Register(
                                        type,
                                        null,
                                        (Serializer)serializer.CreateDelegate(typeof(Serializer)),
                                        (Deserializer)deserializer.CreateDelegate(typeof(Deserializer)),
                                        true);
                                }
                                catch (ArgumentException)
                                {
                                    logger.Warn(
                                        ErrorCode.SerMgr_ErrorBindingMethods,
                                        "Error binding serialization methods for type {0}",
                                        type.OrleansTypeName());
                                    throw;
                                }
                                if (logger.IsVerbose3)
                                    logger.Verbose3(
                                        "Loaded serialization info for type {0} from assembly {1}",
                                        type.Name,
                                        assembly.GetName().Name);
                            }
                            else if (copier != null)
                            {
                                try
                                {
                                    Register(
                                        type,
                                        (DeepCopier)copier.CreateDelegate(typeof(DeepCopier)),
                                        null,
                                        null,
                                        true);
                                }
                                catch (ArgumentException)
                                {
                                    logger.Warn(
                                        ErrorCode.SerMgr_ErrorBindingMethods,
                                        "Error binding serialization methods for type {0}",
                                        type.OrleansTypeName());
                                    throw;
                                }
                                if (logger.IsVerbose3)
                                    logger.Verbose3(
                                        "Loaded serialization info for type {0} from assembly {1}",
                                        type.Name,
                                        assembly.GetName().Name);
                            }
                            else if (TryLookupExternalSerializer(type, out externalSerializer))
                            {
                                // the lookup registers the serializer.
                            }
                            else if (!typeInfo.IsSerializable)
                            {
                                // Comparers with no fields can be safely dealt with as just a type name
                                var comparer = false;
                                foreach (var iface in type.GetInterfaces())
                                {
                                    var ifaceTypeInfo = iface.GetTypeInfo();
                                    if (ifaceTypeInfo.IsGenericType
                                        && (ifaceTypeInfo.GetGenericTypeDefinition() == typeof(IComparer<>)
                                            || ifaceTypeInfo.GetGenericTypeDefinition() == typeof(IEqualityComparer<>)))
                                    {
                                        comparer = true;
                                        break;
                                    }
                                }
                                if (comparer && (type.GetFields().Length == 0)) Register(type);
                            }
                            else
                            {
                                Register(type);
                            }
                        }
                    }
                    else
                    {
                        // type is abstract, an interface, system-defined, or its namespace is null
                        Register(type);
                    }
                }
            }
            catch (ReflectionTypeLoadException rtle)
            {
                var sb = new StringBuilder();
                foreach (var ex in rtle.LoaderExceptions) if (ex != null) sb.AppendFormat("    Exception loading type: {0}", ex).AppendLine();

                foreach (var t in rtle.Types) if (t != null) sb.AppendFormat("    Successfully loaded type {0}", t.Name).AppendLine();

                logger.Warn(
                    ErrorCode.SerMgr_ErrorLoadingAssemblyTypes,
                    "Error loading types for assembly {0}: {1}",
                    assembly.GetName().Name,
                    sb.ToString());
            }
        }

        /// <summary>
        /// Register a Type with the serialization system to use the specified DeepCopier, Serializer and Deserializer functions.
        /// </summary>
        /// <param name="t">Type to be registered.</param>
        /// <param name="cop">DeepCopier function for this type.</param>
        /// <param name="ser">Serializer function for this type.</param>
        /// <param name="deser">Deserializer function for this type.</param>
        public void Register(Type t, DeepCopier cop, Serializer ser, Deserializer deser)
        {
            Register(t, cop, ser, deser, false);
        }

        /// <summary>
        /// Register a Type with the serialization system to use the specified DeepCopier, Serializer and Deserializer functions.
        /// If <c>forcOverride == true</c> then this definition will replace any any previous functions registered for this Type.
        /// </summary>
        /// <param name="t">Type to be registered.</param>
        /// <param name="cop">DeepCopier function for this type.</param>
        /// <param name="ser">Serializer function for this type.</param>
        /// <param name="deser">Deserializer function for this type.</param>
        /// <param name="forceOverride">Whether these functions should replace any previously registered functions for this Type.</param>
        public void Register(Type t, DeepCopier cop, Serializer ser, Deserializer deser, bool forceOverride)
        {
            if ((ser == null) && (deser != null))
            {
                throw new OrleansException("Deserializer without serializer for class " + t.OrleansTypeName());
            }
            if ((ser != null) && (deser == null))
            {
                throw new OrleansException("Serializer without deserializer for class " + t.OrleansTypeName());
            }

            lock (registeredTypes)
            {
                if (registeredTypes.Contains(t))
                {
                    if (cop != null)
                    {
                        lock (copiers)
                        {
                            DeepCopier current;
                            if (forceOverride || !copiers.TryGetValue(t.TypeHandle, out current) || (current == null))
                            {
                                copiers[t.TypeHandle] = cop;
                            }
                        }
                    }
                    if (ser != null)
                    {
                        lock (serializers)
                        {
                            Serializer currentSer;
                            if (forceOverride || !serializers.TryGetValue(t.TypeHandle, out currentSer) || (currentSer == null))
                            {
                                serializers[t.TypeHandle] = ser;
                            }
                        }
                        lock (deserializers)
                        {
                            Deserializer currentDeser;
                            if (forceOverride || !deserializers.TryGetValue(t.TypeHandle, out currentDeser) || (currentDeser == null))
                            {
                                deserializers[t.TypeHandle] = deser;
                            }
                        }
                    }
                }
                else
                {
                    registeredTypes.Add(t);
                    string name = t.OrleansTypeKeyString();
                    lock (types)
                    {
                        types[name] = t;
                    }
                    if (cop != null)
                    {
                        lock (copiers)
                        {
                            copiers[t.TypeHandle] = cop;
                        }
                    }
                    if (ser != null)
                    {
                        lock (serializers)
                        {
                            serializers[t.TypeHandle] = ser;
                        }
                    }
                    if (deser != null)
                    {
                        lock (deserializers)
                        {
                            deserializers[t.TypeHandle] = deser;
                        }
                    }

                    if (logger.IsVerbose3) logger.Verbose3("Registered type {0} as {1}", t, name);
                }
            }

            // Register any interfaces this type implements, in order to support passing values that are statically of the interface type
            // but dynamically of this (implementation) type
            foreach (var iface in t.GetInterfaces())
            {
                Register(iface);
            }
            // Do the same for abstract base classes
            var baseType = t.GetTypeInfo().BaseType;
            while (baseType != null)
            {
                var baseTypeInfo = baseType.GetTypeInfo();
                if (baseTypeInfo.IsAbstract)
                    Register(baseType);

                baseType = baseTypeInfo.BaseType;
            }
        }

        /// <summary>
        /// This method registers a type that has no specific serializer or deserializer.
        /// For instance, abstract base types and interfaces need to be registered this way.
        /// </summary>
        /// <param name="t">Type to be registered.</param>
        public void Register(Type t)
        {
            string name = t.OrleansTypeKeyString();

            lock (registeredTypes)
            {
                if (registeredTypes.Contains(t))
                {
                    return;
                }

                registeredTypes.Add(t);
                lock (types)
                {
                    types[name] = t;
                }
            }
            if (logger.IsVerbose3) logger.Verbose3("Registered type {0} as {1}", t, name);

            // Register any interfaces this type implements, in order to support passing values that are statically of the interface type
            // but dynamically of this (implementation) type
            foreach (var iface in t.GetInterfaces())
            {
                Register(iface);
            }

            // Do the same for abstract base classes
            var baseType = t.GetTypeInfo().BaseType;
            while (baseType != null)
            {
                var baseTypeInfo = baseType.GetTypeInfo();
                if (baseTypeInfo.IsAbstract)
                    Register(baseType);

                baseType = baseTypeInfo.BaseType;
            }
        }

        /// <summary>
        /// Registers <paramref name="serializerType"/> as the serializer for <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type serialized by the provided serializer type.</param>
        /// <param name="serializerType">The type containing serialization methods for <paramref name="type"/>.</param>
        public void Register(Type type, Type serializerType)
        {
            try
            {
                if (type.GetTypeInfo().IsGenericTypeDefinition)
                {
                    Register(
                        type,
                        obj =>
                        {
                            var concrete = RegisterConcreteSerializer(obj.GetType(), serializerType);
                            return concrete.DeepCopy(obj);
                        },
                        (obj, stream, exp) =>
                        {
                            var concrete = RegisterConcreteSerializer(obj.GetType(), serializerType);
                            concrete.Serialize(obj, stream, exp);
                        },
                        (expected, stream) =>
                        {
                            var concrete = RegisterConcreteSerializer(expected, serializerType);
                            return concrete.Deserialize(expected, stream);
                        },
                        true);
                }
                else
                {
                    MethodInfo copier;
                    MethodInfo serializer;
                    MethodInfo deserializer;
                    GetSerializationMethods(serializerType, out copier, out serializer, out deserializer);
                    Register(
                        type,
                        (DeepCopier)copier.CreateDelegate(typeof(DeepCopier)),
                        (Serializer)serializer.CreateDelegate(typeof(Serializer)),
                        (Deserializer)deserializer.CreateDelegate(typeof(Deserializer)),
                        true);
                }
            }
            catch (ArgumentException)
            {
                logger.Warn(
                    ErrorCode.SerMgr_ErrorBindingMethods,
                    "Error binding serialization methods for type {0}",
                    type.OrleansTypeName());
                throw;
            }
        }

        private SerializerMethods RegisterConcreteSerializer(Type concreteType, Type genericSerializerType)
        {
            MethodInfo copier;
            MethodInfo serializer;
            MethodInfo deserializer;

            var concreteSerializerType = genericSerializerType.MakeGenericType(concreteType.GetGenericArguments());
            var typeAlreadyRegistered = false;

            lock (registeredTypes)
            {
                typeAlreadyRegistered = registeredTypes.Contains(concreteSerializerType);
            }

            if (typeAlreadyRegistered)
            {
                return new SerializerMethods(
                    GetCopier(concreteSerializerType),
                    GetSerializer(concreteSerializerType),
                    GetDeserializer(concreteSerializerType));
            }

            GetSerializationMethods(concreteSerializerType, out copier, out serializer, out deserializer);
            var concreteCopier = (DeepCopier)copier.CreateDelegate(typeof(DeepCopier));
            var concreteSerializer = (Serializer)serializer.CreateDelegate(typeof(Serializer));
            var concreteDeserializer = (Deserializer)deserializer.CreateDelegate(typeof(Deserializer));
            Register(concreteType, concreteCopier, concreteSerializer, concreteDeserializer, true);

            return new SerializerMethods(concreteCopier, concreteSerializer, concreteDeserializer);
        }

        private static void GetSerializationMethods(Type type, out MethodInfo copier, out MethodInfo serializer, out MethodInfo deserializer)
        {
            copier = null;
            serializer = null;
            deserializer = null;
            foreach (var method in type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
                if (method.GetCustomAttributes(typeof(CopierMethodAttribute), true).Any())
                {
                    copier = method;
                }
                else if (method.GetCustomAttributes(typeof(SerializerMethodAttribute), true).Any())
                {
                    serializer = method;
                }
                else if (method.GetCustomAttributes(typeof(DeserializerMethodAttribute), true).Any())
                {
                    deserializer = method;
                }
            }
        }

        internal DeepCopier GetCopier(Type t)
        {
            lock (copiers)
            {
                DeepCopier copier;
                if (copiers.TryGetValue(t.TypeHandle, out copier))
                    return copier;

                var typeInfo = t.GetTypeInfo();
                if (typeInfo.IsGenericType && copiers.TryGetValue(typeInfo.GetGenericTypeDefinition().TypeHandle, out copier))
                    return copier;
            }

            return null;
        }

        internal Deserializer GetDeserializer(Type t)
        {
            Deserializer deser;

            lock (deserializers)
            {
                if (deserializers.TryGetValue(t.TypeHandle, out deser))
                    return deser;
            }

            if (t.GetTypeInfo().IsGenericType)
            {
                lock (deserializers)
                {
                    if (deserializers.TryGetValue(t.GetGenericTypeDefinition().TypeHandle, out deser))
                        return deser;
                }
            }

            return null;
        }

        internal Serializer GetSerializer(Type t)
        {
            lock (serializers)
            {
                Serializer ser;
                if (serializers.TryGetValue(t.TypeHandle, out ser))
                    return ser;

                var typeInfo = t.GetTypeInfo();
                if (typeInfo.IsGenericType)
                    if (serializers.TryGetValue(typeInfo.GetGenericTypeDefinition().TypeHandle, out ser))
                        return ser;
            }

            return null;
        }

        /// <summary>
        /// Returns <see langword="true"/> if the type is a generated <see cref="GrainReference"/>,
        /// <see langword="false"/> otherwise.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if the type is a generated <see cref="GrainReference"/>,
        /// <see langword="false"/> otherwise.
        /// </returns>
        internal static bool IsGeneratedGrainReference(MemberInfo type)
        {
            var attr = type.GetCustomAttribute<GrainReferenceAttribute>();
            return attr?.TargetType != null;
        }

        /// <summary>
        /// Registers <see cref="GrainReference"/> serializers for the provided <paramref name="type"/>.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        private void RegisterGrainReferenceSerializers(Type type)
        {
            var attr = type.GetTypeInfo().GetCustomAttribute<GrainReferenceAttribute>();
            if (attr?.TargetType == null)
            {
                return;
            }

            var defaultCtorDelegate = CreateGrainRefConstructorDelegate(type, null);

            // Register GrainReference serialization methods.
            Register(
                type,
                GrainReference.CopyGrainReference,
                GrainReference.SerializeGrainReference,
                (expected, stream) =>
                {
                    Func<GrainReference, GrainReference> ctorDelegate;
                    var deserialized = (GrainReference)GrainReference.DeserializeGrainReference(expected, stream);
                    if (expected.IsConstructedGenericType == false)
                    {
                        return defaultCtorDelegate(deserialized);
                    }

                    if (!grainRefConstructorDictionary.TryGetValue(expected, out ctorDelegate))
                    {
                        ctorDelegate = CreateGrainRefConstructorDelegate(type, expected.GenericTypeArguments);
                        grainRefConstructorDictionary.TryAdd(expected, ctorDelegate);
                    }

                    return ctorDelegate(deserialized);
                });
        }

        private static Func<GrainReference, GrainReference> CreateGrainRefConstructorDelegate(Type type, Type[] genericArgs)
        {
            TypeInfo typeInfo = type.GetTypeInfo();
            if (typeInfo.IsGenericType)
            {
                if (type.IsConstructedGenericType == false && genericArgs == null)
                {
                    return null;
                }

                type = type.MakeGenericType(genericArgs);
            }

            var constructor = TypeUtils.GetConstructorThatMatches(type, new[] { typeof(GrainReference) });
            var method = new DynamicMethod(
                ".ctor_" + type.Name,
                typeof(GrainReference),
                new[] { typeof(GrainReference) },
                typeof(SerializationManager).GetTypeInfo().Module,
                true);
            var il = method.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Newobj, constructor);
            il.Emit(OpCodes.Ret);
            return
                (Func<GrainReference, GrainReference>)
                method.CreateDelegate(typeof(Func<GrainReference, GrainReference>));
        }

        private bool TryLookupExternalSerializer(Type t, out IExternalSerializer serializer)
        {
            // essentially a no-op if there are no external serializers registered
            if (externalSerializers.Count == 0)
            {
                serializer = null;
                return false;
            }

            // the associated serializer will be null if there are no external serializers that handle this type
            if (typeToExternalSerializerDictionary.TryGetValue(t, out serializer))
            {
                return serializer != null;
            }

            serializer = externalSerializers.FirstOrDefault(s => s.IsSupportedType(t));

            // add the serializer to the dictionary, even if it's null to signify that we already performed
            // the search and found none
            if (typeToExternalSerializerDictionary.TryAdd(t, serializer) && serializer != null)
            {
                // we need to register the type, otherwise exceptions are thrown about types not being found
                Register(t, serializer.DeepCopy, serializer.Serialize, serializer.Deserialize, true);
            }

            return serializer != null;
        }

        internal void RegisterBuiltInSerializers()
        {
            lock (registerBuiltInSerializerLockObj)
            {
                if (IsBuiltInSerializersRegistered)
                {
                    return;
                }

                IsBuiltInSerializersRegistered = true;
            }

            // Built-in handlers: Tuples
            Register(typeof(Tuple<>), BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple);
            Register(typeof(Tuple<,>), BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple);
            Register(typeof(Tuple<,,>), BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple);
            Register(typeof(Tuple<,,,>), BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple);
            Register(typeof(Tuple<,,,,>), BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple);
            Register(typeof(Tuple<,,,,,>), BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple);

            // Built-in handlers: enumerables
            Register(typeof(List<>), BuiltInTypes.CopyGenericList, BuiltInTypes.SerializeGenericList, BuiltInTypes.DeserializeGenericList);
            Register(typeof(ReadOnlyCollection<>), BuiltInTypes.CopyGenericReadOnlyCollection, BuiltInTypes.SerializeGenericReadOnlyCollection, BuiltInTypes.DeserializeGenericReadOnlyCollection);
            Register(typeof(LinkedList<>), BuiltInTypes.CopyGenericLinkedList, BuiltInTypes.SerializeGenericLinkedList, BuiltInTypes.DeserializeGenericLinkedList);
            Register(typeof(HashSet<>), BuiltInTypes.CopyGenericHashSet, BuiltInTypes.SerializeGenericHashSet, BuiltInTypes.DeserializeGenericHashSet);
            Register(typeof(SortedSet<>), BuiltInTypes.CopyGenericSortedSet, BuiltInTypes.SerializeGenericSortedSet, BuiltInTypes.DeserializeGenericSortedSet);
            Register(typeof(Stack<>), BuiltInTypes.CopyGenericStack, BuiltInTypes.SerializeGenericStack, BuiltInTypes.DeserializeGenericStack);
            Register(typeof(Queue<>), BuiltInTypes.CopyGenericQueue, BuiltInTypes.SerializeGenericQueue, BuiltInTypes.DeserializeGenericQueue);

            // Built-in handlers: dictionaries
            Register(typeof(ReadOnlyDictionary<,>), BuiltInTypes.CopyGenericReadOnlyDictionary, BuiltInTypes.SerializeGenericReadOnlyDictionary, BuiltInTypes.DeserializeGenericReadOnlyDictionary);
            Register(typeof(Dictionary<,>), BuiltInTypes.CopyGenericDictionary, BuiltInTypes.SerializeGenericDictionary, BuiltInTypes.DeserializeGenericDictionary);
            Register(typeof(Dictionary<string, object>), BuiltInTypes.CopyStringObjectDictionary, BuiltInTypes.SerializeStringObjectDictionary, BuiltInTypes.DeserializeStringObjectDictionary);
            Register(typeof(SortedDictionary<,>), BuiltInTypes.CopyGenericSortedDictionary, BuiltInTypes.SerializeGenericSortedDictionary,
                     BuiltInTypes.DeserializeGenericSortedDictionary);
            Register(typeof(SortedList<,>), BuiltInTypes.CopyGenericSortedList, BuiltInTypes.SerializeGenericSortedList, BuiltInTypes.DeserializeGenericSortedList);

            // Built-in handlers: key-value pairs
            Register(typeof(KeyValuePair<,>), BuiltInTypes.CopyGenericKeyValuePair, BuiltInTypes.SerializeGenericKeyValuePair, BuiltInTypes.DeserializeGenericKeyValuePair);

            // Built-in handlers: nullables
            Register(typeof(Nullable<>), BuiltInTypes.CopyGenericNullable, BuiltInTypes.SerializeGenericNullable, BuiltInTypes.DeserializeGenericNullable);

            // Built-in handlers: Immutables
            Register(typeof(Immutable<>), BuiltInTypes.CopyGenericImmutable, BuiltInTypes.SerializeGenericImmutable, BuiltInTypes.DeserializeGenericImmutable);

            // Built-in handlers: Immutable collections
            Register(typeof(ImmutableQueue<>), BuiltInTypes.CopyGenericImmutableQueue, BuiltInTypes.SerializeGenericImmutableQueue, BuiltInTypes.DeserializeGenericImmutableQueue);
            Register(typeof(ImmutableArray<>), BuiltInTypes.CopyGenericImmutableArray, BuiltInTypes.SerializeGenericImmutableArray, BuiltInTypes.DeserializeGenericImmutableArray);
            Register(typeof(ImmutableSortedDictionary<,>), BuiltInTypes.CopyGenericImmutableSortedDictionary, BuiltInTypes.SerializeGenericImmutableSortedDictionary, BuiltInTypes.DeserializeGenericImmutableSortedDictionary);
            Register(typeof(ImmutableSortedSet<>), BuiltInTypes.CopyGenericImmutableSortedSet, BuiltInTypes.SerializeGenericImmutableSortedSet, BuiltInTypes.DeserializeGenericImmutableSortedSet);
            Register(typeof(ImmutableHashSet<>), BuiltInTypes.CopyGenericImmutableHashSet, BuiltInTypes.SerializeGenericImmutableHashSet, BuiltInTypes.DeserializeGenericImmutableHashSet);
            Register(typeof(ImmutableDictionary<,>), BuiltInTypes.CopyGenericImmutableDictionary, BuiltInTypes.SerializeGenericImmutableDictionary, BuiltInTypes.DeserializeGenericImmutableDictionary);
            Register(typeof(ImmutableList<>), BuiltInTypes.CopyGenericImmutableList, BuiltInTypes.SerializeGenericImmutableList, BuiltInTypes.DeserializeGenericImmutableList);

            // Built-in handlers: random system types
            Register(typeof(TimeSpan), BuiltInTypes.CopyTimeSpan, BuiltInTypes.SerializeTimeSpan, BuiltInTypes.DeserializeTimeSpan);
            Register(typeof(DateTimeOffset), BuiltInTypes.CopyDateTimeOffset, BuiltInTypes.SerializeDateTimeOffset, BuiltInTypes.DeserializeDateTimeOffset);
            Register(typeof(Type), BuiltInTypes.CopyType, BuiltInTypes.SerializeType, BuiltInTypes.DeserializeType);
            // ReSharper disable PossibleMistakenCallToGetType.2
            // RuntimeType is internal but can be obtained indirectly by calling GetType().
            Register(typeof(object).GetType(), BuiltInTypes.CopyType, BuiltInTypes.SerializeType, BuiltInTypes.DeserializeType);
            // ReSharper restore PossibleMistakenCallToGetType.2
            Register(typeof(Guid), BuiltInTypes.CopyGuid, BuiltInTypes.SerializeGuid, BuiltInTypes.DeserializeGuid);
            Register(typeof(IPAddress), BuiltInTypes.CopyIPAddress, BuiltInTypes.SerializeIPAddress, BuiltInTypes.DeserializeIPAddress);
            Register(typeof(IPEndPoint), BuiltInTypes.CopyIPEndPoint, BuiltInTypes.SerializeIPEndPoint, BuiltInTypes.DeserializeIPEndPoint);
            Register(typeof(Uri), BuiltInTypes.CopyUri, BuiltInTypes.SerializeUri, BuiltInTypes.DeserializeUri);

            // Built-in handlers: Orleans internal types
            Register(typeof(InvokeMethodRequest), BuiltInTypes.CopyInvokeMethodRequest, BuiltInTypes.SerializeInvokeMethodRequest,
                     BuiltInTypes.DeserializeInvokeMethodRequest);
            Register(typeof(Response), BuiltInTypes.CopyOrleansResponse, BuiltInTypes.SerializeOrleansResponse,
                     BuiltInTypes.DeserializeOrleansResponse);
            Register(typeof(ActivationId), BuiltInTypes.CopyActivationId, BuiltInTypes.SerializeActivationId, BuiltInTypes.DeserializeActivationId);
            Register(typeof(GrainId), BuiltInTypes.CopyGrainId, BuiltInTypes.SerializeGrainId, BuiltInTypes.DeserializeGrainId);
            Register(typeof(ActivationAddress), BuiltInTypes.CopyActivationAddress, BuiltInTypes.SerializeActivationAddress, BuiltInTypes.DeserializeActivationAddress);
            Register(typeof(CorrelationId), BuiltInTypes.CopyCorrelationId, BuiltInTypes.SerializeCorrelationId, BuiltInTypes.DeserializeCorrelationId);
            Register(typeof(SiloAddress), BuiltInTypes.CopySiloAddress, BuiltInTypes.SerializeSiloAddress, BuiltInTypes.DeserializeSiloAddress);

            // Type names that we need to recognize for generic parameters
            Register(typeof(bool));
            Register(typeof(int));
            Register(typeof(short));
            Register(typeof(sbyte));
            Register(typeof(long));
            Register(typeof(uint));
            Register(typeof(ushort));
            Register(typeof(byte));
            Register(typeof(ulong));
            Register(typeof(float));
            Register(typeof(double));
            Register(typeof(decimal));
            Register(typeof(string));
            Register(typeof(char));
            Register(typeof(DateTime));
            Register(typeof(TimeSpan));
            Register(typeof(object));
            Register(typeof(IPAddress));
            Register(typeof(IPEndPoint));
            Register(typeof(Guid));

            Register(typeof(GrainId));
            Register(typeof(ActivationId));
            Register(typeof(SiloAddress));
            Register(typeof(ActivationAddress));
            Register(typeof(CorrelationId));
            Register(typeof(InvokeMethodRequest));
            Register(typeof(Response));

            Register(typeof(IList<>));
            Register(typeof(IDictionary<,>));
            Register(typeof(IEnumerable<>));

            // Enum names we need to recognize
            Register(typeof(Message.Categories));
            Register(typeof(Message.Directions));
            Register(typeof(Message.RejectionTypes));
            Register(typeof(Message.ResponseTypes));
        }
    }
}