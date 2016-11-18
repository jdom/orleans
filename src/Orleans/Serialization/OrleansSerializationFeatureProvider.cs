using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using Orleans.CodeGeneration;
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
        private static readonly ConcurrentDictionary<Type, Func<GrainReference, GrainReference>> grainRefConstructorDictionary = new ConcurrentDictionary<Type, Func<GrainReference, GrainReference>>();
        private const string AddSerializerRegistrationsMethodName = "AddSerializerRegistrations";

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
                FindSerializationInfo(feature, type);
            }
        }

        /// <summary>
        /// Looks for types with marked serializer and deserializer methods, and registers them if necessary.
        /// </summary>
        private void FindSerializationInfo(OrleansSerializationFeature feature, Type type)
        {
            TypeInfo typeInfo = type.GetTypeInfo();
            var assembly = typeInfo.Assembly;
            bool systemAssembly = !assembly.IsDynamic
                                  && (assembly.FullName.StartsWith("mscorlib", StringComparison.OrdinalIgnoreCase)
                                      || assembly.FullName.StartsWith("System.", StringComparison.Ordinal));

            if (logger.IsVerbose2) logger.Verbose2("Scanning assembly {0} for serialization info", assembly.GetLocationSafe());

            try
            {
                if (typeInfo.IsEnum)
                {
                    AddKnownTypes(feature, type);
                }
                else if (!systemAssembly)
                {
                    string typeNamespace = null;
                    try
                    {
                        typeNamespace = typeInfo.Namespace;
                    }
                    catch (FileNotFoundException)
                    {
                        // TODO: investigate why we are getting this now
                        return;
                    }
                    if (!typeInfo.IsInterface
                        && (!typeInfo.IsAbstract || typeInfo.IsSealed)
                        && (typeNamespace == null || (!typeNamespace.Equals("System", StringComparison.Ordinal) && !typeNamespace.StartsWith("System.", StringComparison.Ordinal))))
                    {
                        var serializerAttributes = typeInfo.GetCustomAttributes<SerializerAttribute>(false).ToList();
                        if (serializerAttributes.Any())
                        {
                            foreach (var serializerAttribute in serializerAttributes)
                            {
                                // Register as the serializer for the target type.
                                AddRegistration(feature, serializerAttribute.TargetType, typeInfo);
                                if (logger.IsVerbose3)
                                    logger.Verbose3(
                                        "Loaded serialization info for type {0} using serializer {1} from assembly {2}",
                                        serializerAttribute.TargetType.Name,
                                        type.Name,
                                        assembly.GetName().Name);
                            }
                        }
                        else if (typeInfo.GetCustomAttributes(typeof(RegisterSerializerAttribute), false).Any())
                        {
                            // Call the static Register method on the type
                            if (logger.IsVerbose3)
                                logger.Verbose3(
                                    "Running register method for type {0} from assembly {1}",
                                    typeInfo.Name,
                                    assembly.GetName().Name);

                            var addSerializerRegistrations = typeInfo.GetMethod(AddSerializerRegistrationsMethodName, new[] { typeof(OrleansSerializationFeature) });
                            //MethodInfo register; // temporary until codegen is fixed
                            if (addSerializerRegistrations != null)
                            {
                                try
                                {
                                    if (addSerializerRegistrations.ContainsGenericParameters) throw new OrleansException($"Type serializer '{ addSerializerRegistrations.GetType().FullName}' contains generic parameters and can not be registered. Did you mean to provide a split your type serializer into a combination of nongeneric RegisterSerializerAttribute and generic SerializableAttribute classes?");
                                    addSerializerRegistrations.Invoke(null, new object[] { feature });
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
                                    ErrorCode.SerMgr_MissingAddSerializerRegistrationsMethod,
                                    "Type {0} from assembly {1} has the " + nameof(RegisterSerializerAttribute) + " attribute but no public static void " + AddSerializerRegistrationsMethodName + " method",
                                    type.Name,
                                    assembly.GetName().Name);
                            }
                        }
                        else if(!type.IsAbstract)
                        { 
                            // if the type isn't abstract (or static), check whether it can serialize itself
                            if (IsGeneratedGrainReference(typeInfo))
                            {
                                RegisterGrainReferenceSerializers(type, feature);
                            }
                            else
                            {
                                SerializerMethods serializerMethods = GetSerializerMethods(type);
                                if ((serializerMethods.DeepCopy != null) && (serializerMethods.Serialize != null) && (serializerMethods.Deserialize != null))
                                {
                                    // Register type as a serializer for type.
                                    AddRegistration(feature, type, typeInfo);
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
                                        AddRegistration(feature, type, serializerMethods, true);
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
                                        AddRegistration(
                                        feature,
                                        type, 
                                        new SerializerMethods(serializerMethods.DeepCopy, null, null), // just in case either serializer or deserializer is set (but not both)
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
                                    if (comparer && (type.GetFields().Length == 0)) AddKnownTypes(feature, type);
                                }
                                else
                                {
                                    AddKnownTypes(feature, type);
                                }
                            }
                        }
                        else
                        {
                            AddKnownTypes(feature, type);
                        }
                    }
                    else
                    {
                        // type is abstract (and non-static), an interface, system-defined, or its namespace is null
                        AddKnownTypes(feature, type);
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
        /// Adds a serializer registration for a Type with the specified DeepCopier, Serializer and Deserializer functions.
        /// If <c>forcOverride == true</c> then this definition will replace any any previous functions registered for this Type.
        /// </summary>
        /// <param name="feature">The feature to populate</param>
        /// <param name="type">Type to be registered.</param>
        /// <param name="cop">DeepCopier function for this type.</param>
        /// <param name="ser">Serializer function for this type.</param>
        /// <param name="deser">Deserializer function for this type.</param>
        /// <param name="forceOverride">Whether these functions should replace any previously registered functions for this Type.</param>
        private static void AddRegistration(OrleansSerializationFeature feature, Type type, SerializerMethods.DeepCopier cop, SerializerMethods.Serializer ser, SerializerMethods.Deserializer deser, bool forceOverride = false)
        {
            AddRegistration(feature, type, new SerializerMethods(cop, ser, deser), forceOverride);
        }

        /// <summary>
        /// Adds a serializer registration for a Type with the specified serializer methods.
        /// If <c>forcOverride == true</c> then this definition will replace any any previous functions registered for this Type.
        /// </summary>
        /// <param name="feature">The feature to populate</param>
        /// <param name="type">Type to be registered.</param>
        /// <param name="serializerMethods">Serializer and copier methods for this type.</param>
        /// <param name="forceOverride">Whether these functions should replace any previously registered functions for this Type.</param>
        public static void AddRegistration(OrleansSerializationFeature feature, Type type, SerializerMethods serializerMethods, bool forceOverride = false)
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

            if (serializerMethods.Serialize != null || serializerMethods.Deserialize != null || serializerMethods.DeepCopy != null)
            {
                feature.SerializerMethods[type] = serializerMethods;
            }
            AddKnownTypes(feature, type);
        }

        /// <summary>
        /// Adds a serializer registration with <paramref name="serializerType"/> as the serializer for <paramref name="type"/>.
        /// </summary>
        /// <param name="feature">The feature instance to populate.</param>
        /// <param name="type">The type serialized by the provided serializer type.</param>
        /// <param name="serializerType">The type containing serialization methods for <paramref name="type"/>.</param>
        public static void AddRegistration(OrleansSerializationFeature feature, Type type, TypeInfo serializerType)
        {
            feature.SerializerTypes[type] = serializerType;
            AddKnownTypes(feature, type);
        }

        /// <summary>
        /// Adds other known types to be recognized by the serialization system.
        /// </summary>
        /// <param name="feature">The feature instance to populate.</param>
        /// <param name="type">The type to register</param>
        public static void AddKnownTypes(OrleansSerializationFeature feature, Type type)
        {
            if (feature.OtherKnownTypes.Add(type))
            {
                // Register any interfaces this type implements, in order to support passing values that are statically of the interface type
                // but dynamically of this (implementation) type
                foreach (var iface in type.GetInterfaces())
                {
                    AddKnownTypes(feature, iface);
                }
                // Do the same for abstract base classes
                var baseType = type.GetTypeInfo().BaseType;
                while (baseType != null)
                {
                    var baseTypeInfo = baseType.GetTypeInfo();
                    if (baseTypeInfo.IsAbstract)
                    {
                        AddKnownTypes(feature, baseType);
                    }

                    baseType = baseTypeInfo.BaseType;
                }
            }
        }

        internal static SerializerMethods GetSerializerMethods(Type type)
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
                (SerializerMethods.DeepCopier)copier?.CreateDelegate(typeof(SerializerMethods.DeepCopier)),
                (SerializerMethods.Serializer)serializer?.CreateDelegate(typeof(SerializerMethods.Serializer)),
                (SerializerMethods.Deserializer)deserializer?.CreateDelegate(typeof(SerializerMethods.Deserializer)));
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
        private static bool IsGeneratedGrainReference(MemberInfo type)
        {
            var attr = type.GetCustomAttribute<GrainReferenceAttribute>();
            return attr?.TargetType != null;
        }

        /// <summary>Registers <see cref="GrainReference"/> serializers for the provided <paramref name="type"/>.</summary>
        /// <param name="type">The type.</param>
        /// <param name="feature">The feature to populate</param>
        private void RegisterGrainReferenceSerializers(Type type, OrleansSerializationFeature feature)
        {
            var attr = type.GetTypeInfo().GetCustomAttribute<GrainReferenceAttribute>();
            if (attr?.TargetType == null)
            {
                return;
            }

            var defaultCtorDelegate = CreateGrainRefConstructorDelegate(type, null);

            // Register GrainReference serialization methods.
            AddRegistration(
                feature,
                type,
                GrainReference.CopyGrainReference,
                GrainReference.SerializeGrainReference,
                (expected, stream) =>
                {
                    Func<GrainReference, GrainReference> ctorDelegate;
                    var deserialized = (GrainReference) GrainReference.DeserializeGrainReference(expected, stream);
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
    }
}