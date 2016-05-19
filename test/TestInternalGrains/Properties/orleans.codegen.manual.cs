#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("TestInternalGrains, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null")]
namespace UnitTests.TestHelper
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.TestHelper.InterlockedFlag)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_TestHelper_InterlockedFlagSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.TestHelper.InterlockedFlag).@GetTypeInfo().@GetField("_value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.TestHelper.InterlockedFlag, global::System.Int32> getField0 = (global::System.Func<global::UnitTests.TestHelper.InterlockedFlag, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::UnitTests.TestHelper.InterlockedFlag, global::System.Int32> setField0 = (global::System.Action<global::UnitTests.TestHelper.InterlockedFlag, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.TestHelper.InterlockedFlag input = ((global::UnitTests.TestHelper.InterlockedFlag)original);
            global::UnitTests.TestHelper.InterlockedFlag result = new global::UnitTests.TestHelper.InterlockedFlag();
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.TestHelper.InterlockedFlag input = (global::UnitTests.TestHelper.InterlockedFlag)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.TestHelper.InterlockedFlag result = new global::UnitTests.TestHelper.InterlockedFlag();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::UnitTests.TestHelper.InterlockedFlag)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.TestHelper.InterlockedFlag), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_TestHelper_InterlockedFlagSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.EchoTaskGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_EchoTaskGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.EchoTaskGrainState input = ((global::UnitTests.Grains.EchoTaskGrainState)original);
            global::UnitTests.Grains.EchoTaskGrainState result = new global::UnitTests.Grains.EchoTaskGrainState();
            result.@LastEcho = input.@LastEcho;
            result.@MyId = input.@MyId;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.EchoTaskGrainState input = (global::UnitTests.Grains.EchoTaskGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@LastEcho, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@MyId, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.EchoTaskGrainState result = new global::UnitTests.Grains.EchoTaskGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@LastEcho = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@MyId = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::UnitTests.Grains.EchoTaskGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.EchoTaskGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_EchoTaskGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.MultifacetFactoryTestGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_MultifacetFactoryTestGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.MultifacetFactoryTestGrainState input = ((global::UnitTests.Grains.MultifacetFactoryTestGrainState)original);
            global::UnitTests.Grains.MultifacetFactoryTestGrainState result = new global::UnitTests.Grains.MultifacetFactoryTestGrainState();
            result.@Reader = (global::UnitTests.GrainInterfaces.IMultifacetReader)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Reader);
            result.@Writer = (global::UnitTests.GrainInterfaces.IMultifacetWriter)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Writer);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.MultifacetFactoryTestGrainState input = (global::UnitTests.Grains.MultifacetFactoryTestGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Reader, stream, typeof (global::UnitTests.GrainInterfaces.IMultifacetReader));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Writer, stream, typeof (global::UnitTests.GrainInterfaces.IMultifacetWriter));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.MultifacetFactoryTestGrainState result = new global::UnitTests.Grains.MultifacetFactoryTestGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Reader = (global::UnitTests.GrainInterfaces.IMultifacetReader)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::UnitTests.GrainInterfaces.IMultifacetReader), stream);
            result.@Writer = (global::UnitTests.GrainInterfaces.IMultifacetWriter)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::UnitTests.GrainInterfaces.IMultifacetWriter), stream);
            return (global::UnitTests.Grains.MultifacetFactoryTestGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.MultifacetFactoryTestGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_MultifacetFactoryTestGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.MultifacetTestGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_MultifacetTestGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.MultifacetTestGrainState input = ((global::UnitTests.Grains.MultifacetTestGrainState)original);
            global::UnitTests.Grains.MultifacetTestGrainState result = new global::UnitTests.Grains.MultifacetTestGrainState();
            result.@Value = input.@Value;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.MultifacetTestGrainState input = (global::UnitTests.Grains.MultifacetTestGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Value, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.MultifacetTestGrainState result = new global::UnitTests.Grains.MultifacetTestGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Value = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::UnitTests.Grains.MultifacetTestGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.MultifacetTestGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_MultifacetTestGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.PersistenceTestGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_PersistenceTestGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.PersistenceTestGrainState input = ((global::UnitTests.Grains.PersistenceTestGrainState)original);
            global::UnitTests.Grains.PersistenceTestGrainState result = new global::UnitTests.Grains.PersistenceTestGrainState();
            result.@Field1 = input.@Field1;
            result.@Field2 = input.@Field2;
            result.@SortedDict = (global::System.Collections.Generic.SortedDictionary<global::System.Int32, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SortedDict);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.PersistenceTestGrainState input = (global::UnitTests.Grains.PersistenceTestGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Field1, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Field2, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SortedDict, stream, typeof (global::System.Collections.Generic.SortedDictionary<global::System.Int32, global::System.Int32>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.PersistenceTestGrainState result = new global::UnitTests.Grains.PersistenceTestGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Field1 = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Field2 = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@SortedDict = (global::System.Collections.Generic.SortedDictionary<global::System.Int32, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.SortedDictionary<global::System.Int32, global::System.Int32>), stream);
            return (global::UnitTests.Grains.PersistenceTestGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.PersistenceTestGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_PersistenceTestGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.PersistenceGenericGrainState<>))]
    internal class OrleansCodeGenUnitTests_Grains_PersistenceGenericGrainStateSerializer<T>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.PersistenceGenericGrainState<T> input = ((global::UnitTests.Grains.PersistenceGenericGrainState<T>)original);
            global::UnitTests.Grains.PersistenceGenericGrainState<T> result = new global::UnitTests.Grains.PersistenceGenericGrainState<T>();
            result.@Field1 = (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Field1);
            result.@Field2 = input.@Field2;
            result.@SortedDict = (global::System.Collections.Generic.SortedDictionary<T, T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SortedDict);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.PersistenceGenericGrainState<T> input = (global::UnitTests.Grains.PersistenceGenericGrainState<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Field1, stream, typeof (T));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Field2, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SortedDict, stream, typeof (global::System.Collections.Generic.SortedDictionary<T, T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.PersistenceGenericGrainState<T> result = new global::UnitTests.Grains.PersistenceGenericGrainState<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Field1 = (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream);
            result.@Field2 = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@SortedDict = (global::System.Collections.Generic.SortedDictionary<T, T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.SortedDictionary<T, T>), stream);
            return (global::UnitTests.Grains.PersistenceGenericGrainState<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_PersistenceGenericGrainStateSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.PersistenceGenericGrainState<>), typeof (OrleansCodeGenUnitTests_Grains_PersistenceGenericGrainStateSerializer<>));
        }

        static OrleansCodeGenUnitTests_Grains_PersistenceGenericGrainStateSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_MemoryStorageTestGrainSerializer_NestedPersistenceTestGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState input = ((global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState)original);
            global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState result = new global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState();
            result.@Field1 = input.@Field1;
            result.@Field2 = input.@Field2;
            result.@SortedDict = (global::System.Collections.Generic.SortedDictionary<global::System.Int32, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SortedDict);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState input = (global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Field1, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Field2, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SortedDict, stream, typeof (global::System.Collections.Generic.SortedDictionary<global::System.Int32, global::System.Int32>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState result = new global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Field1 = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Field2 = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@SortedDict = (global::System.Collections.Generic.SortedDictionary<global::System.Int32, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.SortedDictionary<global::System.Int32, global::System.Int32>), stream);
            return (global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.MemoryStorageTestGrain.NestedPersistenceTestGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_MemoryStorageTestGrainSerializer_NestedPersistenceTestGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.UserState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_UserStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.UserState input = ((global::UnitTests.Grains.UserState)original);
            global::UnitTests.Grains.UserState result = new global::UnitTests.Grains.UserState();
            result.@Friends = (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IUser>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Friends);
            result.@Name = input.@Name;
            result.@Status = input.@Status;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.UserState input = (global::UnitTests.Grains.UserState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Friends, stream, typeof (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IUser>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Status, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.UserState result = new global::UnitTests.Grains.UserState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Friends = (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IUser>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IUser>), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Status = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::UnitTests.Grains.UserState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.UserState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_UserStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.DerivedUserState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_DerivedUserStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.DerivedUserState input = ((global::UnitTests.Grains.DerivedUserState)original);
            global::UnitTests.Grains.DerivedUserState result = new global::UnitTests.Grains.DerivedUserState();
            result.@Field1 = input.@Field1;
            result.@Field2 = input.@Field2;
            result.@Friends = (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IUser>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Friends);
            result.@Name = input.@Name;
            result.@Status = input.@Status;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.DerivedUserState input = (global::UnitTests.Grains.DerivedUserState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Field1, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Field2, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Friends, stream, typeof (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IUser>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Status, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.DerivedUserState result = new global::UnitTests.Grains.DerivedUserState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Field1 = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Field2 = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Friends = (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IUser>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IUser>), stream);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Status = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::UnitTests.Grains.DerivedUserState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.DerivedUserState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_DerivedUserStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.StateForIReentrentGrain)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_StateForIReentrentGrainSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.StateForIReentrentGrain input = ((global::UnitTests.Grains.StateForIReentrentGrain)original);
            global::UnitTests.Grains.StateForIReentrentGrain result = new global::UnitTests.Grains.StateForIReentrentGrain();
            result.@DictOne = (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@DictOne);
            result.@DictTwo = (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@DictTwo);
            result.@One = input.@One;
            result.@Two = input.@Two;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.StateForIReentrentGrain input = (global::UnitTests.Grains.StateForIReentrentGrain)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DictOne, stream, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@DictTwo, stream, typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@One, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Two, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.StateForIReentrentGrain result = new global::UnitTests.Grains.StateForIReentrentGrain();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@DictOne = (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32>), stream);
            result.@DictTwo = (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::System.String, global::System.Int32>), stream);
            result.@One = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Two = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::UnitTests.Grains.StateForIReentrentGrain)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.StateForIReentrentGrain), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_StateForIReentrentGrainSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.InternalGrainStateData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_InternalGrainStateDataSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.InternalGrainStateData input = ((global::UnitTests.Grains.InternalGrainStateData)original);
            global::UnitTests.Grains.InternalGrainStateData result = new global::UnitTests.Grains.InternalGrainStateData();
            result.@One = input.@One;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.InternalGrainStateData input = (global::UnitTests.Grains.InternalGrainStateData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@One, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.InternalGrainStateData result = new global::UnitTests.Grains.InternalGrainStateData();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@One = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::UnitTests.Grains.InternalGrainStateData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.InternalGrainStateData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_InternalGrainStateDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.StateInheritanceTestGrainData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_StateInheritanceTestGrainDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.StateInheritanceTestGrainData).@GetTypeInfo().@GetField("<Field2>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.StateInheritanceTestGrainData, global::System.Int32> getField0 = (global::System.Func<global::UnitTests.Grains.StateInheritanceTestGrainData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::UnitTests.Grains.StateInheritanceTestGrainData, global::System.Int32> setField0 = (global::System.Action<global::UnitTests.Grains.StateInheritanceTestGrainData, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.StateInheritanceTestGrainData input = ((global::UnitTests.Grains.StateInheritanceTestGrainData)original);
            global::UnitTests.Grains.StateInheritanceTestGrainData result = new global::UnitTests.Grains.StateInheritanceTestGrainData();
            result.@Field1 = input.@Field1;
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.StateInheritanceTestGrainData input = (global::UnitTests.Grains.StateInheritanceTestGrainData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Field1, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.StateInheritanceTestGrainData result = new global::UnitTests.Grains.StateInheritanceTestGrainData();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Field1 = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::UnitTests.Grains.StateInheritanceTestGrainData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.StateInheritanceTestGrainData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_StateInheritanceTestGrainDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.StreamItem)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_StreamItemSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.StreamItem).@GetTypeInfo().@GetField("Data", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.StreamItem, global::System.String> getField0 = (global::System.Func<global::UnitTests.Grains.StreamItem, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::UnitTests.Grains.StreamItem, global::System.String> setField0 = (global::System.Action<global::UnitTests.Grains.StreamItem, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::UnitTests.Grains.StreamItem).@GetTypeInfo().@GetField("StreamId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.StreamItem, global::System.Guid> getField1 = (global::System.Func<global::UnitTests.Grains.StreamItem, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::UnitTests.Grains.StreamItem, global::System.Guid> setField1 = (global::System.Action<global::UnitTests.Grains.StreamItem, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.StreamItem input = ((global::UnitTests.Grains.StreamItem)original);
            global::UnitTests.Grains.StreamItem result = (global::UnitTests.Grains.StreamItem)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.StreamItem));
            setField0(result, getField0(input));
            setField1(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.StreamItem input = (global::UnitTests.Grains.StreamItem)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Guid));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.StreamItem result = (global::UnitTests.Grains.StreamItem)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.StreamItem));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream));
            return (global::UnitTests.Grains.StreamItem)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.StreamItem), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_StreamItemSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.ConsumerObserver)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_ConsumerObserverSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::UnitTests.Grains.ConsumerObserver).@GetTypeInfo().@GetField("<ProviderName>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::UnitTests.Grains.ConsumerObserver, global::System.String> setField3 = (global::System.Action<global::UnitTests.Grains.ConsumerObserver, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.ConsumerObserver).@GetTypeInfo().@GetField("_itemsConsumed", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.ConsumerObserver, global::System.Int32> getField0 = (global::System.Func<global::UnitTests.Grains.ConsumerObserver, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::UnitTests.Grains.ConsumerObserver, global::System.Int32> setField0 = (global::System.Action<global::UnitTests.Grains.ConsumerObserver, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::UnitTests.Grains.ConsumerObserver).@GetTypeInfo().@GetField("_streamId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.ConsumerObserver, global::System.Guid> getField1 = (global::System.Func<global::UnitTests.Grains.ConsumerObserver, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::UnitTests.Grains.ConsumerObserver, global::System.Guid> setField1 = (global::System.Action<global::UnitTests.Grains.ConsumerObserver, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::UnitTests.Grains.ConsumerObserver).@GetTypeInfo().@GetField("_streamNamespace", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.ConsumerObserver, global::System.String> getField2 = (global::System.Func<global::UnitTests.Grains.ConsumerObserver, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::UnitTests.Grains.ConsumerObserver, global::System.String> setField2 = (global::System.Action<global::UnitTests.Grains.ConsumerObserver, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.ConsumerObserver input = ((global::UnitTests.Grains.ConsumerObserver)original);
            global::UnitTests.Grains.ConsumerObserver result = (global::UnitTests.Grains.ConsumerObserver)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.ConsumerObserver));
            setField3(result, input.@ProviderName);
            setField0(result, getField0(input));
            setField1(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField2(result, getField2(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.ConsumerObserver input = (global::UnitTests.Grains.ConsumerObserver)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProviderName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.ConsumerObserver result = (global::UnitTests.Grains.ConsumerObserver)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.ConsumerObserver));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField1(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::UnitTests.Grains.ConsumerObserver)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.ConsumerObserver), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_ConsumerObserverSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.ProducerObserver)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_ProducerObserverSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::UnitTests.Grains.ProducerObserver).@GetTypeInfo().@GetField("_cleanedUpFlag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.ProducerObserver, global::UnitTests.TestHelper.InterlockedFlag> getField5 = (global::System.Func<global::UnitTests.Grains.ProducerObserver, global::UnitTests.TestHelper.InterlockedFlag>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::UnitTests.Grains.ProducerObserver, global::UnitTests.TestHelper.InterlockedFlag> setField5 = (global::System.Action<global::UnitTests.Grains.ProducerObserver, global::UnitTests.TestHelper.InterlockedFlag>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::UnitTests.Grains.ProducerObserver).@GetTypeInfo().@GetField("_expectedItemsProduced", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.Int32> getField1 = (global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.Int32> setField1 = (global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.ProducerObserver).@GetTypeInfo().@GetField("_itemsProduced", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.Int32> getField0 = (global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.Int32> setField0 = (global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::UnitTests.Grains.ProducerObserver).@GetTypeInfo().@GetField("_providerName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.String> getField4 = (global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.String> setField4 = (global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::UnitTests.Grains.ProducerObserver).@GetTypeInfo().@GetField("_streamId", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.Guid> getField2 = (global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.Guid> setField2 = (global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::UnitTests.Grains.ProducerObserver).@GetTypeInfo().@GetField("_streamNamespace", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.String> getField3 = (global::System.Func<global::UnitTests.Grains.ProducerObserver, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.String> setField3 = (global::System.Action<global::UnitTests.Grains.ProducerObserver, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.ProducerObserver input = ((global::UnitTests.Grains.ProducerObserver)original);
            global::UnitTests.Grains.ProducerObserver result = (global::UnitTests.Grains.ProducerObserver)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.ProducerObserver));
            setField5(result, (global::UnitTests.TestHelper.InterlockedFlag)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input)));
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            setField4(result, getField4(input));
            setField2(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField3(result, getField3(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.ProducerObserver input = (global::UnitTests.Grains.ProducerObserver)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (global::UnitTests.TestHelper.InterlockedFlag));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.ProducerObserver result = (global::UnitTests.Grains.ProducerObserver)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.ProducerObserver));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField5(result, (global::UnitTests.TestHelper.InterlockedFlag)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::UnitTests.TestHelper.InterlockedFlag), stream));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField4(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField2(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream));
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::UnitTests.Grains.ProducerObserver)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.ProducerObserver), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_ProducerObserverSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_GrainInterfaces_Streaming_ProducerGrain_StateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State input = ((global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State)original);
            global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State result = new global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State();
            result.@Producers = (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IProducerObserver>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Producers);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State input = (global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Producers, stream, typeof (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IProducerObserver>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State result = new global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Producers = (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IProducerObserver>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IProducerObserver>), stream);
            return (global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.GrainInterfaces.Streaming_ProducerGrain_State), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_GrainInterfaces_Streaming_ProducerGrain_StateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_GrainInterfaces_Streaming_ConsumerGrain_StateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State input = ((global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State)original);
            global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State result = new global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State();
            result.@Consumers = (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IConsumerObserver>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Consumers);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State input = (global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Consumers, stream, typeof (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IConsumerObserver>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State result = new global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Consumers = (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IConsumerObserver>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::UnitTests.GrainInterfaces.IConsumerObserver>), stream);
            return (global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.GrainInterfaces.Streaming_ConsumerGrain_State), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_GrainInterfaces_Streaming_ConsumerGrain_StateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.StreamImmutabilityTestObject)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_StreamImmutabilityTestObjectSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.StreamImmutabilityTestObject).@GetTypeInfo().@GetField("MyString", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.StreamImmutabilityTestObject, global::System.String> getField0 = (global::System.Func<global::UnitTests.Grains.StreamImmutabilityTestObject, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::UnitTests.Grains.StreamImmutabilityTestObject, global::System.String> setField0 = (global::System.Action<global::UnitTests.Grains.StreamImmutabilityTestObject, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.StreamImmutabilityTestObject input = ((global::UnitTests.Grains.StreamImmutabilityTestObject)original);
            global::UnitTests.Grains.StreamImmutabilityTestObject result = new global::UnitTests.Grains.StreamImmutabilityTestObject();
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.StreamImmutabilityTestObject input = (global::UnitTests.Grains.StreamImmutabilityTestObject)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.StreamImmutabilityTestObject result = new global::UnitTests.Grains.StreamImmutabilityTestObject();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::UnitTests.Grains.StreamImmutabilityTestObject)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.StreamImmutabilityTestObject), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_StreamImmutabilityTestObjectSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.StreamLifecycleTestGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_StreamLifecycleTestGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.StreamLifecycleTestGrainState input = ((global::UnitTests.Grains.StreamLifecycleTestGrainState)original);
            global::UnitTests.Grains.StreamLifecycleTestGrainState result = new global::UnitTests.Grains.StreamLifecycleTestGrainState();
            result.@ConsumerSubscriptionHandles = (global::System.Collections.Generic.HashSet<global::Orleans.Streams.StreamSubscriptionHandle<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ConsumerSubscriptionHandles);
            result.@IsProducer = input.@IsProducer;
            result.@NumErrors = input.@NumErrors;
            result.@NumMessagesSent = input.@NumMessagesSent;
            result.@Stream = (global::Orleans.Streams.IAsyncStream<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Stream);
            result.@StreamProviderName = input.@StreamProviderName;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.StreamLifecycleTestGrainState input = (global::UnitTests.Grains.StreamLifecycleTestGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ConsumerSubscriptionHandles, stream, typeof (global::System.Collections.Generic.HashSet<global::Orleans.Streams.StreamSubscriptionHandle<global::System.Int32>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IsProducer, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumErrors, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@NumMessagesSent, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Stream, stream, typeof (global::Orleans.Streams.IAsyncStream<global::System.Int32>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamProviderName, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.StreamLifecycleTestGrainState result = new global::UnitTests.Grains.StreamLifecycleTestGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ConsumerSubscriptionHandles = (global::System.Collections.Generic.HashSet<global::Orleans.Streams.StreamSubscriptionHandle<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<global::Orleans.Streams.StreamSubscriptionHandle<global::System.Int32>>), stream);
            result.@IsProducer = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@NumErrors = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@NumMessagesSent = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@Stream = (global::Orleans.Streams.IAsyncStream<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IAsyncStream<global::System.Int32>), stream);
            result.@StreamProviderName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::UnitTests.Grains.StreamLifecycleTestGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.StreamLifecycleTestGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_StreamLifecycleTestGrainStateSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.MyStreamObserver<>))]
    internal class OrleansCodeGenUnitTests_Grains_MyStreamObserverSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::UnitTests.Grains.MyStreamObserver<T>).@GetTypeInfo().@GetField("<NumErrors>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.MyStreamObserver<T>, global::System.Int32> getField1 = (global::System.Func<global::UnitTests.Grains.MyStreamObserver<T>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::UnitTests.Grains.MyStreamObserver<T>, global::System.Int32> setField1 = (global::System.Action<global::UnitTests.Grains.MyStreamObserver<T>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.MyStreamObserver<T>).@GetTypeInfo().@GetField("<NumItems>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.MyStreamObserver<T>, global::System.Int32> getField0 = (global::System.Func<global::UnitTests.Grains.MyStreamObserver<T>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::UnitTests.Grains.MyStreamObserver<T>, global::System.Int32> setField0 = (global::System.Action<global::UnitTests.Grains.MyStreamObserver<T>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::UnitTests.Grains.MyStreamObserver<T>).@GetTypeInfo().@GetField("logger", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::UnitTests.Grains.MyStreamObserver<T>, global::Orleans.Runtime.Logger> getField2 = (global::System.Func<global::UnitTests.Grains.MyStreamObserver<T>, global::Orleans.Runtime.Logger>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::UnitTests.Grains.MyStreamObserver<T>, global::Orleans.Runtime.Logger> setField2 = (global::System.Action<global::UnitTests.Grains.MyStreamObserver<T>, global::Orleans.Runtime.Logger>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.MyStreamObserver<T> input = ((global::UnitTests.Grains.MyStreamObserver<T>)original);
            global::UnitTests.Grains.MyStreamObserver<T> result = (global::UnitTests.Grains.MyStreamObserver<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.MyStreamObserver<T>));
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            setField2(result, (global::Orleans.Runtime.Logger)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.MyStreamObserver<T> input = (global::UnitTests.Grains.MyStreamObserver<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::Orleans.Runtime.Logger));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.MyStreamObserver<T> result = (global::UnitTests.Grains.MyStreamObserver<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.MyStreamObserver<T>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField2(result, (global::Orleans.Runtime.Logger)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.Logger), stream));
            return (global::UnitTests.Grains.MyStreamObserver<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_MyStreamObserverSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.MyStreamObserver<>), typeof (OrleansCodeGenUnitTests_Grains_MyStreamObserverSerializer<>));
        }

        static OrleansCodeGenUnitTests_Grains_MyStreamObserverSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.AsyncObserverArg)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_AsyncObserverArgSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.GenericArg).@GetTypeInfo().@GetField("<A>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::UnitTests.Grains.GenericArg, global::System.String> setField0 = (global::System.Action<global::UnitTests.Grains.GenericArg, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::UnitTests.Grains.GenericArg).@GetTypeInfo().@GetField("<B>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::UnitTests.Grains.GenericArg, global::System.Int32> setField1 = (global::System.Action<global::UnitTests.Grains.GenericArg, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.AsyncObserverArg input = ((global::UnitTests.Grains.AsyncObserverArg)original);
            global::UnitTests.Grains.AsyncObserverArg result = (global::UnitTests.Grains.AsyncObserverArg)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.AsyncObserverArg));
            setField0(result, input.@A);
            setField1(result, input.@B);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.AsyncObserverArg input = (global::UnitTests.Grains.AsyncObserverArg)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@A, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@B, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.AsyncObserverArg result = (global::UnitTests.Grains.AsyncObserverArg)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.AsyncObserverArg));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::UnitTests.Grains.AsyncObserverArg)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.AsyncObserverArg), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_AsyncObserverArgSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.AsyncObservableArg)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_AsyncObservableArgSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.GenericArg).@GetTypeInfo().@GetField("<A>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::UnitTests.Grains.GenericArg, global::System.String> setField0 = (global::System.Action<global::UnitTests.Grains.GenericArg, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::UnitTests.Grains.GenericArg).@GetTypeInfo().@GetField("<B>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::UnitTests.Grains.GenericArg, global::System.Int32> setField1 = (global::System.Action<global::UnitTests.Grains.GenericArg, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.AsyncObservableArg input = ((global::UnitTests.Grains.AsyncObservableArg)original);
            global::UnitTests.Grains.AsyncObservableArg result = (global::UnitTests.Grains.AsyncObservableArg)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.AsyncObservableArg));
            setField0(result, input.@A);
            setField1(result, input.@B);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.AsyncObservableArg input = (global::UnitTests.Grains.AsyncObservableArg)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@A, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@B, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.AsyncObservableArg result = (global::UnitTests.Grains.AsyncObservableArg)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.AsyncObservableArg));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::UnitTests.Grains.AsyncObservableArg)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.AsyncObservableArg), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_AsyncObservableArgSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.AsyncStreamArg)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_AsyncStreamArgSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.GenericArg).@GetTypeInfo().@GetField("<A>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::UnitTests.Grains.GenericArg, global::System.String> setField0 = (global::System.Action<global::UnitTests.Grains.GenericArg, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::UnitTests.Grains.GenericArg).@GetTypeInfo().@GetField("<B>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::UnitTests.Grains.GenericArg, global::System.Int32> setField1 = (global::System.Action<global::UnitTests.Grains.GenericArg, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.AsyncStreamArg input = ((global::UnitTests.Grains.AsyncStreamArg)original);
            global::UnitTests.Grains.AsyncStreamArg result = (global::UnitTests.Grains.AsyncStreamArg)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.AsyncStreamArg));
            setField0(result, input.@A);
            setField1(result, input.@B);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.AsyncStreamArg input = (global::UnitTests.Grains.AsyncStreamArg)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@A, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@B, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.AsyncStreamArg result = (global::UnitTests.Grains.AsyncStreamArg)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.AsyncStreamArg));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::UnitTests.Grains.AsyncStreamArg)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.AsyncStreamArg), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_AsyncStreamArgSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.StreamSubscriptionHandleArg)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_StreamSubscriptionHandleArgSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::UnitTests.Grains.GenericArg).@GetTypeInfo().@GetField("<A>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::UnitTests.Grains.GenericArg, global::System.String> setField0 = (global::System.Action<global::UnitTests.Grains.GenericArg, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::UnitTests.Grains.GenericArg).@GetTypeInfo().@GetField("<B>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::UnitTests.Grains.GenericArg, global::System.Int32> setField1 = (global::System.Action<global::UnitTests.Grains.GenericArg, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.StreamSubscriptionHandleArg input = ((global::UnitTests.Grains.StreamSubscriptionHandleArg)original);
            global::UnitTests.Grains.StreamSubscriptionHandleArg result = (global::UnitTests.Grains.StreamSubscriptionHandleArg)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.StreamSubscriptionHandleArg));
            setField0(result, input.@A);
            setField1(result, input.@B);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.StreamSubscriptionHandleArg input = (global::UnitTests.Grains.StreamSubscriptionHandleArg)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@A, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@B, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.StreamSubscriptionHandleArg result = (global::UnitTests.Grains.StreamSubscriptionHandleArg)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::UnitTests.Grains.StreamSubscriptionHandleArg));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::UnitTests.Grains.StreamSubscriptionHandleArg)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.StreamSubscriptionHandleArg), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_StreamSubscriptionHandleArgSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::UnitTests.Grains.StreamReliabilityTestGrainState)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenUnitTests_Grains_StreamReliabilityTestGrainStateSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::UnitTests.Grains.StreamReliabilityTestGrainState input = ((global::UnitTests.Grains.StreamReliabilityTestGrainState)original);
            global::UnitTests.Grains.StreamReliabilityTestGrainState result = new global::UnitTests.Grains.StreamReliabilityTestGrainState();
            result.@ConsumerSubscriptionHandles = (global::System.Collections.Generic.HashSet<global::Orleans.Streams.StreamSubscriptionHandle<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@ConsumerSubscriptionHandles);
            result.@IsProducer = input.@IsProducer;
            result.@Stream = (global::Orleans.Streams.IAsyncStream<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Stream);
            result.@StreamProviderName = input.@StreamProviderName;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::UnitTests.Grains.StreamReliabilityTestGrainState input = (global::UnitTests.Grains.StreamReliabilityTestGrainState)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ConsumerSubscriptionHandles, stream, typeof (global::System.Collections.Generic.HashSet<global::Orleans.Streams.StreamSubscriptionHandle<global::System.Int32>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IsProducer, stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Stream, stream, typeof (global::Orleans.Streams.IAsyncStream<global::System.Int32>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamProviderName, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::UnitTests.Grains.StreamReliabilityTestGrainState result = new global::UnitTests.Grains.StreamReliabilityTestGrainState();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ConsumerSubscriptionHandles = (global::System.Collections.Generic.HashSet<global::Orleans.Streams.StreamSubscriptionHandle<global::System.Int32>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<global::Orleans.Streams.StreamSubscriptionHandle<global::System.Int32>>), stream);
            result.@IsProducer = (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream);
            result.@Stream = (global::Orleans.Streams.IAsyncStream<global::System.Int32>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Streams.IAsyncStream<global::System.Int32>), stream);
            result.@StreamProviderName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::UnitTests.Grains.StreamReliabilityTestGrainState)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::UnitTests.Grains.StreamReliabilityTestGrainState), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenUnitTests_Grains_StreamReliabilityTestGrainStateSerializer()
        {
            Register();
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
