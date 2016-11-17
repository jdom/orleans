using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using Orleans.Serialization.Registration;

namespace Orleans.Serialization
{
    /// <summary>
    /// SerializationManager to oversee the Orleans serializer system.
    /// </summary>
    public static class SerializationManager
    {
        /// <summary>
        /// The delegate used to set fields in value types.
        /// </summary>
        /// <typeparam name="TDeclaring">The declaring type of the field.</typeparam>
        /// <typeparam name="TField">The field type.</typeparam>
        /// <param name="instance">The instance having its field set.</param>
        /// <param name="value">The value being set.</param>
        public delegate void ValueTypeSetter<TDeclaring, in TField>(ref TDeclaring instance, TField value);

        private static readonly string[] safeFailSerializers = { "Orleans.FSharp" };
        
#if NETSTANDARD
        // Workaround for CoreCLR where FormatterServices.GetUninitializedObject is not public (but might change in RTM so we could remove this then).
        private static readonly Func<Type, object> getUninitializedObjectDelegate =
            (Func<Type, object>)
                typeof(string)
                    .GetTypeInfo()
                    .Assembly
                    .GetType("System.Runtime.Serialization.FormatterServices")
                    .GetMethod("GetUninitializedObject", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static)
                    .CreateDelegate(typeof(Func<Type, object>));

        /// <summary>
        /// Returns an unitialized object with FormatterServices.
        /// </summary>
        /// <param name="type">The type to create</param>
        public static object GetUninitializedObjectWithFormatterServices(Type type)
        {
            return getUninitializedObjectDelegate.Invoke(type);
        }
#endif

        #region Privates

        private static HashSet<Type> registeredTypes = new HashSet<Type>();
        private static List<IExternalSerializer> externalSerializers = new List<IExternalSerializer>();
        private static ConcurrentDictionary<Type, IExternalSerializer> typeToExternalSerializerDictionary = new ConcurrentDictionary<Type, IExternalSerializer>();
        private static Dictionary<string, Type> types = new Dictionary<string, Type>();
        private static Dictionary<RuntimeTypeHandle, SerializerMethods.DeepCopier> copiers = new Dictionary<RuntimeTypeHandle, SerializerMethods.DeepCopier>();
        private static Dictionary<RuntimeTypeHandle, SerializerMethods.Serializer> serializers = new Dictionary<RuntimeTypeHandle, SerializerMethods.Serializer>();
        private static Dictionary<RuntimeTypeHandle, SerializerMethods.Deserializer> deserializers = new Dictionary<RuntimeTypeHandle, SerializerMethods.Deserializer>();

        private static IExternalSerializer fallbackSerializer;
        private static LoggerImpl logger;
        private static bool IsBuiltInSerializersRegistered;
        private static readonly object registerBuiltInSerializerLockObj = new object();
        internal static int RegisteredTypesCount => registeredTypes.Count;

        // Semi-constants: type handles for simple types
        private static readonly RuntimeTypeHandle shortTypeHandle = typeof(short).TypeHandle;
        private static readonly RuntimeTypeHandle intTypeHandle = typeof(int).TypeHandle;
        private static readonly RuntimeTypeHandle longTypeHandle = typeof(long).TypeHandle;
        private static readonly RuntimeTypeHandle ushortTypeHandle = typeof(ushort).TypeHandle;
        private static readonly RuntimeTypeHandle uintTypeHandle = typeof(uint).TypeHandle;
        private static readonly RuntimeTypeHandle ulongTypeHandle = typeof(ulong).TypeHandle;
        private static readonly RuntimeTypeHandle byteTypeHandle = typeof(byte).TypeHandle;
        private static readonly RuntimeTypeHandle sbyteTypeHandle = typeof(sbyte).TypeHandle;
        private static readonly RuntimeTypeHandle floatTypeHandle = typeof(float).TypeHandle;
        private static readonly RuntimeTypeHandle doubleTypeHandle = typeof(double).TypeHandle;
        private static readonly RuntimeTypeHandle charTypeHandle = typeof(char).TypeHandle;
        private static readonly RuntimeTypeHandle boolTypeHandle = typeof(bool).TypeHandle;
        private static readonly RuntimeTypeHandle objectTypeHandle = typeof(object).TypeHandle;
        private static readonly RuntimeTypeHandle byteArrayTypeHandle = typeof(byte[]).TypeHandle;

        internal static CounterStatistic Copies;
        internal static CounterStatistic Serializations;
        internal static CounterStatistic Deserializations;
        internal static CounterStatistic HeaderSers;
        internal static CounterStatistic HeaderDesers;
        internal static CounterStatistic HeaderSersNumHeaders;
        internal static CounterStatistic HeaderDesersNumHeaders;
        internal static CounterStatistic CopyTimeStatistic;
        internal static CounterStatistic SerTimeStatistic;
        internal static CounterStatistic DeserTimeStatistic;
        internal static CounterStatistic HeaderSerTime;
        internal static CounterStatistic HeaderDeserTime;
        internal static IntValueStatistic TotalTimeInSerializer;

        internal static CounterStatistic FallbackSerializations;
        internal static CounterStatistic FallbackDeserializations;
        internal static CounterStatistic FallbackCopies;
        internal static CounterStatistic FallbackSerTimeStatistic;
        internal static CounterStatistic FallbackDeserTimeStatistic;
        internal static CounterStatistic FallbackCopiesTimeStatistic;

        internal static int LARGE_OBJECT_LIMIT = Constants.LARGE_OBJECT_HEAP_THRESHOLD;

        #endregion

        #region Static initialization

        public static void InitializeForTesting(List<TypeInfo> serializationProviders = null, TypeInfo fallbackType = null)
        {
            logger = LogManager.GetLogger("SerializationManager", LoggerType.Runtime);
            try
            {
                RegisterBuiltInSerializers();
                BufferPool.InitGlobalBufferPool(new MessagingConfiguration(false));
                RegisterSerializationProviders(serializationProviders);
                fallbackSerializer = GetFallbackSerializer(fallbackType);
            }
            catch (ReflectionTypeLoadException ex)
            {
                throw ex.Flatten();
            }
        }

