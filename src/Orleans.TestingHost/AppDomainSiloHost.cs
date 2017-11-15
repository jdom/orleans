using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orleans.ApplicationParts;
using Orleans.Providers;
using Orleans.Runtime;
using Orleans.Runtime.GrainDirectory;
using Orleans.Runtime.Messaging;
using Orleans.Runtime.Placement;
using Orleans.Storage;
using Orleans.MultiCluster;
using Orleans.Hosting;
using Orleans.Runtime.Configuration;
using Orleans.Runtime.MultiClusterNetwork;
using Orleans.Runtime.TestHooks;
using Orleans.Runtime.Providers;
using Orleans.Runtime.Storage;

namespace Orleans.TestingHost
{
    /// <summary>Allows programmatically hosting an Orleans silo in the curent app domain, exposing some marshable members via remoting.</summary>
    public class AppDomainSiloHost2 : MarshalByRefObject
    {
        private readonly ISiloHost host;

        /// <summary>Creates and initializes a silo in the current app domain.</summary>
        /// <param name="appDomainName">Name of this silo.</param>
        /// <param name="serializedConfigurationSources">Silo config data to be used for this silo.</param>
        public AppDomainSiloHost2(string appDomainName, string serializedConfigurationSources)
        {
            var deserializedSources = TestClusterBuilder.DeserializeConfigurationSources(serializedConfigurationSources);
            var configBuilder = new ConfigurationBuilder();
            foreach (var source in deserializedSources)
            {
                configBuilder.Add(source);
            }
            var configuration = configBuilder.Build();

            string siloName = configuration["SiloName"] ?? appDomainName;

            ISiloHostBuilder hostBuilder = new SiloHostBuilder()
                .ConfigureSiloName(siloName)
                .ConfigureServices(services => services.AddSingleton<TestHooksSystemTarget>())
                .ConfigureHostConfiguration(cb =>
                {
                    // TODO: Instead of passing the sources individually, just chain the pre-built configuration once we upgrade to Microsoft.Extensions.Configuration 2.1
                    foreach (var source in configBuilder.Sources)
                    {
                        cb.Add(source);
                    }
                });

            var builderConfiguratorType = configuration["SiloBuilderConfiguratorType"];
            if (!string.IsNullOrWhiteSpace(builderConfiguratorType))
            {
                var builderConfigurator = (ISiloBuilderConfigurator)Activator.CreateInstance(Type.GetType(builderConfiguratorType));
                builderConfigurator.Configure(hostBuilder);
            }

            hostBuilder.ConfigureServices((context, services) =>
            {
                // TODO: configure this without requiring the legacy configuration, when that's available
                var clusterConfiguration = services.FirstOrDefault(s => s.ImplementationType == typeof(ClusterConfiguration))?.ImplementationInstance as ClusterConfiguration;
                if (clusterConfiguration == null)
                {
                    int baseSiloPort = int.Parse(context.Configuration["BaseSiloPort"]);
                    int baseGatewayPort = int.Parse(context.Configuration["BaseGatewayPort"]);

                    clusterConfiguration = ClusterConfiguration.LocalhostPrimarySilo(baseSiloPort, baseGatewayPort);
                    services.AddLegacyClusterConfigurationSupport(clusterConfiguration);
                }

                bool.TryParse(context.Configuration["UseTestClusterMemebership"], out bool useTestClusterMemebership);
                if (useTestClusterMemebership)
                {
                    var primaryNode = new IPEndPoint(IPAddress.Loopback, int.Parse(context.Configuration["SeedNodePort"]));
                    if (clusterConfiguration.Globals.SeedNodes.Count == 0)
                    {
                        clusterConfiguration.Globals.SeedNodes.Add(primaryNode);
                    }

                    clusterConfiguration.PrimaryNode = primaryNode;

                    services.UseGrainBasedMembership();
                }

                int siloPort = int.Parse(context.Configuration["SiloPort"]);
                int gatewayPort = int.Parse(context.Configuration["GatewayPort"]);

                var nodeConfig = clusterConfiguration.GetOrCreateNodeConfigurationForSilo(siloName);

                nodeConfig.HostNameOrIPAddress = "localhost";
                nodeConfig.Port = siloPort;
                nodeConfig.ProxyGatewayEndpoint = new IPEndPoint(IPAddress.Loopback, gatewayPort);
            });

            var hasApplicationParts = hostBuilder.GetApplicationPartManager().ApplicationParts.OfType<AssemblyPart>().Any(part => !part.IsFrameworkAssembly);
            if (!hasApplicationParts)
            {
                hostBuilder
                    .AddApplicationPartsFromAppDomain()
                    .AddApplicationPartsFromBasePath();
            }

            this.host = hostBuilder.Build();
            InitializeTestHooksSystemTarget();
            this.AppDomainTestHook = new AppDomainTestHooks(this.host);
        }

