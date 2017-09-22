using System;
using Microsoft.Extensions.DependencyInjection;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;

namespace Orleans.Hosting
{
    /// <summary>
    /// Extensions for <see cref="ISiloBuilder"/> to configure Orleans in the host builder.
    /// </summary>
    public static class SiloBuilderExtensions
    {
        public static IHostBuilder ConfigureSiloHost(this IHostBuilder hostBuilder, Action<ISiloBuilder> configureDelegate)
        {
            var siloBuilder = new SiloBuilder(hostBuilder);
            configureDelegate(siloBuilder);
            return hostBuilder;
        }

        /// <summary>
        /// Configures the name of this silo.
        /// </summary>
        /// <param name="builder">The silo builder.</param>
        /// <param name="siloName">The silo name.</param>
        /// <returns>The silo builder.</returns>
        public static ISiloBuilder ConfigureSiloName(this ISiloBuilder builder, string siloName)
        {
            builder.HostBuilder.Configure<SiloIdentityOptions>(options => options.SiloName = siloName);
            return builder;
        }

        /// <summary>
        /// Specifies the configuration to use for this silo.
        /// </summary>
        /// <param name="builder">The silo builder.</param>
        /// <param name="configuration">The configuration.</param>
        /// <remarks>This method may only be called once per builder instance.</remarks>
        /// <returns>The silo builder.</returns>
        public static ISiloBuilder UseConfiguration(this ISiloBuilder builder, ClusterConfiguration configuration)
        {
            builder.HostBuilder.ConfigureServices(services => services.AddSingleton(configuration));
            return builder;
        }

        /// <summary>
        /// Loads <see cref="ClusterConfiguration"/> using <see cref="ClusterConfiguration.StandardLoad"/>.
        /// </summary>
        /// <param name="builder">The silo builder.</param>
        /// <returns>The silo builder.</returns>
        public static ISiloBuilder LoadClusterConfiguration(this ISiloBuilder builder)
        {
            var configuration = new ClusterConfiguration();
            configuration.StandardLoad();
            return builder.UseConfiguration(configuration);
        }
        
        /// <summary>
        /// Configures a localhost silo.
        /// </summary>
        /// <param name="builder">The silo builder.</param>
        /// <param name="siloPort">The silo-to-silo communication port.</param>
        /// <param name="gatewayPort">The client-to-silo communication port.</param>
        /// <returns>The silo builder.</returns>
        public static ISiloBuilder ConfigureLocalHostPrimarySilo(this ISiloBuilder builder, int siloPort = 22222, int gatewayPort = 40000)
        {
            return builder
                .ConfigureSiloName(Silo.PrimarySiloName)
                .UseConfiguration(ClusterConfiguration.LocalhostPrimarySilo(siloPort, gatewayPort));
        }
    }
}