namespace GoogleMobileAds.Android
{
    public class MobileAdsClient : global::UnityEngine.AndroidJavaProxy, global::GoogleMobileAds.Common.IMobileAdsClient
    {
        private static readonly global::GoogleMobileAds.Android.MobileAdsClient _instance;
        private readonly global::UnityEngine.AndroidJavaClass _mobileAdsClass;
        private readonly global::GoogleMobileAds.Common.IInsightsEmitter _insightsEmitter;
        private readonly global::GoogleMobileAds.Common.ITracer _tracer;
        private readonly global::GoogleMobileAds.Common.AsyncTraceScope _asyncTraceScope;
        private global::System.Action<global::GoogleMobileAds.Common.IInitializationStatusClient> _initCompleteAction;
        public static global::GoogleMobileAds.Android.MobileAdsClient Instance => null;

        private MobileAdsClient() : base((string)null)
        {
        }

        public void Initialize(global::System.Action<global::GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction)
        {
        }

        public void SetApplicationVolume(float volume)
        {
        }

        public void DisableMediationInitialization()
        {
        }

        public void SetApplicationMuted(bool muted)
        {
        }

        public void SetRequestConfiguration(global::GoogleMobileAds.Api.RequestConfiguration requestConfiguration)
        {
        }

        public global::GoogleMobileAds.Api.RequestConfiguration GetRequestConfiguration()
        {
            return null;
        }

        public void SetiOSAppPauseOnBackground(bool pause)
        {
        }

        public void DisableSDKCrashReporting()
        {
        }

        public void OpenAdInspector(global::System.Action<global::GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> onAdInspectorClosed)
        {
        }

        public void Preload(global::System.Collections.Generic.List<global::GoogleMobileAds.Api.PreloadConfiguration> configurations, global::System.Action<global::GoogleMobileAds.Api.PreloadConfiguration> onAdAvailable, global::System.Action<global::GoogleMobileAds.Api.PreloadConfiguration> onAdsExhausted)
        {
        }

        public float GetDeviceScale()
        {
            return 0f;
        }

        public int GetDeviceSafeWidth()
        {
            return 0;
        }

        public global::System.Version GetSDKVersion()
        {
            return null;
        }

        public void onInitializationComplete(global::UnityEngine.AndroidJavaObject initStatus)
        {
        }
    }
}