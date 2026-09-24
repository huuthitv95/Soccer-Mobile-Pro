namespace Firebase
{
    internal sealed class LogUtil : global::System.IDisposable
    {
        internal delegate void LogMessageDelegate(global::Firebase.LogLevel log_level, string message);
        private static global::Firebase.LogUtil _instance;
        private static object InitializeLoggingLock;
        private bool _disposed;
        static LogUtil()
        {
        }

        public static void InitializeLogging()
        {
        }

        internal static global::Firebase.Platform.PlatformLogLevel ConvertLogLevel(global::Firebase.LogLevel logLevel)
        {
            return global::Firebase.Platform.PlatformLogLevel.Verbose;
        }

        internal static void LogMessage(global::Firebase.LogLevel logLevel, string message)
        {
        }

        internal static void LogMessageFromCallback(global::Firebase.LogLevel logLevel, string message)
        {
        }

        ~LogUtil()
        {
        }

        public void Dispose()
        {
        }

        protected void Dispose(bool disposing)
        {
        }
    }
}