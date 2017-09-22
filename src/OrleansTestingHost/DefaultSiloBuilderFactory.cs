using Orleans.Hosting;
using Orleans.Runtime.Configuration;

namespace Orleans.TestingHost
{
    public sealed class DefaultSiloBuilderFactory : ISiloBuilderFactory
    {
        public ISiloHostBuilder CreateSiloBuilder(string siloName, ClusterConfiguration clusterConfiguration)
        {
            var builder = new SiloHostBuilder();
            return builder.ConfigureSiloIdentity(siloName).UseConfiguration(clusterConfiguration);
        }
    }
}
