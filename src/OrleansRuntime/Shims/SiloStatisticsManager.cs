#if NETSTANDARD1_6
using System;
using System.Threading.Tasks;

using Orleans.Runtime.Configuration;

namespace Orleans.Runtime.Counters
{
    internal class SiloStatisticsManager
    {
        internal SiloStatisticsManager(GlobalConfiguration globalConfig, NodeConfiguration nodeConfig)
        {
        }

        public ISiloPerformanceMetrics MetricsTable { get { return null; } }

        internal Task SetSiloMetricsTableDataManager(Silo silo, NodeConfiguration nodeConfig)
        {
            return TaskDone.Done;
        }

        internal Task SetSiloStatsTableDataManager(Silo silo, NodeConfiguration nodeConfig)
        {
            return TaskDone.Done;
        }

        internal void Start(NodeConfiguration config)
        {
        }

        internal void Stop()
        {
        }
    }
}

#endif