        internal static void Initialize(List<TypeInfo> serializationProviders, TypeInfo fallbackType = null)
        {
            logger = LogManager.GetLogger("SerializationManager", LoggerType.Runtime);
            fallbackSerializer = GetFallbackSerializer(fallbackType);

            if (StatisticsCollector.CollectSerializationStats)
            {
                const CounterStorage store = CounterStorage.LogOnly;
                Copies = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_DEEPCOPIES, store);
                Serializations = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_SERIALIZATION, store);
                Deserializations = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_DESERIALIZATION, store);
                HeaderSers = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_HEADER_SERIALIZATION, store);
                HeaderDesers = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_HEADER_DESERIALIZATION, store);
                HeaderSersNumHeaders = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_HEADER_SERIALIZATION_NUMHEADERS, store);
                HeaderDesersNumHeaders = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_HEADER_DESERIALIZATION_NUMHEADERS, store);
                CopyTimeStatistic = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_DEEPCOPY_MILLIS, store).AddValueConverter(Utils.TicksToMilliSeconds);
                SerTimeStatistic = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_SERIALIZATION_MILLIS, store).AddValueConverter(Utils.TicksToMilliSeconds);
                DeserTimeStatistic = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_DESERIALIZATION_MILLIS, store).AddValueConverter(Utils.TicksToMilliSeconds);
                HeaderSerTime = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_HEADER_SERIALIZATION_MILLIS, store).AddValueConverter(Utils.TicksToMilliSeconds);
                HeaderDeserTime = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_HEADER_DESERIALIZATION_MILLIS, store).AddValueConverter(Utils.TicksToMilliSeconds);

                TotalTimeInSerializer = IntValueStatistic.FindOrCreate(StatisticNames.SERIALIZATION_TOTAL_TIME_IN_SERIALIZER_MILLIS, () =>
                    {
                        long ticks = CopyTimeStatistic.GetCurrentValue() + SerTimeStatistic.GetCurrentValue() + DeserTimeStatistic.GetCurrentValue()
                                + HeaderSerTime.GetCurrentValue() + HeaderDeserTime.GetCurrentValue();
                        return Utils.TicksToMilliSeconds(ticks);
                    }, CounterStorage.LogAndTable);

                const CounterStorage storeFallback = CounterStorage.LogOnly;
                FallbackSerializations = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_FALLBACK_SERIALIZATION, storeFallback);
                FallbackDeserializations = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_FALLBACK_DESERIALIZATION, storeFallback);
                FallbackCopies = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_FALLBACK_DEEPCOPIES, storeFallback);
                FallbackSerTimeStatistic = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_FALLBACK_SERIALIZATION_MILLIS, storeFallback).AddValueConverter(Utils.TicksToMilliSeconds);
                FallbackDeserTimeStatistic = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_FALLBACK_DESERIALIZATION_MILLIS, storeFallback).AddValueConverter(Utils.TicksToMilliSeconds);
                FallbackCopiesTimeStatistic = CounterStatistic.FindOrCreate(StatisticNames.SERIALIZATION_BODY_FALLBACK_DEEPCOPY_MILLIS, storeFallback).AddValueConverter(Utils.TicksToMilliSeconds);
            }

            RegisterSerializationProviders(serializationProviders);
        }

        internal static void RegisterBuiltInSerializers()
        {
            lock (registerBuiltInSerializerLockObj)
            {
                if (IsBuiltInSerializersRegistered)
                {
                    return;
                }

                IsBuiltInSerializersRegistered = true;
            }

            logger = LogManager.GetLogger("SerializationManager", LoggerType.Runtime);
#if !NETSTANDARD_TODO
            AppDomain.CurrentDomain.AssemblyResolve += OnResolveEventHandler;
#endif

            var feature = new OrleansSerializationFeature();
            new OrleansSerializationFeatureProvider().PopulateFeature(new[] { typeof(BuiltInTypes).GetTypeInfo() }, feature);
            Register(feature);
        }

        #endregion

        #region Serialization info registration

        /// <summary>
        /// Register a set of types with a serialization system.
        /// </summary>
        /// <param name="orleansSerializationFeature">The serialization feature to register in the serializer</param>
        public static void Register(OrleansSerializationFeature orleansSerializationFeature)
        {
            foreach (var serializerTypeMap in orleansSerializationFeature.SerializerTypes)
            {
                Register(serializerTypeMap.Key, serializerTypeMap.Value.AsType());
            }

            foreach (var serializerMethodsMap in orleansSerializationFeature.SerializerMethods)
            {
                Register(serializerMethodsMap.Key, serializerMethodsMap.Value, true);
            }

            foreach (var type in orleansSerializationFeature.OtherKnownTypes)
            {
                RegisterTypeName(type, false);
            }
        }

        /// <summary>
        /// Register a Type with the serialization system to use the specified DeepCopier, Serializer and Deserializer functions.
        /// </summary>
        /// <param name="t">Type to be registered.</param>
        /// <param name="cop">DeepCopier function for this type.</param>
        /// <param name="ser">Serializer function for this type.</param>
        /// <param name="deser">Deserializer function for this type.</param>
        public static void Register(Type t, SerializerMethods.DeepCopier cop, SerializerMethods.Serializer ser, SerializerMethods.Deserializer deser)
        {
            Register(t, cop, ser, deser, false);
        }

        /// <summary>
        /// Register a Type with the serialization system to use the specified DeepCopier, Serializer and Deserializer functions.
        /// If <c>forcOverride == true</c> then this definition will replace any any previous functions registered for this Type.
        /// </summary>
        /// <param name="t">Type to be registered.</param>
        /// <param name="serializerMethods">The serializer methods for this type.</param>
        /// <param name="forceOverride">Whether these functions should replace any previously registered functions for this Type.</param>
        public static void Register(Type t, SerializerMethods serializerMethods, bool forceOverride)
        {
            Register(t, serializerMethods.DeepCopy, serializerMethods.Serialize, serializerMethods.Deserialize, forceOverride);
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
        public static void Register(Type t, SerializerMethods.DeepCopier cop, SerializerMethods.Serializer ser, SerializerMethods.Deserializer deser, bool forceOverride)
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
                            SerializerMethods.DeepCopier current;
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
                            SerializerMethods.Serializer currentSer;
                            if (forceOverride || !serializers.TryGetValue(t.TypeHandle, out currentSer) || (currentSer == null))
                            {
                                serializers[t.TypeHandle] = ser;
                            }
                        }
                        lock (deserializers)
                        {
                            SerializerMethods.Deserializer currentDeser;
                            if (forceOverride || !deserializers.TryGetValue(t.TypeHandle, out currentDeser) || (currentDeser == null))
                            {
                                deserializers[t.TypeHandle] = deser;
                            }
                        }
                    }
                }
                else
                {
                    RegisterTypeName(t);
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
                }
            }
        }

        /// <summary>
        /// This method registers a type  with the paresable type name.
        /// </summary>
        /// <param name="type">Type to be registered.</param>
        /// <param name="registerAncestors">Also recurses through base clases and interfaces</param>
        private static void RegisterTypeName(Type type, bool registerAncestors = true)
        {
            string name = type.OrleansTypeKeyString();

            lock (registeredTypes)
            {
                if (registeredTypes.Contains(type))
                {
                    return;
                }

                registeredTypes.Add(type);
                lock (types)
                {
                    types[name] = type;
                }
            }
            if (logger.IsVerbose3) logger.Verbose3("Registered type {0} as {1}", type, name);

            if (registerAncestors)
            {
                // Register any interfaces this type implements, in order to support passing values that are statically of the interface type
                // but dynamically of this (implementation) type
                foreach (var iface in type.GetInterfaces())
                {
                    RegisterTypeName(iface);
                }

                // Do the same for abstract base classes
                var baseType = type.GetTypeInfo().BaseType;
                while (baseType != null)
                {
                    var baseTypeInfo = baseType.GetTypeInfo();
                    if (baseTypeInfo.IsAbstract)
                        RegisterTypeName(baseType);

                    baseType = baseTypeInfo.BaseType;
                }
            }
        }

        /// <summary>
        /// Registers <paramref name="serializerType"/> as the serializer for <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type serialized by the provided serializer type.</param>
        /// <param name="serializerType">The type containing serialization methods for <paramref name="type"/>.</param>
        private static void Register(Type type, Type serializerType)
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
                    var serializerMethods = OrleansSerializationFeatureProvider.GetSerializerMethods(serializerType);
                    Register(type, serializerMethods, true);
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

        private static SerializerMethods RegisterConcreteSerializer(Type concreteType, Type genericSerializerType)
        {
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

            var serializerMethods = OrleansSerializationFeatureProvider.GetSerializerMethods(concreteSerializerType);
            Register(concreteType, serializerMethods, true);
            return serializerMethods;
        }

