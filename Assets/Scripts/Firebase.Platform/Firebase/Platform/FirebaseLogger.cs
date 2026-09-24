namespace Firebase.Platform
{
    internal class FirebaseLogger
    {
        private static global::Firebase.Platform.MainThreadProperty<bool> incompatibleStackUnwindingEnabled;
        internal static bool CanRedirectNativeLogs => false;

        private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(global::UnityEngine.StackTraceLogType logType)
        {
            return false;
        }

        private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs()
        {
            return false;
        }

        internal static void LogMessage(global::Firebase.Platform.PlatformLogLevel logLevel, string message)
        {
        }
    }
}