namespace Firebase.Crashlytics
{
    internal class AndroidImpl : global::Firebase.Crashlytics.Impl
    {
        private global::Firebase.Crashlytics.FirebaseCrashlyticsInternal crashlyticsInternal;
        private readonly global::Firebase.FirebaseApp firebaseApp;
        internal AndroidImpl()
        {
        }

        ~AndroidImpl()
        {
        }

        private void Dispose()
        {
        }

        public override bool IsSDKInitialized()
        {
            return false;
        }

        private void LogOperationFailedWarningDueToShutdown(string operation)
        {
        }

        private T CallInternalMethod<T>(global::System.Func<T> methodCall, string operation, T errorValue = default(T))
        {
            return default;
        }

        private void CallInternalMethod(global::System.Action methodCall, string operation)
        {
        }

        public override void Log(string message)
        {
        }

        public override void SetCustomKey(string key, string value)
        {
        }

        public override void SetUserId(string identifier)
        {
        }

        public override void LogException(global::System.Exception exception)
        {
        }

        public override void LogExceptionAsFatal(global::System.Exception exception)
        {
        }

        public override bool IsCrashlyticsCollectionEnabled()
        {
            return false;
        }
    }
}