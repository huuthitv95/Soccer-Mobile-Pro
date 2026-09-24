namespace Coffee.UISoftMaskInternal
{
    internal static class Logging
    {
        private const string k_DisableSymbol = "DISABLE_COFFEE_LOGGER";
        private static void Log_Internal(global::UnityEngine.LogType type, object tag, object message, global::UnityEngine.Object context)
        {
        }

        public static void LogIf(bool enable, object tag, object message, global::UnityEngine.Object context = null)
        {
        }

        public static void Log(object tag, object message, global::UnityEngine.Object context = null)
        {
        }

        public static void LogWarning(object tag, object message, global::UnityEngine.Object context = null)
        {
        }

        public static void LogError(object tag, object message, global::UnityEngine.Object context = null)
        {
        }

        public static void LogMulticast(global::System.Type type, string fieldName, object instance = null, string message = null)
        {
        }

        private static void AppendTag(global::System.Text.StringBuilder sb, object tag)
        {
        }

        private static void AppendType(global::System.Text.StringBuilder sb, global::System.Type type)
        {
        }

        private static void AppendReadableCode(global::System.Text.StringBuilder sb, object tag)
        {
        }
    }
}