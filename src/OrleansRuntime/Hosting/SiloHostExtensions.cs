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
        public static IHostBuilder ConfigureSiloHost(this IHostBuilder builder, ClusterConfiguration configuration)
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

                if (configuration != null)
                {
                    services.TryAddSingleton(configuration);
                }

                services.AddTransient<IServiceProviderFactory<IServiceCollection>, DefaultServiceProviderFactory>();

                services.TryAddSingleton<SiloInitializationParameters>();
                services.TryAddSingleton<Silo>(sp => new Silo(sp.GetRequiredService<SiloInitializationParameters>(), sp));
                DefaultSiloServices.AddDefaultServices(services);
            });
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
