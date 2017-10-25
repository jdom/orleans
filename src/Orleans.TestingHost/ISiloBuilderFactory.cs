using Microsoft.Extensions.DependencyInjection;
using Orleans.Hosting;
using Orleans.Runtime.Configuration;

namespace Orleans.TestingHost
{
    public interface ISiloBuilderFactory
    {
        ISiloHostBuilder CreateSiloBuilder(string siloName, ClusterConfiguration clusterConfiguration);
    }

    /// <summary>
    /// Allows implementations to configure the host builder when starting up each silo in the test cluster
    /// </summary>
    public interface ISiloBuilderConfigurator
    {
        /// <summary>
        /// Configures the host builder
        /// </summary>
        void Configure(ISiloHostBuilder hostBuilder);
        //void Configure(GlobalConfiguration configuration, IServiceCollection services);
    }
}
