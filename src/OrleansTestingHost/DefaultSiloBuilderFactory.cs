using Orleans.Hosting;
using Orleans.Runtime.Configuration;

namespace Orleans.TestingHost
{
    public sealed class DefaultSiloBuilderFactory : ISiloBuilderFactory
    {
        public IHostBuilder CreateSiloBuilder(string siloName, ClusterConfiguration clusterConfiguration)
        {
            return new HostBuilder().ConfigureSiloHost(builder => 
                builder
                    .ConfigureSiloName(siloName)
                    .UseConfiguration(clusterConfiguration));
        }
    }
}
