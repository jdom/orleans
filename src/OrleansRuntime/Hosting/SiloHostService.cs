using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Orleans.Runtime.Hosting
{
    internal class SiloHostService : IHostedService
    {
        private Silo silo;

        public SiloHostService(IOptions<SiloHostServiceOptions> options, IServiceProvider services, HostBuilderContext hostBuilderContext, ILogger<SiloHostService> logger)
        {
            this.Options = options?.Value ?? throw new System.ArgumentNullException(nameof(options));

            //if (this.Options.ConfigureApp == null)
            //{
            //    throw new ArgumentException(nameof(this.Options.ConfigureApp));
            //}

            this.Services = services ?? throw new ArgumentNullException(nameof(services));
            this.HostBuilderContext = hostBuilderContext ?? throw new ArgumentNullException(nameof(hostBuilderContext));
            this.Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public SiloHostServiceOptions Options { get; }
        public IServiceProvider Services { get; }
        public HostBuilderContext HostBuilderContext { get; }
        public ILogger Logger { get; }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                this.silo = new Silo(this.Services.GetRequiredService<SiloInitializationParameters>(), this.Services);
                this.silo.Start();
            }

            // Await to avoid compiler warnings.
            await Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                this.silo?.Stop();
            }
            else
            {
                this.silo?.Shutdown();
            }

            await Task.CompletedTask;
        }
    }
}
