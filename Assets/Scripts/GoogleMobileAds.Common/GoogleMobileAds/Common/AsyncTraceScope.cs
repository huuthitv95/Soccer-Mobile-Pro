[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("GoogleMobileAds.Android")]
namespace GoogleMobileAds.Common
{
    internal class AsyncTraceScope
    {
        private global::GoogleMobileAds.Common.ITrace _activeTrace;
        private readonly global::GoogleMobileAds.Common.ITracer _tracer;
        private readonly object _lock;
        public AsyncTraceScope(global::GoogleMobileAds.Common.ITracer tracer)
        {
        }

        public void StartTraceIfInactive(string name)
        {
        }

        public void Complete()
        {
        }
    }
}