using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Orleans.CodeGeneration;
using Orleans.Serialization;

#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
namespace Orleans
{
    [GeneratedCode("Orleans-CodeGenerator", "1.3.0.0"), Serializer(typeof (Exception)), RegisterSerializerAttribute]
    public class ExceptionSerializer
    {
        private static readonly FieldInfo classNameField = typeof (Exception).GetTypeInfo().GetField("_className", (BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public));
        private static readonly Func<Exception, String> getClassNameField = (Func<Exception, String>)SerializationManager.GetGetter(classNameField);
        private static readonly Action<Exception, String> setClassNameField = (Action<Exception, String>)SerializationManager.GetReferenceSetter(classNameField);
        private static readonly FieldInfo innerExceptionField = typeof (Exception).GetTypeInfo().GetField("_innerException", (BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public));
        private static readonly Func<Exception, Exception> getInnerExceptionField = (Func<Exception, Exception>)SerializationManager.GetGetter(innerExceptionField);
        private static readonly Action<Exception, Exception> setInnerExceptionField = (Action<Exception, Exception>)SerializationManager.GetReferenceSetter(innerExceptionField);
        private static readonly FieldInfo messageField = typeof (Exception).GetTypeInfo().GetField("_message", (BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public));
        private static readonly Func<Exception, String> getMessageField = (Func<Exception, String>)SerializationManager.GetGetter(messageField);
        private static readonly Action<Exception, String> setMessageField = (Action<Exception, String>)SerializationManager.GetReferenceSetter(messageField);
        private static readonly FieldInfo remoteStackTraceStringField = typeof (Exception).GetTypeInfo().GetField("_remoteStackTraceString", (BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public));
        private static readonly Func<Exception, String> getRemoteStackTraceStringField = (Func<Exception, String>)SerializationManager.GetGetter(remoteStackTraceStringField);
        private static readonly Action<Exception, String> setRemoteStackTraceStringField = (Action<Exception, String>)SerializationManager.GetReferenceSetter(remoteStackTraceStringField);
        private static readonly FieldInfo stackTraceStringField = typeof (Exception).GetTypeInfo().GetField("_stackTraceString", (BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public));
        private static readonly Func<Exception, String> getStackTraceStringField = (Func<Exception, String>)SerializationManager.GetGetter(stackTraceStringField);
        private static readonly Action<Exception, String> setStackTraceStringField = (Action<Exception, String>)SerializationManager.GetReferenceSetter(stackTraceStringField);
        
        [CopierMethodAttribute]
        public static Object DeepCopier(Object original)
        {
            Type exceptionType = original.GetType();
            Exception input = (Exception)original;
            Exception result = (Exception)SerializationManager.GetUninitializedObjectWithFormatterServices(exceptionType);
            setClassNameField(result, getClassNameField(input));
            setInnerExceptionField(result, (Exception)SerializationManager.DeepCopyInner(getInnerExceptionField(input)));
            setMessageField(result, getMessageField(input));
            setRemoteStackTraceStringField(result, getRemoteStackTraceStringField(input));
            setStackTraceStringField(result, getStackTraceStringField(input));
            SerializationContext.Current.RecordObject(original, result);
            return result;
        }

        [SerializerMethodAttribute]
        public static void Serializer(Object untypedInput, BinaryTokenStreamWriter stream, Type expected)
        {
            Exception input = (Exception)untypedInput;
            SerializationManager.SerializeInner(getClassNameField(input), stream, typeof (String));
            SerializationManager.SerializeInner(getInnerExceptionField(input), stream, typeof (Exception));
            SerializationManager.SerializeInner(getMessageField(input), stream, typeof (String));
            SerializationManager.SerializeInner(getRemoteStackTraceStringField(input), stream, typeof (String));
            SerializationManager.SerializeInner(getStackTraceStringField(input), stream, typeof (String));
        }

        [DeserializerMethodAttribute]
        public static Object Deserializer(Type expected, BinaryTokenStreamReader stream)
        {
            Type exceptionType = expected;
            Exception result = (Exception)SerializationManager.GetUninitializedObjectWithFormatterServices(exceptionType);
            DeserializationContext.Current.RecordObject(result);
            setClassNameField(result, (String)SerializationManager.DeserializeInner(typeof (String), stream));
            setInnerExceptionField(result, (Exception)SerializationManager.DeserializeInner(typeof (Exception), stream));
            setMessageField(result, (String)SerializationManager.DeserializeInner(typeof (String), stream));
            setRemoteStackTraceStringField(result, (String)SerializationManager.DeserializeInner(typeof (String), stream));
            setStackTraceStringField(result, (String)SerializationManager.DeserializeInner(typeof (String), stream));
            return result;
        }

        public static void Register()
        {
            Register(typeof(Exception));
        }

        public static void Register(Type exceptionType)
        {
            if (!typeof(Exception).IsAssignableFrom(exceptionType)) throw new ArgumentException("Type must be derived from System.Exception", nameof(exceptionType));
            SerializationManager.Register(exceptionType, DeepCopier, Serializer, Deserializer);
        }

        static ExceptionSerializer()
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