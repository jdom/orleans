#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("OrleansProviders, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans.Providers.Streams.Generator
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Providers_Streams_Generator_GeneratedBatchContainerSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer).@GetTypeInfo().@GetField("<Payload>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.Object> setField3 = (global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer).@GetTypeInfo().@GetField("<RealToken>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::Orleans.Providers.Streams.Common.EventSequenceToken> setField2 = (global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::Orleans.Providers.Streams.Common.EventSequenceToken>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer).@GetTypeInfo().@GetField("<StreamGuid>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.Guid> setField0 = (global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.Guid>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer).@GetTypeInfo().@GetField("<StreamNamespace>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.String> setField1 = (global::System.Action<global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer input = ((global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)original);
            global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer result = (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer));
            setField3(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Payload));
            setField2(result, (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@RealToken));
            setField0(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@StreamGuid));
            setField1(result, input.@StreamNamespace);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer input = (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Payload, stream, typeof (global::System.Object));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RealToken, stream, typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamGuid, stream, typeof (global::System.Guid));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamNamespace, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer result = (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField3(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), stream));
            setField2(result, (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken), stream));
            setField0(result, (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Providers.Streams.Generator.GeneratedBatchContainer), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Providers_Streams_Generator_GeneratedBatchContainerSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Generator.GeneratedEvent)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Providers_Streams_Generator_GeneratedEventSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedEvent input = ((global::Orleans.Providers.Streams.Generator.GeneratedEvent)original);
            global::Orleans.Providers.Streams.Generator.GeneratedEvent result = new global::Orleans.Providers.Streams.Generator.GeneratedEvent();
            result.@EventType = input.@EventType;
            result.@Payload = (global::System.Int32[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Payload);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedEvent input = (global::Orleans.Providers.Streams.Generator.GeneratedEvent)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventType, stream, typeof (global::Orleans.Providers.Streams.Generator.GeneratedEvent.GeneratedEventType));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Payload, stream, typeof (global::System.Int32[]));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Providers.Streams.Generator.GeneratedEvent result = new global::Orleans.Providers.Streams.Generator.GeneratedEvent();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@EventType = (global::Orleans.Providers.Streams.Generator.GeneratedEvent.GeneratedEventType)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Providers.Streams.Generator.GeneratedEvent.GeneratedEventType), stream);
            result.@Payload = (global::System.Int32[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32[]), stream);
            return (global::Orleans.Providers.Streams.Generator.GeneratedEvent)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Providers.Streams.Generator.GeneratedEvent), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Providers_Streams_Generator_GeneratedEventSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Providers_Streams_Generator_SimpleGeneratorConfigSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig input = ((global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig)original);
            global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig result = new global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig();
            result.@EventsInStream = input.@EventsInStream;
            result.@StreamNamespace = input.@StreamNamespace;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig input = (global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventsInStream, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StreamNamespace, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig result = new global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@EventsInStream = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@StreamNamespace = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Providers.Streams.Generator.SimpleGeneratorConfig), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Providers_Streams_Generator_SimpleGeneratorConfigSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Providers_Streams_Common_EventSequenceTokenSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Providers.Streams.Common.EventSequenceToken input = ((global::Orleans.Providers.Streams.Common.EventSequenceToken)original);
            global::Orleans.Providers.Streams.Common.EventSequenceToken result = (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken));
            result.@EventIndex = input.@EventIndex;
            result.@SequenceNumber = input.@SequenceNumber;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Providers.Streams.Common.EventSequenceToken input = (global::Orleans.Providers.Streams.Common.EventSequenceToken)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@EventIndex, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SequenceNumber, stream, typeof (global::System.Int64));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Providers.Streams.Common.EventSequenceToken result = (global::Orleans.Providers.Streams.Common.EventSequenceToken)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@EventIndex = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@SequenceNumber = (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream);
            return (global::Orleans.Providers.Streams.Common.EventSequenceToken)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Providers.Streams.Common.EventSequenceToken), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Providers_Streams_Common_EventSequenceTokenSerializer()
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
