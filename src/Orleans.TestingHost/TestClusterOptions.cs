using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Orleans.Runtime.Configuration;
using Orleans.TestingHost.Utils;

namespace Orleans.TestingHost
{
    public class TestClusterOptions2
    {
        public string ClusterId { get; set; }
        public int BaseSiloPort{ get; set; }
        public int BaseGatewayPort { get; set; }
        public bool UseTestClusterMemebership { get; set; }
        public short InitialSilosCount { get; set; }
        public string SerializedHostConfiguration { get; set; }
    }

    /// <summary>Configuration builder for starting a <see cref="TestCluster"/>.</summary>
    public class TestClusterBuilder
    {
        private List<Action<IConfigurationBuilder>> configureHostConfigActions = new List<Action<IConfigurationBuilder>>();

        /// <summary>
        /// Initializes a new instance of <see cref="TestClusterBuilder"/> using the default options.
        /// </summary>
        public TestClusterBuilder()
            : this(2)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="TestClusterBuilder"/> overriding the initial silos count.
        /// </summary>
        /// <param name="initialSilosCount">The number of initial silos to deploy.</param>
        public TestClusterBuilder(short initialSilosCount)
        {
            this.InitialSilosCount = initialSilosCount;
            this.ClusterId = CreateClusterId();
            this.UseTestClusterMemebership = true;
            this.SiloBuilderConfiguratorType = typeof(DefaultSiloBuilderConfigurator);
        }

        public Dictionary<string, object> Properties { get; } = new Dictionary<string, object>();

        public string ClusterId
        {
            get => (string)this.Properties["ClusterId"];
            set => this.Properties["ClusterId"] = value;
        }

        public bool UseTestClusterMemebership
        {
            get => (bool)this.Properties["UseTestClusterMemebership"];
            set => this.Properties["UseTestClusterMemebership"] = value;
        }

        public short InitialSilosCount
        {
            get => (short)this.Properties["InitialSilosCount"];
            set => this.Properties["InitialSilosCount"] = value;
        }

        ///// <summary>Gets or sets the cluster configuration.</summary>
        //public ClusterConfiguration ClusterConfiguration { get; set; }

        ///// <summary>Gets or sets the client configuration.</summary>
        //public ClientConfiguration ClientConfiguration { get; set; }

        /// <summary>
        /// Set up the configuration for the builder itself. This will be used as a base to initialize each silo host
        /// for use later in the build process. This can be called multiple times and the results will be additive.
        /// </summary>
        /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
        /// to construct the <see cref="IConfiguration"/> for the host.</param>
        /// <returns>The same instance of the host builder for chaining.</returns>
        public TestClusterBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate)
        {
            this.configureHostConfigActions.Add(configureDelegate ?? throw new ArgumentNullException(nameof(configureDelegate)));
            return this;
        }

        internal Type SiloBuilderConfiguratorType { get; private set; }

        public void UseSiloBuilderConfigurator<TSiloBuilderConfigurator>() where TSiloBuilderConfigurator : ISiloBuilderConfigurator, new()
        {
            this.SiloBuilderConfiguratorType = typeof(TSiloBuilderConfigurator);
        }

        /// <summary>
        /// Default client builder factory
        /// </summary>
        public static Func<ClientConfiguration, IClientBuilder> DefaultClientBuilderFactory = config =>
            ClientBuilder.CreateDefault()
                .UseConfiguration(config)
                .AddApplicationPartsFromAppDomain()
                .AddApplicationPartsFromBasePath()
                .ConfigureLogging(builder => TestingUtils.ConfigureDefaultLoggingBuilder(builder,
                    TestingUtils.CreateTraceFileName(config.ClientName, config.DeploymentId)));

        /// <summary>
        /// Factory delegate to create a client builder which will be used to build the <see cref="TestCluster"/> client. 
        /// </summary>
        public Func<ClientConfiguration, IClientBuilder> ClientBuilderFactory { get; set; } = DefaultClientBuilderFactory;

