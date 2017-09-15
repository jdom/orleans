using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using Orleans;
using Orleans.Runtime.Configuration;
using Orleans.Runtime.Hosting;
using UnitTests.GrainInterfaces;
using Xunit;

namespace Tester
{
    public class HostBuilderTests
    {
        [Fact]
        public async Task UseGenericHostBuilder()
        {
            const int gatewayPort = 44442;
            var builder = new HostBuilder();
            builder.ConfigureSiloHost(ClusterConfiguration.LocalhostPrimarySilo(2345, gatewayPort));

            using (var host = builder.Build())
            {
                await host.StartAsync();

                await AssertClientConnectivity(gatewayPort);

                await host.StopAsync();
            }
        }

        private static async Task AssertClientConnectivity(int gatewayPort)
        {
            // quick & dirty way of verifying that the Silo is functional
            using (var client = new ClientBuilder().UseConfiguration(ClientConfiguration.LocalhostSilo(gatewayPort)).Build())
            {
                await client.Connect();
                var grain = client.GetGrain<ISimpleGrain>(new Random().Next());
                await grain.SetA(4);
                var actual = await grain.GetA();

                Assert.Equal(4, actual);
            }
        }
    }
}
