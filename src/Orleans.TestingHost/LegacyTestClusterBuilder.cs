using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Orleans.ApplicationParts;
using Orleans.Configuration;
using Orleans.Hosting;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using Orleans.Serialization;
using System;
using System.Collections.Generic;

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

            // TODO: add multiple silo builder configurators, so that we can deserialize it on the other side
        }

        /// <summary>Gets or sets the cluster configuration.</summary>
        public ClusterConfiguration ClusterConfiguration
        {
            get => (ClusterConfiguration)this.Properties[ClusterConfigurationKey];
            set => this.Properties[ClusterConfigurationKey] = value;
        }

        /// <summary>Gets or sets the client configuration.</summary>
        public ClientConfiguration ClientConfiguration
        {
            get => (ClientConfiguration)this.Properties[ClientConfigurationKey];
            set => this.Properties[ClientConfigurationKey] = value;
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
        }

        private static SerializationManager CreateLegacyConfigurationSerializer()
        {
            // TODO: can probably be simplified
            var applicationPartManager = new ApplicationPartManager();
            applicationPartManager.AddFeatureProvider(new BuiltInTypesSerializationFeaturePopulator());
            applicationPartManager.AddFeatureProvider(new AssemblyAttributeFeatureProvider<SerializerFeature>());
            applicationPartManager.AddApplicationPartsFromReferences(typeof(ClusterConfiguration).Assembly);
            var serializationManager = new SerializationManager(null, Options.Create(new SerializationProviderOptions()), new NullLoggerFactory(), new CachedTypeResolver());
            serializationManager.RegisterSerializers(applicationPartManager);
            return serializationManager;
        }

        private static string Serialize(SerializationManager serializationManager, object config)
        {
            var writer = new BinaryTokenStreamWriter();
            serializationManager.Serialize(config, writer);
            string serialized = Convert.ToBase64String(writer.ToByteArray());
            writer.ReleaseBuffers();
            return serialized;
        }
    }
}
