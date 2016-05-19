#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("FSharp.Core, Version=4.4.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("TestInternalGrainInterfaces, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Microsoft.FSharp.Core
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.Unit)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_UnitSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.Unit input = ((global::Microsoft.FSharp.Core.Unit)original);
            global::Microsoft.FSharp.Core.Unit result = (global::Microsoft.FSharp.Core.Unit)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.Unit));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.Unit input = (global::Microsoft.FSharp.Core.Unit)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.Unit result = (global::Microsoft.FSharp.Core.Unit)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.Unit));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.Unit)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.Unit), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_UnitSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.SealedAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_SealedAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.SealedAttribute).@GetTypeInfo().@GetField("value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.SealedAttribute, global::System.Boolean> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.SealedAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.SealedAttribute, global::System.Boolean> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.SealedAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.SealedAttribute input = ((global::Microsoft.FSharp.Core.SealedAttribute)original);
            global::Microsoft.FSharp.Core.SealedAttribute result = new global::Microsoft.FSharp.Core.SealedAttribute();
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.SealedAttribute input = (global::Microsoft.FSharp.Core.SealedAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.SealedAttribute result = new global::Microsoft.FSharp.Core.SealedAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            return (global::Microsoft.FSharp.Core.SealedAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.SealedAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_SealedAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.AbstractClassAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_AbstractClassAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.AbstractClassAttribute input = ((global::Microsoft.FSharp.Core.AbstractClassAttribute)original);
            global::Microsoft.FSharp.Core.AbstractClassAttribute result = new global::Microsoft.FSharp.Core.AbstractClassAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.AbstractClassAttribute input = (global::Microsoft.FSharp.Core.AbstractClassAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.AbstractClassAttribute result = new global::Microsoft.FSharp.Core.AbstractClassAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.AbstractClassAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.AbstractClassAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_AbstractClassAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_EqualityConditionalOnAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute input = ((global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute)original);
            global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute result = new global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute input = (global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute result = new global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.EqualityConditionalOnAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_EqualityConditionalOnAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_ComparisonConditionalOnAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute input = ((global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute)original);
            global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute result = new global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute input = (global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute result = new global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.ComparisonConditionalOnAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_ComparisonConditionalOnAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.AllowNullLiteralAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_AllowNullLiteralAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.AllowNullLiteralAttribute).@GetTypeInfo().@GetField("value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.AllowNullLiteralAttribute, global::System.Boolean> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.AllowNullLiteralAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.AllowNullLiteralAttribute, global::System.Boolean> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.AllowNullLiteralAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.AllowNullLiteralAttribute input = ((global::Microsoft.FSharp.Core.AllowNullLiteralAttribute)original);
            global::Microsoft.FSharp.Core.AllowNullLiteralAttribute result = new global::Microsoft.FSharp.Core.AllowNullLiteralAttribute();
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.AllowNullLiteralAttribute input = (global::Microsoft.FSharp.Core.AllowNullLiteralAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.AllowNullLiteralAttribute result = new global::Microsoft.FSharp.Core.AllowNullLiteralAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            return (global::Microsoft.FSharp.Core.AllowNullLiteralAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.AllowNullLiteralAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_AllowNullLiteralAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.VolatileFieldAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_VolatileFieldAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.VolatileFieldAttribute input = ((global::Microsoft.FSharp.Core.VolatileFieldAttribute)original);
            global::Microsoft.FSharp.Core.VolatileFieldAttribute result = new global::Microsoft.FSharp.Core.VolatileFieldAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.VolatileFieldAttribute input = (global::Microsoft.FSharp.Core.VolatileFieldAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.VolatileFieldAttribute result = new global::Microsoft.FSharp.Core.VolatileFieldAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.VolatileFieldAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.VolatileFieldAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_VolatileFieldAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.DefaultAugmentationAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_DefaultAugmentationAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.DefaultAugmentationAttribute).@GetTypeInfo().@GetField("value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.DefaultAugmentationAttribute, global::System.Boolean> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.DefaultAugmentationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.DefaultAugmentationAttribute, global::System.Boolean> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.DefaultAugmentationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.DefaultAugmentationAttribute input = ((global::Microsoft.FSharp.Core.DefaultAugmentationAttribute)original);
            global::Microsoft.FSharp.Core.DefaultAugmentationAttribute result = (global::Microsoft.FSharp.Core.DefaultAugmentationAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.DefaultAugmentationAttribute));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.DefaultAugmentationAttribute input = (global::Microsoft.FSharp.Core.DefaultAugmentationAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.DefaultAugmentationAttribute result = (global::Microsoft.FSharp.Core.DefaultAugmentationAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.DefaultAugmentationAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            return (global::Microsoft.FSharp.Core.DefaultAugmentationAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.DefaultAugmentationAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_DefaultAugmentationAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CLIEventAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CLIEventAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CLIEventAttribute input = ((global::Microsoft.FSharp.Core.CLIEventAttribute)original);
            global::Microsoft.FSharp.Core.CLIEventAttribute result = new global::Microsoft.FSharp.Core.CLIEventAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CLIEventAttribute input = (global::Microsoft.FSharp.Core.CLIEventAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CLIEventAttribute result = new global::Microsoft.FSharp.Core.CLIEventAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.CLIEventAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CLIEventAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CLIEventAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CLIMutableAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CLIMutableAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CLIMutableAttribute input = ((global::Microsoft.FSharp.Core.CLIMutableAttribute)original);
            global::Microsoft.FSharp.Core.CLIMutableAttribute result = new global::Microsoft.FSharp.Core.CLIMutableAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CLIMutableAttribute input = (global::Microsoft.FSharp.Core.CLIMutableAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CLIMutableAttribute result = new global::Microsoft.FSharp.Core.CLIMutableAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.CLIMutableAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CLIMutableAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CLIMutableAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.AutoSerializableAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_AutoSerializableAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.AutoSerializableAttribute).@GetTypeInfo().@GetField("value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.AutoSerializableAttribute, global::System.Boolean> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.AutoSerializableAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.AutoSerializableAttribute, global::System.Boolean> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.AutoSerializableAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.AutoSerializableAttribute input = ((global::Microsoft.FSharp.Core.AutoSerializableAttribute)original);
            global::Microsoft.FSharp.Core.AutoSerializableAttribute result = (global::Microsoft.FSharp.Core.AutoSerializableAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.AutoSerializableAttribute));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.AutoSerializableAttribute input = (global::Microsoft.FSharp.Core.AutoSerializableAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.AutoSerializableAttribute result = (global::Microsoft.FSharp.Core.AutoSerializableAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.AutoSerializableAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            return (global::Microsoft.FSharp.Core.AutoSerializableAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.AutoSerializableAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_AutoSerializableAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.DefaultValueAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_DefaultValueAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.DefaultValueAttribute).@GetTypeInfo().@GetField("check", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.DefaultValueAttribute, global::System.Boolean> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.DefaultValueAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.DefaultValueAttribute, global::System.Boolean> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.DefaultValueAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.DefaultValueAttribute input = ((global::Microsoft.FSharp.Core.DefaultValueAttribute)original);
            global::Microsoft.FSharp.Core.DefaultValueAttribute result = new global::Microsoft.FSharp.Core.DefaultValueAttribute();
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.DefaultValueAttribute input = (global::Microsoft.FSharp.Core.DefaultValueAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.DefaultValueAttribute result = new global::Microsoft.FSharp.Core.DefaultValueAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            return (global::Microsoft.FSharp.Core.DefaultValueAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.DefaultValueAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_DefaultValueAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.EntryPointAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_EntryPointAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.EntryPointAttribute input = ((global::Microsoft.FSharp.Core.EntryPointAttribute)original);
            global::Microsoft.FSharp.Core.EntryPointAttribute result = new global::Microsoft.FSharp.Core.EntryPointAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.EntryPointAttribute input = (global::Microsoft.FSharp.Core.EntryPointAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.EntryPointAttribute result = new global::Microsoft.FSharp.Core.EntryPointAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.EntryPointAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.EntryPointAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_EntryPointAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.ReferenceEqualityAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_ReferenceEqualityAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.ReferenceEqualityAttribute input = ((global::Microsoft.FSharp.Core.ReferenceEqualityAttribute)original);
            global::Microsoft.FSharp.Core.ReferenceEqualityAttribute result = new global::Microsoft.FSharp.Core.ReferenceEqualityAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.ReferenceEqualityAttribute input = (global::Microsoft.FSharp.Core.ReferenceEqualityAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.ReferenceEqualityAttribute result = new global::Microsoft.FSharp.Core.ReferenceEqualityAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.ReferenceEqualityAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.ReferenceEqualityAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_ReferenceEqualityAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.StructuralComparisonAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_StructuralComparisonAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.StructuralComparisonAttribute input = ((global::Microsoft.FSharp.Core.StructuralComparisonAttribute)original);
            global::Microsoft.FSharp.Core.StructuralComparisonAttribute result = new global::Microsoft.FSharp.Core.StructuralComparisonAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.StructuralComparisonAttribute input = (global::Microsoft.FSharp.Core.StructuralComparisonAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.StructuralComparisonAttribute result = new global::Microsoft.FSharp.Core.StructuralComparisonAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.StructuralComparisonAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.StructuralComparisonAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_StructuralComparisonAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.StructuralEqualityAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_StructuralEqualityAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.StructuralEqualityAttribute input = ((global::Microsoft.FSharp.Core.StructuralEqualityAttribute)original);
            global::Microsoft.FSharp.Core.StructuralEqualityAttribute result = new global::Microsoft.FSharp.Core.StructuralEqualityAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.StructuralEqualityAttribute input = (global::Microsoft.FSharp.Core.StructuralEqualityAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.StructuralEqualityAttribute result = new global::Microsoft.FSharp.Core.StructuralEqualityAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.StructuralEqualityAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.StructuralEqualityAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_StructuralEqualityAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.NoEqualityAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_NoEqualityAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.NoEqualityAttribute input = ((global::Microsoft.FSharp.Core.NoEqualityAttribute)original);
            global::Microsoft.FSharp.Core.NoEqualityAttribute result = new global::Microsoft.FSharp.Core.NoEqualityAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.NoEqualityAttribute input = (global::Microsoft.FSharp.Core.NoEqualityAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.NoEqualityAttribute result = new global::Microsoft.FSharp.Core.NoEqualityAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.NoEqualityAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.NoEqualityAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_NoEqualityAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CustomEqualityAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CustomEqualityAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CustomEqualityAttribute input = ((global::Microsoft.FSharp.Core.CustomEqualityAttribute)original);
            global::Microsoft.FSharp.Core.CustomEqualityAttribute result = new global::Microsoft.FSharp.Core.CustomEqualityAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CustomEqualityAttribute input = (global::Microsoft.FSharp.Core.CustomEqualityAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CustomEqualityAttribute result = new global::Microsoft.FSharp.Core.CustomEqualityAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.CustomEqualityAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CustomEqualityAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CustomEqualityAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CustomComparisonAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CustomComparisonAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CustomComparisonAttribute input = ((global::Microsoft.FSharp.Core.CustomComparisonAttribute)original);
            global::Microsoft.FSharp.Core.CustomComparisonAttribute result = new global::Microsoft.FSharp.Core.CustomComparisonAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CustomComparisonAttribute input = (global::Microsoft.FSharp.Core.CustomComparisonAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CustomComparisonAttribute result = new global::Microsoft.FSharp.Core.CustomComparisonAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.CustomComparisonAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CustomComparisonAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CustomComparisonAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.NoComparisonAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_NoComparisonAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.NoComparisonAttribute input = ((global::Microsoft.FSharp.Core.NoComparisonAttribute)original);
            global::Microsoft.FSharp.Core.NoComparisonAttribute result = new global::Microsoft.FSharp.Core.NoComparisonAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.NoComparisonAttribute input = (global::Microsoft.FSharp.Core.NoComparisonAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.NoComparisonAttribute result = new global::Microsoft.FSharp.Core.NoComparisonAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.NoComparisonAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.NoComparisonAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_NoComparisonAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_ReflectedDefinitionAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute).@GetTypeInfo().@GetField("includeValue", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute, global::System.Boolean> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute, global::System.Boolean> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute input = ((global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute)original);
            global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute result = new global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute();
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute input = (global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute result = new global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            return (global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.ReflectedDefinitionAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_ReflectedDefinitionAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompiledNameAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompiledNameAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompiledNameAttribute).@GetTypeInfo().@GetField("compiledName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompiledNameAttribute, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompiledNameAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompiledNameAttribute, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompiledNameAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompiledNameAttribute input = ((global::Microsoft.FSharp.Core.CompiledNameAttribute)original);
            global::Microsoft.FSharp.Core.CompiledNameAttribute result = (global::Microsoft.FSharp.Core.CompiledNameAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompiledNameAttribute));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompiledNameAttribute input = (global::Microsoft.FSharp.Core.CompiledNameAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompiledNameAttribute result = (global::Microsoft.FSharp.Core.CompiledNameAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompiledNameAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.CompiledNameAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompiledNameAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompiledNameAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.StructAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_StructAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.StructAttribute input = ((global::Microsoft.FSharp.Core.StructAttribute)original);
            global::Microsoft.FSharp.Core.StructAttribute result = new global::Microsoft.FSharp.Core.StructAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.StructAttribute input = (global::Microsoft.FSharp.Core.StructAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.StructAttribute result = new global::Microsoft.FSharp.Core.StructAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.StructAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.StructAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_StructAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.MeasureAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_MeasureAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.MeasureAttribute input = ((global::Microsoft.FSharp.Core.MeasureAttribute)original);
            global::Microsoft.FSharp.Core.MeasureAttribute result = new global::Microsoft.FSharp.Core.MeasureAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.MeasureAttribute input = (global::Microsoft.FSharp.Core.MeasureAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.MeasureAttribute result = new global::Microsoft.FSharp.Core.MeasureAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.MeasureAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.MeasureAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_MeasureAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_MeasureAnnotatedAbbreviationAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute input = ((global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute)original);
            global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute result = new global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute input = (global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute result = new global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.MeasureAnnotatedAbbreviationAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_MeasureAnnotatedAbbreviationAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.InterfaceAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_InterfaceAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.InterfaceAttribute input = ((global::Microsoft.FSharp.Core.InterfaceAttribute)original);
            global::Microsoft.FSharp.Core.InterfaceAttribute result = new global::Microsoft.FSharp.Core.InterfaceAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.InterfaceAttribute input = (global::Microsoft.FSharp.Core.InterfaceAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.InterfaceAttribute result = new global::Microsoft.FSharp.Core.InterfaceAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.InterfaceAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.InterfaceAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_InterfaceAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.ClassAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_ClassAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.ClassAttribute input = ((global::Microsoft.FSharp.Core.ClassAttribute)original);
            global::Microsoft.FSharp.Core.ClassAttribute result = new global::Microsoft.FSharp.Core.ClassAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.ClassAttribute input = (global::Microsoft.FSharp.Core.ClassAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.ClassAttribute result = new global::Microsoft.FSharp.Core.ClassAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.ClassAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.ClassAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_ClassAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.LiteralAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_LiteralAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.LiteralAttribute input = ((global::Microsoft.FSharp.Core.LiteralAttribute)original);
            global::Microsoft.FSharp.Core.LiteralAttribute result = new global::Microsoft.FSharp.Core.LiteralAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.LiteralAttribute input = (global::Microsoft.FSharp.Core.LiteralAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.LiteralAttribute result = new global::Microsoft.FSharp.Core.LiteralAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.LiteralAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.LiteralAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_LiteralAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpInterfaceDataVersionAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute).@GetTypeInfo().@GetField("major", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32> getField2 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32> setField2 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute).@GetTypeInfo().@GetField("minor", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute).@GetTypeInfo().@GetField("release", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute input = ((global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute)original);
            global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute result = (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute));
            setField2(result, getField2(input));
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute input = (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute result = (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField2(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpInterfaceDataVersionAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilationMappingAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilationMappingAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Microsoft.FSharp.Core.CompilationMappingAttribute).@GetTypeInfo().@GetField("resourceName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.String> getField4 = (global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.String> setField4 = (global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Core.CompilationMappingAttribute).@GetTypeInfo().@GetField("sequenceNumber", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Int32> getField3 = (global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Int32> setField3 = (global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Core.CompilationMappingAttribute).@GetTypeInfo().@GetField("sourceConstructFlags", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::Microsoft.FSharp.Core.SourceConstructFlags> getField2 = (global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::Microsoft.FSharp.Core.SourceConstructFlags>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::Microsoft.FSharp.Core.SourceConstructFlags> setField2 = (global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::Microsoft.FSharp.Core.SourceConstructFlags>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.CompilationMappingAttribute).@GetTypeInfo().@GetField("typeDefinitions", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Type[]> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Type[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Type[]> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Type[]>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompilationMappingAttribute).@GetTypeInfo().@GetField("variantNumber", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Int32> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Int32> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompilationMappingAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilationMappingAttribute input = ((global::Microsoft.FSharp.Core.CompilationMappingAttribute)original);
            global::Microsoft.FSharp.Core.CompilationMappingAttribute result = (global::Microsoft.FSharp.Core.CompilationMappingAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilationMappingAttribute));
            setField4(result, getField4(input));
            setField3(result, getField3(input));
            setField2(result, getField2(input));
            setField1(result, (global::System.Type[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilationMappingAttribute input = (global::Microsoft.FSharp.Core.CompilationMappingAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::Microsoft.FSharp.Core.SourceConstructFlags));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Type[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilationMappingAttribute result = (global::Microsoft.FSharp.Core.CompilationMappingAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilationMappingAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField4(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField3(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField2(result, (global::Microsoft.FSharp.Core.SourceConstructFlags)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Microsoft.FSharp.Core.SourceConstructFlags), stream));
            setField1(result, (global::System.Type[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type[]), stream));
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::Microsoft.FSharp.Core.CompilationMappingAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilationMappingAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilationMappingAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilationSourceNameAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilationSourceNameAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompilationSourceNameAttribute).@GetTypeInfo().@GetField("sourceName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilationSourceNameAttribute, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompilationSourceNameAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilationSourceNameAttribute, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompilationSourceNameAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilationSourceNameAttribute input = ((global::Microsoft.FSharp.Core.CompilationSourceNameAttribute)original);
            global::Microsoft.FSharp.Core.CompilationSourceNameAttribute result = (global::Microsoft.FSharp.Core.CompilationSourceNameAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilationSourceNameAttribute));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilationSourceNameAttribute input = (global::Microsoft.FSharp.Core.CompilationSourceNameAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilationSourceNameAttribute result = (global::Microsoft.FSharp.Core.CompilationSourceNameAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilationSourceNameAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.CompilationSourceNameAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilationSourceNameAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilationSourceNameAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilationRepresentationAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilationRepresentationAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompilationRepresentationAttribute).@GetTypeInfo().@GetField("flags", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilationRepresentationAttribute, global::Microsoft.FSharp.Core.CompilationRepresentationFlags> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompilationRepresentationAttribute, global::Microsoft.FSharp.Core.CompilationRepresentationFlags>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilationRepresentationAttribute, global::Microsoft.FSharp.Core.CompilationRepresentationFlags> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompilationRepresentationAttribute, global::Microsoft.FSharp.Core.CompilationRepresentationFlags>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilationRepresentationAttribute input = ((global::Microsoft.FSharp.Core.CompilationRepresentationAttribute)original);
            global::Microsoft.FSharp.Core.CompilationRepresentationAttribute result = (global::Microsoft.FSharp.Core.CompilationRepresentationAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilationRepresentationAttribute));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilationRepresentationAttribute input = (global::Microsoft.FSharp.Core.CompilationRepresentationAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Microsoft.FSharp.Core.CompilationRepresentationFlags));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilationRepresentationAttribute result = (global::Microsoft.FSharp.Core.CompilationRepresentationAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilationRepresentationAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::Microsoft.FSharp.Core.CompilationRepresentationFlags)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Microsoft.FSharp.Core.CompilationRepresentationFlags), stream));
            return (global::Microsoft.FSharp.Core.CompilationRepresentationAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilationRepresentationAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilationRepresentationAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.ExperimentalAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_ExperimentalAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.ExperimentalAttribute).@GetTypeInfo().@GetField("message", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.ExperimentalAttribute, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.ExperimentalAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.ExperimentalAttribute, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.ExperimentalAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.ExperimentalAttribute input = ((global::Microsoft.FSharp.Core.ExperimentalAttribute)original);
            global::Microsoft.FSharp.Core.ExperimentalAttribute result = (global::Microsoft.FSharp.Core.ExperimentalAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.ExperimentalAttribute));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.ExperimentalAttribute input = (global::Microsoft.FSharp.Core.ExperimentalAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.ExperimentalAttribute result = (global::Microsoft.FSharp.Core.ExperimentalAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.ExperimentalAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.ExperimentalAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.ExperimentalAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_ExperimentalAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilationArgumentCountsAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute).@GetTypeInfo().@GetField("counts", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute, global::System.Int32[]> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute, global::System.Int32[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute, global::System.Int32[]> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute, global::System.Int32[]>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute input = ((global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute)original);
            global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute result = (global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute));
            setField0(result, (global::System.Int32[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute input = (global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32[]));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute result = (global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Int32[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32[]), stream));
            return (global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilationArgumentCountsAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilationArgumentCountsAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CustomOperationAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute).@GetTypeInfo().@GetField("allowInto", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> getField2 = (global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> setField2 = (global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute).@GetTypeInfo().@GetField("isBinary", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute).@GetTypeInfo().@GetField("isGroupJoin", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> getField4 = (global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> setField4 = (global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute).@GetTypeInfo().@GetField("isJoin", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> getField3 = (global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> setField3 = (global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute).@GetTypeInfo().@GetField("joinOnWord", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.String> getField7 = (global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.String> setField7 = (global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute).@GetTypeInfo().@GetField("maintainsVarSpace", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> getField5 = (global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> setField5 = (global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute).@GetTypeInfo().@GetField("maintainsVarSpaceWithBind", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> getField6 = (global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean> setField6 = (global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute).@GetTypeInfo().@GetField("name", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CustomOperationAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CustomOperationAttribute input = ((global::Microsoft.FSharp.Core.CustomOperationAttribute)original);
            global::Microsoft.FSharp.Core.CustomOperationAttribute result = (global::Microsoft.FSharp.Core.CustomOperationAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute));
            setField2(result, getField2(input));
            setField1(result, getField1(input));
            setField4(result, getField4(input));
            setField3(result, getField3(input));
            setField7(result, getField7(input));
            setField5(result, getField5(input));
            setField6(result, getField6(input));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CustomOperationAttribute input = (global::Microsoft.FSharp.Core.CustomOperationAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CustomOperationAttribute result = (global::Microsoft.FSharp.Core.CustomOperationAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField2(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField1(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField4(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField3(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField7(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField5(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField6(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.CustomOperationAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CustomOperationAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CustomOperationAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.ProjectionParameterAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_ProjectionParameterAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.ProjectionParameterAttribute input = ((global::Microsoft.FSharp.Core.ProjectionParameterAttribute)original);
            global::Microsoft.FSharp.Core.ProjectionParameterAttribute result = new global::Microsoft.FSharp.Core.ProjectionParameterAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.ProjectionParameterAttribute input = (global::Microsoft.FSharp.Core.ProjectionParameterAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.ProjectionParameterAttribute result = new global::Microsoft.FSharp.Core.ProjectionParameterAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.ProjectionParameterAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.ProjectionParameterAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_ProjectionParameterAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_StructuredFormatDisplayAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute).@GetTypeInfo().@GetField("value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute input = ((global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute)original);
            global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute result = (global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute input = (global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute result = (global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.StructuredFormatDisplayAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_StructuredFormatDisplayAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerMessageAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerMessageAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Core.CompilerMessageAttribute).@GetTypeInfo().@GetField("isError", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Boolean> getField2 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Boolean> setField2 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Core.CompilerMessageAttribute).@GetTypeInfo().@GetField("isHidden", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Boolean> getField3 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Boolean> setField3 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.CompilerMessageAttribute).@GetTypeInfo().@GetField("message", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.String> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.String> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompilerMessageAttribute).@GetTypeInfo().@GetField("messageNumber", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Int32> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Int32> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerMessageAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerMessageAttribute input = ((global::Microsoft.FSharp.Core.CompilerMessageAttribute)original);
            global::Microsoft.FSharp.Core.CompilerMessageAttribute result = (global::Microsoft.FSharp.Core.CompilerMessageAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerMessageAttribute));
            setField2(result, getField2(input));
            setField3(result, getField3(input));
            setField1(result, getField1(input));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerMessageAttribute input = (global::Microsoft.FSharp.Core.CompilerMessageAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerMessageAttribute result = (global::Microsoft.FSharp.Core.CompilerMessageAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerMessageAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField2(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField3(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField0(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::Microsoft.FSharp.Core.CompilerMessageAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerMessageAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerMessageAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.UnverifiableAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_UnverifiableAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.UnverifiableAttribute input = ((global::Microsoft.FSharp.Core.UnverifiableAttribute)original);
            global::Microsoft.FSharp.Core.UnverifiableAttribute result = new global::Microsoft.FSharp.Core.UnverifiableAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.UnverifiableAttribute input = (global::Microsoft.FSharp.Core.UnverifiableAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.UnverifiableAttribute result = new global::Microsoft.FSharp.Core.UnverifiableAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.UnverifiableAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.UnverifiableAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_UnverifiableAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_NoDynamicInvocationAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute input = ((global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute)original);
            global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute result = new global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute input = (global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute result = new global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.NoDynamicInvocationAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_NoDynamicInvocationAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.OptionalArgumentAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_OptionalArgumentAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.OptionalArgumentAttribute input = ((global::Microsoft.FSharp.Core.OptionalArgumentAttribute)original);
            global::Microsoft.FSharp.Core.OptionalArgumentAttribute result = new global::Microsoft.FSharp.Core.OptionalArgumentAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.OptionalArgumentAttribute input = (global::Microsoft.FSharp.Core.OptionalArgumentAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.OptionalArgumentAttribute result = new global::Microsoft.FSharp.Core.OptionalArgumentAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.OptionalArgumentAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.OptionalArgumentAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_OptionalArgumentAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.GeneralizableValueAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_GeneralizableValueAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.GeneralizableValueAttribute input = ((global::Microsoft.FSharp.Core.GeneralizableValueAttribute)original);
            global::Microsoft.FSharp.Core.GeneralizableValueAttribute result = new global::Microsoft.FSharp.Core.GeneralizableValueAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.GeneralizableValueAttribute input = (global::Microsoft.FSharp.Core.GeneralizableValueAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.GeneralizableValueAttribute result = new global::Microsoft.FSharp.Core.GeneralizableValueAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.GeneralizableValueAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.GeneralizableValueAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_GeneralizableValueAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_RequiresExplicitTypeArgumentsAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute input = ((global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute)original);
            global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute result = new global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute input = (global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute result = new global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_RequiresExplicitTypeArgumentsAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_RequireQualifiedAccessAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute input = ((global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute)original);
            global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute result = new global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute input = (global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute result = new global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.RequireQualifiedAccessAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_RequireQualifiedAccessAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.AutoOpenAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_AutoOpenAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.AutoOpenAttribute).@GetTypeInfo().@GetField("path", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.AutoOpenAttribute, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.AutoOpenAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.AutoOpenAttribute, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.AutoOpenAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.AutoOpenAttribute input = ((global::Microsoft.FSharp.Core.AutoOpenAttribute)original);
            global::Microsoft.FSharp.Core.AutoOpenAttribute result = new global::Microsoft.FSharp.Core.AutoOpenAttribute();
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.AutoOpenAttribute input = (global::Microsoft.FSharp.Core.AutoOpenAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.AutoOpenAttribute result = new global::Microsoft.FSharp.Core.AutoOpenAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.AutoOpenAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.AutoOpenAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_AutoOpenAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<, >.Choice1Of2))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of2Serializer<T1, T2>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice1Of2)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of2Serializer_T1_T2_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<, >.Choice1Of2), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of2Serializer<, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of2Serializer_T1_T2_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<, >.Choice2Of2))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of2Serializer<T1, T2>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2, T2> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2, T2> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T2));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2>.Choice2Of2)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of2Serializer_T1_T2_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<, >.Choice2Of2), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of2Serializer<, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of2Serializer_T1_T2_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,, >.Choice1Of3))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of3Serializer<T1, T2, T3>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice1Of3)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of3Serializer_T1_T2_T3_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,, >.Choice1Of3), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of3Serializer<,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of3Serializer_T1_T2_T3_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,, >.Choice2Of3))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of3Serializer<T1, T2, T3>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3, T2> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3, T2> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T2));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice2Of3)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of3Serializer_T1_T2_T3_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,, >.Choice2Of3), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of3Serializer<,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of3Serializer_T1_T2_T3_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,, >.Choice3Of3))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of3Serializer<T1, T2, T3>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3, T3> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3, T3> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3));
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T3));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3>.Choice3Of3)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of3Serializer_T1_T2_T3_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,, >.Choice3Of3), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of3Serializer<,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of3Serializer_T1_T2_T3_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,, >.Choice1Of4))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of4Serializer<T1, T2, T3, T4>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4));
            setField1(result, getField1(input));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice1Of4)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of4Serializer_T1_T2_T3_T4_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,, >.Choice1Of4), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of4Serializer<,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of4Serializer_T1_T2_T3_T4_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,, >.Choice2Of4))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of4Serializer<T1, T2, T3, T4>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4, T2> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4, T2> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4));
            setField1(result, getField1(input));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T2));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice2Of4)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of4Serializer_T1_T2_T3_T4_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,, >.Choice2Of4), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of4Serializer<,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of4Serializer_T1_T2_T3_T4_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,, >.Choice3Of4))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of4Serializer<T1, T2, T3, T4>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4, T3> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4, T3> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4));
            setField1(result, getField1(input));
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T3));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice3Of4)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of4Serializer_T1_T2_T3_T4_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,, >.Choice3Of4), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of4Serializer<,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of4Serializer_T1_T2_T3_T4_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,, >.Choice4Of4))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of4Serializer<T1, T2, T3, T4>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4, T4> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4, T4>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4, T4> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4, T4>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4));
            setField1(result, getField1(input));
            setField0(result, (T4)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T4));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T4)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T4), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4>.Choice4Of4)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of4Serializer_T1_T2_T3_T4_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,, >.Choice4Of4), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of4Serializer<,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of4Serializer_T1_T2_T3_T4_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice1Of5))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of5Serializer<T1, T2, T3, T4, T5>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5));
            setField1(result, getField1(input));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice1Of5)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of5Serializer_T1_T2_T3_T4_T5_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice1Of5), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of5Serializer<,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of5Serializer_T1_T2_T3_T4_T5_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice2Of5))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of5Serializer<T1, T2, T3, T4, T5>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5, T2> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5, T2> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5));
            setField1(result, getField1(input));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T2));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice2Of5)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of5Serializer_T1_T2_T3_T4_T5_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice2Of5), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of5Serializer<,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of5Serializer_T1_T2_T3_T4_T5_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice3Of5))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of5Serializer<T1, T2, T3, T4, T5>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5, T3> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5, T3> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5));
            setField1(result, getField1(input));
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T3));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice3Of5)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of5Serializer_T1_T2_T3_T4_T5_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice3Of5), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of5Serializer<,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of5Serializer_T1_T2_T3_T4_T5_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice4Of5))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of5Serializer<T1, T2, T3, T4, T5>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5, T4> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5, T4>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5, T4> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5, T4>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5));
            setField1(result, getField1(input));
            setField0(result, (T4)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T4));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T4)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T4), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice4Of5)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of5Serializer_T1_T2_T3_T4_T5_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice4Of5), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of5Serializer<,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of5Serializer_T1_T2_T3_T4_T5_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice5Of5))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of5Serializer<T1, T2, T3, T4, T5>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5, T5> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5, T5>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5, T5> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5, T5>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5));
            setField1(result, getField1(input));
            setField0(result, (T5)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T5));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T5)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T5), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5>.Choice5Of5)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of5Serializer_T1_T2_T3_T4_T5_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,, >.Choice5Of5), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of5Serializer<,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of5Serializer_T1_T2_T3_T4_T5_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice1Of6))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of6Serializer<T1, T2, T3, T4, T5, T6>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6));
            setField1(result, getField1(input));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice1Of6)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice1Of6), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of6Serializer<,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice2Of6))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of6Serializer<T1, T2, T3, T4, T5, T6>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6, T2> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6, T2> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6));
            setField1(result, getField1(input));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T2));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice2Of6)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice2Of6), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of6Serializer<,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice3Of6))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of6Serializer<T1, T2, T3, T4, T5, T6>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6, T3> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6, T3> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6));
            setField1(result, getField1(input));
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T3));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice3Of6)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice3Of6), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of6Serializer<,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice4Of6))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of6Serializer<T1, T2, T3, T4, T5, T6>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6, T4> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6, T4>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6, T4> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6, T4>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6));
            setField1(result, getField1(input));
            setField0(result, (T4)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T4));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T4)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T4), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice4Of6)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice4Of6), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of6Serializer<,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice5Of6))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of6Serializer<T1, T2, T3, T4, T5, T6>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6, T5> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6, T5>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6, T5> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6, T5>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6));
            setField1(result, getField1(input));
            setField0(result, (T5)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T5));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T5)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T5), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice5Of6)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice5Of6), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of6Serializer<,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice6Of6))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice6Of6Serializer<T1, T2, T3, T4, T5, T6>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6, T6> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6, T6>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6, T6> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6, T6>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6));
            setField1(result, getField1(input));
            setField0(result, (T6)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T6));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T6)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T6), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6>.Choice6Of6)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice6Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,, >.Choice6Of6), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice6Of6Serializer<,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice6Of6Serializer_T1_T2_T3_T4_T5_T6_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice1Of7))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of7Serializer<T1, T2, T3, T4, T5, T6, T7>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7));
            setField1(result, getField1(input));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice1Of7)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice1Of7), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of7Serializer<,,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice1Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice2Of7))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of7Serializer<T1, T2, T3, T4, T5, T6, T7>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7, T2> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7, T2> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7));
            setField1(result, getField1(input));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T2));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice2Of7)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice2Of7), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of7Serializer<,,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice2Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice3Of7))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of7Serializer<T1, T2, T3, T4, T5, T6, T7>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7, T3> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7, T3> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7));
            setField1(result, getField1(input));
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T3));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice3Of7)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice3Of7), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of7Serializer<,,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice3Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice4Of7))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of7Serializer<T1, T2, T3, T4, T5, T6, T7>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7, T4> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7, T4>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7, T4> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7, T4>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7));
            setField1(result, getField1(input));
            setField0(result, (T4)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T4));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T4)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T4), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice4Of7)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice4Of7), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of7Serializer<,,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice4Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice5Of7))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of7Serializer<T1, T2, T3, T4, T5, T6, T7>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7, T5> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7, T5>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7, T5> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7, T5>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7));
            setField1(result, getField1(input));
            setField0(result, (T5)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T5));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T5)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T5), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice5Of7)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice5Of7), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of7Serializer<,,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice5Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice6Of7))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice6Of7Serializer<T1, T2, T3, T4, T5, T6, T7>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7, T6> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7, T6>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7, T6> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7, T6>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7));
            setField1(result, getField1(input));
            setField0(result, (T6)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T6));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T6)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T6), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice6Of7)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice6Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice6Of7), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice6Of7Serializer<,,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice6Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice7Of7))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice7Of7Serializer<T1, T2, T3, T4, T5, T6, T7>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("_tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7).@GetTypeInfo().@GetField("item", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7, T7> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7, T7>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7, T7> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7, T7>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7 input = ((global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7)original);
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7));
            setField1(result, getField1(input));
            setField0(result, (T7)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7 input = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T7));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7 result = (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (T7)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T7), stream));
            return (global::Microsoft.FSharp.Core.FSharpChoice<T1, T2, T3, T4, T5, T6, T7>.Choice7Of7)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice7Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpChoice<,,,,,, >.Choice7Of7), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice7Of7Serializer<,,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpChoiceSerializer_Choice7Of7Serializer_T1_T2_T3_T4_T5_T6_T7_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpRef<>))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpRefSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpRef<T>).@GetTypeInfo().@GetField("contents@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpRef<T>, T> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpRef<T>, T>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpRef<T>, T> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpRef<T>, T>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpRef<T> input = ((global::Microsoft.FSharp.Core.FSharpRef<T>)original);
            global::Microsoft.FSharp.Core.FSharpRef<T> result = (global::Microsoft.FSharp.Core.FSharpRef<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpRef<T>));
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpRef<T> input = (global::Microsoft.FSharp.Core.FSharpRef<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpRef<T> result = (global::Microsoft.FSharp.Core.FSharpRef<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpRef<T>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream));
            return (global::Microsoft.FSharp.Core.FSharpRef<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpRefSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpRef<>), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpRefSerializer<>));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpRefSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.FSharpOption<>))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpOptionSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.FSharpOption<T>).@GetTypeInfo().@GetField("value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.FSharpOption<T>, T> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.FSharpOption<T>, T>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.FSharpOption<T>, T> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.FSharpOption<T>, T>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.FSharpOption<T> input = ((global::Microsoft.FSharp.Core.FSharpOption<T>)original);
            global::Microsoft.FSharp.Core.FSharpOption<T> result = (global::Microsoft.FSharp.Core.FSharpOption<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpOption<T>));
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.FSharpOption<T> input = (global::Microsoft.FSharp.Core.FSharpOption<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.FSharpOption<T> result = (global::Microsoft.FSharp.Core.FSharpOption<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.FSharpOption<T>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream));
            return (global::Microsoft.FSharp.Core.FSharpOption<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_FSharpOptionSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.FSharpOption<>), typeof (OrleansCodeGenMicrosoft_FSharp_Core_FSharpOptionSerializer<>));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_FSharpOptionSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Collections.FSharpList<>))]
    internal class OrleansCodeGenMicrosoft_FSharp_Collections_FSharpListSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Collections.FSharpList<T>).@GetTypeInfo().@GetField("head", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Collections.FSharpList<T>, T> getField0 = (global::System.Func<global::Microsoft.FSharp.Collections.FSharpList<T>, T>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Collections.FSharpList<T>, T> setField0 = (global::System.Action<global::Microsoft.FSharp.Collections.FSharpList<T>, T>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Collections.FSharpList<T>).@GetTypeInfo().@GetField("tail", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Collections.FSharpList<T>, global::Microsoft.FSharp.Collections.FSharpList<T>> getField1 = (global::System.Func<global::Microsoft.FSharp.Collections.FSharpList<T>, global::Microsoft.FSharp.Collections.FSharpList<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Collections.FSharpList<T>, global::Microsoft.FSharp.Collections.FSharpList<T>> setField1 = (global::System.Action<global::Microsoft.FSharp.Collections.FSharpList<T>, global::Microsoft.FSharp.Collections.FSharpList<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Collections.FSharpList<T> input = ((global::Microsoft.FSharp.Collections.FSharpList<T>)original);
            global::Microsoft.FSharp.Collections.FSharpList<T> result = (global::Microsoft.FSharp.Collections.FSharpList<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Collections.FSharpList<T>));
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (global::Microsoft.FSharp.Collections.FSharpList<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Collections.FSharpList<T> input = (global::Microsoft.FSharp.Collections.FSharpList<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::Microsoft.FSharp.Collections.FSharpList<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Collections.FSharpList<T> result = (global::Microsoft.FSharp.Collections.FSharpList<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Collections.FSharpList<T>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T), stream));
            setField1(result, (global::Microsoft.FSharp.Collections.FSharpList<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Microsoft.FSharp.Collections.FSharpList<T>), stream));
            return (global::Microsoft.FSharp.Collections.FSharpList<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Collections_FSharpListSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Collections.FSharpList<>), typeof (OrleansCodeGenMicrosoft_FSharp_Collections_FSharpListSerializer<>));
        }

        static OrleansCodeGenMicrosoft_FSharp_Collections_FSharpListSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Collections.FSharpMap<, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Collections_FSharpMapSerializer<TKey, TValue>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>).@GetTypeInfo().@GetField("serializedData", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>, global::System.Collections.Generic.KeyValuePair<TKey, TValue>[]> getField0 = (global::System.Func<global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>, global::System.Collections.Generic.KeyValuePair<TKey, TValue>[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>, global::System.Collections.Generic.KeyValuePair<TKey, TValue>[]> setField0 = (global::System.Action<global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>, global::System.Collections.Generic.KeyValuePair<TKey, TValue>[]>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue> input = ((global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>)original);
            global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue> result = (global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>));
            setField0(result, (global::System.Collections.Generic.KeyValuePair<TKey, TValue>[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue> input = (global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.KeyValuePair<TKey, TValue>[]));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue> result = (global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.KeyValuePair<TKey, TValue>[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.KeyValuePair<TKey, TValue>[]), stream));
            return (global::Microsoft.FSharp.Collections.FSharpMap<TKey, TValue>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Collections_FSharpMapSerializer_TKey_TValue_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Collections.FSharpMap<, >), typeof (OrleansCodeGenMicrosoft_FSharp_Collections_FSharpMapSerializer<, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Collections_FSharpMapSerializer_TKey_TValue_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Collections.FSharpSet<>))]
    internal class OrleansCodeGenMicrosoft_FSharp_Collections_FSharpSetSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Collections.FSharpSet<T>).@GetTypeInfo().@GetField("serializedData", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Collections.FSharpSet<T>, T[]> getField0 = (global::System.Func<global::Microsoft.FSharp.Collections.FSharpSet<T>, T[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Collections.FSharpSet<T>, T[]> setField0 = (global::System.Action<global::Microsoft.FSharp.Collections.FSharpSet<T>, T[]>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Collections.FSharpSet<T> input = ((global::Microsoft.FSharp.Collections.FSharpSet<T>)original);
            global::Microsoft.FSharp.Collections.FSharpSet<T> result = (global::Microsoft.FSharp.Collections.FSharpSet<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Collections.FSharpSet<T>));
            setField0(result, (T[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Collections.FSharpSet<T> input = (global::Microsoft.FSharp.Collections.FSharpSet<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T[]));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Collections.FSharpSet<T> result = (global::Microsoft.FSharp.Collections.FSharpSet<T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Collections.FSharpSet<T>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T[]), stream));
            return (global::Microsoft.FSharp.Collections.FSharpSet<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Collections_FSharpSetSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Collections.FSharpSet<>), typeof (OrleansCodeGenMicrosoft_FSharp_Collections_FSharpSetSerializer<>));
        }

        static OrleansCodeGenMicrosoft_FSharp_Collections_FSharpSetSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Reflection.UnionCaseInfo)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Reflection_UnionCaseInfoSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Reflection.UnionCaseInfo).@GetTypeInfo().@GetField("names", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::Microsoft.FSharp.Core.FSharpOption<global::Microsoft.FSharp.Core.FSharpFunc<global::System.Int32, global::System.String>>> getField2 = (global::System.Func<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::Microsoft.FSharp.Core.FSharpOption<global::Microsoft.FSharp.Core.FSharpFunc<global::System.Int32, global::System.String>>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::Microsoft.FSharp.Core.FSharpOption<global::Microsoft.FSharp.Core.FSharpFunc<global::System.Int32, global::System.String>>> setField2 = (global::System.Action<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::Microsoft.FSharp.Core.FSharpOption<global::Microsoft.FSharp.Core.FSharpFunc<global::System.Int32, global::System.String>>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Reflection.UnionCaseInfo).@GetTypeInfo().@GetField("tag", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Reflection.UnionCaseInfo).@GetTypeInfo().@GetField("typ", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::System.Type> getField0 = (global::System.Func<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::System.Type> setField0 = (global::System.Action<global::Microsoft.FSharp.Reflection.UnionCaseInfo, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Reflection.UnionCaseInfo input = ((global::Microsoft.FSharp.Reflection.UnionCaseInfo)original);
            global::Microsoft.FSharp.Reflection.UnionCaseInfo result = (global::Microsoft.FSharp.Reflection.UnionCaseInfo)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Reflection.UnionCaseInfo));
            setField2(result, (global::Microsoft.FSharp.Core.FSharpOption<global::Microsoft.FSharp.Core.FSharpFunc<global::System.Int32, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField1(result, getField1(input));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Reflection.UnionCaseInfo input = (global::Microsoft.FSharp.Reflection.UnionCaseInfo)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::Microsoft.FSharp.Core.FSharpOption<global::Microsoft.FSharp.Core.FSharpFunc<global::System.Int32, global::System.String>>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Type));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Reflection.UnionCaseInfo result = (global::Microsoft.FSharp.Reflection.UnionCaseInfo)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Reflection.UnionCaseInfo));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField2(result, (global::Microsoft.FSharp.Core.FSharpOption<global::Microsoft.FSharp.Core.FSharpFunc<global::System.Int32, global::System.String>>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Microsoft.FSharp.Core.FSharpOption<global::Microsoft.FSharp.Core.FSharpFunc<global::System.Int32, global::System.String>>), stream));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), stream));
            return (global::Microsoft.FSharp.Reflection.UnionCaseInfo)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Reflection.UnionCaseInfo), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Reflection_UnionCaseInfoSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Control.FSharpEvent<>))]
    internal class OrleansCodeGenMicrosoft_FSharp_Control_FSharpEventSerializer<T>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Control.FSharpEvent<T>).@GetTypeInfo().@GetField("multicast", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Control.FSharpEvent<T>, global::Microsoft.FSharp.Control.FSharpHandler<T>> getField0 = (global::System.Func<global::Microsoft.FSharp.Control.FSharpEvent<T>, global::Microsoft.FSharp.Control.FSharpHandler<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Control.FSharpEvent<T>, global::Microsoft.FSharp.Control.FSharpHandler<T>> setField0 = (global::System.Action<global::Microsoft.FSharp.Control.FSharpEvent<T>, global::Microsoft.FSharp.Control.FSharpHandler<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Control.FSharpEvent<T> input = ((global::Microsoft.FSharp.Control.FSharpEvent<T>)original);
            global::Microsoft.FSharp.Control.FSharpEvent<T> result = new global::Microsoft.FSharp.Control.FSharpEvent<T>();
            setField0(result, (global::Microsoft.FSharp.Control.FSharpHandler<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Control.FSharpEvent<T> input = (global::Microsoft.FSharp.Control.FSharpEvent<T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Microsoft.FSharp.Control.FSharpHandler<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Control.FSharpEvent<T> result = new global::Microsoft.FSharp.Control.FSharpEvent<T>();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::Microsoft.FSharp.Control.FSharpHandler<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Microsoft.FSharp.Control.FSharpHandler<T>), stream));
            return (global::Microsoft.FSharp.Control.FSharpEvent<T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Control_FSharpEventSerializer_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Control.FSharpEvent<>), typeof (OrleansCodeGenMicrosoft_FSharp_Control_FSharpEventSerializer<>));
        }

        static OrleansCodeGenMicrosoft_FSharp_Control_FSharpEventSerializer_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.PrintfFormat<,,, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_PrintfFormatSerializer<TPrinter, TState, TResidue, TResult>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>).@GetTypeInfo().@GetField("value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult> input = ((global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>)original);
            global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult> result = (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult> input = (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult> result = (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_PrintfFormatSerializer_TPrinter_TState_TResidue_TResult_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.PrintfFormat<,,, >), typeof (OrleansCodeGenMicrosoft_FSharp_Core_PrintfFormatSerializer<,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_PrintfFormatSerializer_TPrinter_TState_TResidue_TResult_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.PrintfFormat<,,,, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_PrintfFormatSerializer<TPrinter, TState, TResidue, TResult, TTuple>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>).@GetTypeInfo().@GetField("value", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult>, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple> input = ((global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple>)original);
            global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple> result = (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple>));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple> input = (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple> result = (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.PrintfFormat<TPrinter, TState, TResidue, TResult, TTuple>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_PrintfFormatSerializer_TPrinter_TState_TResidue_TResult_TTuple_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.PrintfFormat<,,,, >), typeof (OrleansCodeGenMicrosoft_FSharp_Core_PrintfFormatSerializer<,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_PrintfFormatSerializer_TPrinter_TState_TResidue_TResult_TTuple_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Quotations.FSharpVar)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Quotations_FSharpVarSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Quotations.FSharpVar).@GetTypeInfo().@GetField("isMutable@100", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Boolean> getField3 = (global::System.Func<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Boolean> setField3 = (global::System.Action<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Quotations.FSharpVar).@GetTypeInfo().@GetField("name", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.String> getField1 = (global::System.Func<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.String> setField1 = (global::System.Action<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Quotations.FSharpVar).@GetTypeInfo().@GetField("stamp", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Int64> getField2 = (global::System.Func<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Int64> setField2 = (global::System.Action<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Int64>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Quotations.FSharpVar).@GetTypeInfo().@GetField("typ", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Type> getField0 = (global::System.Func<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Type> setField0 = (global::System.Action<global::Microsoft.FSharp.Quotations.FSharpVar, global::System.Type>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Quotations.FSharpVar input = ((global::Microsoft.FSharp.Quotations.FSharpVar)original);
            global::Microsoft.FSharp.Quotations.FSharpVar result = (global::Microsoft.FSharp.Quotations.FSharpVar)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Quotations.FSharpVar));
            setField3(result, getField3(input));
            setField1(result, getField1(input));
            setField2(result, getField2(input));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Quotations.FSharpVar input = (global::Microsoft.FSharp.Quotations.FSharpVar)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Int64));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Type));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Quotations.FSharpVar result = (global::Microsoft.FSharp.Quotations.FSharpVar)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Quotations.FSharpVar));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField3(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField2(result, (global::System.Int64)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int64), stream));
            setField0(result, (global::System.Type)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Type), stream));
            return (global::Microsoft.FSharp.Quotations.FSharpVar)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Quotations.FSharpVar), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Quotations_FSharpVarSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Control.FSharpAsyncBuilder)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Control_FSharpAsyncBuilderSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Control.FSharpAsyncBuilder input = ((global::Microsoft.FSharp.Control.FSharpAsyncBuilder)original);
            global::Microsoft.FSharp.Control.FSharpAsyncBuilder result = (global::Microsoft.FSharp.Control.FSharpAsyncBuilder)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Control.FSharpAsyncBuilder));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Control.FSharpAsyncBuilder input = (global::Microsoft.FSharp.Control.FSharpAsyncBuilder)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Control.FSharpAsyncBuilder result = (global::Microsoft.FSharp.Control.FSharpAsyncBuilder)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Control.FSharpAsyncBuilder));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Control.FSharpAsyncBuilder)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Control.FSharpAsyncBuilder), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Control_FSharpAsyncBuilderSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Control.FSharpAsync)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Control_FSharpAsyncSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Control.FSharpAsync input = ((global::Microsoft.FSharp.Control.FSharpAsync)original);
            global::Microsoft.FSharp.Control.FSharpAsync result = (global::Microsoft.FSharp.Control.FSharpAsync)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Control.FSharpAsync));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Control.FSharpAsync input = (global::Microsoft.FSharp.Control.FSharpAsync)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Control.FSharpAsync result = (global::Microsoft.FSharp.Control.FSharpAsync)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Control.FSharpAsync));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Control.FSharpAsync)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Control.FSharpAsync), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Control_FSharpAsyncSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<>))]
    internal class OrleansCodeGenMicrosoft_FSharp_Control_FSharpAsyncReplyChannelSerializer<TReply>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>).@GetTypeInfo().@GetField("replyf", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>, global::Microsoft.FSharp.Core.FSharpFunc<TReply, global::Microsoft.FSharp.Core.Unit>> getField0 = (global::System.Func<global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>, global::Microsoft.FSharp.Core.FSharpFunc<TReply, global::Microsoft.FSharp.Core.Unit>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>, global::Microsoft.FSharp.Core.FSharpFunc<TReply, global::Microsoft.FSharp.Core.Unit>> setField0 = (global::System.Action<global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>, global::Microsoft.FSharp.Core.FSharpFunc<TReply, global::Microsoft.FSharp.Core.Unit>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply> input = ((global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>)original);
            global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply> result = (global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>));
            setField0(result, (global::Microsoft.FSharp.Core.FSharpFunc<TReply, global::Microsoft.FSharp.Core.Unit>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply> input = (global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Microsoft.FSharp.Core.FSharpFunc<TReply, global::Microsoft.FSharp.Core.Unit>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply> result = (global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::Microsoft.FSharp.Core.FSharpFunc<TReply, global::Microsoft.FSharp.Core.Unit>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Microsoft.FSharp.Core.FSharpFunc<TReply, global::Microsoft.FSharp.Core.Unit>), stream));
            return (global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<TReply>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Control_FSharpAsyncReplyChannelSerializer_TReply_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Control.FSharpAsyncReplyChannel<>), typeof (OrleansCodeGenMicrosoft_FSharp_Control_FSharpAsyncReplyChannelSerializer<>));
        }

        static OrleansCodeGenMicrosoft_FSharp_Control_FSharpAsyncReplyChannelSerializer_TReply_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<>))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<T1>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>).@GetTypeInfo().@GetField("item1@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1> input = ((global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>)original);
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1> input = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            return (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<>), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<>));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<T1, T2>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>).@GetTypeInfo().@GetField("item1@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>).@GetTypeInfo().@GetField("item2@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>, T2> getField1 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>, T2> setField1 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2> input = ((global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>)original);
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2> input = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (T2));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            return (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<, >), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<T1, T2, T3>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>).@GetTypeInfo().@GetField("item1@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>).@GetTypeInfo().@GetField("item2@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T2> getField1 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T2> setField1 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>).@GetTypeInfo().@GetField("item3@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T3> getField2 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T3> setField2 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3> input = ((global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>)original);
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3> input = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (T2));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (T3));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            return (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,, >), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<T1, T2, T3, T4>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>).@GetTypeInfo().@GetField("item1@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>).@GetTypeInfo().@GetField("item2@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T2> getField1 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T2> setField1 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>).@GetTypeInfo().@GetField("item3@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T3> getField2 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T3> setField2 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>).@GetTypeInfo().@GetField("item4@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T4> getField3 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T4>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T4> setField3 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>, T4>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4> input = ((global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>)original);
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4> input = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (T2));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (T3));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (T4));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T4), stream));
            return (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,, >), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,,, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<T1, T2, T3, T4, T5>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("item1@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("item2@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T2> getField1 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T2> setField1 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("item3@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T3> getField2 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T3> setField2 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("item4@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T4> getField3 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T4>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T4> setField3 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T4>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>).@GetTypeInfo().@GetField("item5@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T5> getField4 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T5>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T5> setField4 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>, T5>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5> input = ((global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>)original);
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input)));
            setField4(result, (T5)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5> input = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (T2));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (T3));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (T4));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (T5));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T4), stream));
            setField4(result, (T5)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T5), stream));
            return (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_T5_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,,, >), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_T5_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,,,, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<T1, T2, T3, T4, T5, T6>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("item1@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("item2@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T2> getField1 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T2> setField1 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("item3@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T3> getField2 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T3> setField2 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("item4@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T4> getField3 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T4>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T4> setField3 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T4>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("item5@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T5> getField4 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T5>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T5> setField4 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T5>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>).@GetTypeInfo().@GetField("item6@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T6> getField5 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T6>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T6> setField5 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>, T6>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6> input = ((global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>)original);
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input)));
            setField4(result, (T5)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input)));
            setField5(result, (T6)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6> input = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (T2));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (T3));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (T4));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (T5));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (T6));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T4), stream));
            setField4(result, (T5)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T5), stream));
            setField5(result, (T6)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T6), stream));
            return (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_T5_T6_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,,,, >), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_T5_T6_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,,,,, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<T1, T2, T3, T4, T5, T6, T7>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("item1@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("item2@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T2> getField1 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T2> setField1 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("item3@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T3> getField2 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T3> setField2 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("item4@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T4> getField3 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T4>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T4> setField3 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T4>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("item5@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T5> getField4 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T5>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T5> setField4 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T5>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("item6@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T6> getField5 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T6>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T6> setField5 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T6>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>).@GetTypeInfo().@GetField("item7@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T7> getField6 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T7>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T7> setField6 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>, T7>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7> input = ((global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>)original);
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input)));
            setField4(result, (T5)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input)));
            setField5(result, (T6)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input)));
            setField6(result, (T7)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7> input = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (T2));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (T3));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (T4));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (T5));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (T6));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), stream, typeof (T7));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T4), stream));
            setField4(result, (T5)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T5), stream));
            setField5(result, (T6)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T6), stream));
            setField6(result, (T7)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T7), stream));
            return (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_T5_T6_T7_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,,,,, >), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<,,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_T5_T6_T7_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,,,,,, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>).@GetTypeInfo().@GetField("item1@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T1> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T1>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T1> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T1>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>).@GetTypeInfo().@GetField("item2@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T2> getField1 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T2>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T2> setField1 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T2>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>).@GetTypeInfo().@GetField("item3@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T3> getField2 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T3>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T3> setField2 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T3>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>).@GetTypeInfo().@GetField("item4@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T4> getField3 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T4>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T4> setField3 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T4>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>).@GetTypeInfo().@GetField("item5@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T5> getField4 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T5>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T5> setField4 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T5>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>).@GetTypeInfo().@GetField("item6@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T6> getField5 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T6>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T6> setField5 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T6>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>).@GetTypeInfo().@GetField("item7@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T7> getField6 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T7>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T7> setField6 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T7>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>).@GetTypeInfo().@GetField("item8@", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T8> getField7 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T8>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T8> setField7 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>, T8>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8> input = ((global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>)original);
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>));
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField2(input)));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input)));
            setField4(result, (T5)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField4(input)));
            setField5(result, (T6)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField5(input)));
            setField6(result, (T7)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField6(input)));
            setField7(result, (T8)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField7(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8> input = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (T1));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (T2));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (T3));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (T4));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (T5));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (T6));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), stream, typeof (T7));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), stream, typeof (T8));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (T1)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T1), stream));
            setField1(result, (T2)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T2), stream));
            setField2(result, (T3)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T3), stream));
            setField3(result, (T4)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T4), stream));
            setField4(result, (T5)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T5), stream));
            setField5(result, (T6)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T6), stream));
            setField6(result, (T7)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T7), stream));
            setField7(result, (T8)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (T8), stream));
            return (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<T1, T2, T3, T4, T5, T6, T7, T8>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_T5_T6_T7_T8_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.AnonymousObject<,,,,,,, >), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer<,,,,,,, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_AnonymousObjectSerializer_T1_T2_T3_T4_T5_T6_T7_T8_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_GroupingSerializer<K, T>
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>).@GetTypeInfo().@GetField("key", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>, K> getField1 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>, K>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>, K> setField1 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>, K>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>).@GetTypeInfo().@GetField("values", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>, global::System.Collections.Generic.IEnumerable<T>> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>, global::System.Collections.Generic.IEnumerable<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>, global::System.Collections.Generic.IEnumerable<T>> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>, global::System.Collections.Generic.IEnumerable<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T> input = ((global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>)original);
            global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>));
            setField1(result, (K)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField1(input)));
            setField0(result, (global::System.Collections.Generic.IEnumerable<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T> input = (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (K));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.IEnumerable<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T> result = (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (K)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (K), stream));
            setField0(result, (global::System.Collections.Generic.IEnumerable<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IEnumerable<T>), stream));
            return (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<K, T>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_GroupingSerializer_K_T_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.RuntimeHelpers.Grouping<, >), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_GroupingSerializer<, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_RuntimeHelpers_GroupingSerializer_K_T_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.QuerySource<, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_QuerySourceSerializer<T, Q>
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Linq.QuerySource<T, Q>).@GetTypeInfo().@GetField("source", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Linq.QuerySource<T, Q>, global::System.Collections.Generic.IEnumerable<T>> getField0 = (global::System.Func<global::Microsoft.FSharp.Linq.QuerySource<T, Q>, global::System.Collections.Generic.IEnumerable<T>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Linq.QuerySource<T, Q>, global::System.Collections.Generic.IEnumerable<T>> setField0 = (global::System.Action<global::Microsoft.FSharp.Linq.QuerySource<T, Q>, global::System.Collections.Generic.IEnumerable<T>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.QuerySource<T, Q> input = ((global::Microsoft.FSharp.Linq.QuerySource<T, Q>)original);
            global::Microsoft.FSharp.Linq.QuerySource<T, Q> result = (global::Microsoft.FSharp.Linq.QuerySource<T, Q>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.QuerySource<T, Q>));
            setField0(result, (global::System.Collections.Generic.IEnumerable<T>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.QuerySource<T, Q> input = (global::Microsoft.FSharp.Linq.QuerySource<T, Q>)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.Collections.Generic.IEnumerable<T>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.QuerySource<T, Q> result = (global::Microsoft.FSharp.Linq.QuerySource<T, Q>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Linq.QuerySource<T, Q>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.Collections.Generic.IEnumerable<T>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.IEnumerable<T>), stream));
            return (global::Microsoft.FSharp.Linq.QuerySource<T, Q>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_QuerySourceSerializer_T_Q_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.QuerySource<, >), typeof (OrleansCodeGenMicrosoft_FSharp_Linq_QuerySourceSerializer<, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_QuerySourceSerializer_T_Q_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Linq.QueryBuilder)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Linq_QueryBuilderSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Linq.QueryBuilder input = ((global::Microsoft.FSharp.Linq.QueryBuilder)original);
            global::Microsoft.FSharp.Linq.QueryBuilder result = new global::Microsoft.FSharp.Linq.QueryBuilder();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Linq.QueryBuilder input = (global::Microsoft.FSharp.Linq.QueryBuilder)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Linq.QueryBuilder result = new global::Microsoft.FSharp.Linq.QueryBuilder();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Linq.QueryBuilder)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Linq.QueryBuilder), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Linq_QueryBuilderSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_metreSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre input = ((global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre)original);
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre input = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.metre), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_metreSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_kilogramSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram input = ((global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram)original);
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram input = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kilogram), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_kilogramSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_secondSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second input = ((global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second)original);
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second input = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.second), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_secondSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_ampereSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere input = ((global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere)original);
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere input = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.ampere), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_ampereSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_kelvinSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin input = ((global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin)original);
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin input = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.kelvin), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_kelvinSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_moleSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole input = ((global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole)original);
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole input = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.mole), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_moleSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_candelaSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela input = ((global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela)original);
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela input = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela result = (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Data.UnitSystems.SI.UnitNames.candela), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Data_UnitSystems_SI_UnitNames_candelaSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<, >))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureProductSerializer<TMeasure1, TMeasure2>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2> input = ((global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2>)original);
            global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2> result = (global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2>));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2> input = (global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2>)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2> result = (global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<TMeasure1, TMeasure2>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureProductSerializer_TMeasure1_TMeasure2_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureProduct<, >), typeof (OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureProductSerializer<, >));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureProductSerializer_TMeasure1_TMeasure2_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<>))]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureInverseSerializer<TMeasure>
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure> input = ((global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure>)original);
            global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure> result = (global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure>));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure> input = (global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure>)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure> result = (global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure>)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure>));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<TMeasure>)result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureInverseSerializer_TMeasure_Registerer
    {
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureInverse<>), typeof (OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureInverseSerializer<>));
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureInverseSerializer_TMeasure_Registerer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureOne)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureOneSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerServices.MeasureOne input = ((global::Microsoft.FSharp.Core.CompilerServices.MeasureOne)original);
            global::Microsoft.FSharp.Core.CompilerServices.MeasureOne result = (global::Microsoft.FSharp.Core.CompilerServices.MeasureOne)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureOne));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerServices.MeasureOne input = (global::Microsoft.FSharp.Core.CompilerServices.MeasureOne)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerServices.MeasureOne result = (global::Microsoft.FSharp.Core.CompilerServices.MeasureOne)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureOne));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.CompilerServices.MeasureOne)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerServices.MeasureOne), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_MeasureOneSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute input = ((global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute)original);
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute result = new global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute input = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute result = new global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderAssemblyAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute).@GetTypeInfo().@GetField("assemblyName", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute input = ((global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute)original);
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute result = new global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute();
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute input = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute result = new global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderAssemblyAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderAssemblyAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderXmlDocAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute).@GetTypeInfo().@GetField("commentText", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute input = ((global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute)original);
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute result = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute));
            setField0(result, getField0(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute input = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute result = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            return (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderXmlDocAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderXmlDocAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderDefinitionLocationAttributeSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute).@GetTypeInfo().@GetField("column", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.Int32> getField2 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.Int32> setField2 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute).@GetTypeInfo().@GetField("filePath", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.String> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.String> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute).@GetTypeInfo().@GetField("line", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.Int32> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.Int32> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute, global::System.Int32>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute input = ((global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute)original);
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute result = new global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute();
            setField2(result, getField2(input));
            setField0(result, getField0(input));
            setField1(result, getField1(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute input = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.Int32));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.Int32));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute result = new global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField2(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            setField0(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField1(result, (global::System.Int32)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Int32), stream));
            return (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderDefinitionLocationAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderDefinitionLocationAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderEditorHideMethodsAttributeSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute input = ((global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute)original);
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute result = new global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute input = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute result = new global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderEditorHideMethodsAttribute), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderEditorHideMethodsAttributeSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderConfigSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field5 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig).@GetTypeInfo().@GetField("isInvalidationSupported", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Boolean> getField5 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field5);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Boolean> setField5 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field5);
        private static readonly global::System.Reflection.FieldInfo field3 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig).@GetTypeInfo().@GetField("referencedAssemblies", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String[]> getField3 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String[]>)global::Orleans.Serialization.SerializationManager.@GetGetter(field3);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String[]> setField3 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String[]>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field3);
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig).@GetTypeInfo().@GetField("resolutionFolder", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String> getField1 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field1);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String> setField1 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        private static readonly global::System.Reflection.FieldInfo field2 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig).@GetTypeInfo().@GetField("runtimeAssembly", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String> getField2 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field2);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String> setField2 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field2);
        private static readonly global::System.Reflection.FieldInfo field7 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig).@GetTypeInfo().@GetField("systemRuntimeAssemblyVersion", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Version> getField7 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Version>)global::Orleans.Serialization.SerializationManager.@GetGetter(field7);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Version> setField7 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Version>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field7);
        private static readonly global::System.Reflection.FieldInfo field0 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig).@GetTypeInfo().@GetField("systemRuntimeContainsType", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::Microsoft.FSharp.Core.FSharpFunc<global::System.String, global::System.Boolean>> getField0 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::Microsoft.FSharp.Core.FSharpFunc<global::System.String, global::System.Boolean>>)global::Orleans.Serialization.SerializationManager.@GetGetter(field0);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::Microsoft.FSharp.Core.FSharpFunc<global::System.String, global::System.Boolean>> setField0 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::Microsoft.FSharp.Core.FSharpFunc<global::System.String, global::System.Boolean>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field0);
        private static readonly global::System.Reflection.FieldInfo field4 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig).@GetTypeInfo().@GetField("temporaryFolder", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String> getField4 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetGetter(field4);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String> setField4 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.String>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field4);
        private static readonly global::System.Reflection.FieldInfo field6 = typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig).@GetTypeInfo().@GetField("useResolutionFolderAtRuntime", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Boolean> getField6 = (global::System.Func<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetGetter(field6);
        private static readonly global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Boolean> setField6 = (global::System.Action<global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field6);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig input = ((global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig)original);
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig result = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig));
            setField5(result, getField5(input));
            setField3(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField3(input)));
            setField1(result, getField1(input));
            setField2(result, getField2(input));
            setField7(result, (global::System.Version)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField7(input)));
            setField0(result, (global::Microsoft.FSharp.Core.FSharpFunc<global::System.String, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(getField0(input)));
            setField4(result, getField4(input));
            setField6(result, getField6(input));
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig input = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField5(input), stream, typeof (global::System.Boolean));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField3(input), stream, typeof (global::System.String[]));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField1(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField2(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField7(input), stream, typeof (global::System.Version));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField0(input), stream, typeof (global::Microsoft.FSharp.Core.FSharpFunc<global::System.String, global::System.Boolean>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField4(input), stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(getField6(input), stream, typeof (global::System.Boolean));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig result = (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig)global::System.Runtime.Serialization.FormatterServices.@GetUninitializedObject(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig));
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField5(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            setField3(result, (global::System.String[])global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String[]), stream));
            setField1(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField2(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField7(result, (global::System.Version)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Version), stream));
            setField0(result, (global::Microsoft.FSharp.Core.FSharpFunc<global::System.String, global::System.Boolean>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Microsoft.FSharp.Core.FSharpFunc<global::System.String, global::System.Boolean>), stream));
            setField4(result, (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream));
            setField6(result, (global::System.Boolean)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Boolean), stream));
            return (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Microsoft.FSharp.Core.CompilerServices.TypeProviderConfig), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenMicrosoft_FSharp_Core_CompilerServices_TypeProviderConfigSerializer()
        {
            Register();
        }
    }
}

