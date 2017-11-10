using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Memory;
using Newtonsoft.Json.Linq;
using Orleans.Runtime.Configuration;
using Orleans.TestingHost.Utils;

namespace Orleans.TestingHost
{
    /// <summary>Configuration builder for starting a <see cref="TestCluster"/>.</summary>
    public class TestClusterBuilder
    {
        private List<Action<IConfigurationBuilder>> configureHostConfigActions = new List<Action<IConfigurationBuilder>>();
        private Dictionary<string, string> defaultConfigurationSource;

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
            (int baseSiloPort, int baseGatewayPort) = GetAvailableConsecutiveServerPortsPair();

            this.defaultConfigurationSource =
                new Dictionary<string, string>
                {
                    ["BaseSiloPort"] = baseSiloPort.ToString(),
                    ["BaseGatewayPort"] = baseGatewayPort.ToString(),
                    ["AssumeHomogenousSilosForTesting"] = true.ToString(),
                };

            this.InitialSilosCount = initialSilosCount;
            this.ClusterId = CreateClusterId(baseSiloPort);
            this.UseDefaultTestMemebership = true;

            this.ConfigureHostConfiguration(builder => builder.AddInMemoryCollection(this.defaultConfigurationSource));
            this.SiloBuilderConfiguratorType = typeof(DefaultSiloBuilderConfigurator);
        }

                public string ClusterId
        {
            get => this.defaultConfigurationSource["ClusterId"];
            set => this.defaultConfigurationSource["ClusterId"] = value;
        }

        public bool UseDefaultTestMemebership
        {
            get => this.defaultConfigurationSource.TryGetValue("UseDefaultTestMemebership", out string strValue) && bool.TryParse(strValue, out var retValue) ? retValue : true;
            set => this.defaultConfigurationSource["UseDefaultTestMemebership"] = value.ToString(CultureInfo.InvariantCulture);
        }

        public short InitialSilosCount
        {
            get => this.defaultConfigurationSource.TryGetValue("InitialSilosCount", out string strValue) && short.TryParse(strValue, out var retValue) ? retValue : (short)1;
            set => this.defaultConfigurationSource["InitialSilosCount"] = value.ToString(CultureInfo.InvariantCulture);
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
            this.defaultConfigurationSource["SiloBuilderConfiguratorType"] = this.SiloBuilderConfiguratorType.AssemblyQualifiedName;

            var configBuilder = new SerializableConfigurationBuilder();
            foreach (var buildAction in this.configureHostConfigActions)
            {
                buildAction(configBuilder);
            }

        }


        private void BuildHostConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();
            foreach (var buildAction in this.configureHostConfigActions)
            {
                buildAction(configBuilder);
            }
            this.hostConfiguration = configBuilder.Build();
        }

        private static string CreateClusterId(int baseSiloPort)
        {
            string prefix = "testdepid-";
            int randomSuffix = ThreadSafeRandom.Next(1000);
            DateTime now = DateTime.UtcNow;
            string DateTimeFormat = @"yyyy-MM-dd\tHH-mm-ss";
            string depId = $"{prefix}{now.ToString(DateTimeFormat, CultureInfo.InvariantCulture)}-{baseSiloPort}-{randomSuffix}";
            return depId;
        }

        private static ValueTuple<int, int> GetAvailableConsecutiveServerPortsPair()
        {
            // Evaluate current system tcp connections
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpListeners();

            // each returned port in the pair will have to have at least this amount of available ports following it
            const int consecutivePortsToCheck = 5;

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

        private class SerializableConfigurationBuilder : IConfigurationBuilder
        {
            public IList<IConfigurationSource> Sources { get; } = (IList<IConfigurationSource>)new List<IConfigurationSource>();
            public IDictionary<string, object> Properties { get; } = (IDictionary<string, object>)new Dictionary<string, object>();
            public IConfigurationBuilder Add(IConfigurationSource source)
            {
                if (source == null)
                    throw new ArgumentNullException(nameof(source));

                // TODO: add support for file and a few others
                if (source is MemoryConfigurationSource)
                {
                    this.Sources.Add(source);
                }
                else
                {
                    // TODO: improve error message
                    throw new InvalidOperationException($"The specified {nameof(IConfigurationSource)} is not supported, as it needs to be serializable.");
                }

                return this;
            }

            public string Serialize()
            {
                var payload = new JObject();
                foreach (var configurationSource in this.Sources)
                {
                    if (configurationSource is MemoryConfigurationSource memorySource)
                    {
                        //payload.
                    }
                }


            }

            public IConfigurationRoot Build()
            {
                List<IConfigurationProvider> configurationProviderList = new List<IConfigurationProvider>();
                foreach (IConfigurationSource source in this.Sources)
                {
                    IConfigurationProvider configurationProvider = source.Build(this);
                    configurationProviderList.Add(configurationProvider);
                }
                return new ConfigurationRoot(configurationProviderList);
            }
        }
    }
}
