#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("OrleansRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans.Runtime
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GenericGrainTypeData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_GenericGrainTypeDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<GrainClass>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.String> getField3 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.String> setField3 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<IsReentrant>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> getField6 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> setField6 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<IsStatelessWorker>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> getField7 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> setField7 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<RemoteInterfaceTypes>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>> getField4 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>> setField4 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<StateObjectType>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type> getField5 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type> setField5 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<Type>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type> getField2 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type> setField2 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GenericGrainTypeData).@GetTypeInfo().@GetField("activationType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type> getField0 = (global::System.Func<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type> setField0 = (global::System.Action<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GenericGrainTypeData).@GetTypeInfo().@GetField("stateObjectType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type> getField1 = (global::System.Func<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type> setField1 = (global::System.Action<global::Orleans.Runtime.GenericGrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.GenericGrainTypeData input = ((global::Orleans.Runtime.GenericGrainTypeData)original);
            global::Orleans.Runtime.GenericGrainTypeData result = (global::Orleans.Runtime.GenericGrainTypeData)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.Runtime.GenericGrainTypeData));
            setField3(result, getField3(input));
            setField6(result, getField6(input));
            setField7(result, getField7(input));
            setField4(result, (global::System.Collections.Generic.List<global::System.Type>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input)));
            setField5(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input)));
            setField2(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.GenericGrainTypeData input = (global::Orleans.Runtime.GenericGrainTypeData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.Collections.Generic.List<global::System.Type>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (global::System.Type));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Type));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Type));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Type));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.GenericGrainTypeData result = (global::Orleans.Runtime.GenericGrainTypeData)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.Runtime.GenericGrainTypeData));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField6(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField7(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField4(result, (global::System.Collections.Generic.List<global::System.Type>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Type>), stream));
            setField5(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), stream));
            setField2(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), stream));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), stream));
            setField1(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), stream));
            return (global::Orleans.Runtime.GenericGrainTypeData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.GenericGrainTypeData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_GenericGrainTypeDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.GrainTypeData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_GrainTypeDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<GrainClass>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.String> getField1 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.String> setField1 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<IsReentrant>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> getField4 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> setField4 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<IsStatelessWorker>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> getField5 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean> setField5 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<RemoteInterfaceTypes>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>> getField2 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>> setField2 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Collections.Generic.List<global::System.Type>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<StateObjectType>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type> getField3 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type> setField3 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.GrainTypeData).@GetTypeInfo().@GetField("<Type>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type> getField0 = (global::System.Func<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type> setField0 = (global::System.Action<global::Orleans.Runtime.GrainTypeData, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.GrainTypeData input = ((global::Orleans.Runtime.GrainTypeData)original);
            global::Orleans.Runtime.GrainTypeData result = (global::Orleans.Runtime.GrainTypeData)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.Runtime.GrainTypeData));
            setField1(result, getField1(input));
            setField4(result, getField4(input));
            setField5(result, getField5(input));
            setField2(result, (global::System.Collections.Generic.List<global::System.Type>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField3(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input)));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.GrainTypeData input = (global::Orleans.Runtime.GrainTypeData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Collections.Generic.List<global::System.Type>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.Type));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Type));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.GrainTypeData result = (global::Orleans.Runtime.GrainTypeData)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.Runtime.GrainTypeData));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField4(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField5(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField2(result, (global::System.Collections.Generic.List<global::System.Type>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Type>), stream));
            setField3(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), stream));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), stream));
            return (global::Orleans.Runtime.GrainTypeData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.GrainTypeData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_GrainTypeDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.ReminderService.InMemoryRemindersTable)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_ReminderService_InMemoryRemindersTableSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.ReminderService.InMemoryRemindersTable).@GetTypeInfo().@GetField("reminderTable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.ReminderService.InMemoryRemindersTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>> getField0 = (global::System.Func<global::Orleans.Runtime.ReminderService.InMemoryRemindersTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.ReminderService.InMemoryRemindersTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>> setField0 = (global::System.Action<global::Orleans.Runtime.ReminderService.InMemoryRemindersTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.ReminderService.InMemoryRemindersTable input = ((global::Orleans.Runtime.ReminderService.InMemoryRemindersTable)original);
            global::Orleans.Runtime.ReminderService.InMemoryRemindersTable result = new global::Orleans.Runtime.ReminderService.InMemoryRemindersTable();
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.ReminderService.InMemoryRemindersTable input = (global::Orleans.Runtime.ReminderService.InMemoryRemindersTable)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.ReminderService.InMemoryRemindersTable result = new global::Orleans.Runtime.ReminderService.InMemoryRemindersTable();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.GrainReference, global::System.Collections.Generic.Dictionary<global::System.String, global::Orleans.ReminderEntry>>), stream));
            return (global::Orleans.Runtime.ReminderService.InMemoryRemindersTable)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.ReminderService.InMemoryRemindersTable), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_ReminderService_InMemoryRemindersTableSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.ReminderEntry)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_ReminderEntrySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.ReminderEntry input = ((global::Orleans.ReminderEntry)original);
            global::Orleans.ReminderEntry result = new global::Orleans.ReminderEntry();
            result.@ETag = input.@ETag;
            result.@GrainRef = (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@GrainRef);
            result.@Period = input.@Period;
            result.@ReminderName = input.@ReminderName;
            result.@StartAt = input.@StartAt;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.ReminderEntry input = (global::Orleans.ReminderEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ETag, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@GrainRef, stream, typeof (global::Orleans.Runtime.GrainReference));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Period, stream, typeof (global::System.TimeSpan));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ReminderName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartAt, stream, typeof (global::System.DateTime));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.ReminderEntry result = new global::Orleans.ReminderEntry();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ETag = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@GrainRef = (global::Orleans.Runtime.GrainReference)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.GrainReference), stream);
            result.@Period = (global::System.TimeSpan)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.TimeSpan), stream);
            result.@ReminderName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@StartAt = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            return (global::Orleans.ReminderEntry)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.ReminderEntry), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_ReminderEntrySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_MembershipService_InMemoryMembershipTableSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable).@GetTypeInfo().@GetField("lastETagCounter", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Int64> getField2 = (global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Int64> setField2 = (global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable).@GetTypeInfo().@GetField("siloTable", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>> getField0 = (global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>> setField0 = (global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable).@GetTypeInfo().@GetField("tableVersion", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::Orleans.TableVersion> getField1 = (global::System.Func<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::Orleans.TableVersion>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::Orleans.TableVersion> setField1 = (global::System.Action<global::Orleans.Runtime.MembershipService.InMemoryMembershipTable, global::Orleans.TableVersion>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.MembershipService.InMemoryMembershipTable input = ((global::Orleans.Runtime.MembershipService.InMemoryMembershipTable)original);
            global::Orleans.Runtime.MembershipService.InMemoryMembershipTable result = new global::Orleans.Runtime.MembershipService.InMemoryMembershipTable();
            setField2(result, getField2(input));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, getField1(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.MembershipService.InMemoryMembershipTable input = (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::Orleans.TableVersion));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.MembershipService.InMemoryMembershipTable result = new global::Orleans.Runtime.MembershipService.InMemoryMembershipTable();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField2(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream));
            setField0(result, (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.Dictionary<global::Orleans.Runtime.SiloAddress, global::System.Tuple<global::Orleans.MembershipEntry, global::System.String>>), stream));
            setField1(result, (global::Orleans.TableVersion)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.TableVersion), stream));
            return (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.MembershipService.InMemoryMembershipTable), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_MembershipService_InMemoryMembershipTableSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.TableVersion)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_TableVersionSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.TableVersion).@GetTypeInfo().@GetField("<Version>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.TableVersion, global::System.Int32> setField0 = (global::System.Action<global::Orleans.TableVersion, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.TableVersion).@GetTypeInfo().@GetField("<VersionEtag>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.TableVersion, global::System.String> setField1 = (global::System.Action<global::Orleans.TableVersion, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.TableVersion input = (global::Orleans.TableVersion)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Version, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@VersionEtag, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.TableVersion result = (global::Orleans.TableVersion)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.TableVersion));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Orleans.TableVersion)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.TableVersion), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_TableVersionSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.MembershipEntry)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_MembershipEntrySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.MembershipEntry input = ((global::Orleans.MembershipEntry)original);
            global::Orleans.MembershipEntry result = new global::Orleans.MembershipEntry();
            result.@FaultZone = input.@FaultZone;
            result.@HostName = input.@HostName;
            result.@IAmAliveTime = input.@IAmAliveTime;
            result.@ProxyPort = input.@ProxyPort;
            result.@RoleName = input.@RoleName;
            result.@SiloAddress = input.@SiloAddress;
            result.@SiloName = input.@SiloName;
            result.@StartTime = input.@StartTime;
            result.@Status = input.@Status;
            result.@SuspectTimes = (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@SuspectTimes);
            result.@UpdateZone = input.@UpdateZone;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.MembershipEntry input = (global::Orleans.MembershipEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@FaultZone, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HostName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@IAmAliveTime, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ProxyPort, stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@RoleName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, stream, typeof (global::Orleans.Runtime.SiloAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloName, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@StartTime, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Status, stream, typeof (global::Orleans.Runtime.SiloStatus));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SuspectTimes, stream, typeof (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@UpdateZone, stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.MembershipEntry result = new global::Orleans.MembershipEntry();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@FaultZone = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@HostName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@IAmAliveTime = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@ProxyPort = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            result.@RoleName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), stream);
            result.@SiloName = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@StartTime = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@Status = (global::Orleans.Runtime.SiloStatus)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloStatus), stream);
            result.@SuspectTimes = (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::System.DateTime>>), stream);
            result.@UpdateZone = (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream);
            return (global::Orleans.MembershipEntry)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.MembershipEntry), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_MembershipEntrySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_MultiClusterNetwork_MultiClusterDataSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData).@GetTypeInfo().@GetField("<Configuration>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData, global::Orleans.MultiCluster.MultiClusterConfiguration> setField1 = (global::System.Action<global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData, global::Orleans.MultiCluster.MultiClusterConfiguration>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData).@GetTypeInfo().@GetField("<Gateways>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData, global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>> setField0 = (global::System.Action<global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData, global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData input = ((global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData)original);
            global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData result = new global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData();
            setField1(result, (global::Orleans.MultiCluster.MultiClusterConfiguration)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Configuration));
            setField0(result, (global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Gateways));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData input = (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Configuration, stream, typeof (global::Orleans.MultiCluster.MultiClusterConfiguration));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Gateways, stream, typeof (global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData result = new global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::Orleans.MultiCluster.MultiClusterConfiguration)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.MultiCluster.MultiClusterConfiguration), stream));
            setField0(result, (global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IReadOnlyDictionary<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry>), stream));
            return (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.MultiClusterNetwork.MultiClusterData), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_MultiClusterNetwork_MultiClusterDataSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.MultiCluster.MultiClusterConfiguration)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_MultiCluster_MultiClusterConfigurationSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Orleans.MultiCluster.MultiClusterConfiguration).@GetTypeInfo().@GetField("<AdminTimestamp>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.DateTime> setField0 = (global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.DateTime>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Orleans.MultiCluster.MultiClusterConfiguration).@GetTypeInfo().@GetField("<Clusters>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.Collections.Generic.IReadOnlyList<global::System.String>> setField1 = (global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.Collections.Generic.IReadOnlyList<global::System.String>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Orleans.MultiCluster.MultiClusterConfiguration).@GetTypeInfo().@GetField("<Comment>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.String> setField2 = (global::System.Action<global::Orleans.MultiCluster.MultiClusterConfiguration, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.MultiCluster.MultiClusterConfiguration input = ((global::Orleans.MultiCluster.MultiClusterConfiguration)original);
            global::Orleans.MultiCluster.MultiClusterConfiguration result = (global::Orleans.MultiCluster.MultiClusterConfiguration)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.MultiCluster.MultiClusterConfiguration));
            setField0(result, input.@AdminTimestamp);
            setField1(result, (global::System.Collections.Generic.IReadOnlyList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Clusters));
            setField2(result, input.@Comment);
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.MultiCluster.MultiClusterConfiguration input = (global::Orleans.MultiCluster.MultiClusterConfiguration)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@AdminTimestamp, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Clusters, stream, typeof (global::System.Collections.Generic.IReadOnlyList<global::System.String>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Comment, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.MultiCluster.MultiClusterConfiguration result = (global::Orleans.MultiCluster.MultiClusterConfiguration)global::Orleans.Serialization.SerializationManager.GetUninitializedObjectWithFormatterServices(typeof (global::Orleans.MultiCluster.MultiClusterConfiguration));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream));
            setField1(result, (global::System.Collections.Generic.IReadOnlyList<global::System.String>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IReadOnlyList<global::System.String>), stream));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Orleans.MultiCluster.MultiClusterConfiguration)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.MultiCluster.MultiClusterConfiguration), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_MultiCluster_MultiClusterConfigurationSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_Runtime_MultiClusterNetwork_GatewayEntrySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry input = ((global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry)original);
            global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry result = new global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry();
            result.@ClusterId = input.@ClusterId;
            result.@HeartbeatTimestamp = input.@HeartbeatTimestamp;
            result.@SiloAddress = input.@SiloAddress;
            result.@Status = input.@Status;
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry input = (global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@ClusterId, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@HeartbeatTimestamp, stream, typeof (global::System.DateTime));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@SiloAddress, stream, typeof (global::Orleans.Runtime.SiloAddress));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Status, stream, typeof (global::Orleans.MultiCluster.GatewayStatus));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry result = new global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@ClusterId = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@HeartbeatTimestamp = (global::System.DateTime)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.DateTime), stream);
            result.@SiloAddress = (global::Orleans.Runtime.SiloAddress)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.Runtime.SiloAddress), stream);
            result.@Status = (global::Orleans.MultiCluster.GatewayStatus)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Orleans.MultiCluster.GatewayStatus), stream);
            return (global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.MultiClusterNetwork.GatewayEntry), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_Runtime_MultiClusterNetwork_GatewayEntrySerializer()
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
