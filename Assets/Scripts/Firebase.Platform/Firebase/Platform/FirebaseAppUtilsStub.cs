namespace Firebase.Platform
{
    internal class FirebaseAppUtilsStub : global::Firebase.Platform.IFirebaseAppUtils
    {
        private static global::Firebase.Platform.FirebaseAppUtilsStub _instance;
        public static global::Firebase.Platform.FirebaseAppUtilsStub Instance => null;

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