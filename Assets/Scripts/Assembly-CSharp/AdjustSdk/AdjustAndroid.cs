namespace AdjustSdk
{
    public class AdjustAndroid
    {
        private class AttributionChangedListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::AdjustSdk.AdjustAttribution> callback;
            public AttributionChangedListener(global::System.Action<global::AdjustSdk.AdjustAttribution> pCallback) : base((string)null)
            {
            }

            public void onAttributionChanged(global::UnityEngine.AndroidJavaObject ajoAttribution)
            {
            }
        }

        private class DeferredDeeplinkListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<string> callback;
            public DeferredDeeplinkListener(global::System.Action<string> pCallback) : base((string)null)
            {
            }

            public bool launchReceivedDeeplink(global::UnityEngine.AndroidJavaObject deeplink)
            {
                return false;
            }
        }

        private class EventTrackingSucceededListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::AdjustSdk.AdjustEventSuccess> callback;
            public EventTrackingSucceededListener(global::System.Action<global::AdjustSdk.AdjustEventSuccess> pCallback) : base((string)null)
            {
            }

            public void onEventTrackingSucceeded(global::UnityEngine.AndroidJavaObject eventSuccessData)
            {
            }
        }

        private class EventTrackingFailedListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::AdjustSdk.AdjustEventFailure> callback;
            public EventTrackingFailedListener(global::System.Action<global::AdjustSdk.AdjustEventFailure> pCallback) : base((string)null)
            {
            }

            public void onEventTrackingFailed(global::UnityEngine.AndroidJavaObject eventFailureData)
            {
            }
        }

        private class SessionTrackingSucceededListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::AdjustSdk.AdjustSessionSuccess> callback;
            public SessionTrackingSucceededListener(global::System.Action<global::AdjustSdk.AdjustSessionSuccess> pCallback) : base((string)null)
            {
            }

            public void onSessionTrackingSucceeded(global::UnityEngine.AndroidJavaObject sessionSuccessData)
            {
            }
        }

        private class SessionTrackingFailedListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::AdjustSdk.AdjustSessionFailure> callback;
            public SessionTrackingFailedListener(global::System.Action<global::AdjustSdk.AdjustSessionFailure> pCallback) : base((string)null)
            {
            }

            public void onSessionTrackingFailed(global::UnityEngine.AndroidJavaObject sessionFailureData)
            {
            }
        }

        private class GoogleAdIdReadListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<string> callback;
            public GoogleAdIdReadListener(global::System.Action<string> pCallback) : base((string)null)
            {
            }

            public void onGoogleAdIdRead(string adid)
            {
            }
        }

        private class VerificationResultListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::AdjustSdk.AdjustPurchaseVerificationResult> callback;
            public VerificationResultListener(global::System.Action<global::AdjustSdk.AdjustPurchaseVerificationResult> pCallback) : base((string)null)
            {
            }

            public void onVerificationFinished(global::UnityEngine.AndroidJavaObject ajoVerificationInfo)
            {
            }
        }

        private class DeeplinkResolutionListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<string> callback;
            public DeeplinkResolutionListener(global::System.Action<string> pCallback) : base((string)null)
            {
            }

            public void onDeeplinkResolved(string resolvedLink)
            {
            }
        }

        private class AdidReadListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<string> callback;
            public AdidReadListener(global::System.Action<string> pCallback) : base((string)null)
            {
            }

            public void onAdidRead(string adid)
            {
            }
        }

        private class AttributionReadListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::AdjustSdk.AdjustAttribution> callback;
            public AttributionReadListener(global::System.Action<global::AdjustSdk.AdjustAttribution> pCallback) : base((string)null)
            {
            }

            public void onAttributionRead(global::UnityEngine.AndroidJavaObject ajoAttribution)
            {
            }
        }

        private class AmazonAdIdReadListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<string> callback;
            public AmazonAdIdReadListener(global::System.Action<string> pCallback) : base((string)null)
            {
            }

            public void onAmazonAdIdRead(string amazonAdId)
            {
            }
        }

        private class SdkVersionReadListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<string> callback;
            private string sdkPrefix;
            public SdkVersionReadListener(global::System.Action<string> pCallback, string sdkPrefix) : base((string)null)
            {
            }

            public void onSdkVersionRead(string sdkVersion)
            {
            }
        }

        private class IsEnabledListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<bool> callback;
            public IsEnabledListener(global::System.Action<bool> pCallback) : base((string)null)
            {
            }

            public void onIsEnabledRead(bool isEnabled)
            {
            }
        }

        private class LastDeeplinkListener : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<string> callback;
            public LastDeeplinkListener(global::System.Action<string> pCallback) : base((string)null)
            {
            }

            public void onLastDeeplinkRead(global::UnityEngine.AndroidJavaObject ajoLastDeeplink)
            {
            }
        }

        private const string sdkPrefix = "unity5.4.1";
        private static bool isDeferredDeeplinkOpeningEnabled;
        private static global::UnityEngine.AndroidJavaClass ajcAdjust;
        private static global::UnityEngine.AndroidJavaObject ajoCurrentActivity;
        private static global::AdjustSdk.AdjustAndroid.DeferredDeeplinkListener onDeferredDeeplinkListener;
        private static global::AdjustSdk.AdjustAndroid.AttributionChangedListener onAttributionChangedListener;
        private static global::AdjustSdk.AdjustAndroid.EventTrackingFailedListener onEventTrackingFailedListener;
        private static global::AdjustSdk.AdjustAndroid.EventTrackingSucceededListener onEventTrackingSucceededListener;
        private static global::AdjustSdk.AdjustAndroid.SessionTrackingFailedListener onSessionTrackingFailedListener;
        private static global::AdjustSdk.AdjustAndroid.SessionTrackingSucceededListener onSessionTrackingSucceededListener;
        private static global::AdjustSdk.AdjustAndroid.VerificationResultListener onVerificationResultListener;
        private static global::AdjustSdk.AdjustAndroid.VerificationResultListener onVerifyAndTrackListener;
        private static global::AdjustSdk.AdjustAndroid.DeeplinkResolutionListener onDeeplinkResolvedListener;
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

        public static void SwitchToOfflineMode()
        {
        }

        public static void SwitchBackToOnlineMode()
        {
        }

        public static void EnableCoppaCompliance()
        {
        }

        public static void DisableCoppaCompliance()
        {
        }

        public static void EnablePlayStoreKidsApp()
        {
        }

        public static void DisablePlayStoreKidsApp()
        {
        }

        public static void SetPushToken(string pushToken)
        {
        }

        public static void GdprForgetMe()
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

        public static void ProcessDeeplink(global::AdjustSdk.AdjustDeeplink deeplink)
        {
        }

        public static void TrackAdRevenue(global::AdjustSdk.AdjustAdRevenue adRevenue)
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

        public static void IsEnabled(global::System.Action<bool> onIsEnabled)
        {
        }

        public static void GetAdid(global::System.Action<string> onAdidRead)
        {
        }

        public static void GetAttribution(global::System.Action<global::AdjustSdk.AdjustAttribution> onAttributionRead)
        {
        }

        public static void GetSdkVersion(global::System.Action<string> onSdkVersionRead)
        {
        }

        public static void GetLastDeeplink(global::System.Action<string> onLastDeeplinkRead)
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

        public static void SetExternalDeviceIdInDelay(string externalDeviceId)
        {
        }

        public static void GetGoogleAdId(global::System.Action<string> onDeviceIdsRead)
        {
        }

        public static void GetAmazonAdId(global::System.Action<string> onAmazonAdIdRead)
        {
        }

        public static void VerifyPlayStorePurchase(global::AdjustSdk.AdjustPlayStorePurchase purchase, global::System.Action<global::AdjustSdk.AdjustPurchaseVerificationResult> verificationInfoCallback)
        {
        }

        public static void ProcessAndResolveDeeplink(global::AdjustSdk.AdjustDeeplink deeplink, global::System.Action<string> resolvedLinkCallback)
        {
        }

        public static void VerifyAndTrackPlayStorePurchase(global::AdjustSdk.AdjustEvent adjustEvent, global::System.Action<global::AdjustSdk.AdjustPurchaseVerificationResult> verificationInfoCallback)
        {
        }

        public static void EnablePlayStoreKidsComplianceInDelay()
        {
        }

        public static void DisablePlayStoreKidsComplianceInDelay()
        {
        }

        public static void SetTestOptions(global::System.Collections.Generic.Dictionary<string, string> testOptions)
        {
        }

        public static void OnResume(string testingArgument = null)
        {
        }

        public static void OnPause(string testingArgument = null)
        {
        }
    }
}