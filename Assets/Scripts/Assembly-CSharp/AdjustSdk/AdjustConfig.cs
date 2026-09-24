namespace AdjustSdk
{
    public class AdjustConfig
    {
        public string AppToken { get; private set; }
        public string DefaultTracker { get; set; }
        public string ExternalDeviceId { get; set; }
        public bool? IsCoppaComplianceEnabled { get; set; }
        public bool? IsSendingInBackgroundEnabled { get; set; }
        public bool? IsCostDataInAttributionEnabled { get; set; }
        public bool? IsDeviceIdsReadingOnceEnabled { get; set; }
        public bool? IsDeferredDeeplinkOpeningEnabled { get; set; }
        public bool? IsAppTrackingTransparencyUsageEnabled { get; set; }
        public bool? IsFirstSessionDelayEnabled { get; set; }
        public bool? AllowSuppressLogLevel { get; private set; }
        public bool? IsDataResidency { get; private set; }
        public bool? ShouldUseSubdomains { get; private set; }
        public int? EventDeduplicationIdsMaxSize { get; set; }
        public global::System.Collections.Generic.List<string> UrlStrategyDomains { get; private set; }
        public global::AdjustSdk.AdjustLogLevel? LogLevel { get; set; }
        public global::AdjustSdk.AdjustEnvironment Environment { get; private set; }
        public global::AdjustSdk.AdjustStoreInfo StoreInfo { get; set; }
        public global::System.Action<global::AdjustSdk.AdjustAttribution> AttributionChangedDelegate { get; set; }
        public global::System.Action<global::AdjustSdk.AdjustEventSuccess> EventSuccessDelegate { get; set; }
        public global::System.Action<global::AdjustSdk.AdjustEventFailure> EventFailureDelegate { get; set; }
        public global::System.Action<global::AdjustSdk.AdjustSessionSuccess> SessionSuccessDelegate { get; set; }
        public global::System.Action<global::AdjustSdk.AdjustSessionFailure> SessionFailureDelegate { get; set; }
        public global::System.Action<string> DeferredDeeplinkDelegate { get; set; }
        public global::System.Action<global::System.Collections.Generic.Dictionary<string, string>> SkanUpdatedDelegate { get; set; }
        public bool? IsAdServicesEnabled { get; set; }
        public bool? IsIdfaReadingEnabled { get; set; }
        public bool? IsSkanAttributionEnabled { get; set; }
        public bool? IsLinkMeEnabled { get; set; }
        public int? AttConsentWaitingInterval { get; set; }
        public bool? IsPlayStoreKidsComplianceEnabled { get; set; }
        public bool? IsPreinstallTrackingEnabled { get; set; }
        public string PreinstallFilePath { get; set; }
        public string FbAppId { get; set; }

        public AdjustConfig(string appToken, global::AdjustSdk.AdjustEnvironment environment)
        {
        }

        public AdjustConfig(string appToken, global::AdjustSdk.AdjustEnvironment environment, bool allowSuppressLogLevel)
        {
        }

        public void SetUrlStrategy(global::System.Collections.Generic.List<string> urlStrategyDomains, bool shouldUseSubdomains, bool isDataResidency)
        {
        }
    }
}