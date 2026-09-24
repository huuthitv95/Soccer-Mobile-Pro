namespace Firebase.Platform
{
    internal class FirebaseAppUtils
    {
        private static global::Firebase.Platform.FirebaseAppUtils instance;
        public static global::Firebase.Platform.FirebaseAppUtils Instance => null;

        public void TranslateDllNotFoundException(global::System.Action action)
        {
        }

        public void PollCallbacks()
        {
        }

        public global::Firebase.Platform.PlatformLogLevel GetLogLevel()
        {
            return global::Firebase.Platform.PlatformLogLevel.Verbose;
        }
    }
}