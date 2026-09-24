namespace GoogleMobileAds.Ump.Android
{
    internal class ConsentFormClient : global::UnityEngine.AndroidJavaProxy, global::GoogleMobileAds.Ump.Common.IConsentFormClient
    {
        internal global::GoogleMobileAds.Ump.Android.OnConsentFormLoadSuccessListener _onSuccess;
        internal global::GoogleMobileAds.Ump.Android.OnConsentFormLoadFailureListener _onFailure;
        internal global::GoogleMobileAds.Ump.Android.OnConsentFormDismissedListener _onDismissed;
        private static readonly global::GoogleMobileAds.Ump.Android.ConsentFormClient _instance;
        private readonly global::UnityEngine.AndroidJavaObject _activity;
        private readonly global::UnityEngine.AndroidJavaObject _userMessagingPlatformClass;
        private global::UnityEngine.AndroidJavaObject _consentForm;
        private global::UnityEngine.AndroidJavaObject _unityConsentForm;
        private global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> _onConsentFormDismissed;
        public static global::GoogleMobileAds.Ump.Android.ConsentFormClient Instance => null;

        public ConsentFormClient() : base((string)null)
        {
        }

        public void Load(global::System.Action onFormLoaded, global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> onError)
        {
        }

        public void Show(global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> onDismissed)
        {
        }

        public void LoadAndShowConsentFormIfRequired(global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> onDismissed)
        {
        }

        public void ShowPrivacyOptionsForm(global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> onDismissed)
        {
        }

        public void onConsentFormDismissed(global::UnityEngine.AndroidJavaObject error)
        {
        }
    }
}