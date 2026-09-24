namespace Firebase.Crashlytics
{
    internal class FirebaseCrashlyticsInternal : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
        internal bool IsDisposed => false;

        internal FirebaseCrashlyticsInternal(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        ~FirebaseCrashlyticsInternal()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        internal static global::Firebase.Crashlytics.FirebaseCrashlyticsInternal GetInstance(global::Firebase.FirebaseApp app, out global::Firebase.InitResult init_result_out)
        {
            init_result_out = default;
            return null;
        }

        public void Log(string message)
        {
        }

        public void SetCustomKey(string key, string value)
        {
        }

        public void SetUserId(string id)
        {
        }

        public void LogException(string name, string reason, global::Firebase.Crashlytics.StackFrames frames)
        {
        }

        public void LogExceptionAsFatal(string name, string reason, global::Firebase.Crashlytics.StackFrames frames)
        {
        }

        public bool IsCrashlyticsCollectionEnabled()
        {
            return false;
        }
    }
}