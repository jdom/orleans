#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
namespace Orleans
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.Runtime.OrleansException)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenTester_CodeGenTests_OrleansExceptionSerializer
    {
        // private static readonly global::System.Reflection.FieldInfo field13 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_HResult", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.Int32> getField13 = (global::System.Func<global::System.Exception, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field13);
        // private static readonly global::System.Action<global::System.Exception, global::System.Int32> setField13 = (global::System.Action<global::System.Exception, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field13);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_className", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::System.Exception, global::System.String> getField0 = (global::System.Func<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::System.Exception, global::System.String> setField0 = (global::System.Action<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        // private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_data", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.Collections.IDictionary> getField4 = (global::System.Func<global::System.Exception, global::System.Collections.IDictionary>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        // private static readonly global::System.Action<global::System.Exception, global::System.Collections.IDictionary> setField4 = (global::System.Action<global::System.Exception, global::System.Collections.IDictionary>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        // private static readonly global::System.Reflection.FieldInfo field12 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_dynamicMethods", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.Object> getField12 = (global::System.Func<global::System.Exception, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetGetter(field12);
        // private static readonly global::System.Action<global::System.Exception, global::System.Object> setField12 = (global::System.Action<global::System.Exception, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field12);
        // private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_exceptionMethod", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.Reflection.MethodBase> getField1 = (global::System.Func<global::System.Exception, global::System.Reflection.MethodBase>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        // private static readonly global::System.Action<global::System.Exception, global::System.Reflection.MethodBase> setField1 = (global::System.Action<global::System.Exception, global::System.Reflection.MethodBase>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        // private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_exceptionMethodString", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.String> getField2 = (global::System.Func<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        // private static readonly global::System.Action<global::System.Exception, global::System.String> setField2 = (global::System.Action<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        // private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_helpURL", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.String> getField6 = (global::System.Func<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        // private static readonly global::System.Action<global::System.Exception, global::System.String> setField6 = (global::System.Action<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_innerException", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::System.Exception, global::System.Exception> getField5 = (global::System.Func<global::System.Exception, global::System.Exception>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::System.Exception, global::System.Exception> setField5 = (global::System.Action<global::System.Exception, global::System.Exception>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        // private static readonly global::System.Reflection.FieldInfo field17 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_ipForWatsonBuckets", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.UIntPtr> getField17 = (global::System.Func<global::System.Exception, global::System.UIntPtr>)global::Orleans.Serialization.SerializationManager.@GetGetter(field17);
        // private static readonly global::System.Action<global::System.Exception, global::System.UIntPtr> setField17 = (global::System.Action<global::System.Exception, global::System.UIntPtr>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field17);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_message", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::System.Exception, global::System.String> getField3 = (global::System.Func<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::System.Exception, global::System.String> setField3 = (global::System.Action<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        // private static readonly global::System.Reflection.FieldInfo field11 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_remoteStackIndex", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.Int32> getField11 = (global::System.Func<global::System.Exception, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field11);
        // private static readonly global::System.Action<global::System.Exception, global::System.Int32> setField11 = (global::System.Action<global::System.Exception, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field11);
        private static readonly global::System.Reflection.FieldInfo field10 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_remoteStackTraceString", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::System.Exception, global::System.String> getField10 = (global::System.Func<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field10);
        private static readonly global::System.Action<global::System.Exception, global::System.String> setField10 = (global::System.Action<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field10);
        // private static readonly global::System.Reflection.FieldInfo field14 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_source", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.String> getField14 = (global::System.Func<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field14);
        // private static readonly global::System.Action<global::System.Exception, global::System.String> setField14 = (global::System.Action<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field14);
        // private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_stackTrace", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.Object> getField7 = (global::System.Func<global::System.Exception, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        // private static readonly global::System.Action<global::System.Exception, global::System.Object> setField7 = (global::System.Action<global::System.Exception, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field9 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_stackTraceString", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::System.Exception, global::System.String> getField9 = (global::System.Func<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field9);
        private static readonly global::System.Action<global::System.Exception, global::System.String> setField9 = (global::System.Action<global::System.Exception, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field9);
        // private static readonly global::System.Reflection.FieldInfo field8 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_watsonBuckets", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.Object> getField8 = (global::System.Func<global::System.Exception, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetGetter(field8);
        // private static readonly global::System.Action<global::System.Exception, global::System.Object> setField8 = (global::System.Action<global::System.Exception, global::System.Object>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field8);
        // private static readonly global::System.Reflection.FieldInfo field16 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_xcode", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.Int32> getField16 = (global::System.Func<global::System.Exception, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field16);
        // private static readonly global::System.Action<global::System.Exception, global::System.Int32> setField16 = (global::System.Action<global::System.Exception, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field16);
        // private static readonly global::System.Reflection.FieldInfo field15 = typeof (global::System.Exception).@GetTypeInfo().@GetField("_xptrs", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        // private static readonly global::System.Func<global::System.Exception, global::System.IntPtr> getField15 = (global::System.Func<global::System.Exception, global::System.IntPtr>)global::Orleans.Serialization.SerializationManager.@GetGetter(field15);
        // private static readonly global::System.Action<global::System.Exception, global::System.IntPtr> setField15 = (global::System.Action<global::System.Exception, global::System.IntPtr>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field15);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Orleans.Runtime.OrleansException input = ((global::Orleans.Runtime.OrleansException)original);
            global::Orleans.Runtime.OrleansException result = new global::Orleans.Runtime.OrleansException();
            //setField13(result, getField13(input));
            setField0(result, getField0(input));
            //setField4(result, (global::System.Collections.IDictionary)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input)));
            //setField12(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField12(input)));
            //setField1(result, (global::System.Reflection.MethodBase)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            //setField2(result, getField2(input));
            //setField6(result, getField6(input));
            setField5(result, (global::System.Exception)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input)));
            //setField17(result, getField17(input));
            setField3(result, getField3(input));
            //setField11(result, getField11(input));
            setField10(result, getField10(input));
            //setField14(result, getField14(input));
            //setField7(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField7(input)));
            setField9(result, getField9(input));
            //setField8(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField8(input)));
            //setField16(result, getField16(input));
            //setField15(result, getField15(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.Runtime.OrleansException input = (global::Orleans.Runtime.OrleansException)untypedInput;
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField13(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.Collections.IDictionary));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField12(input), stream, typeof (global::System.Object));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Reflection.MethodBase));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.String));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (global::System.Exception));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField17(input), stream, typeof (global::System.UIntPtr));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.String));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField11(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField10(input), stream, typeof (global::System.String));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField14(input), stream, typeof (global::System.String));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), stream, typeof (global::System.Object));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField9(input), stream, typeof (global::System.String));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField8(input), stream, typeof (global::System.Object));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField16(input), stream, typeof (global::System.Int32));
            //global::Orleans.Serialization.SerializationManager.@SerializeInner(getField15(input), stream, typeof (global::System.IntPtr));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.Runtime.OrleansException result = new global::Orleans.Runtime.OrleansException();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            //setField13(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            //setField4(result, (global::System.Collections.IDictionary)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.IDictionary), stream));
            //setField12(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), stream));
            //setField1(result, (global::System.Reflection.MethodBase)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Reflection.MethodBase), stream));
            //setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            //setField6(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField5(result, (global::System.Exception)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Exception), stream));
            //setField17(result, (global::System.UIntPtr)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.UIntPtr), stream));
            setField3(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            //setField11(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField10(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            //setField14(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            //setField7(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), stream));
            setField9(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            //setField8(result, (global::System.Object)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Object), stream));
            //setField16(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            //setField15(result, (global::System.IntPtr)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.IntPtr), stream));
            return (global::Orleans.Runtime.OrleansException)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.Runtime.OrleansException), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenTester_CodeGenTests_OrleansExceptionSerializer()
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