#endregion

#region Deep copying

        internal static SerializerMethods.DeepCopier GetCopier(Type t)
        {
            lock (copiers)
            {
                SerializerMethods.DeepCopier copier;
                if (copiers.TryGetValue(t.TypeHandle, out copier))
                    return copier;

                var typeInfo = t.GetTypeInfo();
                if (typeInfo.IsGenericType && copiers.TryGetValue(typeInfo.GetGenericTypeDefinition().TypeHandle, out copier))
                    return copier;
            }

            return null;
        }

        /// <summary>
        /// Deep copy the specified object, using DeepCopier functions previously registered for this type.
        /// </summary>
        /// <param name="original">The input data to be deep copied.</param>
        /// <returns>Deep copied clone of the original input object.</returns>
        public static object DeepCopy(object original)
        {
            Stopwatch timer = null;
            if (StatisticsCollector.CollectSerializationStats)
            {
                timer = new Stopwatch();
                timer.Start();
                Copies.Increment();
            }

            SerializationContext.Current.Reset();
            object copy = DeepCopyInner(original);
            SerializationContext.Current.Reset();
            

            if (timer!=null)
            {
                timer.Stop();
                CopyTimeStatistic.IncrementBy(timer.ElapsedTicks);
            }
            
            return copy;
        }

        /// <summary>
        /// <para>
        /// This method makes a deep copy of the object passed to it.
        /// </para>
        /// </summary>
        /// <param name="original">The input data to be deep copied.</param>
        /// <returns>Deep copied clone of the original input object.</returns>
        public static object DeepCopyInner(object original)
        {
            if (original == null) return null;

            var t = original.GetType();
            var shallow = t.IsOrleansShallowCopyable();

            if (shallow)
                return original;

            var reference = SerializationContext.Current.CheckObjectWhileCopying(original);
            if (reference != null)
                return reference;

            object copy;

            IExternalSerializer serializer;
            if (TryLookupExternalSerializer(t, out serializer))
            {
                copy = serializer.DeepCopy(original);
                SerializationContext.Current.RecordObject(original, copy);
                return copy;
            }

            var copier = GetCopier(t);
            if (copier != null)
            {
                copy = copier(original);
                SerializationContext.Current.RecordObject(original, copy);
                return copy;
            }

            return DeepCopierHelper(t, original);
        }

        private static object DeepCopierHelper(Type t, object original)
        {
            // Arrays are all that's left. 
            // Handling arbitrary-rank arrays is a bit complex, but why not?
            var originalArray = original as Array;
            if (originalArray != null)
            {
                if (originalArray.Rank == 1 && originalArray.GetLength(0) == 0)
                {
                    // A common special case - empty one dimentional array
                    return originalArray;
                }
                // A common special case
                if (t.TypeHandle.Equals(byteArrayTypeHandle) && (originalArray.Rank == 1))
                {
                    var source = (byte[])original;
                    if (source.Length > LARGE_OBJECT_LIMIT)
                    {
                        logger.Info(ErrorCode.Ser_LargeObjectAllocated,
                            "Large byte array of size {0} is being copied. This will result in an allocation on the large object heap. " +
                            "Frequent allocations to the large object heap can result in frequent gen2 garbage collections and poor system performance. " +
                            "Please consider using Immutable<byte[]> instead.", source.Length);
                    }
                    var dest = new byte[source.Length];
                    Array.Copy(source, dest, source.Length);
                    return dest;
                }

                var et = t.GetElementType();
                var etInfo = et.GetTypeInfo();
                if (et.IsOrleansShallowCopyable())
                {
                    // Only check the size for primitive types because otherwise Buffer.ByteLength throws
                    if (etInfo.IsPrimitive && Buffer.ByteLength(originalArray) > LARGE_OBJECT_LIMIT)
                    {
                        logger.Info(ErrorCode.Ser_LargeObjectAllocated,
                            "Large {0} array of total byte size {1} is being copied. This will result in an allocation on the large object heap. " +
                            "Frequent allocations to the large object heap can result in frequent gen2 garbage collections and poor system performance. " +
                            "Please consider using Immutable<{0}> instead.", t.OrleansTypeName(), Buffer.ByteLength(originalArray));
                    }
                    return originalArray.Clone();
                }

                // We assume that all arrays have lower bound 0. In .NET 4.0, it's hard to create an array with a non-zero lower bound.
                var rank = originalArray.Rank;
                var lengths = new int[rank];
                for (var i = 0; i < rank; i++)
                    lengths[i] = originalArray.GetLength(i);

                var copyArray = Array.CreateInstance(et, lengths);
                SerializationContext.Current.RecordObject(original, copyArray);

                if (rank == 1)
                {
                    for (var i = 0; i < lengths[0]; i++)
                        copyArray.SetValue(DeepCopyInner(originalArray.GetValue(i)), i);
                }
                else if (rank == 2)
                {
                    for (var i = 0; i < lengths[0]; i++)
                        for (var j = 0; j < lengths[1]; j++)
                            copyArray.SetValue(DeepCopyInner(originalArray.GetValue(i, j)), i, j);
                }
                else
                {
                    var index = new int[rank];
                    var sizes = new int[rank];
                    sizes[rank - 1] = 1;
                    for (var k = rank - 2; k >= 0; k--)
                        sizes[k] = sizes[k + 1]*lengths[k + 1];

                    for (var i = 0; i < originalArray.Length; i++)
                    {
                        int k = i;
                        for (int n = 0; n < rank; n++)
                        {
                            int offset = k / sizes[n];
                            k = k - offset * sizes[n];
                            index[n] = offset;
                        }
                        copyArray.SetValue(DeepCopyInner(originalArray.GetValue(index)), index);
                    }
                }
                return copyArray;

            }

            if (fallbackSerializer.IsSupportedType(t))
                return FallbackSerializationDeepCopy(original);

            throw new OrleansException("No copier found for object of type " + t.OrleansTypeName() + 
                ". Perhaps you need to mark it [Serializable] or define a custom serializer for it?");
        }

