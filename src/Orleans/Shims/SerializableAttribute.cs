#if NETSTANDARD_TODO
namespace Orleans
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
    public sealed class SerializableAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Field, Inherited=false)] 
    public sealed class NonSerializedAttribute : Attribute
    {
    }
}

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary> 
    /// Specifies that the attributed code should be excluded from code coverage
    /// collection.  Placing this attribute on a class/struct excludes all 
    /// enclosed methods and properties from code coverage collection. 
    /// </summary>
    [AttributeUsage( 
        AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event,
        Inherited = false,
        AllowMultiple = false
    )] 
    public sealed class ExcludeFromCodeCoverageAttribute : Attribute
    { 
        public ExcludeFromCodeCoverageAttribute() 
        {
        } 
    }
}
#endif
