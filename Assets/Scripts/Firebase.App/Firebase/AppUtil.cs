namespace Firebase
{
    internal class AppUtil
    {
        internal static void PollCallbacks()
        {
        }

        internal static void AppEnableLogCallback(bool arg0)
        {
        }

        internal static void SetEnabledAllAppCallbacks(bool arg0)
        {
        }

        internal static void SetEnabledAppCallbackByName(string arg0, bool arg1)
        {
        }

        internal static bool GetEnabledAppCallbackByName(string arg0)
        {
            return false;
        }

        internal static void SetLogFunction(global::Firebase.LogUtil.LogMessageDelegate arg0)
        {
        }

        public static global::Firebase.GooglePlayServicesAvailability CheckAndroidDependencies()
        {
            return global::Firebase.GooglePlayServicesAvailability.AvailabilityAvailable;
        }
    }
}