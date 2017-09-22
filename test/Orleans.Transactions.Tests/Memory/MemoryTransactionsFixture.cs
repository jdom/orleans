using Orleans.Runtime.Configuration;
using Orleans.TestingHost;
using Orleans.Hosting;
using Orleans.Transactions.Development;
using TestExtensions;

namespace Orleans.Transactions.Tests
{
    public class MemoryTransactionsFixture : BaseTestClusterFixture
    {
        protected override TestCluster CreateTestCluster()
        {
            var options = new TestClusterOptions();
            options.ClusterConfiguration.AddMemoryStorageProvider(TransactionTestConstants.TransactionStore);
            options.UseSiloBuilderFactory<SiloBuilderFactory>();
            return new TestCluster(options);
        }

        private class SiloBuilderFactory : ISiloBuilderFactory
        {
            public IHostBuilder CreateSiloBuilder(string siloName, ClusterConfiguration clusterConfiguration)
            {
                return new HostBuilder()
                    .ConfigureSiloHost(silo => silo
                        .ConfigureSiloName(siloName)
                        .UseConfiguration(clusterConfiguration)
                        .UseInClusterTransactionManager(new TransactionsConfiguration())
                        .UseInMemoryTransactionLog()
                        .UseTransactionalState());
            }
        }
    }
}
