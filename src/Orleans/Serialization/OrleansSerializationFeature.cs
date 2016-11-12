using System;
using System.Collections.Generic;
using System.Reflection;

namespace Orleans.Serialization.Registration
{
    /// <summary>
    /// Deep copier function.
    /// </summary>
    /// <param name="original">Original object to be deep copied.</param>
    /// <returns>Deep copy of the original object.</returns>
    public delegate object DeepCopier(object original);

    /// <summary> Serializer function. </summary>
    /// <param name="raw">Input object to be serialized.</param>
    /// <param name="stream">Stream to write this data to.</param>
    /// <param name="expected">Current Type active in this stream.</param>
    public delegate void Serializer(object raw, BinaryTokenStreamWriter stream, Type expected);

    /// <summary>
    /// Deserializer function.
    /// </summary>
    /// <param name="expected">Expected Type to receive.</param>
    /// <param name="stream">Input stream to be read from.</param>
    /// <returns>Rehydrated object of the specified Type read from the current position in the input stream.</returns>
    public delegate object Deserializer(Type expected, BinaryTokenStreamReader stream);

    public struct SerializerMethods
    {
        public SerializerMethods(DeepCopier deepCopy, Serializer serialize, Deserializer deserialize)
            : this()
        {
            this.DeepCopy = deepCopy;
            this.Serialize = serialize;
            this.Deserialize = deserialize;
        }

        public DeepCopier DeepCopy { get; private set; }
        public Serializer Serialize { get; private set; }
        public Deserializer Deserialize { get; private set; }
    }

    /// <summary>
    /// The collection of Orleans serializer types in an Orleans application.
    /// </summary>
    public class OrleansSerializationFeature
    {
        /// <summary>
        /// Gets a map from type to serializer type in an Orleans application.
        /// </summary>
        public IDictionary<Type, TypeInfo> SerializerTypes { get; } = new Dictionary<Type, TypeInfo>();

        /// <summary>
        /// Gets a map from type to serializer methods in an Orleans application, when the type to serialize does not have a type that explicily serializes a single type.
        /// </summary>
        public IDictionary<Type, SerializerMethods> SerializerMethods { get; } = new Dictionary<Type, SerializerMethods>();

        /// <summary>
        /// Gets a reverse lookup map from friendly name to serializable type in an Orleans application.
        /// </summary>
        public IDictionary<string, Type> FriendlyNameMap { get; } = new Dictionary<string, Type>();
    }
}
