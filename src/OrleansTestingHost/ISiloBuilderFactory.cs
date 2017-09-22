using Orleans.Hosting;
using Orleans.Runtime.Configuration;

namespace Orleans.TestingHost
{
    public interface ISiloBuilderFactory
    {
        IHostBuilder CreateSiloBuilder(string siloName, ClusterConfiguration clusterConfiguration);
    }
}
