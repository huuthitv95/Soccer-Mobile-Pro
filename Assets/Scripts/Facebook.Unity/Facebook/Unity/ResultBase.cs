namespace Facebook.Unity
{
    internal abstract class ResultBase : global::Facebook.Unity.IInternalResult, global::Facebook.Unity.IResult
    {
        public virtual string Error { get; protected set; }
        public virtual global::System.Collections.Generic.IDictionary<string, string> ErrorDictionary { get; protected set; }
        public virtual global::System.Collections.Generic.IDictionary<string, object> ResultDictionary { get; protected set; }
        public virtual string RawResult { get; protected set; }
        public virtual bool Cancelled { get; protected set; }
        public virtual string CallbackId { get; protected set; }
        protected long? CanvasErrorCode { get; private set; }

        internal ResultBase(global::Facebook.Unity.ResultContainer result)
        {
        }

        internal ResultBase(global::Facebook.Unity.ResultContainer result, string error, bool cancelled)
        {
        }

        public override string ToString()
        {
            return null;
        }

        protected void Init(global::Facebook.Unity.ResultContainer result, string error, bool cancelled, string callbackId)
        {
        }

        private static string GetErrorValue(global::System.Collections.Generic.IDictionary<string, object> result)
        {
            return null;
        }

        private static bool GetCancelledValue(global::System.Collections.Generic.IDictionary<string, object> result)
        {
            return false;
        }

        private static string GetCallbackId(global::System.Collections.Generic.IDictionary<string, object> result)
        {
            return null;
        }
    }
}