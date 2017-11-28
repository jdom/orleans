﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Orleans.ApplicationParts;
using Orleans.Hosting;
using Orleans.Runtime.Configuration;
using Orleans.Runtime.Providers;
using Orleans.Runtime.TestHooks;
using Orleans.Configuration;
using Orleans.Runtime;

namespace Orleans.TestingHost
{
    internal class TestClusterHostFactory
    {
        public static ISiloHost CreateSiloHost(string hostName, IEnumerable<IConfigurationSource> configurationSources)
        {
            var configBuilder = new ConfigurationBuilder();
            foreach (var source in configurationSources)
            {
                configBuilder.Add(source);
            }
            var configuration = configBuilder.Build();

            string siloName = configuration["SiloName"] ?? hostName;

            ISiloHostBuilder hostBuilder = new SiloHostBuilder()
                .ConfigureSiloName(siloName)
                .ConfigureHostConfiguration(cb =>
                {
                    // TODO: Instead of passing the sources individually, just chain the pre-built configuration once we upgrade to Microsoft.Extensions.Configuration 2.1
                    foreach (var source in configBuilder.Sources)
                    {
                        cb.Add(source);
                    }
                });

            ConfigureAppServices(configuration, hostBuilder);

            hostBuilder.ConfigureServices((context, services) =>
            {
                services.AddSingleton<TestHooksSystemTarget>();
                TryConfigureTestClusterMembership(context, services);

                // TODO: configure this without requiring the legacy configuration, when that's available
                var clusterConfiguration = GetOrCreateClusterConfiguration(services, context);
                ConfigureListeningPorts(context, clusterConfiguration, siloName);

                if (string.IsNullOrWhiteSpace(clusterConfiguration.Globals.DeploymentId))
                {
                    clusterConfiguration.Globals.DeploymentId = context.Configuration["ClusterId"];
                }
            });

            AddDefaultApplicationParts(hostBuilder.GetApplicationPartManager());

            var host = hostBuilder.Build();
            InitializeTestHooksSystemTarget(host);
            return host;
        }

        public static IClusterClient CreateClusterClient(string hostName, IEnumerable<IConfigurationSource> configurationSources)
        {
            var configBuilder = new ConfigurationBuilder();
            foreach (var source in configurationSources)
            {
                configBuilder.Add(source);
            }
            var configuration = configBuilder.Build();

            var builder = new ClientBuilder();
            ConfigureAppServices(configuration, builder);

            builder.ConfigureServices(services =>
                {
                    TryConfigureTestClusterMembership(configuration, services);

                    // TODO: configure this without requiring the legacy configuration, when that's available
                    var clientConfiguration = GetOrCreateClientConfiguration(services, configuration);

                    if (string.IsNullOrWhiteSpace(clientConfiguration.DeploymentId))
                    {
                        clientConfiguration.DeploymentId = configuration["ClusterId"];
                    }

                    if (Debugger.IsAttached)
                    {
                        // Test is running inside debugger - Make timeout ~= infinite
                        clientConfiguration.ResponseTimeout = TimeSpan.FromMilliseconds(1000000);
                    }
                });

            AddDefaultApplicationParts(builder.GetApplicationPartManager());
            return builder.Build();
        }

        public static string SerializeConfigurationSources(IList<IConfigurationSource> sources)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
            };

