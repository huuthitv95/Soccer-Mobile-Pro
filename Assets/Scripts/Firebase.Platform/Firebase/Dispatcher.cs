namespace Firebase
{
    internal class Dispatcher
    {
        private class CallbackStorage<TResult>
        {
            public TResult Result { get; set; }
            public global::System.Exception Exception { get; set; }
        }

        private int ownerThreadId;
        private global::System.Collections.Generic.Queue<global::System.Action> queue;
        public TResult Run<TResult>(global::System.Func<TResult> callback)
        {
            return default;
        }

        public global::System.Threading.Tasks.Task<TResult> RunAsync<TResult>(global::System.Func<TResult> callback)
        {
            return null;
        }

        internal static global::System.Threading.Tasks.Task<TResult> RunAsyncNow<TResult>(global::System.Func<TResult> callback)
        {
            return null;
        }

        internal bool ManagesThisThread()
        {
            return false;
        }

        public void PollJobs()
        {
        }
    }
}