namespace UnitTests.GrainInterfaces
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject))]
    internal class OrleansCodeGenClientAddressableTestClientObjectReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject
    {
        protected @OrleansCodeGenClientAddressableTestClientObjectReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

#if !NETSTANDARD1_6
        protected @OrleansCodeGenClientAddressableTestClientObjectReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }
#endif

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -413437530;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -413437530;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -413437530:
                    switch (@methodId)
                    {
                        case 1001930530:
                            return "OnHappyPath";
                        case 1740088762:
                            return "OnSadPath";
                        case -1140724741:
                            return "OnSerialStress";
                        case -252098785:
                            return "OnParallelStress";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -413437530 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @OnHappyPath(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.String>(1001930530, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task @OnSadPath(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1740088762, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @OnSerialStress(global::System.Int32 @n)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-1140724741, new global::System.Object[]{@n});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @OnParallelStress(global::System.Int32 @n)
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-252098785, new global::System.Object[]{@n});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject", -413437530, typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientAddressableTestClientObjectMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -413437530:
                        switch (methodId)
                        {
                            case 1001930530:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)@grain).@OnHappyPath((global::System.String)arguments[0]).@Box();
                            case 1740088762:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)@grain).@OnSadPath((global::System.String)arguments[0]).@Box();
                            case -1140724741:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)@grain).@OnSerialStress((global::System.Int32)arguments[0]).@Box();
                            case -252098785:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)@grain).@OnParallelStress((global::System.Int32)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -413437530 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -413437530;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestGrain))]
    internal class OrleansCodeGenClientAddressableTestGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IClientAddressableTestGrain
    {
        protected @OrleansCodeGenClientAddressableTestGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

#if !NETSTANDARD1_6
        protected @OrleansCodeGenClientAddressableTestGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }
#endif

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1146001751;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IClientAddressableTestGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1146001751;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1146001751:
                    switch (@methodId)
                    {
                        case 1054570258:
                            return "SetTarget";
                        case -921057028:
                            return "HappyPath";
                        case -1261808465:
                            return "SadPath";
                        case 265614114:
                            return "MicroSerialStressTest";
                        case 107468207:
                            return "MicroParallelStressTest";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1146001751 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @SetTarget(global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject @target)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1054570258, new global::System.Object[]{@target is global::Orleans.Grain ? @target.@AsReference<global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject>() : @target});
        }

        public global::System.Threading.Tasks.Task<global::System.String> @HappyPath(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.String>(-921057028, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task @SadPath(global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1261808465, new global::System.Object[]{@message});
        }

        public global::System.Threading.Tasks.Task @MicroSerialStressTest(global::System.Int32 @iterationCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(265614114, new global::System.Object[]{@iterationCount});
        }

        public global::System.Threading.Tasks.Task @MicroParallelStressTest(global::System.Int32 @iterationCount)
        {
            return base.@InvokeMethodAsync<global::System.Object>(107468207, new global::System.Object[]{@iterationCount});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IClientAddressableTestGrain", 1146001751, typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientAddressableTestGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1146001751:
                        switch (methodId)
                        {
                            case 1054570258:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@SetTarget((global::UnitTests.GrainInterfaces.IClientAddressableTestClientObject)arguments[0]).@Box();
                            case -921057028:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@HappyPath((global::System.String)arguments[0]).@Box();
                            case -1261808465:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@SadPath((global::System.String)arguments[0]).@Box();
                            case 265614114:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@MicroSerialStressTest((global::System.Int32)arguments[0]).@Box();
                            case 107468207:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestGrain)@grain).@MicroParallelStressTest((global::System.Int32)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1146001751 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1146001751;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestProducer))]
    internal class OrleansCodeGenClientAddressableTestProducerReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IClientAddressableTestProducer
    {
        protected @OrleansCodeGenClientAddressableTestProducerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

#if !NETSTANDARD1_6
        protected @OrleansCodeGenClientAddressableTestProducerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }
#endif

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 924523153;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IClientAddressableTestProducer";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 924523153;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 924523153:
                    switch (@methodId)
                    {
                        case -439075721:
                            return "Poll";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 924523153 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @Poll()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(-439075721, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IClientAddressableTestProducer", 924523153, typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestProducer)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientAddressableTestProducerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 924523153:
                        switch (methodId)
                        {
                            case -439075721:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestProducer)@grain).@Poll().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 924523153 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 924523153;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain))]
    internal class OrleansCodeGenClientAddressableTestRendezvousGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain
    {
        protected @OrleansCodeGenClientAddressableTestRendezvousGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

#if !NETSTANDARD1_6
        protected @OrleansCodeGenClientAddressableTestRendezvousGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }
#endif

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1879648219;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1879648219;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1879648219:
                    switch (@methodId)
                    {
                        case 500328066:
                            return "GetProducer";
                        case -1738589351:
                            return "SetProducer";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1879648219 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IClientAddressableTestProducer> @GetProducer()
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IClientAddressableTestProducer>(500328066, null);
        }

        public global::System.Threading.Tasks.Task @SetProducer(global::UnitTests.GrainInterfaces.IClientAddressableTestProducer @producer)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1738589351, new global::System.Object[]{@producer is global::Orleans.Grain ? @producer.@AsReference<global::UnitTests.GrainInterfaces.IClientAddressableTestProducer>() : @producer});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain", 1879648219, typeof (global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientAddressableTestRendezvousGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1879648219:
                        switch (methodId)
                        {
                            case 500328066:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain)@grain).@GetProducer().@Box();
                            case -1738589351:
                                return ((global::UnitTests.GrainInterfaces.IClientAddressableTestRendezvousGrain)@grain).@SetProducer((global::UnitTests.GrainInterfaces.IClientAddressableTestProducer)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1879648219 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1879648219;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain))]
    internal class OrleansCodeGenMultifacetFactoryTestGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain
    {
        protected @OrleansCodeGenMultifacetFactoryTestGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

#if !NETSTANDARD1_6
        protected @OrleansCodeGenMultifacetFactoryTestGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }
#endif

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1185322135;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1185322135;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1185322135:
                    switch (@methodId)
                    {
                        case 1321973978:
                            return "GetReader";
                        case 872009969:
                            return "GetReader";
                        case -2056720036:
                            return "GetWriter";
                        case 105514979:
                            return "GetWriter";
                        case -281962391:
                            return "SetReader";
                        case -843412927:
                            return "SetWriter";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1185322135 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IMultifacetReader> @GetReader(global::UnitTests.GrainInterfaces.IMultifacetTestGrain @grain)
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IMultifacetReader>(1321973978, new global::System.Object[]{@grain is global::Orleans.Grain ? @grain.@AsReference<global::UnitTests.GrainInterfaces.IMultifacetTestGrain>() : @grain});
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IMultifacetReader> @GetReader()
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IMultifacetReader>(872009969, null);
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IMultifacetWriter> @GetWriter(global::UnitTests.GrainInterfaces.IMultifacetTestGrain @grain)
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IMultifacetWriter>(-2056720036, new global::System.Object[]{@grain is global::Orleans.Grain ? @grain.@AsReference<global::UnitTests.GrainInterfaces.IMultifacetTestGrain>() : @grain});
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IMultifacetWriter> @GetWriter()
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IMultifacetWriter>(105514979, null);
        }

        public global::System.Threading.Tasks.Task @SetReader(global::UnitTests.GrainInterfaces.IMultifacetReader @reader)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-281962391, new global::System.Object[]{@reader is global::Orleans.Grain ? @reader.@AsReference<global::UnitTests.GrainInterfaces.IMultifacetReader>() : @reader});
        }

        public global::System.Threading.Tasks.Task @SetWriter(global::UnitTests.GrainInterfaces.IMultifacetWriter @writer)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-843412927, new global::System.Object[]{@writer is global::Orleans.Grain ? @writer.@AsReference<global::UnitTests.GrainInterfaces.IMultifacetWriter>() : @writer});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain", 1185322135, typeof (global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMultifacetFactoryTestGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1185322135:
                        switch (methodId)
                        {
                            case 1321973978:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@GetReader((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)arguments[0]).@Box();
                            case 872009969:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@GetReader().@Box();
                            case -2056720036:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@GetWriter((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)arguments[0]).@Box();
                            case 105514979:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@GetWriter().@Box();
                            case -281962391:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@SetReader((global::UnitTests.GrainInterfaces.IMultifacetReader)arguments[0]).@Box();
                            case -843412927:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetFactoryTestGrain)@grain).@SetWriter((global::UnitTests.GrainInterfaces.IMultifacetWriter)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1185322135 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1185322135;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IMultifacetTestGrain))]
    internal class OrleansCodeGenMultifacetTestGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IMultifacetTestGrain
    {
        protected @OrleansCodeGenMultifacetTestGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

#if !NETSTANDARD1_6
        protected @OrleansCodeGenMultifacetTestGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }
