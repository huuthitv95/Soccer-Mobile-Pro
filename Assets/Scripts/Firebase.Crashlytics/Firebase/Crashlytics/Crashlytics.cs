namespace Firebase.Crashlytics
{
    [global::UnityEngine.Scripting.Preserve]
    public static class Crashlytics
    {
        [global::UnityEngine.Scripting.Preserve]
        internal static class PlatformAccessor
        {
            private static global::Firebase.Crashlytics.ExceptionHandler _exceptionHandler;
            private static global::Firebase.Crashlytics.Impl _impl;
            private static global::Firebase.FirebaseApp _app;
            [global::UnityEngine.Scripting.Preserve]
            internal static global::Firebase.Crashlytics.ExceptionHandler ExceptionHandler => null;
            internal static global::Firebase.Crashlytics.Impl Impl => null;

            [global::UnityEngine.Scripting.Preserve]
            internal static global::Firebase.FirebaseApp App => null;

            static PlatformAccessor()
            {
            }
        }

        public static bool ReportUncaughtExceptionsAsFatal { get; set; }
        public static bool IsCrashlyticsCollectionEnabled => false;

        [global::UnityEngine.Scripting.Preserve]
        private static void Initialize()
        {
        }

        public static void Log(string message)
        {
        }

        public static void SetUserId(string identifier)
        {
        }

        public static void LogException(global::System.Exception exception)
        {
        }

        internal static void LogExceptionAsFatal(global::System.Exception exception)
        {
        }
    }
}