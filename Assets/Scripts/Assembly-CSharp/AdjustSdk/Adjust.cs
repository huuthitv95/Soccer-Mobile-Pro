namespace AdjustSdk
{
    public class Adjust : global::UnityEngine.MonoBehaviour
    {
        private const string errorMsgEditor = "[Adjust]: SDK can not be used in Editor.";
        private const string errorMsgStart = "[Adjust]: SDK not started. Start it manually using the 'start' method.";
        private const string errorMsgPlatform = "[Adjust]: SDK can only be used in Android and iOS apps.";
        [global::UnityEngine.HideInInspector]
        private bool startManually;
        [global::UnityEngine.HideInInspector]
        private string appToken;
        [global::UnityEngine.HideInInspector]
        private global::AdjustSdk.AdjustEnvironment environment;
        [global::UnityEngine.HideInInspector]
        private global::AdjustSdk.AdjustLogLevel logLevel;
        [global::UnityEngine.HideInInspector]
        private bool coppaCompliance;
        [global::UnityEngine.HideInInspector]
        private bool sendInBackground;
        [global::UnityEngine.HideInInspector]
        private bool launchDeferredDeeplink;
        [global::UnityEngine.HideInInspector]
        private bool costDataInAttribution;
        [global::UnityEngine.HideInInspector]
        private bool linkMe;
        [global::UnityEngine.HideInInspector]
        private string defaultTracker;
        [global::UnityEngine.HideInInspector]
        private bool preinstallTracking;
        [global::UnityEngine.HideInInspector]
        private string preinstallFilePath;
        [global::UnityEngine.HideInInspector]
        private bool adServices;
        [global::UnityEngine.HideInInspector]
        private bool idfaReading;
        [global::UnityEngine.HideInInspector]
        private bool skanAttribution;
        public static bool Initialized;
        public static global::AdjustSdk.Adjust Instance;
        private void Awake()
        {
        }

        public void Init()
        {
        }

        private void AttributionChangedCallback(global::AdjustSdk.AdjustAttribution attributionData)
        {
        }

        public static void InitSdk(global::AdjustSdk.AdjustConfig adjustConfig)
        {
        }

        public static void TrackEvent(global::AdjustSdk.AdjustEvent adjustEvent)
        {
        }

        public static void Enable()
        {
        }

        public static void Disable()
        {
        }

        public static void IsEnabled(global::System.Action<bool> callback)
        {
        }

        public static void SwitchToOfflineMode()
        {
        }

        public static void SwitchBackToOnlineMode()
        {
        }

        public static void SetPushToken(string pushToken)
        {
        }

        public static void GdprForgetMe()
        {
        }

        public static void ProcessDeeplink(global::AdjustSdk.AdjustDeeplink deeplink)
        {
        }

        public static void AddGlobalPartnerParameter(string key, string value)
        {
        }

        public static void AddGlobalCallbackParameter(string key, string value)
        {
        }

        public static void RemoveGlobalPartnerParameter(string key)
        {
        }

        public static void RemoveGlobalCallbackParameter(string key)
        {
        }

        public static void RemoveGlobalPartnerParameters()
        {
        }

        public static void RemoveGlobalCallbackParameters()
        {
        }

        public static void TrackAdRevenue(global::AdjustSdk.AdjustAdRevenue adRevenue)
        {
        }

        public static void TrackAppStoreSubscription(global::AdjustSdk.AdjustAppStoreSubscription subscription)
        {
        }

        public static void TrackPlayStoreSubscription(global::AdjustSdk.AdjustPlayStoreSubscription subscription)
        {
        }

        public static void TrackThirdPartySharing(global::AdjustSdk.AdjustThirdPartySharing thirdPartySharing)
        {
        }

        public static void TrackMeasurementConsent(bool measurementConsent)
        {
        }

        public static void RequestAppTrackingAuthorization(global::System.Action<int> callback)
        {
        }

        public static void UpdateSkanConversionValue(int conversionValue, string coarseValue, bool lockWindow, global::System.Action<string> callback)
        {
        }

        public static int GetAppTrackingAuthorizationStatus()
        {
            return 0;
        }

        public static void GetAdid(global::System.Action<string> callback)
        {
        }

        public static void GetAttribution(global::System.Action<global::AdjustSdk.AdjustAttribution> callback)
        {
        }

        public static void GetIdfa(global::System.Action<string> callback)
        {
        }

        public static void GetIdfv(global::System.Action<string> callback)
        {
        }

        public static void GetGoogleAdId(global::System.Action<string> callback)
        {
        }

        public static void GetAmazonAdId(global::System.Action<string> callback)
        {
        }

        public static void GetSdkVersion(global::System.Action<string> callback)
        {
        }

        public static void GetLastDeeplink(global::System.Action<string> callback)
        {
        }

        public static void VerifyAppStorePurchase(global::AdjustSdk.AdjustAppStorePurchase purchase, global::System.Action<global::AdjustSdk.AdjustPurchaseVerificationResult> callback)
        {
        }

        public static void VerifyPlayStorePurchase(global::AdjustSdk.AdjustPlayStorePurchase purchase, global::System.Action<global::AdjustSdk.AdjustPurchaseVerificationResult> verificationResultCallback)
        {
        }

        public static void ProcessAndResolveDeeplink(global::AdjustSdk.AdjustDeeplink deeplink, global::System.Action<string> callback)
        {
        }

        public static void VerifyAndTrackAppStorePurchase(global::AdjustSdk.AdjustEvent adjustEvent, global::System.Action<global::AdjustSdk.AdjustPurchaseVerificationResult> callback)
        {
        }

        public static void VerifyAndTrackPlayStorePurchase(global::AdjustSdk.AdjustEvent adjustEvent, global::System.Action<global::AdjustSdk.AdjustPurchaseVerificationResult> verificationResultCallback)
        {
        }

        public static void EndFirstSessionDelay()
        {
        }

        public static void EnableCoppaComplianceInDelay()
        {
        }

        public static void DisableCoppaComplianceInDelay()
        {
        }

        public static void EnablePlayStoreKidsComplianceInDelay()
        {
        }

        public static void DisablePlayStoreKidsComplianceInDelay()
        {
        }

        public static void SetExternalDeviceIdInDelay(string externalDeviceId)
        {
        }

        private static bool IsEditor()
        {
            return false;
        }

        public static void SetTestOptions(global::System.Collections.Generic.Dictionary<string, string> testOptions)
        {
        }
    }
}