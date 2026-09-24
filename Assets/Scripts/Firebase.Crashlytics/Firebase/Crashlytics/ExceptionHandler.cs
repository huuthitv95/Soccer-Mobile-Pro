namespace Firebase.Crashlytics
{
    internal class ExceptionHandler
    {
        private bool isRegistered;
        internal void Register()
        {
        }

        internal void HandleException(object sender, global::System.UnhandledExceptionEventArgs eArgs)
        {
        }

        internal void HandleLog(string message, string stackTraceString, global::UnityEngine.LogType type)
        {
        }

        private string[] getMessageParts(string message)
        {
            return null;
        }

        internal virtual void LogException(global::Firebase.Crashlytics.LoggedException e)
        {
        }
    }
}