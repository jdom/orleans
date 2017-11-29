using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orleans.Hosting;
using Orleans.Runtime.Configuration;
using Orleans.TestingHost.Tests.Grains;
using Orleans.TestingHost.Utils;
using TestExtensions;
using Xunit;
using Xunit.Abstractions;

namespace Orleans.TestingHost.Tests
{
    public class TestClusterTests : IDisposable
    {
        private readonly ITestOutputHelper output;
        private TestCluster2 testCluster;

        public TestClusterTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact, TestCategory("BVT"), TestCategory("Functional")]
        public async Task CanInitialize()
        {
            var builder = new TestClusterBuilder(2);
            builder.ConfigureHostConfiguration(TestDefaultConfiguration.ConfigureHostConfiguration);
            builder.AddSiloBuilderConfigurator<TestSiloBuilderConfigurator>();
            builder.AddClientBuilderConfigurator<TestClientBuilderConfigurator>();
            this.testCluster = builder.Build();

            await this.testCluster.DeployAsync();

            var grain = this.testCluster.Client.GetGrain<ISimpleGrain>(1);

            await grain.SetA(2);
            Assert.Equal(2, await grain.GetA());
        }

        [Fact, TestCategory("Functional")]
        public async Task CanInitializeWithLegacyConfiguration()
        {
            var builder = new LegacyTestClusterBuilder(2);
            builder.ConfigureHostConfiguration(TestDefaultConfiguration.ConfigureHostConfiguration);
            builder.AddSiloBuilderConfigurator<LegacyTestSiloBuilderConfigurator>();
            var config = ClusterConfiguration.LocalhostPrimarySilo();
            config.AddMemoryStorageProvider("Default");

            builder.ClusterConfiguration = config;
            this.testCluster = builder.Build();

            await this.testCluster.DeployAsync();

            var grain = this.testCluster.Client.GetGrain<ISimpleGrain>(1);

            await grain.SetA(2);
            Assert.Equal(2, await grain.GetA());
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
                    var clusterConfiguration = services.TryGetClusterConfiguration();
                    // all of this related to logging can be moved to a base class or app-specific helper method
                    var siloName = context.Configuration["SiloName"] ?? context.HostingEnvironment.ApplicationName;
                    var clusterId = context.Configuration["ClusterId"]; // or clusterConfiguration.Globals.DeploymentId
                    services.AddLogging(builder => TestingUtils.ConfigureDefaultLoggingBuilder(builder, TestingUtils.CreateTraceFileName(siloName, clusterId)));

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

        private class TestClientBuilderConfigurator : IClientBuilderConfigurator
        {
            public void Configure(IConfiguration configuration, IClientBuilder clientBuilder)
            {
                var clusterId = configuration["ClusterId"];
                clientBuilder.ConfigureLogging(builder => TestingUtils.ConfigureDefaultLoggingBuilder(builder, TestingUtils.CreateTraceFileName("Client", clusterId)));
            }
        }

        private class LegacyTestSiloBuilderConfigurator : ISiloBuilderConfigurator
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

                    // ConfigureServices(services);
                    //services.AddMemoryStorageProvider("Default");
                    //services.AddMemoryStorageProvider("PubSubStore");
                    //services.AddSimpleMessageStreamProvider("SMSProvider");
                    //services.AddSimpleMessageStreamProvider("SMSProvider");
                    //services.AddBootstrapProvider<PreInvokeCallbackBootrstrapProvider>("PreInvokeCallbackBootrstrapProvider");
                });
            }
        }
     }
}
