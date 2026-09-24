namespace GoogleMobileAds.Mediation.Mintegral.Android
{
    public class MintegralClient : global::GoogleMobileAds.Mediation.Mintegral.Common.IMintegralClient
    {
        private static global::GoogleMobileAds.Mediation.Mintegral.Android.MintegralClient instance;
        private const string MintegralSDKClassName = "com.mbridge.msdk.MBridgeSDK";
        private const string MintegralSDKFactoryClassName = "com.mbridge.msdk.out.MBridgeSDKFactory";
        private const string MintegralConstantsClassName = "com.mbridge.msdk.MBridgeConstans";
        public static global::GoogleMobileAds.Mediation.Mintegral.Android.MintegralClient Instance => null;

        private MintegralClient()
        {
        }

        public void SetConsentStatus(bool consentStatus)
        {
        }

        public void SetDoNotTrackStatus(bool doNotTrack)
        {
        }

        private global::UnityEngine.AndroidJavaObject getAndroidCurrentActivity()
        {
            return null;
        }

        private int getMintegralConstantFromConsentStatus(bool consentStatus)
        {
            return 0;
        }
    }
}