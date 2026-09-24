namespace GoogleMobileAds.Ump.Android
{
    internal class ConsentInformationClient : global::GoogleMobileAds.Ump.Common.IConsentInformationClient
    {
        internal global::GoogleMobileAds.Ump.Android.OnConsentInfoUpdateSuccessListener _onSuccess;
        internal global::GoogleMobileAds.Ump.Android.OnConsentInfoUpdateFailureListener _onFailure;
        private static readonly global::GoogleMobileAds.Ump.Android.ConsentInformationClient _instance;
        private readonly global::UnityEngine.AndroidJavaObject _consentInformation;
        private readonly global::UnityEngine.AndroidJavaObject _activity;
        public static global::GoogleMobileAds.Ump.Android.ConsentInformationClient Instance => null;

        private ConsentInformationClient()
        {
        }

        public void Update(global::GoogleMobileAds.Ump.Api.ConsentRequestParameters request, global::System.Action onConsentInfoUpdateSuccessCallback, global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback)
        {
        }

        public void Reset()
        {
        }

        public int GetConsentStatus()
        {
            return 0;
        }

        public int GetPrivacyOptionsRequirementStatus()
        {
            return 0;
        }

        public bool CanRequestAds()
        {
            return false;
        }

        public bool IsConsentFormAvailable()
        {
            return false;
        }
    }
}