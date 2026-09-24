namespace GoogleMobileAds.Mediation.AppLovin.Android
{
    public class AppLovinClient : global::GoogleMobileAds.Mediation.AppLovin.Common.IAppLovinClient
    {
        private static readonly global::GoogleMobileAds.Mediation.AppLovin.Android.AppLovinClient instance;
        private const string appLovinSdkClassName = "com.applovin.sdk.AppLovinSdk";
        private const string appLovinPrivacySettingsClassName = "com.applovin.sdk.AppLovinPrivacySettings";
        private const string UnityActivityClassName = "com.unity3d.player.UnityPlayer";
        public static global::GoogleMobileAds.Mediation.AppLovin.Android.AppLovinClient Instance => null;

        private AppLovinClient()
        {
        }

        public void SetHasUserConsent(bool hasUserConsent)
        {
        }

        public void SetDoNotSell(bool doNotSell)
        {
        }

        private global::UnityEngine.AndroidJavaObject getCurrentActivityAndroidJavaObject()
        {
            return null;
        }
    }
}