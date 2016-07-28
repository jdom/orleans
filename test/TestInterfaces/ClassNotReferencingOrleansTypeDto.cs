using System;

namespace UnitTests.Dtos
{
#if !NETSTANDARD
    [Serializable]
#endif
    public class ClassNotReferencingOrleansTypeDto
    {
        public string MyProperty { get; set; }
    }
}