#endif

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -498812991;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IMultifacetTestGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -498812991 || @interfaceId == -1899485304 || @interfaceId == -1574751914;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -498812991:
                    switch (@methodId)
                    {
                        case 637921746:
                            return "GetValue";
                        case -317315461:
                            return "SetValue";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -498812991 + ",methodId=" + @methodId);
                    }

                case -1899485304:
                    switch (@methodId)
                    {
                        case 637921746:
                            return "GetValue";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1899485304 + ",methodId=" + @methodId);
                    }

                case -1574751914:
                    switch (@methodId)
                    {
                        case -317315461:
                            return "SetValue";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1574751914 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetValue()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(637921746, null);
        }

        public global::System.Threading.Tasks.Task @SetValue(global::System.Int32 @x)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-317315461, new global::System.Object[]{@x});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IMultifacetTestGrain", -498812991, typeof (global::UnitTests.GrainInterfaces.IMultifacetTestGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenMultifacetTestGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -498812991:
                        switch (methodId)
                        {
                            case 637921746:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)@grain).@GetValue().@Box();
                            case -317315461:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)@grain).@SetValue((global::System.Int32)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -498812991 + ",methodId=" + methodId);
                        }

                    case -1899485304:
                        switch (methodId)
                        {
                            case 637921746:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)@grain).@GetValue().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1899485304 + ",methodId=" + methodId);
                        }

                    case -1574751914:
                        switch (methodId)
                        {
                            case -317315461:
                                return ((global::UnitTests.GrainInterfaces.IMultifacetTestGrain)@grain).@SetValue((global::System.Int32)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1574751914 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -498812991;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.ISerializerPresenceTest))]
    internal class OrleansCodeGenSerializerPresenceTestReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.ISerializerPresenceTest
    {
        protected @OrleansCodeGenSerializerPresenceTestReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

#if !NETSTANDARD1_6
        protected @OrleansCodeGenSerializerPresenceTestReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }
