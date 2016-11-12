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
        private List<IExternalSerializer> externalSerializers = new List<IExternalSerializer>();
        private ConcurrentDictionary<Type, IExternalSerializer> typeToExternalSerializerDictionary = new ConcurrentDictionary<Type, IExternalSerializer>();
        private ConcurrentDictionary<Type, Func<GrainReference, GrainReference>> grainRefConstructorDictionary = new ConcurrentDictionary<Type, Func<GrainReference, GrainReference>>();

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
            foreach (var type in types)
            {
                FindSerializationInfo(type, feature);
            }
        }

        /// <summary>
        /// Looks for types with marked serializer and deserializer methods, and registers them if necessary.
        /// </summary>
        internal void FindSerializationInfo(Type type, OrleansSerializationFeature feature)
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
                    RegisterFriendlyNames(type, feature);
                }
                else if (!systemAssembly)
                {
                    if (!typeInfo.IsInterface && !typeInfo.IsAbstract
                        && (typeInfo.Namespace == null
                            || (!typeInfo.Namespace.Equals("System", StringComparison.Ordinal)
                                && !typeInfo.Namespace.StartsWith("System.", StringComparison.Ordinal))))
                    {
                        var serializerAttribute = typeInfo.GetCustomAttribute<SerializerAttribute>(false);
                        if (serializerAttribute != null)
                        {
                            // Register as the serializer for the target type.
                            Register(serializerAttribute.TargetType, typeInfo, feature);
                            if (logger.IsVerbose3)
                                logger.Verbose3(
                                    "Loaded serialization info for type {0} using serializer {1} from assembly {2}",
                                    serializerAttribute.TargetType.Name,
                                    type.Name,
                                    assembly.GetName().Name);
                        }
                        else if (typeInfo.GetCustomAttributes(typeof(RegisterSerializerAttribute), false).Any())
                        {
                            // Call the static Register method on the type
                            if (logger.IsVerbose3)
                                logger.Verbose3(
                                    "Running register method for type {0} from assembly {1}",
                                    typeInfo.Name,
                                    assembly.GetName().Name);

                            var getSerializerRegistrations = typeInfo.GetMethod("GetSerializerRegistrations", Type.EmptyTypes);
                            MethodInfo register; // temporary until codegen is fixed
                            if (getSerializerRegistrations != null)
                            {
                                try
                                {
                                    if (getSerializerRegistrations.ContainsGenericParameters) throw new OrleansException($"Type serializer '{ getSerializerRegistrations.GetType().FullName}' contains generic parameters and can not be registered. Did you mean to provide a split your type serializer into a combination of nongeneric RegisterSerializerAttribute and generic SerializableAttribute classes?");
                                    var registrations = (IEnumerable<KeyValuePair<Type, SerializerMethods>>)getSerializerRegistrations.Invoke(null, Type.EmptyTypes);
                                    foreach (var registration in registrations)
                                    {
                                        Register(registration.Key, registration.Value, feature, false);
                                    }
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
                            //else if ((register = typeInfo.GetMethod("Register", Type.EmptyTypes)) != null)
                            //{
                            //    // TODO: REMOVE THIS!
                            //    try
                            //    {
                            //        if (register.ContainsGenericParameters) throw new OrleansException("Type serializer '" + register.GetType().FullName + "' contains generic parameters and can not be registered. Did you mean to provide a split your type serializer into a combination of nongeneric RegisterSerializerAttribute and generic SerializableAttribute classes?");
                            //        register.Invoke(null, Type.EmptyTypes);
                            //    }
                            //    catch (OrleansException ex)
                            //    {
                            //        logger.Error(
                            //            ErrorCode.SerMgr_TypeRegistrationFailure,
                            //            "Failure registering type " + type.OrleansTypeName() + " from assembly "
                            //            + assembly.GetLocationSafe(),
                            //            ex);
                            //        throw;
                            //    }
                            //    catch (Exception)
                            //    {
                            //        // Ignore failures to load our own serializers, such as the F# ones in case F# isn't installed.
                            //        if (safeFailSerializers.Contains(assembly.GetName().Name))
                            //            logger.Warn(
                            //                ErrorCode.SerMgr_TypeRegistrationFailureIgnore,
                            //                "Failure registering type " + type.OrleansTypeName() + " from assembly "
                            //                + assembly.GetLocationSafe() + ". Ignoring it.");
                            //        else throw;
                            //    }
                            //}
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
                            RegisterGrainReferenceSerializers(type, feature);
                        }
                        else
                        {
                            SerializerMethods serializerMethods = GetSerializerMethods(type);
                            if ((serializerMethods.DeepCopy != null) && (serializerMethods.Serialize != null) && (serializerMethods.Deserialize != null))
                            {
                                // Register type as a serializer for type.
                                Register(type, typeInfo, feature);
                                if (logger.IsVerbose3)
                                    logger.Verbose3(
                                        "Loaded serialization info for type {0} from assembly {1}",
                                        type.Name,
                                        assembly.GetName().Name);
                            }
                            else if ((serializerMethods.Serialize != null) && (serializerMethods.Deserialize != null))
                            {
                                try
                                {
                                    Register(type, serializerMethods, feature, true);
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
                            else if ((serializerMethods.DeepCopy != null))
                            {
                                try
                                {
                                    Register(
                                        type,
                                        new SerializerMethods(serializerMethods.DeepCopy, null, null), // just in case either serializer or deserializer is set (but not both)
                                        feature,
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
                            else if (TryLookupExternalSerializer(type, out externalSerializer, feature))
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
                                if (comparer && (type.GetFields().Length == 0)) RegisterFriendlyNames(type, feature);
                            }
                            else
                            {
                                RegisterFriendlyNames(type, feature);
                            }
                        }
                    }
                    else
                    {
                        // type is abstract, an interface, system-defined, or its namespace is null
                        RegisterFriendlyNames(type, feature);
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
        /// <param name="type">Type to be registered.</param>
        /// <param name="cop">DeepCopier function for this type.</param>
        /// <param name="ser">Serializer function for this type.</param>
        /// <param name="deser">Deserializer function for this type.</param>
        public void Register(Type type, DeepCopier cop, Serializer ser, Deserializer deser, OrleansSerializationFeature feature)
        {
            Register(type, cop, ser, deser, feature, false);
        }

        /// <summary>
        /// Register a Type with the serialization system to use the specified DeepCopier, Serializer and Deserializer functions.
        /// If <c>forcOverride == true</c> then this definition will replace any any previous functions registered for this Type.
        /// </summary>
        /// <param name="type">Type to be registered.</param>
        /// <param name="cop">DeepCopier function for this type.</param>
        /// <param name="ser">Serializer function for this type.</param>
        /// <param name="deser">Deserializer function for this type.</param>
        /// <param name="forceOverride">Whether these functions should replace any previously registered functions for this Type.</param>
        public void Register(Type type, DeepCopier cop, Serializer ser, Deserializer deser, OrleansSerializationFeature feature, bool forceOverride)
        {
            Register(type, new SerializerMethods(cop, ser, deser), feature, forceOverride);
        }

        /// <summary>
        /// Register a Type with the serialization system to use the specified DeepCopier, Serializer and Deserializer functions.
        /// If <c>forcOverride == true</c> then this definition will replace any any previous functions registered for this Type.
        /// </summary>
        /// <param name="type">Type to be registered.</param>
        /// <param name="serializerMethods">Serializer and copier methods for this type.</param>
        /// <param name="forceOverride">Whether these functions should replace any previously registered functions for this Type.</param>
        public void Register(Type type, SerializerMethods serializerMethods, OrleansSerializationFeature feature, bool forceOverride)
        {
            if ((serializerMethods.Serialize == null) && (serializerMethods.Deserialize != null))
            {
                throw new OrleansException("Deserializer without serializer for class " + type.OrleansTypeName());
            }
            if ((serializerMethods.Serialize != null) && (serializerMethods.Deserialize == null))
            {
                throw new OrleansException("Serializer without deserializer for class " + type.OrleansTypeName());
            }

            SerializerMethods oldSerializerMethods;
            if (feature.SerializerMethods.TryGetValue(type, out oldSerializerMethods))
            {
                if (!forceOverride)
                {
                    return;
                }

                serializerMethods = new SerializerMethods(
                    serializerMethods.DeepCopy ?? oldSerializerMethods.DeepCopy,
                    serializerMethods.Serialize ?? oldSerializerMethods.Serialize,
                    serializerMethods.Deserialize ?? oldSerializerMethods.Deserialize);
            }

            feature.SerializerMethods[type] = serializerMethods;
            RegisterFriendlyNames(type, feature);
            if (logger.IsVerbose3) logger.Verbose3("Registered type {0} as {1}", type, type.OrleansTypeKeyString());
        }

        /// <summary>
        /// Registers <paramref name="serializerType"/> as the serializer for <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type serialized by the provided serializer type.</param>
        /// <param name="serializerType">The type containing serialization methods for <paramref name="type"/>.</param>
        /// <param name="feature">The feature instance to populate.</param>
        public void Register(Type type, TypeInfo serializerType, OrleansSerializationFeature feature)
        {
            feature.SerializerTypes[type] = serializerType;
            RegisterFriendlyNames(type, feature);
        }

        private static void RegisterFriendlyNames(Type type, OrleansSerializationFeature feature)
        {
            string name = type.OrleansTypeKeyString();
            if (!feature.FriendlyNameMap.ContainsKey(name))
            {
                feature.FriendlyNameMap[name] = type;

                // Register any interfaces this type implements, in order to support passing values that are statically of the interface type
                // but dynamically of this (implementation) type
                foreach (var iface in type.GetInterfaces())
                {
                    RegisterFriendlyNames(iface, feature);
                }
                // Do the same for abstract base classes
                var baseType = type.GetTypeInfo().BaseType;
                while (baseType != null)
                {
                    var baseTypeInfo = baseType.GetTypeInfo();
                    if (baseTypeInfo.IsAbstract)
                    {
                        RegisterFriendlyNames(baseType, feature);
                    }

                    baseType = baseTypeInfo.BaseType;
                }
            }
        }

        private static SerializerMethods GetSerializerMethods(Type type)
        {
            MethodInfo copier = null;
            MethodInfo serializer = null;
            MethodInfo deserializer = null;
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

                if (copier != null && serializer != null && deserializer != null) break;
            }

            return new SerializerMethods(
                (DeepCopier)copier?.CreateDelegate(typeof(DeepCopier)),
                (Serializer)serializer?.CreateDelegate(typeof(Serializer)),
                (Deserializer)deserializer?.CreateDelegate(typeof(Deserializer)));
        }

        internal SerializerMethods FindExistingSerializerMethods(Type type, OrleansSerializationFeature feature)
        {
            // TODO: this was using RuntimeTypeHandle, is it equivalent?
            SerializerMethods serializerMethods;
            if (feature.SerializerMethods.TryGetValue(type, out serializerMethods))
                return serializerMethods;

            var typeInfo = type.GetTypeInfo();
            if (typeInfo.IsGenericType)
                if (feature.SerializerMethods.TryGetValue(typeInfo.GetGenericTypeDefinition(), out serializerMethods))
                    return serializerMethods;

            return default(SerializerMethods);
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
        private void RegisterGrainReferenceSerializers(Type type, OrleansSerializationFeature feature)
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
                },
                feature);
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

        private bool TryLookupExternalSerializer(Type t, out IExternalSerializer serializer, OrleansSerializationFeature feature)
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
                Register(t, serializer.DeepCopy, serializer.Serialize, serializer.Deserialize, feature, true);
            }

            return serializer != null;
        }
    }

    [RegisterSerializer]
    internal class BuiltInSerializers
    {
        public static IEnumerable<KeyValuePair<Type, SerializerMethods>> GetSerializerRegistrations()
        {
            return new[]
            {
                // Built-in handlers: Tuples
                new KeyValuePair<Type, SerializerMethods>(typeof(Tuple<>), new SerializerMethods(BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Tuple<,>), new SerializerMethods(BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Tuple<,,>), new SerializerMethods(BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Tuple<,,,>), new SerializerMethods(BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Tuple<,,,,>), new SerializerMethods(BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Tuple<,,,,,>), new SerializerMethods(BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Tuple<,,,,,,>), new SerializerMethods(BuiltInTypes.DeepCopyTuple, BuiltInTypes.SerializeTuple, BuiltInTypes.DeserializeTuple)),

                // Built-in handlers: enumerables
                new KeyValuePair<Type, SerializerMethods>(typeof(List<>), new SerializerMethods(BuiltInTypes.CopyGenericList, BuiltInTypes.SerializeGenericList, BuiltInTypes.DeserializeGenericList)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ReadOnlyCollection<>), new SerializerMethods(BuiltInTypes.CopyGenericReadOnlyCollection, BuiltInTypes.SerializeGenericReadOnlyCollection, BuiltInTypes.DeserializeGenericReadOnlyCollection)),
                new KeyValuePair<Type, SerializerMethods>(typeof(LinkedList<>), new SerializerMethods(BuiltInTypes.CopyGenericLinkedList, BuiltInTypes.SerializeGenericLinkedList, BuiltInTypes.DeserializeGenericLinkedList)),
                new KeyValuePair<Type, SerializerMethods>(typeof(HashSet<>), new SerializerMethods(BuiltInTypes.CopyGenericHashSet, BuiltInTypes.SerializeGenericHashSet, BuiltInTypes.DeserializeGenericHashSet)),
                new KeyValuePair<Type, SerializerMethods>(typeof(SortedSet<>), new SerializerMethods(BuiltInTypes.CopyGenericSortedSet, BuiltInTypes.SerializeGenericSortedSet, BuiltInTypes.DeserializeGenericSortedSet)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Stack<>), new SerializerMethods(BuiltInTypes.CopyGenericStack, BuiltInTypes.SerializeGenericStack, BuiltInTypes.DeserializeGenericStack)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Queue<>), new SerializerMethods(BuiltInTypes.CopyGenericQueue, BuiltInTypes.SerializeGenericQueue, BuiltInTypes.DeserializeGenericQueue)),

                // Built-in handlers: dictionaries
                new KeyValuePair<Type, SerializerMethods>(typeof(ReadOnlyDictionary<,>), new SerializerMethods(BuiltInTypes.CopyGenericReadOnlyDictionary, BuiltInTypes.SerializeGenericReadOnlyDictionary, BuiltInTypes.DeserializeGenericReadOnlyDictionary)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Dictionary<,>), new SerializerMethods(BuiltInTypes.CopyGenericDictionary, BuiltInTypes.SerializeGenericDictionary, BuiltInTypes.DeserializeGenericDictionary)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Dictionary<string, object>), new SerializerMethods(BuiltInTypes.CopyStringObjectDictionary, BuiltInTypes.SerializeStringObjectDictionary, BuiltInTypes.DeserializeStringObjectDictionary)),
                new KeyValuePair<Type, SerializerMethods>(typeof(SortedDictionary<,>), new SerializerMethods(BuiltInTypes.CopyGenericSortedDictionary, BuiltInTypes.SerializeGenericSortedDictionary, BuiltInTypes.DeserializeGenericSortedDictionary)),
                new KeyValuePair<Type, SerializerMethods>(typeof(SortedList<,>), new SerializerMethods(BuiltInTypes.CopyGenericSortedList, BuiltInTypes.SerializeGenericSortedList, BuiltInTypes.DeserializeGenericSortedList)),

                // Built-in handlers: key-value pairs
                new KeyValuePair<Type, SerializerMethods>(typeof(KeyValuePair<,>), new SerializerMethods(BuiltInTypes.CopyGenericKeyValuePair, BuiltInTypes.SerializeGenericKeyValuePair, BuiltInTypes.DeserializeGenericKeyValuePair)),

                // Built-in handlers: nullables
                new KeyValuePair<Type, SerializerMethods>(typeof(Nullable<>), new SerializerMethods(BuiltInTypes.CopyGenericNullable, BuiltInTypes.SerializeGenericNullable, BuiltInTypes.DeserializeGenericNullable)),

                // Built-in handlers: Immutables
                new KeyValuePair<Type, SerializerMethods>(typeof(Immutable<>), new SerializerMethods(BuiltInTypes.CopyGenericImmutable, BuiltInTypes.SerializeGenericImmutable, BuiltInTypes.DeserializeGenericImmutable)),

                // Built-in handlers: Immutable collections
                new KeyValuePair<Type, SerializerMethods>(typeof(ImmutableQueue<>), new SerializerMethods(BuiltInTypes.CopyGenericImmutableQueue, BuiltInTypes.SerializeGenericImmutableQueue, BuiltInTypes.DeserializeGenericImmutableQueue)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ImmutableArray<>), new SerializerMethods(BuiltInTypes.CopyGenericImmutableArray, BuiltInTypes.SerializeGenericImmutableArray, BuiltInTypes.DeserializeGenericImmutableArray)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ImmutableSortedDictionary<,>), new SerializerMethods(BuiltInTypes.CopyGenericImmutableSortedDictionary, BuiltInTypes.SerializeGenericImmutableSortedDictionary, BuiltInTypes.DeserializeGenericImmutableSortedDictionary)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ImmutableSortedSet<>), new SerializerMethods(BuiltInTypes.CopyGenericImmutableSortedSet, BuiltInTypes.SerializeGenericImmutableSortedSet, BuiltInTypes.DeserializeGenericImmutableSortedSet)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ImmutableHashSet<>), new SerializerMethods(BuiltInTypes.CopyGenericImmutableHashSet, BuiltInTypes.SerializeGenericImmutableHashSet, BuiltInTypes.DeserializeGenericImmutableHashSet)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ImmutableDictionary<,>), new SerializerMethods(BuiltInTypes.CopyGenericImmutableDictionary, BuiltInTypes.SerializeGenericImmutableDictionary, BuiltInTypes.DeserializeGenericImmutableDictionary)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ImmutableList<>), new SerializerMethods(BuiltInTypes.CopyGenericImmutableList, BuiltInTypes.SerializeGenericImmutableList, BuiltInTypes.DeserializeGenericImmutableList)),

                // Built-in handlers: random system types
                new KeyValuePair<Type, SerializerMethods>(typeof(TimeSpan), new SerializerMethods(BuiltInTypes.CopyTimeSpan, BuiltInTypes.SerializeTimeSpan, BuiltInTypes.DeserializeTimeSpan)),
                new KeyValuePair<Type, SerializerMethods>(typeof(DateTimeOffset), new SerializerMethods(BuiltInTypes.CopyDateTimeOffset, BuiltInTypes.SerializeDateTimeOffset, BuiltInTypes.DeserializeDateTimeOffset)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Type), new SerializerMethods(BuiltInTypes.CopyType, BuiltInTypes.SerializeType, BuiltInTypes.DeserializeType)),
                // ReSharper disable PossibleMistakenCallToGetType.2
                // RuntimeType is internal but can be obtained indirectly by calling GetType().
                new KeyValuePair<Type, SerializerMethods>(typeof(object).GetType(), new SerializerMethods(BuiltInTypes.CopyType, BuiltInTypes.SerializeType, BuiltInTypes.DeserializeType)),
                // ReSharper restore PossibleMistakenCallToGetType.2
                new KeyValuePair<Type, SerializerMethods>(typeof(Guid), new SerializerMethods(BuiltInTypes.CopyGuid, BuiltInTypes.SerializeGuid, BuiltInTypes.DeserializeGuid)),
                new KeyValuePair<Type, SerializerMethods>(typeof(IPAddress), new SerializerMethods(BuiltInTypes.CopyIPAddress, BuiltInTypes.SerializeIPAddress, BuiltInTypes.DeserializeIPAddress)),
                new KeyValuePair<Type, SerializerMethods>(typeof(IPEndPoint), new SerializerMethods(BuiltInTypes.CopyIPEndPoint, BuiltInTypes.SerializeIPEndPoint, BuiltInTypes.DeserializeIPEndPoint)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Uri), new SerializerMethods(BuiltInTypes.CopyUri, BuiltInTypes.SerializeUri, BuiltInTypes.DeserializeUri)),

                // Built-in handlers: Orleans internal types
                new KeyValuePair<Type, SerializerMethods>(typeof(InvokeMethodRequest), new SerializerMethods(BuiltInTypes.CopyInvokeMethodRequest, BuiltInTypes.SerializeInvokeMethodRequest, BuiltInTypes.DeserializeInvokeMethodRequest)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Response), new SerializerMethods(BuiltInTypes.CopyOrleansResponse, BuiltInTypes.SerializeOrleansResponse, BuiltInTypes.DeserializeOrleansResponse)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ActivationId), new SerializerMethods(BuiltInTypes.CopyActivationId, BuiltInTypes.SerializeActivationId, BuiltInTypes.DeserializeActivationId)),
                new KeyValuePair<Type, SerializerMethods>(typeof(GrainId), new SerializerMethods(BuiltInTypes.CopyGrainId, BuiltInTypes.SerializeGrainId, BuiltInTypes.DeserializeGrainId)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ActivationAddress), new SerializerMethods(BuiltInTypes.CopyActivationAddress, BuiltInTypes.SerializeActivationAddress, BuiltInTypes.DeserializeActivationAddress)),
                new KeyValuePair<Type, SerializerMethods>(typeof(CorrelationId), new SerializerMethods(BuiltInTypes.CopyCorrelationId, BuiltInTypes.SerializeCorrelationId, BuiltInTypes.DeserializeCorrelationId)),
                new KeyValuePair<Type, SerializerMethods>(typeof(SiloAddress), new SerializerMethods(BuiltInTypes.CopySiloAddress, BuiltInTypes.SerializeSiloAddress, BuiltInTypes.DeserializeSiloAddress)),

                // Type names that we need to recognize for generic parameters
                new KeyValuePair<Type, SerializerMethods>(typeof(bool), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(int), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(short), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(sbyte), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(long), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(uint), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ushort), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(byte), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ulong), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(float), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(double), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(decimal), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(string), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(char), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(DateTime), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(TimeSpan), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(object), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(IPAddress), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(IPEndPoint), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Guid), default(SerializerMethods)),

                new KeyValuePair<Type, SerializerMethods>(typeof(GrainId), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ActivationId), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(SiloAddress), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(ActivationAddress), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(CorrelationId), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(InvokeMethodRequest), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Response), default(SerializerMethods)),

                new KeyValuePair<Type, SerializerMethods>(typeof(IList<>), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(IDictionary<,>), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(IEnumerable<>), default(SerializerMethods)),

                // Enum names we need to recognize
                new KeyValuePair<Type, SerializerMethods>(typeof(Message.Categories), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Message.Directions), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Message.RejectionTypes), default(SerializerMethods)),
                new KeyValuePair<Type, SerializerMethods>(typeof(Message.ResponseTypes), default(SerializerMethods)),
            };
        }
    }
}