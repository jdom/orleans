using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Orleans.Hosting;
using Orleans.Runtime.Configuration;
using Orleans.TestingHost;
using Orleans.TestingHost.Utils;
using TestExtensions;
using UnitTests.GrainInterfaces;
using UnitTests.Grains;
using Xunit;
using Xunit.Abstractions;

namespace Tester
{
    public class TestClusterTests : IDisposable
    {
        private readonly ITestOutputHelper output;
        private TestCluster2 testCluster;

        public TestClusterTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact, TestCategory("BVT")]
        public async Task CanInitialize()
        {
            var builder = new TestClusterBuilder(1);
            //builder.InitializeClientOnDeploy = false;
            builder.ConfigureHostConfiguration(TestDefaultConfiguration.ConfigureHostConfiguration);
            builder.AddSiloBuilderConfigurator<TestSiloBuilderConfigurator>();
            this.testCluster = builder.Build();

            var sw = Stopwatch.StartNew();
            await this.testCluster.DeployAsync();
            this.output.WriteLine($"Started {this.testCluster.GetActiveSilos().Count()} and client in {sw.ElapsedMilliseconds}ms");
            var grain = this.testCluster.Client.GetGrain<ISimpleGrain>(1, SimpleGrain.SimpleGrainNamePrefix);

            await grain.SetA(2);
            Assert.Equal(2, await grain.GetA());
        }

        private static async Task<long?> InitializeBenchmark(int silos, bool client, ITestOutputHelper output)
        {
            var builder = new TestClusterBuilder(1);
            builder.InitializeClientOnDeploy = false;
            builder.ConfigureHostConfiguration(TestDefaultConfiguration.ConfigureHostConfiguration);
            builder.AddSiloBuilderConfigurator<TestSiloBuilderConfigurator>();
            var testCluster = builder.Build();
            try
            {
                var sw = Stopwatch.StartNew();
                await testCluster.DeployAsync();
                long ellapsed = sw.ElapsedMilliseconds;
                output.WriteLine($"Started {silos} and client={client} in {ellapsed}ms");
                return ellapsed;
            }
            catch (Exception ex)
            {
                output.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                testCluster.StopAllSilos();
            }
        }

        [Fact]
        public async Task InitializeBenchmark1NoClient()
        {
            int count = 150;
            await RunBenchmark(count, 1, false, this.output);
        }

        [Fact]
        public async Task InitializeBenchmark2NoClient()
        {
            int count = 150;
            await RunBenchmark(count, 2, false, this.output);
        }

        [Fact]
        public async Task InitializeBenchmark1WithClient()
        {
            int count = 150;
            await RunBenchmark(count, 1, true, this.output);
        }


        private async static Task RunBenchmark(int count, int silos, bool client, ITestOutputHelper output)
        {
            int successful = 0;
            long totalTime = 0;
            for (int i = 0; i < count; i++)
            {
                long? ellapsed = await InitializeBenchmark(silos, client, output);
                if (ellapsed.HasValue)
                {
                    totalTime += ellapsed.Value;
                    successful++;
                }
            }

            output.WriteLine("---------------------");
            output.WriteLine($"Average: {totalTime / count}ms (Total: {totalTime}ms / Successful: {successful})");
        }

        [Fact, TestCategory("BVT")]
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

            var grain = this.testCluster.Client.GetGrain<ISimpleGrain>(1, SimpleGrain.SimpleGrainNamePrefix);

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
                    services.AddLogging(builder => builder.AddConsole());

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