            return JsonConvert.SerializeObject(sources, settings);
        }

        public static IList<IConfigurationSource> DeserializeConfigurationSources(string serializedSources)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
            };

            return JsonConvert.DeserializeObject<IList<IConfigurationSource>>(serializedSources, settings);
        }

        private static void ConfigureListeningPorts(HostBuilderContext context, ClusterConfiguration clusterConfiguration, string siloName)
        {
            int siloPort = int.Parse(context.Configuration["SiloPort"]);
            int gatewayPort = int.Parse(context.Configuration["GatewayPort"]);

            var nodeConfig = clusterConfiguration.GetOrCreateNodeConfigurationForSilo(siloName);

            nodeConfig.HostNameOrIPAddress = "localhost";
            nodeConfig.Port = siloPort;
            nodeConfig.ProxyGatewayEndpoint = new IPEndPoint(IPAddress.Loopback, gatewayPort);
        }

        private static ClusterConfiguration GetOrCreateClusterConfiguration(IServiceCollection services, HostBuilderContext context)
        {
            var clusterConfiguration = services
                .FirstOrDefault(s => s.ServiceType == typeof(ClusterConfiguration))
                ?.ImplementationInstance as ClusterConfiguration;

            if (clusterConfiguration == null)
            {
                clusterConfiguration = new ClusterConfiguration
                {
                    Globals =
                    {
                        ReminderServiceType = GlobalConfiguration.ReminderServiceProviderType.ReminderTableGrain
                    }
                };

                services.AddLegacyClusterConfigurationSupport(clusterConfiguration);
            }
            return clusterConfiguration;
        }

        private static ClientConfiguration GetOrCreateClientConfiguration(IServiceCollection services, IConfiguration configuration)
        {
            var clientConfiguration = services.TryGetClientConfiguration();

            if (clientConfiguration == null)
            {
                clientConfiguration = new ClientConfiguration();
                services.AddLegacyClientConfigurationSupport(clientConfiguration);
            }
            return clientConfiguration;
        }

        private static void ConfigureAppServices(IConfiguration configuration, ISiloHostBuilder hostBuilder)
        {
            var builderConfiguratorTypes = configuration.GetSection("SiloBuilderConfiguratorTypes")?.Get<string[]>();
            if (builderConfiguratorTypes == null) return;

            foreach (var builderConfiguratorType in builderConfiguratorTypes)
            {
                if (!string.IsNullOrWhiteSpace(builderConfiguratorType))
                {
                    var builderConfigurator = (ISiloBuilderConfigurator)Activator.CreateInstance(Type.GetType(builderConfiguratorType, true));
                    builderConfigurator.Configure(hostBuilder);
                }
            }
        }

        private static void ConfigureAppServices(IConfiguration configuration, IClientBuilder clientBuilder)
        {
            var builderConfiguratorType = configuration["ClientBuilderConfiguratorType"];
            if (!string.IsNullOrWhiteSpace(builderConfiguratorType))
            {
                var builderConfigurator = (IClientBuilderConfigurator)Activator.CreateInstance(Type.GetType(builderConfiguratorType));
                builderConfigurator.Configure(clientBuilder);
            }
        }

        private static void TryConfigureTestClusterMembership(HostBuilderContext context, IServiceCollection services)
        {
            bool.TryParse(context.Configuration["UseTestClusterMemebership"], out bool useTestClusterMemebership);
            if (useTestClusterMemebership)
            {
                var primarySiloEndPoint = new IPEndPoint(IPAddress.Loopback, int.Parse(context.Configuration["PrimarySiloPort"]));

                services.UseDevelopmentMembership(options => options.PrimarySiloEndPoint = primarySiloEndPoint);
            }
        }

        private static void TryConfigureTestClusterMembership(IConfiguration configuration, IServiceCollection services)
        {
            bool.TryParse(configuration["UseTestClusterMemebership"], out bool useTestClusterMemebership);
            if (useTestClusterMemebership)
            {
                services.UseStaticGatewayListProvider(options =>
                {
                    int baseGatewayPort = int.Parse(configuration["BaseGatewayPort"]);
                    int initialSilosCount = int.Parse(configuration["InitialSilosCount"]);

                    options.Gateways = Enumerable.Range(baseGatewayPort, initialSilosCount)
                        .Select(port => new IPEndPoint(IPAddress.Loopback, port).ToGatewayUri())
                        .ToList();
                });
            }
        }

        private static void AddDefaultApplicationParts(ApplicationPartManager applicationPartsManager)
        {
            var hasApplicationParts = applicationPartsManager.ApplicationParts.OfType<AssemblyPart>()
                .Any(part => !part.IsFrameworkAssembly);
            if (!hasApplicationParts)
            {
                applicationPartsManager.AddApplicationPartsFromAppDomain();
                applicationPartsManager.AddApplicationPartsFromBasePath();
            }
        }

        private static void InitializeTestHooksSystemTarget(ISiloHost host)
        {
            var testHook = host.Services.GetRequiredService<TestHooksSystemTarget>();
            var providerRuntime = host.Services.GetRequiredService<SiloProviderRuntime>();
            providerRuntime.RegisterSystemTarget(testHook);
        }
    }
}
