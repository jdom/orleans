using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Orleans.Hosting
{
    /// <summary>
    /// Extensions for <see cref="IHostBuilder"/> instances. These are generic extensions that will not be needed when we migrate to Microsoft.Extensions.Hosting when it's released.
    /// </summary>
    public static class HostBuilderExtensions
    {
        /// <summary>
        /// Adds services to the container. This can be called multiple times and the results will be additive.
        /// </summary>
        /// <param name="hostBuilder">The <see cref="IHostBuilder" /> to configure.</param>
        /// <param name="configureDelegate"></param>
        /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
        public static IHostBuilder ConfigureServices(this IHostBuilder hostBuilder, Action<IServiceCollection> configureDelegate)
        {
            return hostBuilder.ConfigureServices((context, collection) => configureDelegate(collection));
        }

        /// <summary>
        /// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
        /// the results will be additive. The results will be available at <see cref="HostBuilderContext.Configuration"/> for
        /// subsequent operations, as well as in <see cref="IHost.Services"/>.
        /// </summary>
        /// <param name="hostBuilder">The <see cref="IHostBuilder" /> to configure.</param>
        /// <param name="configureDelegate"></param>
        /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
        public static IHostBuilder ConfigureAppConfiguration(this IHostBuilder hostBuilder, Action<IConfigurationBuilder> configureDelegate)
        {
            return hostBuilder.ConfigureAppConfiguration((context, builder) => configureDelegate(builder));
        }

        /// <summary>
        /// Registers an action used to configure a particular type of options.
        /// </summary>
        /// <typeparam name="TOptions">The options type to be configured.</typeparam>
        /// <param name="builder">The host builder.</param>
        /// <param name="configureOptions">The action used to configure the options.</param>
        /// <returns>The silo builder.</returns>
        public static IHostBuilder Configure<TOptions>(this IHostBuilder builder, Action<TOptions> configureOptions) where TOptions : class
        {
            return builder.ConfigureServices(services => services.Configure(configureOptions));
        }

        /// <summary>
        /// Specifies how the <see cref="IServiceProvider"/> for this silo is configured. 
        /// </summary>
        /// <param name="builder">The host builder.</param>
        /// <param name="factory">The service provider configuration method.</param>
        /// <returns>The silo builder.</returns>
        public static IHostBuilder UseServiceProviderFactory<TContainerBuilder>(IHostBuilder builder, IServiceProviderFactory<TContainerBuilder> factory)
        {
            return builder.UseServiceProviderFactory(services => factory.CreateServiceProvider(factory.CreateBuilder(services)));
        }

        /// <summary>
        /// Specifies how the <see cref="IServiceProvider"/> for this silo is configured. 
        /// </summary>
        /// <param name="builder">The host builder.</param>
        /// <param name="configureServiceProvider">The service provider configuration method.</param>
        /// <returns>The silo builder.</returns>
        public static IHostBuilder UseServiceProviderFactory(this IHostBuilder builder, Func<IServiceCollection, IServiceProvider> configureServiceProvider)
        {
            if (configureServiceProvider == null) throw new ArgumentNullException(nameof(configureServiceProvider));
            return builder.UseServiceProviderFactory(new DelegateServiceProviderFactory(configureServiceProvider));
        }
    }
}