#endregion

#region Serializing

        /// <summary>
        /// Returns true if <paramref name="t"/> is serializable, false otherwise.
        /// </summary>
        /// <param name="t">The type.</param>
        /// <returns>true if <paramref name="t"/> is serializable, false otherwise.</returns>
        internal static bool HasSerializer(Type t)
        {
            lock (serializers)
            {
                SerializerMethods.Serializer ser;
                if (serializers.TryGetValue(t.TypeHandle, out ser)) return true;
                var typeInfo = t.GetTypeInfo();
                return typeInfo.IsGenericType && serializers.TryGetValue(typeInfo.GetGenericTypeDefinition().TypeHandle, out ser);
            }
        }

        internal static SerializerMethods.Serializer GetSerializer(Type t)
        {
            lock (serializers)
            {
                SerializerMethods.Serializer ser;
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
        /// Serialize the specified object, using Serializer functions previously registered for this type.
        /// </summary>
        /// <param name="raw">The input data to be serialized.</param>
        /// <param name="stream">The output stream to write to.</param>
        public static void Serialize(object raw, BinaryTokenStreamWriter stream)
        {
            Stopwatch timer = null;
            if (StatisticsCollector.CollectSerializationStats)
            {
                timer = new Stopwatch();
                timer.Start();
                Serializations.Increment();
            }
            
            SerializationContext.Current.Reset();
            SerializeInner(raw, stream, null);
            SerializationContext.Current.Reset();
            
            if (timer!=null)
            {
                timer.Stop();
                SerTimeStatistic.IncrementBy(timer.ElapsedTicks);
            }
        }

        /// <summary>
        /// Encodes the object to the provided binary token stream.
        /// </summary>
        /// <param name="obj">The input data to be serialized.</param>
        /// <param name="stream">The output stream to write to.</param>
        /// <param name="expected">Current expected Type on this stream.</param>
        [SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes")]
        public static void SerializeInner(object obj, BinaryTokenStreamWriter stream, Type expected)
        {
            // Nulls get special handling
            if (obj == null)
            {
                stream.WriteNull();
                return;
            }

            var t = obj.GetType();
            var typeInfo = t.GetTypeInfo();

            // Enums are extra-special
            if (typeInfo.IsEnum)
            {
                stream.WriteTypeHeader(t, expected);
                WriteEnum(obj, stream, t);

                return;
            }

            // Check for simple types
            if (stream.TryWriteSimpleObject(obj)) return;

            // Check for primitives
            // At this point, we're either an object or a non-trivial value type

            // Start by checking to see if we're a back-reference, and recording us for possible future back-references if not
            if (!typeInfo.IsValueType)
            {
                int reference = SerializationContext.Current.CheckObjectWhileSerializing(obj);
                if (reference >= 0)
                {
                    stream.WriteReference(reference);
                    return;
                }
                SerializationContext.Current.RecordObject(obj, stream.CurrentOffset);
            }

            // If we're simply a plain old unadorned, undifferentiated object, life is easy
            if (t.TypeHandle.Equals(objectTypeHandle))
            {
                stream.Write(SerializationTokenType.SpecifiedType);
                stream.Write(SerializationTokenType.Object);
                return;
            }

            // Arrays get handled specially
            if (typeInfo.IsArray)
            {
                var et = t.GetElementType();
                SerializeArray((Array)obj, stream, expected, et);
                return;
            }

            IExternalSerializer serializer;
            if (TryLookupExternalSerializer(t, out serializer))
            {
                stream.WriteTypeHeader(t, expected);
                serializer.Serialize(obj, stream, expected);
                return;
            }

            SerializerMethods.Serializer ser = GetSerializer(t);
            if (ser != null)
            {
                stream.WriteTypeHeader(t, expected);
                ser(obj, stream, expected);
                return;
            }

            if (fallbackSerializer.IsSupportedType(t))
            {
                FallbackSerializer(obj, stream, expected);
                return;
            }

            if (obj is Exception && !fallbackSerializer.IsSupportedType(t))
            {
                // Exceptions should always be serializable, and thus handled by the prior if.
                // In case someone creates a non-serializable exception, though, we don't want to 
                // throw and return a serialization exception...
                // Note that the "!t.IsSerializable" is redundant in this if, but it's there in case
                // this code block moves.
                var rawException = obj as Exception;
                var foo = new Exception(String.Format("Non-serializable exception of type {0}: {1}" + Environment.NewLine + "at {2}",
                                                      t.OrleansTypeName(), rawException.Message,
                                                      rawException.StackTrace));
                FallbackSerializer(foo, stream, expected);
                return;
            }

            throw new ArgumentException("No serializer found for object of type " + t.OrleansTypeName()
                 + ". Perhaps you need to mark it [Serializable] or define a custom serializer for it?");
        }

        private static void WriteEnum(object obj, BinaryTokenStreamWriter stream, Type type)
        {
            var t = Enum.GetUnderlyingType(type).TypeHandle;
            if (t.Equals(byteTypeHandle) || t.Equals(sbyteTypeHandle)) stream.Write(Convert.ToByte(obj));
            else if (t.Equals(shortTypeHandle) || t.Equals(ushortTypeHandle)) stream.Write(Convert.ToInt16(obj));
            else if (t.Equals(intTypeHandle) || t.Equals(uintTypeHandle)) stream.Write(Convert.ToInt32(obj));
            else if (t.Equals(longTypeHandle) || t.Equals(ulongTypeHandle)) stream.Write(Convert.ToInt64(obj));
            else throw new NotSupportedException($"Serialization of type {type.GetParseableName()} is not supported.");
        }

        private static object ReadEnum(BinaryTokenStreamReader stream, Type type)
        {
            var t = Enum.GetUnderlyingType(type).TypeHandle;
            if (t.Equals(byteTypeHandle) || t.Equals(sbyteTypeHandle)) return Enum.ToObject(type, stream.ReadByte());
            if (t.Equals(shortTypeHandle) || t.Equals(ushortTypeHandle)) return Enum.ToObject(type, stream.ReadShort());
            if (t.Equals(intTypeHandle) || t.Equals(uintTypeHandle)) return Enum.ToObject(type, stream.ReadInt());
            if (t.Equals(longTypeHandle) || t.Equals(ulongTypeHandle)) return Enum.ToObject(type, stream.ReadLong());
            throw new NotSupportedException($"Deserialization of type {type.GetParseableName()} is not supported.");
        }

        // We assume that all lower bounds are 0, since creating an array with lower bound !=0 is hard in .NET 4.0+
        private static void SerializeArray(Array array, BinaryTokenStreamWriter stream, Type expected, Type et)
        {
            // First check for one of the optimized cases
            if (array.Rank == 1)
            {
                if (et.TypeHandle.Equals(byteTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.ByteArray);
                    stream.Write(array.Length);
                    stream.Write((byte[])array);
                    return;
                }
                if (et.TypeHandle.Equals(sbyteTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.SByteArray);
                    stream.Write(array.Length);
                    stream.Write((sbyte[])array);
                    return;
                }
                if (et.TypeHandle.Equals(boolTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.BoolArray);
                    stream.Write(array.Length);
                    stream.Write((bool[])array);
                    return;
                }
                if (et.TypeHandle.Equals(charTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.CharArray);
                    stream.Write(array.Length);
                    stream.Write((char[])array);
                    return;
                }
                if (et.TypeHandle.Equals(shortTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.ShortArray);
                    stream.Write(array.Length);
                    stream.Write((short[])array);
                    return;
                }
                if (et.TypeHandle.Equals(intTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.IntArray);
                    stream.Write(array.Length);
                    stream.Write((int[])array);
                    return;
                }
                if (et.TypeHandle.Equals(longTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.LongArray);
                    stream.Write(array.Length);
                    stream.Write((long[])array);
                    return;
                }
                if (et.TypeHandle.Equals(ushortTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.UShortArray);
                    stream.Write(array.Length);
                    stream.Write((ushort[])array);
                    return;
                }
                if (et.TypeHandle.Equals(uintTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.UIntArray);
                    stream.Write(array.Length);
                    stream.Write((uint[])array);
                    return;
                }
                if (et.TypeHandle.Equals(ulongTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.ULongArray);
                    stream.Write(array.Length);
                    stream.Write((ulong[])array);
                    return;
                }
                if (et.TypeHandle.Equals(floatTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.FloatArray);
                    stream.Write(array.Length);
                    stream.Write((float[])array);
                    return;
                }
                if (et.TypeHandle.Equals(doubleTypeHandle))
                {
                    stream.Write(SerializationTokenType.SpecifiedType);
                    stream.Write(SerializationTokenType.DoubleArray);
                    stream.Write(array.Length);
                    stream.Write((double[])array);
                    return;
                }
            }

            // Write the array header
            stream.WriteArrayHeader(array, expected);

            // Figure out the array size
            var rank = array.Rank;
            var lengths = new int[rank];
            for (var i = 0; i < rank; i++)
            {
                lengths[i] = array.GetLength(i);
            }

            if (rank == 1)
            {
                for (int i = 0; i < lengths[0]; i++)
                    SerializeInner(array.GetValue(i), stream, et);
            }
            else if (rank == 2)
            {
                for (int i = 0; i < lengths[0]; i++)
                    for (int j = 0; j < lengths[1]; j++)
                        SerializeInner(array.GetValue(i, j), stream, et);
            }
            else
            {
                var index = new int[rank];
                var sizes = new int[rank];
                sizes[rank - 1] = 1;
                for (var k = rank - 2; k >= 0; k--)
                    sizes[k] = sizes[k + 1]*lengths[k + 1];

                for (var i = 0; i < array.Length; i++)
                {
                    int k = i;
                    for (int n = 0; n < rank; n++)
                    {
                        int offset = k / sizes[n];
                        k = k - offset * sizes[n];
                        index[n] = offset;
                    }
                    SerializeInner(array.GetValue(index), stream, et);
                }
            }
        }

        /// <summary>
        /// Serialize data into byte[].
        /// </summary>
        /// <param name="raw">Input data.</param>
        /// <returns>Object of the required Type, rehydrated from the input stream.</returns>
        public static byte[] SerializeToByteArray(object raw)
        {
            var stream = new BinaryTokenStreamWriter();
            byte[] result;
            try
            {
                SerializationContext.Current.Reset();
                SerializeInner(raw, stream, null);
                SerializationContext.Current.Reset();
                result = stream.ToByteArray();
            }
            finally
            {
                stream.ReleaseBuffers();
            }
            return result;
        }

#endregion

#region Deserializing

        /// <summary>
        /// Deserialize the next object from the input binary stream.
        /// </summary>
        /// <param name="stream">Input stream.</param>
        /// <returns>Object of the required Type, rehydrated from the input stream.</returns>
        public static object Deserialize(BinaryTokenStreamReader stream)
        {
            return Deserialize(null, stream);
        }

        /// <summary>
        /// Deserialize the next object from the input binary stream.
        /// </summary>
        /// <typeparam name="T">Type to return.</typeparam>
        /// <param name="stream">Input stream.</param>
        /// <returns>Object of the required Type, rehydrated from the input stream.</returns>
        public static T Deserialize<T>(BinaryTokenStreamReader stream)
        {
            return (T)Deserialize(typeof(T), stream);
        }

        /// <summary>
        /// Deserialize the next object from the input binary stream.
        /// </summary>
        /// <param name="t">Type to return.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>Object of the required Type, rehydrated from the input stream.</returns>
        public static object Deserialize(Type t, BinaryTokenStreamReader stream)
        {
            Stopwatch timer = null;
            if (StatisticsCollector.CollectSerializationStats)
            {
                timer = new Stopwatch();
                timer.Start();
                Deserializations.Increment();
            }
            object result = null;
            
            DeserializationContext.Current.Reset();
            result = DeserializeInner(t, stream);
            DeserializationContext.Current.Reset();
            
            if (timer!=null)
            {
                timer.Stop();
                DeserTimeStatistic.IncrementBy(timer.ElapsedTicks);
            }
            return result;
        }

        /// <summary>
        /// Deserialize the next object from the input binary stream.
        /// </summary>
        /// <typeparam name="T">Type to return.</typeparam>
        /// <param name="stream">Input stream.</param>
        /// <returns>Object of the required Type, rehydrated from the input stream.</returns>
        public static T DeserializeInner<T>(BinaryTokenStreamReader stream)
        {
            return (T)DeserializeInner(typeof(T), stream);
        }

        /// <summary>
        /// Deserialize the next object from the input binary stream.
        /// </summary>
        /// <param name="expected">Type to return.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>Object of the required Type, rehydrated from the input stream.</returns>
        public static object DeserializeInner(Type expected, BinaryTokenStreamReader stream)
        {
            var previousOffset = DeserializationContext.Current.CurrentObjectOffset;
            DeserializationContext.Current.CurrentObjectOffset = stream.CurrentPosition;

            try
            {
                // NOTE: we don't check that the actual dynamic result implements the expected type.
                // We'll allow a cast exception higher up to catch this.
                SerializationTokenType token;
                object result;
                if (stream.TryReadSimpleType(out result, out token))
                {
                    return result;
                }

                // Special serializations (reference, fallback)
                if (token == SerializationTokenType.Reference)
                {
                    var offset = stream.ReadInt();
                    result = DeserializationContext.Current.FetchReferencedObject(offset);
                    return result;
                }
                if (token == SerializationTokenType.Fallback)
                {
                    var fallbackResult = FallbackDeserializer(stream, expected);
                    DeserializationContext.Current.RecordObject(fallbackResult);
                    return fallbackResult;
                }

                Type resultType;
                if (token == SerializationTokenType.ExpectedType)
                {
                    if (expected == null)
                    {
                        throw new SerializationException("ExpectedType token encountered but no expected type provided");
                    }

                    resultType = expected;
                }
                else if (token == SerializationTokenType.SpecifiedType)
                {
                    resultType = stream.ReadSpecifiedTypeHeader();
                }
                else
                {
                    throw new SerializationException("Unexpected token '" + token + "' introducing type specifier");
                }

                // Handle object, which is easy
                if (resultType.TypeHandle.Equals(objectTypeHandle))
                {
                    return new object();
                }

                var resultTypeInfo = resultType.GetTypeInfo();
                // Handle enums
                if (resultTypeInfo.IsEnum)
                {
                    result = ReadEnum(stream, resultType);
                    return result;
                }

                if (resultTypeInfo.IsArray)
                {
                    result = DeserializeArray(resultType, stream);
                    DeserializationContext.Current.RecordObject(result);
                    return result;
                }

                IExternalSerializer serializer;
                if (TryLookupExternalSerializer(resultType, out serializer))
                {
                    result = serializer.Deserialize(resultType, stream);
                    DeserializationContext.Current.RecordObject(result);
                    return result;
                }

                var deser = GetDeserializer(resultType);
                if (deser != null)
                {
                    result = deser(resultType, stream);
                    DeserializationContext.Current.RecordObject(result);
                    return result;
                }

                throw new SerializationException(
                    "Unsupported type '" + resultType.OrleansTypeName()
                    + "' encountered. Perhaps you need to mark it [Serializable] or define a custom serializer for it?");
            }
            finally
            {
                DeserializationContext.Current.CurrentObjectOffset = previousOffset;
            }
        }

        private static object DeserializeArray(Type resultType, BinaryTokenStreamReader stream)
        {
            var lengths = ReadArrayLengths(resultType.GetArrayRank(), stream);
            var rank = lengths.Length;
            var et = resultType.GetElementType();

            // Optimized special cases
            if (rank == 1)
            {
                if (et.TypeHandle.Equals(byteTypeHandle))
                    return stream.ReadBytes(lengths[0]);

                if (et.TypeHandle.Equals(sbyteTypeHandle))
                {
                    var result = new sbyte[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(shortTypeHandle))
                {
                    var result = new short[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(intTypeHandle))
                {
                    var result = new int[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(longTypeHandle))
                {
                    var result = new long[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(ushortTypeHandle))
                {
                    var result = new ushort[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(uintTypeHandle))
                {
                    var result = new uint[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(ulongTypeHandle))
                {
                    var result = new ulong[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(doubleTypeHandle))
                {
                    var result = new double[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(floatTypeHandle))
                {
                    var result = new float[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(charTypeHandle))
                {
                    var result = new char[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
                if (et.TypeHandle.Equals(boolTypeHandle))
                {
                    var result = new bool[lengths[0]];
                    var n = Buffer.ByteLength(result);
                    stream.ReadBlockInto(result, n);
                    return result;
                }
            }

            var array = Array.CreateInstance(et, lengths);

            if (rank == 1)
            {
                for (int i = 0; i < lengths[0]; i++)
                    array.SetValue(DeserializeInner(et, stream), i);
            }
            else if (rank == 2)
            {
                for (int i = 0; i < lengths[0]; i++)
                    for (int j = 0; j < lengths[1]; j++)
                        array.SetValue(DeserializeInner(et, stream), i, j);
            }
            else
            {
                var index = new int[rank];
                var sizes = new int[rank];
                sizes[rank - 1] = 1;
                for (var k = rank - 2; k >= 0; k--)
                    sizes[k] = sizes[k + 1]*lengths[k + 1];

                for (var i = 0; i < array.Length; i++)
                {
                    int k = i;
                    for (int n = 0; n < rank; n++)
                    {
                        int offset = k / sizes[n];
                        k = k - offset * sizes[n];
                        index[n] = offset;
                    }
                    array.SetValue(DeserializeInner(et, stream), index);
                }
            }

            return array;
        }

        private static int[] ReadArrayLengths(int n, BinaryTokenStreamReader stream)
        {
            var result = new int[n];
            for (var i = 0; i < n; i++)
                result[i] = stream.ReadInt();

            return result;
        }

        internal static SerializerMethods.Deserializer GetDeserializer(Type t)
        {
            SerializerMethods.Deserializer deser;

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

        /// <summary>
        /// Deserialize data from the specified byte[] and rehydrate backi into objects.
        /// </summary>
        /// <typeparam name="T">Type of data to be returned.</typeparam>
        /// <param name="data">Input data.</param>
        /// <returns>Object of the required Type, rehydrated from the input stream.</returns>
        public static T DeserializeFromByteArray<T>(byte[] data)
        {
            var stream = new BinaryTokenStreamReader(data);
            DeserializationContext.Current.Reset();
            var result = DeserializeInner<T>(stream);
            DeserializationContext.Current.Reset();
            return result;
        }

#endregion

#region Special case code for message headers

        internal static void SerializeMessageHeaders(Message.HeadersContainer headers, BinaryTokenStreamWriter stream)
        {
            Stopwatch timer = null;
            if (StatisticsCollector.CollectSerializationStats)
            {
                timer = new Stopwatch();
                timer.Start();
            }

            var ser = GetSerializer(typeof(Message.HeadersContainer));
            ser(headers, stream, typeof(Message.HeadersContainer));

            if (timer != null)
            {
                timer.Stop();
                HeaderSers.Increment();
                HeaderSerTime.IncrementBy(timer.ElapsedTicks);
            }
        }

        internal static Message.HeadersContainer DeserializeMessageHeaders(BinaryTokenStreamReader stream)
        {
            Stopwatch timer = null;
            if (StatisticsCollector.CollectSerializationStats)
            {
                timer = new Stopwatch();
                timer.Start();
            }

             var des = GetDeserializer(typeof(Message.HeadersContainer));
             var headers = (Message.HeadersContainer)des(typeof(Message.HeadersContainer), stream);

            if (timer != null)
            {
                timer.Stop();
                HeaderDesers.Increment();
                HeaderDeserTime.IncrementBy(timer.ElapsedTicks);
            }

            return headers;
        }
        
        private static bool TryLookupExternalSerializer(Type t, out IExternalSerializer serializer)
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
                //Register(t, serializer.DeepCopy, serializer.Serialize, serializer.Deserialize, true);
                RegisterTypeName(t);
            }
   
            return serializer != null;
        }

#endregion

#region Fallback serializer and deserializer

        private static void FallbackSerializer(object raw, BinaryTokenStreamWriter stream, Type t)
        {
            Stopwatch timer = null;
            if (StatisticsCollector.CollectSerializationStats)
            {
                timer = new Stopwatch();
                timer.Start();
                FallbackSerializations.Increment();
            }

            stream.Write(SerializationTokenType.Fallback);
            fallbackSerializer.Serialize(raw, stream, t);

            if (StatisticsCollector.CollectSerializationStats)
            {
                timer.Stop();
                FallbackSerTimeStatistic.IncrementBy(timer.ElapsedTicks);
            }
        }

        private static object FallbackDeserializer(BinaryTokenStreamReader stream, Type expectedType)
        {
            Stopwatch timer = null;
            if (StatisticsCollector.CollectSerializationStats)
            {
                timer = new Stopwatch();
                timer.Start();
                FallbackDeserializations.Increment();
            }
            var retVal = fallbackSerializer.Deserialize(expectedType, stream);
            if (timer != null)
            {
                timer.Stop();
                FallbackDeserTimeStatistic.IncrementBy(timer.ElapsedTicks);
            }

            return retVal;
        }

        private static IExternalSerializer GetFallbackSerializer(TypeInfo fallbackType)
        {
            IExternalSerializer serializer;
            if (fallbackType != null)
            {
                serializer = (IExternalSerializer)Activator.CreateInstance(fallbackType.AsType());
            }
            else
            {
#if NETSTANDARD
                serializer = new ILBasedSerializer();
#else
                serializer = new BinaryFormatterSerializer();
#endif
            }

            serializer.Initialize(logger);
            return serializer;
        }

#if !NETSTANDARD_TODO
        private static Assembly OnResolveEventHandler(Object sender, ResolveEventArgs arg)
        {
            // types defined in assemblies loaded by path name (e.g. Assembly.LoadFrom) aren't resolved during deserialization without some help.
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
                if (assembly.FullName == arg.Name)
                    return assembly;

            return null;
        }
#endif

        private static object FallbackSerializationDeepCopy(object obj)
        {
            Stopwatch timer = null;
            if (StatisticsCollector.CollectSerializationStats)
            {
                timer = new Stopwatch();
                timer.Start();
                FallbackCopies.Increment();
            }

            var retVal = fallbackSerializer.DeepCopy(obj);
            if (StatisticsCollector.CollectSerializationStats)
            {
                timer.Stop();
                FallbackCopiesTimeStatistic.IncrementBy(timer.ElapsedTicks);
            }
            return retVal;
        }

#endregion

#region Utilities

        internal static Type ResolveTypeName(string typeName)
        {
            Type t;

            if (types.TryGetValue(typeName, out t))
                return t;

            if (typeName[typeName.Length - 1] == ']')
            {
                // It's an array type declaration: elementType[,,,]
                var j = typeName.LastIndexOf('[');
                // The rank of the array will be the length of the string, minus the index of the [, minus 1; it's the number of commas between the [ and the ]
                var rank = typeName.Length - j - 1;
                var baseName = typeName.Substring(0, j);
                var baseType = ResolveTypeName(baseName);
                return rank == 1 ? baseType.MakeArrayType() : baseType.MakeArrayType(rank);
            }

            var i = typeName.IndexOf('<');
            if (i >= 0)
            {
                // It's a generic type, definitionType<arg1,arg2,arg3,...>
                var baseName = typeName.Substring(0, i) + "'";
                var typeArgs = new List<Type>();
                i++; // Skip the <
                while (i < typeName.Length - 1)
                {
                    // Get the next type argument, watching for matching angle brackets
                    int n = i;
                    int nestingDepth = 0;
                    while (n < typeName.Length - 1)
                    {
                        if (typeName[n] == '<')
                        {
                            nestingDepth++;
                        }
                        else if (typeName[n] == '>')
                        {
                            if (nestingDepth == 0)
                                break;

                            nestingDepth--;
                        }
                        else if (typeName[n] == ',')
                        {
                            if (nestingDepth == 0)
                                break;
                        }
                        n++;
                    }
                    typeArgs.Add(ResolveTypeName(typeName.Substring(i, n - i)));
                    i = n + 1;
                }
                var baseType = ResolveTypeName(baseName + typeArgs.Count);
                return baseType.MakeGenericType(typeArgs.ToArray<Type>());
            }

            throw new TypeAccessException("Type string \"" + typeName + "\" cannot be resolved.");
        }

#endregion

        public static Delegate GetGetter(FieldInfo field)
        {
            return GetGetDelegate(
                field,
                typeof(Func<,>).MakeGenericType(field.DeclaringType, field.FieldType),
                new[] { field.DeclaringType });
        }

        /// <summary>
        /// Returns a delegate to get the value of a specified field.
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
        /// <param name="delegateType">The delegate type.</param>
        /// <param name="parameterTypes">The parameter types.</param>
        /// <returns>A delegate to get the value of a specified field.</returns>
        private static Delegate GetGetDelegate(FieldInfo field, Type delegateType, Type[] parameterTypes)
        {
            var declaringType = field.DeclaringType;
            if (declaringType == null)
            {
                throw new InvalidOperationException("Field " + field.Name + " does not have a declaring type.");
            }

            // Create a method to hold the generated IL.
            var method = new DynamicMethod(
                field.Name + "Get",
                field.FieldType,
                parameterTypes,
                field.FieldType.GetTypeInfo().Module,
                true);

            // Emit IL to return the value of the Transaction property.
            var emitter = method.GetILGenerator();
            emitter.Emit(OpCodes.Ldarg_0);
            emitter.Emit(OpCodes.Ldfld, field);
            emitter.Emit(OpCodes.Ret);

            return method.CreateDelegate(delegateType);
        }

        /// <summary>
        /// Returns a delegate to set the value of this field for an instance.
        /// </summary>
        /// <returns>A delegate to set the value of this field for an instance.</returns>
        public static Delegate GetReferenceSetter(FieldInfo field)
        {
            var delegateType = typeof(Action<,>).MakeGenericType(field.DeclaringType, field.FieldType);
            return GetSetDelegate(field, delegateType, new[] { field.DeclaringType, field.FieldType });
        }

        /// <summary>
        /// Returns a delegate to set the value of this field for an instance.
        /// </summary>
        /// <returns>A delegate to set the value of this field for an instance.</returns>
        public static Delegate GetValueSetter(FieldInfo field)
        {
            var declaringType = field.DeclaringType;
            if (declaringType == null)
            {
                throw new InvalidOperationException("Field " + field.Name + " does not have a declaring type.");
            }

            // Value types need to be passed by-ref.
            var parameterTypes = new[] { declaringType.MakeByRefType(), field.FieldType };
            var delegateType = typeof(ValueTypeSetter<,>).MakeGenericType(field.DeclaringType, field.FieldType);

            return GetSetDelegate(field, delegateType, parameterTypes);
        }

        /// <summary>
        /// Returns a delegate to set the value of a specified field.
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
        /// <param name="delegateType">The delegate type.</param>
        /// <param name="parameterTypes">The parameter types.</param>
        /// <returns>A delegate to set the value of a specified field.</returns>
        private static Delegate GetSetDelegate(FieldInfo field, Type delegateType, Type[] parameterTypes)
        {
            var declaringType = field.DeclaringType;
            if (declaringType == null)
            {
                throw new InvalidOperationException("Field " + field.Name + " does not have a declaring type.");
            }

            // Create a method to hold the generated IL.
            var method = new DynamicMethod(field.Name + "Set", null, parameterTypes, field.FieldType.GetTypeInfo().Module, true);

            // Emit IL to return the value of the Transaction property.
            var emitter = method.GetILGenerator();
            emitter.Emit(OpCodes.Ldarg_0);
            emitter.Emit(OpCodes.Ldarg_1);
            emitter.Emit(OpCodes.Stfld, field);
            emitter.Emit(OpCodes.Ret);

            return method.CreateDelegate(delegateType);
        }

        /// <summary>
        /// Internal test method to do a round-trip Serialize+Deserialize loop
        /// </summary>
        public static T RoundTripSerializationForTesting<T>(T source)
        {
            byte[] data = SerializeToByteArray(source);
            return DeserializeFromByteArray<T>(data);
        }

        public static void LogRegisteredTypes()
        {
            int count = 0;
            var lines = new StringBuilder();
            foreach (var name in types.Keys.OrderBy(k => k))
            {
                var line = new StringBuilder();
                RuntimeTypeHandle typeHandle = types[name].TypeHandle;
                bool discardLine = true;

                line.Append("    - ");
                line.Append(name);
                line.Append(" :");
                if (copiers.ContainsKey(typeHandle))
                {
                    line.Append(" copier");
                    discardLine = false;
                }
                if (deserializers.ContainsKey(typeHandle))
                {
                    line.Append(" deserializer");
                    discardLine = false;
                }
                if (serializers.ContainsKey(typeHandle))
                {
                    line.Append(" serializer");
                    discardLine = false;
                }
                if (!discardLine)
                {
                    line.AppendLine();
                    lines.Append(line);
                    ++count;
                }
            }

            var report = String.Format("Registered artifacts for {0} types:" + Environment.NewLine + "{1}", count, lines);
            logger.LogWithoutBulkingAndTruncating(Severity.Verbose, ErrorCode.SerMgr_ArtifactReport, report);
        }

        /// <summary>
        /// Loads the external srializers and places them into a hash set
        /// </summary>
        /// <param name="providerTypes">The list of types that implement <see cref="IExternalSerializer"/></param>
        private static void RegisterSerializationProviders(List<TypeInfo> providerTypes)
        {
            if (providerTypes == null)
            {
                return;
            }

            externalSerializers.Clear();
            typeToExternalSerializerDictionary.Clear();
            providerTypes.ForEach(
                typeInfo =>
                {
                    try
                    {
                        var serializer = Activator.CreateInstance(typeInfo.AsType()) as IExternalSerializer;
                        serializer.Initialize(logger);
                        externalSerializers.Add(serializer);
                    }
                    catch (Exception exception)
                    {
                        logger.Error(ErrorCode.SerMgr_ErrorLoadingAssemblyTypes, "Failed to create instance of type: " + typeInfo.FullName, exception);
                    }
                });
        }
    }
}
