namespace GoogleMobileAds.Mediation.UnityAds.Android
{
    public class UnityAdsClient : global::GoogleMobileAds.Mediation.UnityAds.Common.IUnityAdsClient
    {
        private const string UNITY_PLAYER_CLASS_NAME = "com.unity3d.player.UnityPlayer";
        private const string UNITY_ADS_METADATA_CLASS_NAME = "com.unity3d.ads.metadata.MetaData";
        private static global::GoogleMobileAds.Mediation.UnityAds.Android.UnityAdsClient instance;
        public static global::GoogleMobileAds.Mediation.UnityAds.Android.UnityAdsClient Instance => null;

        private UnityAdsClient()
        {
        }

        public void SetConsentMetaData(string key, bool metaDataValue)
        {
        }
    }
}