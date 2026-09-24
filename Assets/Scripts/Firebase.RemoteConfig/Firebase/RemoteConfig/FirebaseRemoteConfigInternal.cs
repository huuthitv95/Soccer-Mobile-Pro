namespace Firebase.RemoteConfig
{
    internal class FirebaseRemoteConfigInternal : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
        internal string InstanceKey => null;
        public global::Firebase.FirebaseApp App => null;

        internal FirebaseRemoteConfigInternal(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(global::Firebase.RemoteConfig.FirebaseRemoteConfigInternal obj)
        {
            return default;
        }

        ~FirebaseRemoteConfigInternal()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        internal void SetSwigCMemOwn(bool ownership)
        {
        }

        public global::System.Threading.Tasks.Task<bool> FetchAndActivateAsync()
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerable<string> GetKeys()
        {
            return null;
        }

        internal global::Firebase.RemoteConfig.ConfigInfoInternal GetInfo()
        {
            return null;
        }

        internal static global::Firebase.RemoteConfig.FirebaseRemoteConfigInternal GetInstanceInternal(global::Firebase.FirebaseApp app)
        {
            return null;
        }

        internal static void ReleaseReferenceInternal(global::Firebase.RemoteConfig.FirebaseRemoteConfigInternal rc)
        {
        }

        internal global::Firebase.RemoteConfig.ConfigValueInternal GetValueInternal(string key)
        {
            return null;
        }
    }
}