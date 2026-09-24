namespace Firebase
{
    internal class FutureString : global::Firebase.FutureBase
    {
        public delegate void Action();
        internal delegate void SWIG_CompletionDelegate(int index);
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        private static global::System.Collections.Generic.Dictionary<int, global::Firebase.FutureString.Action> Callbacks;
        private static int CallbackIndex;
        private static object CallbackLock;
        private global::System.IntPtr callbackData;
        private global::Firebase.FutureString.SWIG_CompletionDelegate SWIG_CompletionCB;
        internal FutureString(global::System.IntPtr cPtr, bool cMemoryOwn) : base((global::System.IntPtr)0, cMemoryOwn: false)
        {
        }

        public override void Dispose(bool disposing)
        {
        }

        public static global::System.Threading.Tasks.Task<string> GetTask(global::Firebase.FutureString fu)
        {
            return null;
        }

        private void ThrowIfDisposed()
        {
        }

        public void SetOnCompletionCallback(global::Firebase.FutureString.Action userCompletionCallback)
        {
        }

        private void SetCompletionData(global::System.IntPtr data)
        {
        }

        private static void SWIG_CompletionDispatcher(int key)
        {
        }

        internal global::System.IntPtr SWIG_OnCompletion(global::Firebase.FutureString.SWIG_CompletionDelegate cs_callback, int cs_key)
        {
            return (global::System.IntPtr)0;
        }

        public static void SWIG_FreeCompletionData(global::System.IntPtr data)
        {
        }

        public string GetResult()
        {
            return null;
        }
    }
}