        /// <summary> SiloAddress for this silo. </summary>
        public SiloAddress SiloAddress => this.host.Services.GetRequiredService<ILocalSiloDetails>().SiloAddress;
        
        internal AppDomainTestHooks AppDomainTestHook { get; }
        
        /// <summary>Starts the silo</summary>
        public void Start()
        {
            this.host.StartAsync().GetAwaiter().GetResult();
        }

        /// <summary>Gracefully shuts down the silo</summary>
        public void Shutdown()
        {
            this.host.StopAsync().GetAwaiter().GetResult();
        }

        private void InitializeTestHooksSystemTarget()
        {
            var testHook = this.host.Services.GetRequiredService<TestHooksSystemTarget>();
            var providerRuntime = this.host.Services.GetRequiredService<SiloProviderRuntime>();
            providerRuntime.RegisterSystemTarget(testHook);
        }
    }

    /// <summary>
    /// Test hook functions for white box testing.
    /// NOTE: this class has to and will be removed entirely. This requires the tests that currently rely on it, to assert using different mechanisms, such as with grains.
    /// </summary>
    internal class AppDomainTestHooks : MarshalByRefObject
    {
        private readonly ISiloHost host;

        public AppDomainTestHooks(ISiloHost host)
        {
            this.host = host;
        }

        internal IBootstrapProvider GetBootstrapProvider(string name)
        {
            var bootstrapProviderManager = this.host.Services.GetRequiredService<BootstrapProviderManager>();
            IBootstrapProvider provider = (IBootstrapProvider)bootstrapProviderManager.GetProvider(name);
            return CheckReturnBoundaryReference("bootstrap provider", provider);
        }

        /// <summary>Find the named storage provider loaded in this silo. </summary>
        internal IStorageProvider GetStorageProvider(string name) => CheckReturnBoundaryReference("storage provider", (IStorageProvider)this.host.Services.GetRequiredService<StorageProviderManager>().GetProvider(name));

        private static T CheckReturnBoundaryReference<T>(string what, T obj) where T : class
        {
            if (obj == null) return null;
            if (obj is MarshalByRefObject || obj is ISerializable)
            {
                // Reference to the provider can safely be passed across app-domain boundary in unit test process
                return obj;
            }
            throw new InvalidOperationException(
                $"Cannot return reference to {what} {TypeUtils.GetFullName(obj.GetType())} if it is not MarshalByRefObject or Serializable");
        }

        public IDictionary<GrainId, IGrainInfo> GetDirectoryForTypeNamesContaining(string expr)
        {
            var x = new Dictionary<GrainId, IGrainInfo>();
            LocalGrainDirectory localGrainDirectory = this.host.Services.GetRequiredService<LocalGrainDirectory>();
            var catalog = this.host.Services.GetRequiredService<Catalog>();
            foreach (var kvp in localGrainDirectory.DirectoryPartition.GetItems())
            {
                if (kvp.Key.IsSystemTarget || kvp.Key.IsClient || !kvp.Key.IsGrain)
                    continue;// Skip system grains, system targets and clients
                if (catalog.GetGrainTypeName(kvp.Key).Contains(expr))
                    x.Add(kvp.Key, kvp.Value);
            }
            return x;
        }
        
        // store silos for which we simulate faulty communication
        // number indicates how many percent of requests are lost
        private ConcurrentDictionary<IPEndPoint, double> simulatedMessageLoss;
        private readonly SafeRandom random = new SafeRandom();

        internal void BlockSiloCommunication(IPEndPoint destination, double lossPercentage)
        {
            if (simulatedMessageLoss == null)
                simulatedMessageLoss = new ConcurrentDictionary<IPEndPoint, double>();

            simulatedMessageLoss[destination] = lossPercentage;

            var mc = this.host.Services.GetRequiredService<MessageCenter>();
            mc.ShouldDrop = ShouldDrop;
        }

        internal void UnblockSiloCommunication()
        {
            var mc = this.host.Services.GetRequiredService<MessageCenter>();
            mc.ShouldDrop = null;
            simulatedMessageLoss.Clear();
        }

        internal Func<ILogConsistencyProtocolMessage,bool> ProtocolMessageFilterForTesting
        {
            get
            {
                var mco = this.host.Services.GetRequiredService<MultiClusterOracle>();
                return mco.ProtocolMessageFilterForTesting;
            }
            set
            {
                var mco = this.host.Services.GetRequiredService<MultiClusterOracle>();
                mco.ProtocolMessageFilterForTesting = value;
            }
        }

        private bool ShouldDrop(Message msg)
        {
            if (simulatedMessageLoss != null)
            {
                double blockedpercentage;
                simulatedMessageLoss.TryGetValue(msg.TargetSilo.Endpoint, out blockedpercentage);
                return (random.NextDouble() * 100 < blockedpercentage);
            }
            else
                return false;
        }
    }
}
