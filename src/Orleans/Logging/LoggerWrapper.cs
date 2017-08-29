using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orleans.Runtime
{
    //TODO: Mark it as [Obsolete] after all runtime has migrated
    internal class LoggerWrapper : Logger
    {
        public override Severity SeverityLevel => this.maxSeverityLevel;

        public override string Name => this.name;
        private string name;
        private readonly Severity maxSeverityLevel;
        private readonly ILogger logger;
        private readonly IPEndPoint ipEndpoint;
        private readonly ILoggerFactory loggerFactory;
        public LoggerWrapper(string name, ILoggerFactory loggerFactory, IPEndPoint ipEndpoint)
        {
            this.name = Name;
            this.logger = loggerFactory.CreateLogger(name);
            this.maxSeverityLevel = FindSeverityForLogger(logger);
            this.ipEndpoint = ipEndpoint;
            this.loggerFactory = loggerFactory;
        }

        public override void Log(int errorCode, Severity sev, string format, object[] args, Exception exception)
        {
            var message = FormatLogMessage(DateTime.UtcNow, sev, this.name, FormatMessageText(format, args), this.ipEndpoint, exception, errorCode, true);
            this.logger.Log<string>(SeverityToLogLevel(sev), new EventId(0), message, exception, (msg, exc) => $"{msg}. Exception:{exc}");
        }

        private static string FormatMessageText(string format, object[] args)
        {
            // avoids exceptions if format string contains braces in calls that were not
            // designed to use format strings
            return (args == null || args.Length == 0) ? format : String.Format(format, args);
        }

        private static string FormatLogMessage(
         DateTime timestamp,
         Severity severity,
         string caller,
         string message,
         IPEndPoint myIPEndPoint,
         Exception exception,
         int errorCode,
         bool includeStackTrace)
        {
            if (severity == Severity.Error)
                message = "!!!!!!!!!! " + message;

            string ip = myIPEndPoint == null ? String.Empty : myIPEndPoint.ToString();
            string exc = includeStackTrace ? LogFormatter.PrintException(exception) : LogFormatter.PrintExceptionWithoutStackTrace(exception);
            string msg = String.Format("[{0} {1,5}\t{2}\t{3}\t{4}\t{5}]\t{6}\t{7}",
                LogFormatter.PrintDate(timestamp),           //0
                Thread.CurrentThread.ManagedThreadId,   //1
                severity.ToString(),    //2
                errorCode,                              //3
                caller,                                 //4
                ip,                                     //5
                message,                                //6
                exc);      //7

            return msg;
        }

        private static LogLevel SeverityToLogLevel(Severity severity)
        {
            switch (severity)
            {
                case Severity.Off: return LogLevel.None;
                case Severity.Error: return LogLevel.Error;
                case Severity.Warning: return LogLevel.Warning;
                case Severity.Info: return LogLevel.Information;
                case Severity.Verbose: return LogLevel.Debug;
                default: return LogLevel.Trace;
            }
        }
        private Severity FindSeverityForLogger(ILogger logger)
        {
            //traversal from the lowest LogLevel to the highest to find the Severity of current Logger
            //If Trace is enabled, then minimun enabled LogLevel is Trace, which maps to Severity being Verbose2
            if (logger.IsEnabled(LogLevel.Trace))
                return Severity.Verbose3;
            //If Trace is not enabled but Debug is enabled, then minimun enabled LogLevel is Debug, which maps to Severity being Verbose.
            if (logger.IsEnabled(LogLevel.Debug))
                return Severity.Verbose;
            //same logic as aboce
            if (logger.IsEnabled(LogLevel.Information))
                return Severity.Info;
            if (logger.IsEnabled(LogLevel.Warning))
                return Severity.Warning;
            if (logger.IsEnabled(LogLevel.Error) || logger.IsEnabled(LogLevel.Critical))
                return Severity.Error;
            if (logger.IsEnabled(LogLevel.None))
                return Severity.Off;
            //default;
            return Severity.Verbose3;
        }

        public override Logger GetLogger(string loggerName)
        {
            return new LoggerWrapper(loggerName, this.loggerFactory, this.ipEndpoint);
        }
    }
}