        public TestCluster2 Build()
        {
            var configBuilder = new ConfigurationBuilder();
            (int baseSiloPort, int baseGatewayPort) = GetAvailableConsecutiveServerPortsPair(this.InitialSilosCount + 3);

            configBuilder.Properties["BaseSiloPort"] = baseSiloPort;
            configBuilder.Properties["BaseGatewayPort"] = baseGatewayPort;
            configBuilder.Properties["ClusterId"] = this.ClusterId;

            var defaultConfigurationSource = new Dictionary<string, string>
            {
                ["ClusterId"] = this.ClusterId,
                ["BaseSiloPort"] = baseSiloPort.ToString(),
                ["BaseGatewayPort"] = baseGatewayPort.ToString(),
                ["AssumeHomogenousSilosForTesting"] = true.ToString(),
                ["SiloBuilderConfiguratorType"] = this.SiloBuilderConfiguratorType.AssemblyQualifiedName,
            };

            configBuilder.AddInMemoryCollection(defaultConfigurationSource);

            foreach (var buildAction in this.configureHostConfigActions)
            {
                buildAction(configBuilder);
            }

            var serializedConfigurationSources = SerializeConfigurationSources(configBuilder);

            var configuration = configBuilder.Build();
            var options = new TestClusterOptions2();
            configuration.Bind(options);
            options.SerializedHostConfiguration = serializedConfigurationSources;
            var testCluster = new TestCluster2(options);
            return testCluster;
        }

        private static string SerializeConfigurationSources(IConfigurationBuilder builder)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
            };

            return JsonConvert.SerializeObject(builder.Sources, settings);
        }

        internal static IList<IConfigurationSource> DeserializeConfigurationSources(string serializedSources)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
            };

            return JsonConvert.DeserializeObject<IList<IConfigurationSource>>(serializedSources, settings);
        }

        private static string CreateClusterId()
        {
            string prefix = "testcluster-";
            int randomSuffix = ThreadSafeRandom.Next(1000);
            DateTime now = DateTime.UtcNow;
            string DateTimeFormat = @"yyyy-MM-dd\tHH-mm-ss";
            return $"{prefix}{now.ToString(DateTimeFormat, CultureInfo.InvariantCulture)}-{randomSuffix}";
        }

        /// <summary>Returns a 2 pairs of ports which have the specified number of consecutive ports available for use.</summary>
        /// <param name="consecutivePortsToCheck">Each returned port in the pair will have to have at least this amount of available ports following it</param>
        private static ValueTuple<int, int> GetAvailableConsecutiveServerPortsPair(int consecutivePortsToCheck = 5)
        {
            // Evaluate current system tcp connections
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpListeners();

            // each returned port in the pair will have to have at least this amount of available ports following it

            return (GetAvailableConsecutiveServerPorts(tcpConnInfoArray, 22300, 30000, consecutivePortsToCheck),
                    GetAvailableConsecutiveServerPorts(tcpConnInfoArray, 40000, 50000, consecutivePortsToCheck));
        }

        private static int GetAvailableConsecutiveServerPorts(IPEndPoint[] tcpConnInfoArray, int portStartRange, int portEndRange, int consecutivePortsToCheck)
        {
            const int MaxAttempts = 10;

            for (int attempts = 0; attempts < MaxAttempts; attempts++)
            {
                int basePort = ThreadSafeRandom.Next(portStartRange, portEndRange);

                // get ports in buckets, so we don't interfere with parallel runs of this same function
                basePort = basePort - (basePort % consecutivePortsToCheck);
                int endPort = basePort + consecutivePortsToCheck;
                
                // make sure non of the ports in the sub range are in use
                if (tcpConnInfoArray.All(endpoint => endpoint.Port < basePort || endpoint.Port >= endPort))
                    return basePort;
            }

            throw new InvalidOperationException("Cannot find enough free ports to spin up a cluster");
        }
    }
}
