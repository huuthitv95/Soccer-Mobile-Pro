namespace Google.Play.Common
{
    public abstract class PlayAsyncOperation<TResult, TError> : global::UnityEngine.CustomYieldInstruction
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Google.Play.Common.PlayAsyncOperation<TResult, TError>> m_Completed;
        public bool IsDone { get; protected set; }
        public abstract bool IsSuccessful { get; }
        public TError Error { get; protected set; }
        public override bool keepWaiting => false;

        public virtual event global::System.Action<global::Google.Play.Common.PlayAsyncOperation<TResult, TError>> Completed
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public TResult GetResult()
        {
            return default;
        }

        protected void InvokeCompletedEvent()
        {
        }

        protected abstract TResult GetResultImpl();
    }
}