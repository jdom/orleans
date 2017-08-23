using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.Runtime
{
    public class LoggingUtils
    {
        private const string LogCodeString = "OrleansLogCode: ";
        ///In order to user message bulking feature, Application needs to use this method to create EventId, 
        /// and also build their loggerProvider on top of OrleansLoggerDecorator 
        public static EventId CreateEventId(int eventId, int errorCode)
        {
            return new EventId(eventId, $"{LogCodeString}{errorCode}");
        }

        internal static EventId CreateEventId(int eventId, ErrorCode errorCode)
        {
            return new EventId(eventId, $"{LogCodeString}{(int)errorCode}");
        }
    }
}
