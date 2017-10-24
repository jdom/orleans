using System;
using System.Numerics;
using Orleans.CodeGeneration;
using Orleans.Serialization;

//[assembly: GenerateSerializer(typeof(Vector3))]

[Serializer(typeof(Vector3))]
internal class Vector3Serializer
{
    [CopierMethod]
    public static object DeepCopier(global::System.Object original, ICopyContext context)
    {
        Vector3 input = (Vector3)original;
        Vector3 result = new Vector3(input.X, input.Y, input.Z);
        return result;
    }

    [SerializerMethod]
    public static void Serializer(object untypedInput, ISerializationContext context, Type expected)
    {
        Vector3 input = (Vector3)untypedInput;
        context.SerializeInner(input.X, typeof(float));
        context.SerializeInner(input.Y, typeof(float));
        context.SerializeInner(input.Z, typeof(float));
    }

    [DeserializerMethod]
    public static object Deserializer(Type expected, IDeserializationContext context)
    {
        float x = (float)context.DeserializeInner(typeof(float));
        float y = (float)context.DeserializeInner(typeof(float));
        float z = (float)context.DeserializeInner(typeof(float));
        Vector3 result = new Vector3(x, y, z);
        return result;
    }
}