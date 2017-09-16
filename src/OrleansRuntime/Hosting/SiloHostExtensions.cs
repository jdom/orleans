using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Orleans.Hosting;
using Orleans.Runtime.Configuration;

namespace Orleans.Runtime.Hosting
{
    public static class SiloHostExtensions
    {
        //public static IHostBuilder ConfigureSiloHost(this IHostBuilder builder, Action<HostBuilderContext, ISiloBuilder2> configureApp)
        public static IHostBuilder ConfigureSiloHost(this IHostBuilder builder)
        {
            return builder.ConfigureServices((bulderContext, services) =>
            {
                // Configure the container, including the default silo name & services.

                //services.Configure<SiloHostServiceOptions>(options =>
                //{
                //    options.ConfigureApp = configureApp;
                //    options.SiloName = options.SiloName ?? $"Silo_{Guid.NewGuid().ToString("N").Substring(0, 5)}";
                //});

                services.Configure<SiloIdentityOptions>(options =>
                {
                    options.SiloName = options.SiloName ?? $"Silo_{Guid.NewGuid().ToString("N").Substring(0, 5)}";
                });
                services.AddSingleton<IHostedService, SiloHostService>();
                services.AddTransient<IServiceProviderFactory<IServiceCollection>, DefaultServiceProviderFactory>();

                services.TryAddSingleton<SiloInitializationParameters>();
                DefaultSiloServices.AddDefaultServices(services);
            });
        }

        public static IHostBuilder ConfigureSiloHost(this IHostBuilder builder, ClusterConfiguration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            return builder
                .ConfigureServices((bulderContext, services) => services.TryAddSingleton(configuration))
                .ConfigureSiloHost();
        }
    }

    public class SiloHostServiceOptions
    {
        /// <summary>Gets or sets the silo name.</summary>
        public string SiloName { get; set; }

        public Action<HostBuilderContext, ISiloBuilder2> ConfigureApp { get; internal set; }
    }

    public interface ISiloBuilder2
    {
    }
}
