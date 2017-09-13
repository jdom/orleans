using System;
using System.Collections.Generic;
using Orleans.Runtime;

namespace Orleans.TestingHost.Utils
{
    /// <summary>
    /// Test metrics writer that does nothing with the metrics.
    /// </summary>
    public class NullTelemetryClient : ITelemetryClient
    {
        void ITelemetryClient.DecrementMetric(string name)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.DecrementMetric(string name, double value)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.IncrementMetric(string name)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.IncrementMetric(string name, double value)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackDependency(string name, string commandName, DateTimeOffset startTime, TimeSpan duration, bool success)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackEvent(string name, IDictionary<string, string> properties, IDictionary<string, double> metrics)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackException(Exception exception, IDictionary<string, string> properties, IDictionary<string, double> metrics)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackMetric(string name, double value, IDictionary<string, string> properties)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackMetric(string name, TimeSpan value, IDictionary<string, string> properties)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackRequest(string name, DateTimeOffset startTime, TimeSpan duration, string responseCode, bool success)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackTrace(string message)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackTrace(string message, Severity severityLevel)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackTrace(string message, Severity severityLevel, IDictionary<string, string> properties)
        {
            throw new NotImplementedException();
        }

        void ITelemetryClient.TrackTrace(string message, IDictionary<string, string> properties)
        {
            throw new NotImplementedException();
        }
    }
}
