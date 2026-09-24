namespace Google.Play.Common.Internal
{
    public abstract class PlayAsyncOperationImpl<TResult, TError> : global::Google.Play.Common.PlayAsyncOperation<TResult, TError>
    {
        private TResult _result;
        public override event global::System.Action<global::Google.Play.Common.PlayAsyncOperation<TResult, TError>> Completed
        {
            add
            {
            }

            remove
            {
            }
        }

        public void SetResult(TResult result)
        {
        }

        public void SetError(TError errorCode)
        {
        }

        protected override TResult GetResultImpl()
        {
            return default;
        }
    }
}