using Microsoft.Extensions.DependencyInjection;
using Orleans.Configuration;
using Orleans.Hosting;
using Orleans.Runtime;
using Orleans.Storage;
using System;
using System.Linq;

namespace Orleans.Hosting
{
    public static class AzureStorageHostingExtensions
    {
        public static ISiloHostBuilder AddAzureTableStorage(this ISiloHostBuilder hostBuilder, string name, Action<AzureTableStorageOptions> configureOptions)
        {
            return hostBuilder.ConfigureServices(services => services.AddAzureTableStorage(name, configureOptions));
        }

        public static ISiloHostBuilder AddAzureTableStorage(this ISiloHostBuilder hostBuilder, string name, Action<OptionsBuilder<AzureTableStorageOptions>> configureOptions = null)
        {
            return hostBuilder.ConfigureServices(services => services.AddAzureTableStorage(name, configureOptions));
        }

        public static IServiceCollection AddAzureTableStorage(this IServiceCollection services, string name, Action<AzureTableStorageOptions> configureOptions)
        {
            return services.AddAzureTableStorage(name, ob => ob.Configure(configureOptions));
        }

        public static IServiceCollection AddAzureTableStorage(this IServiceCollection services, string name, Action<OptionsBuilder<AzureTableStorageOptions>> configureOptions = null)
        {
            configureOptions?.Invoke(services.AddOptions<AzureTableStorageOptions>(name));
            services.TryAddKeyedServiceCollection();

            services.AddNamedSiloLifecycleParticipant(name, AzureTableGrainStorageFactory.Create);
            return services;
        }

        // TODO: can be simplified
        private static void TryAddKeyedServiceCollection(this IServiceCollection services)
        {
            if (!services.Any(s => s.ServiceType == typeof(KeyedSiloLifecycleParticipantCollection<string, IGrainStorage>)))
            {
                services.AddSingleton<KeyedSiloLifecycleParticipantCollection<string, IGrainStorage>>();
                services.AddFromExisting<ILifecycleParticipant<ISiloLifecycle>, KeyedSiloLifecycleParticipantCollection<string, IGrainStorage>>();
            }
        }
    }
}
