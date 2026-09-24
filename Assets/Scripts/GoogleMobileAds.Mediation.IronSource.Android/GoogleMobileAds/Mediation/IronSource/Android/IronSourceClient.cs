namespace GoogleMobileAds.Mediation.IronSource.Android
{
    public class IronSourceClient : global::GoogleMobileAds.Mediation.IronSource.Common.IIronSourceClient
    {
        private const string IRONSOURCE_CLASS_NAME = "com.unity3d.mediation.LevelPlay";
        private static global::GoogleMobileAds.Mediation.IronSource.Android.IronSourceClient instance;
        public static global::GoogleMobileAds.Mediation.IronSource.Android.IronSourceClient Instance => null;

        private IronSourceClient()
        {
        }

        public void SetConsent(bool consent)
        {
        }

        public void SetMetaData(string key, string metaDataValue)
        {
        }
    }
}