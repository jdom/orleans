using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Orleans.Runtime;

namespace Orleans.Hosting
{
    /// <summary>
    /// Functionality for building <see cref="IHost"/> instances. This will be replaced by Microsoft.Extensions.Hosting.HostBuilder when it's released.
    /// </summary>
    public class HostBuilder : IHostBuilder
    {
        private readonly ServiceProviderBuilder serviceProviderBuilder = new ServiceProviderBuilder();

        private bool built;
        private HostBuilderContext hostBuilderContext;
        private List<Action<HostBuilderContext, IConfigurationBuilder>> configureAppConfigActions = new List<Action<HostBuilderContext, IConfigurationBuilder>>();
        private IConfiguration appConfiguration;

        /// <inheritdoc />
        public IDictionary<object, object> Properties { get; } = new Dictionary<object, object>();

        /// <inheritdoc />
        public IHost Build()
        {
            if (this.built)
                throw new InvalidOperationException($"{nameof(this.Build)} may only be called once per {nameof(HostBuilder)} instance.");
            this.built = true;
            
            // Configure the container, including the default silo name & services.
            this.Configure<SiloIdentityOptions>(
                options => options.SiloName = options.SiloName ?? $"Silo_{Guid.NewGuid().ToString("N").Substring(0, 5)}");
            this.serviceProviderBuilder.ConfigureServices(
                (context, services) =>
                {
                    services.TryAddSingleton<SiloInitializationParameters>();
                    services.TryAddSingleton<Silo>(sp => new Silo(sp.GetRequiredService<SiloInitializationParameters>(), sp));
                });
            this.serviceProviderBuilder.ConfigureServices(DefaultSiloServices.AddDefaultServices);

            this.CreateHostBuilderContext();
            this.BuildAppConfiguration();
            var serviceProvider = this.serviceProviderBuilder.BuildServiceProvider(this.hostBuilderContext);
            
            // Construct and return the silo.
            return serviceProvider.GetRequiredService<IHost>();
        }

        /// <inheritdoc />
        public IHostBuilder ConfigureAppConfiguration(Action<HostBuilderContext, IConfigurationBuilder> configureDelegate)
        {
            this.configureAppConfigActions.Add(configureDelegate ?? throw new ArgumentNullException(nameof(configureDelegate)));
            return this;
        }


        /// <inheritdoc />
        public IHostBuilder ConfigureServices(Action<HostBuilderContext, IServiceCollection> configureDelegate)
        {
            if (configureDelegate == null) throw new ArgumentNullException(nameof(configureDelegate));
            this.serviceProviderBuilder.ConfigureServices(configureDelegate);
            return this;
        }

        /// <inheritdoc />
        public IHostBuilder UseServiceProviderFactory<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> factory)
        {
            this.serviceProviderBuilder.UseServiceProviderFactory(factory);
            return this;
        }

        /// <inheritdoc />
        public IHostBuilder ConfigureContainer<TContainerBuilder>(Action<HostBuilderContext, TContainerBuilder> configureDelegate)
        {
            this.serviceProviderBuilder.ConfigureContainer(configureDelegate);
            return this;
        }

        private void CreateHostBuilderContext()
        {
            this.hostBuilderContext = new HostBuilderContext(this.Properties)
            {
                Configuration = null
            };
        }


        private void BuildAppConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();
            foreach (var buildAction in this.configureAppConfigActions)
            {
                buildAction(this.hostBuilderContext, configBuilder);
            }
            this.appConfiguration = configBuilder.Build();
            this.hostBuilderContext.Configuration = this.appConfiguration;
        }
    }
}
