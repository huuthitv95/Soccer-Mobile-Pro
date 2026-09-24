namespace DG.Tweening.Core
{
    public static class Debugger
    {
        private static int _logPriority;
        public static int logPriority => 0;

        public static void Log(object message)
        {
        }

        public static void LogWarning(object message, global::DG.Tweening.Tween t = null)
        {
        }

        public static void LogError(object message)
        {
        }

        public static void LogReport(object message)
        {
        }

        public static void LogSafeModeReport(object message)
        {
        }

        public static void LogInvalidTween(global::DG.Tweening.Tween t)
        {
        }

        public static void LogNestedTween(global::DG.Tweening.Tween t)
        {
        }

        public static void LogNullTween(global::DG.Tweening.Tween t)
        {
        }

        public static void LogMissingMaterialProperty(string propertyName)
        {
        }

        public static void LogMissingMaterialProperty(int propertyId)
        {
        }

        public static void LogRemoveActiveTweenError(string errorInfo, global::DG.Tweening.Tween t)
        {
        }

        public static void LogAddActiveTweenError(string errorInfo, global::DG.Tweening.Tween t)
        {
        }

        public static void SetLogPriority(global::DG.Tweening.LogBehaviour logBehaviour)
        {
        }
    }
}