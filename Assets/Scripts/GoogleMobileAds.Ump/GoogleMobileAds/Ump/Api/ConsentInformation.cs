namespace GoogleMobileAds.Ump.Api
{
    public class ConsentInformation
    {
        private static global::GoogleMobileAds.Ump.Common.IUmpClientFactory _clientFactory;
        internal static global::GoogleMobileAds.Ump.Common.IUmpClientFactory ClientFactory => null;
        public static global::GoogleMobileAds.Ump.Api.ConsentStatus ConsentStatus => global::GoogleMobileAds.Ump.Api.ConsentStatus.Unknown;

        public static void Update(global::GoogleMobileAds.Ump.Api.ConsentRequestParameters request, global::System.Action<global::GoogleMobileAds.Ump.Api.FormError> consentInfoUpdateCallback)
        {
        }

        public static void Reset()
        {
        }
    }
}