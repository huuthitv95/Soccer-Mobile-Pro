namespace Firebase.Analytics
{
    internal static class FirebaseAnalyticsInternal
    {
        private static global::Firebase.FirebaseApp app;
        static FirebaseAnalyticsInternal()
        {
        }

        public static void LogEvent(string name, string parameterName, string parameterValue)
        {
        }

        public static void LogEvent(string name, string parameterName, long parameterValue)
        {
        }

        public static void LogEvent(string name)
        {
        }

        public static void SetUserProperty(string name, string property)
        {
        }

        public static global::System.Threading.Tasks.Task<string> GetAnalyticsInstanceIdAsync()
        {
            return null;
        }

        public static void LogEvent(string name, global::Firebase.StringList parameterNames, global::Firebase.VariantList parameterValues)
        {
        }

        public static void SetConsentWithInts(global::Firebase.Analytics.IntIntMap settings)
        {
        }
    }
}