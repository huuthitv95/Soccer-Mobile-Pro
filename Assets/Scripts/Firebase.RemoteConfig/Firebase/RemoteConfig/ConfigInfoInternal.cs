namespace Firebase.RemoteConfig
{
    internal class ConfigInfoInternal : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
        public ulong fetch_time => 0uL;
        public global::Firebase.RemoteConfig.LastFetchStatus last_fetch_status => global::Firebase.RemoteConfig.LastFetchStatus.Success;
        public global::Firebase.RemoteConfig.FetchFailureReason last_fetch_failure_reason => global::Firebase.RemoteConfig.FetchFailureReason.Invalid;
        public ulong throttled_end_time => 0uL;

        internal ConfigInfoInternal(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        ~ConfigInfoInternal()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }
    }
}