using Orleans.Hosting;
using Orleans.Runtime.Configuration;

namespace Orleans.TestingHost
{
    public sealed class DefaultSiloBuilderFactory : ISiloBuilderFactory
    {
        public ISiloHostBuilder CreateSiloBuilder(string siloName, ClusterConfiguration clusterConfiguration)
        {
            return new SiloHostBuilder().ConfigureSiloHost(builder => 
                builder
                    .ConfigureSiloName(siloName)
                    .UseConfiguration(clusterConfiguration));
        }
    }
}
