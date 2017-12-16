using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Orleans.ApplicationParts;
using Orleans.Hosting;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using Orleans.Serialization;
using System;
using System.Collections.Generic;
using Orleans.Configuration;

namespace Orleans.TestingHost
{
    public class LegacyTestClusterBuilder : TestClusterBuilder
    {
        private const string ClusterConfigurationKey = nameof(ClusterConfiguration);
        private const string ClientConfigurationKey = nameof(ClientConfiguration);

        public LegacyTestClusterBuilder()
            : this(2)
        {
        }

        public LegacyTestClusterBuilder(short initialSilosCount)
            : base(initialSilosCount)
        {
            base.ConfigureHostConfiguration(ConfigureLegacyConfiguration);
            base.AddSiloBuilderConfigurator<LegacySiloBuilderConfigurator>();
            base.AddClientBuilderConfigurator<LegacyClientBuilderConfigurator>();
        }

        /// <summary>Gets or sets the cluster configuration.</summary>
        public ClusterConfiguration ClusterConfiguration
        {
            get => (ClusterConfiguration)(this.Properties.TryGetValue(ClusterConfigurationKey, out var config) 
                ? config
                : (this.Properties[ClusterConfigurationKey] = BuildClusterConfiguration()));
            set => this.Properties[ClusterConfigurationKey] = value;
        }

        /// <summary>Gets or sets the client configuration.</summary>
        public ClientConfiguration ClientConfiguration
        {
            get => (ClientConfiguration)(this.Properties.TryGetValue(ClientConfigurationKey, out var config)
                ? config
                : (this.Properties[ClientConfigurationKey] = BuildClientConfiguration(this.ClusterConfiguration)));
            set => this.Properties[ClientConfigurationKey] = value;
        }

        /// <summary>Build a cluster configuration.</summary>
        /// <returns>The builded cluster configuration</returns>
        public ClusterConfiguration BuildClusterConfiguration()
        {
            var config = new ClusterConfiguration
            {
                Globals =
                {
                    ReminderServiceType = GlobalConfiguration.ReminderServiceProviderType.ReminderTableGrain
                }
            };

            config.Globals.ClusterId = base.ClusterId;

            

            config.Globals.ExpectedClusterSize = base.InitialSilosCount;
            config.Globals.AssumeHomogenousSilosForTesting = true;

            // config.AdjustForTestEnvironment(extendedOptions.DataConnectionString);
            return config;
        }

        /// <summary>
        /// Build the client configuration based on the cluster configuration.
        /// </summary>
        /// <param name="clusterConfig">The reference cluster configuration.</param>
        /// <returns>THe builded client configuration</returns>
        public static ClientConfiguration BuildClientConfiguration(ClusterConfiguration clusterConfig)
        {
            var config = new ClientConfiguration();

            config.DataConnectionString = clusterConfig.Globals.DataConnectionString;
            config.AdoInvariant = clusterConfig.Globals.AdoInvariant;
            config.ClusterId = clusterConfig.Globals.ClusterId;
            config.PropagateActivityId = clusterConfig.Defaults.PropagateActivityId;

            //config.AdjustForTestEnvironment(clusterConfig.Globals.DataConnectionString);
            return config;
        }

        private void ConfigureLegacyConfiguration(IConfigurationBuilder builder)
        {
            SerializationManager serializationManager = CreateLegacyConfigurationSerializer();

            var configSource = new Dictionary<string, string>();
            if (this.Properties.TryGetValue(ClusterConfigurationKey, out object clusterConfig))
            {
                configSource[ClusterConfigurationKey] = Serialize(serializationManager, clusterConfig);
            }

            if (this.Properties.TryGetValue(ClientConfigurationKey, out object clientConfig))
            {
                configSource[ClientConfigurationKey] = Serialize(serializationManager, clientConfig);
            }

            builder.AddInMemoryCollection(configSource);
        }

        private static SerializationManager CreateLegacyConfigurationSerializer()
        {
            // TODO: can probably be simplified
            var applicationPartManager = new ApplicationPartManager();
            applicationPartManager.AddFeatureProvider(new BuiltInTypesSerializationFeaturePopulator());
            applicationPartManager.AddFeatureProvider(new AssemblyAttributeFeatureProvider<SerializerFeature>());
            applicationPartManager.AddApplicationPart(typeof(ClusterConfiguration).Assembly).WithReferences();
            var serializationManager = new SerializationManager(null, Options.Create(new SerializationProviderOptions()), new NullLoggerFactory(), new CachedTypeResolver());
            serializationManager.RegisterSerializers(applicationPartManager);
            return serializationManager;
        }

        private static string Serialize(SerializationManager serializationManager, object config)
        {
            BufferPool.InitGlobalBufferPool(Options.Create(new MessagingOptions()));
            var writer = new BinaryTokenStreamWriter();
            serializationManager.Serialize(config, writer);
            string serialized = Convert.ToBase64String(writer.ToByteArray());
            writer.ReleaseBuffers();
            return serialized;
        }

        private static T Deserialize<T>(SerializationManager serializationManager, string config)
        {
            var data = Convert.FromBase64String(config);
            var reader = new BinaryTokenStreamReader(data);
            return serializationManager.Deserialize<T>(reader);
        }

        internal class LegacySiloBuilderConfigurator : ISiloBuilderConfigurator
        {
            public void Configure(ISiloHostBuilder hostBuilder)
            {
                SerializationManager serializationManager = CreateLegacyConfigurationSerializer();
                hostBuilder.ConfigureServices((context, services) =>
                {
                    var serializedConfiguration = context.Configuration[ClusterConfigurationKey];
                    if (string.IsNullOrWhiteSpace(serializedConfiguration))
                    {
                        throw new InvalidOperationException(
                            "There is no ClusterConfiguration, which is unexpected for the current set up.");
                    }
                    var clusterConfiguration =
                        Deserialize<ClusterConfiguration>(serializationManager, serializedConfiguration);
                    services.AddLegacyClusterConfigurationSupport(clusterConfiguration);
                });
            }
        }


        internal class LegacyClientBuilderConfigurator : IClientBuilderConfigurator
        {
            public void Configure(IConfiguration configuration, IClientBuilder clientBuilder)
            {
                SerializationManager serializationManager = CreateLegacyConfigurationSerializer();
                clientBuilder.ConfigureServices(services =>
                {
                    var serializedConfiguration = configuration[ClientConfigurationKey];
                    if (!string.IsNullOrWhiteSpace(serializedConfiguration))
                    {
                        var clientConfiguration =
                            Deserialize<ClientConfiguration>(serializationManager, serializedConfiguration);
                        services.AddLegacyClientConfigurationSupport(clientConfiguration);
                    }
                });
            }
        }
    }
}
