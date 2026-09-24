namespace GoogleMobileAds.Common
{
    public class Tracer : global::GoogleMobileAds.Common.ITracer
    {
        private class Trace : global::GoogleMobileAds.Common.ITrace, global::System.IDisposable
        {
            private readonly global::GoogleMobileAds.Common.TraceInfo _traceInfo;
            private readonly string _parentId;
            private readonly global::GoogleMobileAds.Common.Tracer _tracer;
            private readonly bool _isSynchronous;
            private bool _isDisposed;
            private readonly object _disposeLock;
            public Trace(global::GoogleMobileAds.Common.TraceInfo traceInfo, string parentId, global::GoogleMobileAds.Common.Tracer tracer, bool isSynchronous)
            {
            }

            public void Dispose()
            {
            }
        }

        [global::System.ThreadStatic]
        private static global::System.Collections.Generic.Stack<global::GoogleMobileAds.Common.TraceInfo> _traceStack;
        private readonly global::GoogleMobileAds.Common.IInsightsEmitter _insightsEmitter;
        internal global::GoogleMobileAds.Common.IInsightsEmitter Emitter => null;

        public Tracer(global::GoogleMobileAds.Common.IInsightsEmitter insightsEmitter)
        {
        }

        internal global::System.Collections.Generic.Stack<global::GoogleMobileAds.Common.TraceInfo> GetTraceStack()
        {
            return null;
        }

        public global::GoogleMobileAds.Common.ITrace StartTrace(string name)
        {
            return null;
        }

        public global::GoogleMobileAds.Common.ITrace StartAsyncTrace(string name)
        {
            return null;
        }

        private global::GoogleMobileAds.Common.ITrace StartTraceInternal(string name, bool isSynchronous)
        {
            return null;
        }
    }
}