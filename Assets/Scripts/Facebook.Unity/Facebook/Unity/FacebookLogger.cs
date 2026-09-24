namespace Facebook.Unity
{
    internal static class FacebookLogger
    {
        private class DebugLogger : global::Facebook.Unity.IFacebookLogger
        {
            public void Log(string msg)
            {
            }

            public void Info(string msg)
            {
            }

            public void Warn(string msg)
            {
            }
        }

        internal static global::Facebook.Unity.IFacebookLogger Instance { private get; set; }

        static FacebookLogger()
        {
        }

        public static void Log(string msg)
        {
        }

        public static void Info(string msg)
        {
        }

        public static void Warn(string msg)
        {
        }

        public static void Warn(string format, params string[] args)
        {
        }
    }
}