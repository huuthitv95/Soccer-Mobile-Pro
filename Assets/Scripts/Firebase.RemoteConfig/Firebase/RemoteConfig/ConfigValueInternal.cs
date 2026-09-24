namespace Firebase.RemoteConfig
{
    internal class ConfigValueInternal : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
        public global::Firebase.CharVector data => null;
        public global::Firebase.RemoteConfig.ValueSource source => global::Firebase.RemoteConfig.ValueSource.StaticValue;

        internal ConfigValueInternal(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        ~ConfigValueInternal()
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