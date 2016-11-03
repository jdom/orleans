using System.Reflection;
using Orleans.Runtime;
using Orleans.Serialization;
using Xunit;

namespace UnitTests
{
    public class AssemblyLoaderTests
    {
        const string ExpectedFileName = "OrleansProviders.dll";
        private readonly Logger logger = LogManager.GetLogger("AssemblyLoaderTests", LoggerType.Application);

        public AssemblyLoaderTests()
        {
            SerializationManager.InitializeForTesting();
        }

        [Fact, TestCategory("AssemblyLoader"), TestCategory("BVT"), TestCategory("Functional")]
        public void CatalogLoadsDependencies()
        {
            var catalog = NewCatalog()
                .WithAssembly("TestInternalGrainInterfaces");

            Assert.Contains(Assembly.Load("TestInternalGrainInterfaces"), catalog.GetAssemblies());
            Assert.Contains(Assembly.Load("TestGrainInterfaces"), catalog.GetAssemblies());
        }

        [Fact, TestCategory("AssemblyLoader"), TestCategory("BVT"), TestCategory("Functional")]
        public void AssemblyLoaderTest()
        {
            var catalog = NewCatalog();
            var loader = AssemblyLoader.NewAssemblyLoader(catalog);
        }

        private AssemblyCatalog NewCatalog()
        {
            return new AssemblyCatalog()
                .WithAssembly("TestInternalGrains");
        }
    }
}