#endif

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -353951835;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.ISerializerPresenceTest";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -353951835;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -353951835:
                    switch (@methodId)
                    {
                        case 768252436:
                            return "SerializerExistsForType";
                        case -1814233889:
                            return "TakeSerializedData";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -353951835 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Boolean> @SerializerExistsForType(global::System.Type @param)
        {
            return base.@InvokeMethodAsync<global::System.Boolean>(768252436, new global::System.Object[]{@param});
        }

        public global::System.Threading.Tasks.Task @TakeSerializedData(global::System.Object @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1814233889, new global::System.Object[]{@data});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.ISerializerPresenceTest", -353951835, typeof (global::UnitTests.GrainInterfaces.ISerializerPresenceTest)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenSerializerPresenceTestMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -353951835:
                        switch (methodId)
                        {
                            case 768252436:
                                return ((global::UnitTests.GrainInterfaces.ISerializerPresenceTest)@grain).@SerializerExistsForType((global::System.Type)arguments[0]).@Box();
                            case -1814233889:
                                return ((global::UnitTests.GrainInterfaces.ISerializerPresenceTest)@grain).@TakeSerializedData((global::System.Object)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -353951835 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -353951835;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::UnitTests.GrainInterfaces.IStressTestGrain))]
    internal class OrleansCodeGenStressTestGrainReference : global::Orleans.Runtime.GrainReference, global::UnitTests.GrainInterfaces.IStressTestGrain
    {
        protected @OrleansCodeGenStressTestGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

#if !NETSTANDARD1_6
        protected @OrleansCodeGenStressTestGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }
