using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orleans.Runtime
{
    internal class LoggingUtils
    {
        internal static EventId CreateEventId(ErrorCode errorCode)
        {
            return new EventId((int)errorCode);
        }
    }
}
