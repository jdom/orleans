
using System;
using System.Diagnostics;

namespace Orleans.Runtime
{
    internal static class LoggerExtensionsWithErrorCodes
    {
        private static readonly object[] EmptyObjectArray = new object[0];

        internal static void Verbose(this Logger logger, ErrorCode errorCode, string format, params object[] args)
        {
            logger.Log((int)errorCode, Severity.Verbose, format, args, null);
        }
        internal static void Verbose(this Logger logger, ErrorCode errorCode, string message)
        {
            logger.Log((int)errorCode, Severity.Verbose, message, EmptyObjectArray, null);
        }
        internal static void Verbose2(this Logger logger, ErrorCode errorCode, string format, params object[] args)
        {
            logger.Log((int)errorCode, Severity.Verbose2, format, args, null);
        }
        internal static void Verbose2(this Logger logger, ErrorCode errorCode, string message)
        {
            logger.Log((int)errorCode, Severity.Verbose2, message, EmptyObjectArray, null);
        }
        internal static void Verbose3(this Logger logger, ErrorCode errorCode, string format, params object[] args)
        {
            logger.Log((int)errorCode, Severity.Verbose3, format, args, null);
        }
        internal static void Verbose3(this Logger logger, ErrorCode errorCode, string message)
        {
            logger.Log((int)errorCode, Severity.Verbose3, message, EmptyObjectArray, null);
        }
        internal static void Info(this Logger logger, ErrorCode errorCode, string format, params object[] args)
        {
            logger.Log((int)errorCode, Severity.Info, format, args, null);
        }
        internal static void Info(this Logger logger, ErrorCode errorCode, string message)
        {
            logger.Log((int)errorCode, Severity.Info, message, EmptyObjectArray, null);
        }
        internal static void Warn(this Logger logger, ErrorCode errorCode, string format, params object[] args)
        {
            logger.Log((int)errorCode, Severity.Warning, format, args, null);
        }
        internal static void Warn(this Logger logger, ErrorCode errorCode, string message, Exception exception)
        {
            logger.Log((int)errorCode, Severity.Warning, message, EmptyObjectArray, exception);
        }
        internal static void Error(this Logger logger, ErrorCode errorCode, string message, Exception exception = null)
        {
            logger.Log((int)errorCode, Severity.Error, message, EmptyObjectArray, exception);
        }

        internal static void Assert(this Logger logger, ErrorCode errorCode, bool condition, string message = null)
        {
            if (condition) return;

            if (message == null)
            {
                message = "Internal contract assertion has failed!";
            }

            logger.Fail(errorCode, "Assert failed with message = " + message);
        }

        internal static void Fail(this Logger logger, ErrorCode errorCode, string message)
        {
            if (message == null)
            {
                message = "Internal Fail!";
            }

            if (errorCode == 0)
            {
                errorCode = ErrorCode.Runtime;
            }

            logger.Error(errorCode, "INTERNAL FAILURE! About to crash! Fail message is: " + message + Environment.NewLine + Environment.StackTrace);

            // Create mini-dump of this failure, for later diagnosis
            var dumpFile = LogManager.CreateMiniDump();
            logger.Error(ErrorCode.Logger_MiniDumpCreated, "INTERNAL FAILURE! Application mini-dump written to file " + dumpFile.FullName);

            LogManager.Flush(); // Flush logs to disk

            // Kill process
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
            else
            {
                logger.Error(ErrorCode.Logger_ProcessCrashing, "INTERNAL FAILURE! Process crashing!");
                LogManager.Close();

                Environment.FailFast("Unrecoverable failure: " + message);
            }
        }
    }
}
