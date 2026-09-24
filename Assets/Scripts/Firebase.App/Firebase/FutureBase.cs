namespace Firebase
{
    internal class FutureBase : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
        internal FutureBase(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        ~FutureBase()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        public global::Firebase.FutureStatus status()
        {
            return global::Firebase.FutureStatus.Complete;
        }

        public int error()
        {
            return 0;
        }

        public string error_message()
        {
            return null;
        }
    }
}