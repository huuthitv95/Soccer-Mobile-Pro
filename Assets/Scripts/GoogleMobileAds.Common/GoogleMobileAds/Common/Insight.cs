namespace GoogleMobileAds.Common
{
    [global::System.Serializable]
    public class Insight
    {
        [global::System.Serializable]
        public class TracingActivity
        {
            public string OperationName;
            public string Id;
            public string ParentId;
            public long DurationMillis;
            public bool HasEnded;
        }

        public enum CuiName
        {
            Unknown = 0,
            SdkInitialized = 1,
            AdRequested = 2,
            AdLoaded = 3,
            AdFailedToLoad = 4,
            AdShown = 5,
            AdClosed = 6,
            AdClicked = 7
        }

        public enum AdFormat
        {
            Unknown = 0,
            Banner = 1,
            Interstitial = 2,
            Rewarded = 3,
            RewardedInterstitial = 4,
            AppOpen = 5,
            Native = 6
        }

        public enum AdPlatform
        {
            Unknown = 0,
            Android = 1,
            Ios = 2,
            Unity = 3
        }

        internal static readonly global::System.DateTime UnixEpoch;
        private static global::GoogleMobileAds.Common.Insight.AdPlatform _platform;
        private static string _appId;
        private static string _appVersionName;
        private static string _unityVersion;
        private static string _osVersion;
        private static string _deviceModel;
        public global::GoogleMobileAds.Common.Insight.CuiName Name;
        public bool Success;
        public long StartTimeEpochMillis;
        public string SdkVersion;
        public string AppId;
        public string AdUnitId;
        public global::GoogleMobileAds.Common.Insight.AdFormat Format;
        public global::GoogleMobileAds.Common.Insight.AdPlatform Platform;
        public string AppVersionName;
        public string UnityVersion;
        public string OSVersion;
        public string DeviceModel;
        public global::System.Collections.Generic.List<string> Tags;
        public global::GoogleMobileAds.Common.Insight.TracingActivity Tracing;
        public string Details;
        private static void CacheBaseProperties()
        {
        }

        public override string ToString()
        {
            return null;
        }

        public string ToJson()
        {
            return null;
        }
    }
}