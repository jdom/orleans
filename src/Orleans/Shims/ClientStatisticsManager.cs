﻿#if NETSTANDARD1_6
using System.Threading.Tasks;
using Orleans.Providers;
using Orleans.Runtime.Configuration;

namespace Orleans.Runtime
{
    internal class ClientStatisticsManager
    {
        public ClientStatisticsManager(IStatisticsConfiguration configuration)
        {
        }

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