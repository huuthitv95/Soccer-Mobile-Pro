namespace FL.SponsorAD
{
    public class SponsorADManager : global::Common.Singleton<global::FL.SponsorAD.SponsorADManager>
    {
        private const string InterstitialDateKey = "sponsor_interstitial_date";
        private const string InterstitialCountKey = "sponsor_interstitial_count";
        private int sponsorAdPlan;
        private int startDate;
        private int endDate;
        private int dailyInterstitialLimit;
        private global::FL.SponsorAD.SponsorBanner sponsorBanner;
        private global::FL.SponsorAD.SponsorInterstitial sponsorInterstitial;
        public static bool HasShownInterstitial => false;
        public bool Enable => false;
        public bool CanShowInterstitial => false;
        public global::System.Collections.Generic.List<int> ADBoardGroupIds => null;

        public void SetSponsorAdConfig(string config)
        {
        }

        private bool IsEnabledOnDate(int date)
        {
            return false;
        }

        private int GetDailyInterstitialCount(int date)
        {
            return 0;
        }

        private void EnsureSponsorAD()
        {
        }

        public void ShowBanner(global::System.Action openedAction)
        {
        }

        public void HideBanner()
        {
        }

        public bool ShowInterstitial(string pos, global::System.Action openedAction, global::System.Action closedAction)
        {
            return false;
        }
    }
}