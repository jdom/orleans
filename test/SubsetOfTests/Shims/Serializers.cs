using System.Reflection;

namespace SubsetOfTests.Shims
{
    public static class Serializers
    {
        public static void RegisterAll()
        {
            var assembliesToScan = new[]
            {
                typeof(UnitTests.GrainInterfaces.LargeTestData).GetTypeInfo().Assembly,
                typeof(UnitTests.Serialization.BuiltInSerializerTests).GetTypeInfo().Assembly,
            };

            foreach (var assembly in assembliesToScan)
            {
                Orleans.Runtime.AssemblyProcessor.ProcessAssembly(assembly);
            }
        }
    }
}