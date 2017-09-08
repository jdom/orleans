using Orleans.Runtime.Configuration;
using Orleans.TestingHost;

namespace TestExtensions
{
    public class DefaultClusterFixture : BaseTestClusterFixture
    {
        protected override TestCluster CreateTestCluster()
        {
            var options = new TestClusterOptions();
            options.ClusterConfiguration.AddMemoryStorageProvider("Default");
            options.ClusterConfiguration.AddMemoryStorageProvider("MemoryStore");
            options.ClusterConfiguration.AddPerfCountersTelemetryConsumer();
            options.ClientConfiguration.AddPerfCountersTelemetryConsumer();
            return new TestCluster(options);
        }
    }
}
