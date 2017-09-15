using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Orleans.Runtime.Hosting
{
    public class SiloHostService : IHostedService
    {
        private readonly Silo silo;

        public SiloHostService(Silo silo)
        {
            this.silo = silo;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                this.silo.Start();
            }

            // Await to avoid compiler warnings.
            await Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                this.silo.Stop();
            }
            else
            {
                this.silo.Shutdown();
            }

            await Task.CompletedTask;
        }
    }
}
