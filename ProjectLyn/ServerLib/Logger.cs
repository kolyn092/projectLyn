using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using ILogger = Microsoft.Extensions.Logging.ILogger;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace ServerLib
{
    public static class Logger
    {
        private static ILoggerFactory _loggerFactory;
        private static LogFactory _nLogFactory;
        private static ILogger _default;

        public static ILogger Default => _default; // { get; private set; }
        public static ILoggerFactory LogFactory => _loggerFactory;

        static Logger()
        {

        }

        public static void Init(string envName)
        {

        }
    }
}
