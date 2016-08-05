#if NETSTANDARD
using System.Threading.Tasks;
using Orleans.Providers;
using Orleans.Runtime.Configuration;

namespace Orleans.Runtime
{
    internal class ClientStatisticsManager
    {
        internal Task Start(ClientConfiguration config, StatisticsProviderManager statsManager, IMessageCenter transport, GrainId clientId)
        {
            return TaskDone.Done;
        }

        internal void Stop()
        {
        }
    }
}
#endif