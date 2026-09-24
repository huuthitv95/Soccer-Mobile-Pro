namespace Firebase.Crashlytics
{
    internal class Impl
    {
        private static readonly string LogString;
        private static readonly string SetKeyValueString;
        private static readonly string SetUserIdentifierString;
        private static readonly string LogExceptionString;
        private static readonly string LogExceptionAsFatalString;
        private static readonly string IsCrashlyticsCollectionEnabledString;
        private static readonly string SetCrashlyticsCollectionEnabledString;
        public static global::Firebase.Crashlytics.Impl Make()
        {
            return null;
        }

        public virtual bool IsSDKInitialized()
        {
            return false;
        }

        public virtual void Log(string message)
        {
        }

        public virtual void SetCustomKey(string key, string value)
        {
        }

        public virtual void SetUserId(string identifier)
        {
        }

        public virtual void LogException(global::System.Exception exception)
        {
        }

        public virtual void LogExceptionAsFatal(global::System.Exception exception)
        {
        }

        public virtual bool IsCrashlyticsCollectionEnabled()
        {
            return false;
        }
    }
}