#endif

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1803695362;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::UnitTests.GrainInterfaces.IStressTestGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1803695362;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1803695362:
                    switch (@methodId)
                    {
                        case 815427771:
                            return "GetLabel";
                        case 137111425:
                            return "SetLabel";
                        case -2120489211:
                            return "PingOthers";
                        case 1178934261:
                            return "LookUpMany";
                        case 1040966585:
                            return "Send";
                        case -608678522:
                            return "Echo";
                        case -2068079123:
                            return "Ping";
                        case -105598243:
                            return "PingWithDelay";
                        case 2018329561:
                            return "GetGrainReference";
                        case 543404287:
                            return "DeactivateSelf";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1803695362 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> @GetLabel()
        {
            return base.@InvokeMethodAsync<global::System.String>(815427771, null);
        }

        public global::System.Threading.Tasks.Task @SetLabel(global::System.String @label)
        {
            return base.@InvokeMethodAsync<global::System.Object>(137111425, new global::System.Object[]{@label});
        }

        public global::System.Threading.Tasks.Task @PingOthers(global::System.Int64[] @others)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2120489211, new global::System.Object[]{@others});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32, global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.ActivationId>>>>> @LookUpMany(global::Orleans.Runtime.SiloAddress @destination, global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32>> @grainAndETagList, global::System.Int32 @retries)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32, global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.ActivationId>>>>>(1178934261, new global::System.Object[]{@destination, @grainAndETagList, @retries});
        }

        public global::System.Threading.Tasks.Task @Send(global::System.Byte[] @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1040966585, new global::System.Object[]{@data});
        }

        public global::System.Threading.Tasks.Task<global::System.Byte[]> @Echo(global::System.Byte[] @data)
        {
            return base.@InvokeMethodAsync<global::System.Byte[]>(-608678522, new global::System.Object[]{@data});
        }

        public global::System.Threading.Tasks.Task @Ping(global::System.Byte[] @data)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2068079123, new global::System.Object[]{@data});
        }

        public global::System.Threading.Tasks.Task @PingWithDelay(global::System.Byte[] @data, global::System.TimeSpan @delay)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-105598243, new global::System.Object[]{@data, @delay});
        }

        public global::System.Threading.Tasks.Task<global::UnitTests.GrainInterfaces.IStressTestGrain> @GetGrainReference()
        {
            return base.@InvokeMethodAsync<global::UnitTests.GrainInterfaces.IStressTestGrain>(2018329561, null);
        }

        public global::System.Threading.Tasks.Task @DeactivateSelf()
        {
            return base.@InvokeMethodAsync<global::System.Object>(543404287, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::UnitTests.GrainInterfaces.IStressTestGrain", -1803695362, typeof (global::UnitTests.GrainInterfaces.IStressTestGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStressTestGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1803695362:
                        switch (methodId)
                        {
                            case 815427771:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@GetLabel().@Box();
                            case 137111425:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@SetLabel((global::System.String)arguments[0]).@Box();
                            case -2120489211:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@PingOthers((global::System.Int64[])arguments[0]).@Box();
                            case 1178934261:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@LookUpMany((global::Orleans.Runtime.SiloAddress)arguments[0], (global::System.Collections.Generic.List<global::System.Tuple<global::Orleans.Runtime.GrainId, global::System.Int32>>)arguments[1], (global::System.Int32)arguments[2]).@Box();
                            case 1040966585:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@Send((global::System.Byte[])arguments[0]).@Box();
                            case -608678522:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@Echo((global::System.Byte[])arguments[0]).@Box();
                            case -2068079123:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@Ping((global::System.Byte[])arguments[0]).@Box();
                            case -105598243:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@PingWithDelay((global::System.Byte[])arguments[0], (global::System.TimeSpan)arguments[1]).@Box();
                            case 2018329561:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@GetGrainReference().@Box();
                            case 543404287:
                                return ((global::UnitTests.GrainInterfaces.IStressTestGrain)@grain).@DeactivateSelf().@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1803695362 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1803695362;
            }
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
