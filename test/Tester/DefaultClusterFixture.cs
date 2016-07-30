using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using Orleans.TestingHost;

namespace Tester
{
    public class DefaultClusterFixture : BaseTestClusterFixture
    {
        protected override TestCluster CreateTestCluster()
        {
            var options = new TestClusterOptions();
            options.ClusterConfiguration.AddMemoryStorageProvider("Default");
            options.ClusterConfiguration.AddMemoryStorageProvider("MemoryStore");
            options.ClusterConfiguration.Defaults.AssemblyCatalog = new PathBasedAssemblyCatalog()
                    .WithAssembly(@".\TestGrainInterfaces.dll")
                    .WithAssembly(@".\TestInternalGrainInterfaces.dll");
            options.ClientConfiguration.AssemblyCatalog = new PathBasedAssemblyCatalog()
                    .WithAssembly(@".\TestGrainInterfaces.dll")
                    .WithAssembly(@".\TestInternalGrainInterfaces.dll");
            return new TestCluster(options);
        }
    }
}
