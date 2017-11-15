using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Orleans.Hosting;
using Orleans.Runtime.Configuration;
using Orleans.TestingHost;
using Orleans.TestingHost.Utils;
using TestExtensions;
using Xunit;

namespace Tester
{
    public class TestClusterTests : IDisposable
    {
        private TestCluster2 testCluster;

        [Fact]
        public async Task CanInitialize()
        {
            var builder = new TestClusterBuilder(2);
            builder.ConfigureHostConfiguration(TestDefaultConfiguration.ConfigureHostConfiguration);
            builder.UseSiloBuilderConfigurator<TestSiloBuilderConfigurator>();
            this.testCluster = builder.Build();

            await this.testCluster.DeployAsync();
        }

        public void Dispose()
        {
            this.testCluster?.StopAllSilos();
        }

        private class TestSiloBuilderConfigurator : ISiloBuilderConfigurator
        {
            public void Configure(ISiloHostBuilder hostBuilder)
            {
                // TODO: Legacy support could be added to test cluster infrastructure too
                //var clusterConfiguration = (ClusterConfiguration)hostBuilder.Properties["ClusterConfiguration"];
                //hostBuilder.UseConfiguration(clusterConfiguration);

                hostBuilder.ConfigureServices((context, services) =>
                {
                    // all of this related to logging can be moved to a base class or app-specific helper method
                    var siloName = context.Configuration["SiloName"] ?? context.HostingEnvironment.ApplicationName;
                    var clusterId = context.Configuration["ClusterId"]; // or clusterConfiguration.Globals.DeploymentId
                    services.AddLogging(builder => TestingUtils.ConfigureDefaultLoggingBuilder(builder, TestingUtils.CreateTraceFileName(siloName, clusterId)));
                    services.AddLogging(builder => builder.AddConsole());

                    // ConfigureServices(services);
                    //services.AddMemoryStorageProvider("Default");
                    //services.AddMemoryStorageProvider("PubSubStore");
                    //services.AddSimpleMessageStreamProvider("SMSProvider");
                    //services.AddSimpleMessageStreamProvider("SMSProvider");
                    //services.AddBootstrapProvider<PreInvokeCallbackBootrstrapProvider>("PreInvokeCallbackBootrstrapProvider");
                });
            }

            //public void ConfigureServicesAlt(HostBuilderContext context, IServiceCollection services)
            //{
            //    // TODO: Legacy support could be added to test cluster infrastructure too
            //    var clusterConfiguration = (ClusterConfiguration)context.Properties["ClusterConfiguration"];
            //    services.AddLegacyClusterConfigurationSupport(clusterConfiguration);

            //    var siloName = context.HostingEnvironment.ApplicationName;
            //    var clusterId = context.Configuration["ClusterId"]; // or clusterConfiguration.Globals.DeploymentId
            //    services.AddLogging(builder => TestingUtils.ConfigureDefaultLoggingBuilder(builder, TestingUtils.CreateTraceFileName(siloName, clusterId)));

            //    ConfigureServices(services);
            //}
        }
    }
}
