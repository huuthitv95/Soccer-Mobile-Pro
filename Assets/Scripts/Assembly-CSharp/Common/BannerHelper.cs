namespace Common
{
    public class BannerHelper
    {
        public enum WindowBannerState
        {
            NoWindow = 0,
            WindowNoBanner = 1,
            WindowWithBanner = 2
        }

        private global::Common.BannerHelper.WindowBannerState windowBannerState;
        private bool viewState;
        public void SetViewBannerState(bool showBanner, bool enableSponsorAD)
        {
        }

        public void SetWindowBannerState(global::Common.BannerHelper.WindowBannerState windowBannerState)
        {
        }

        private void CheckBannerStatus(bool enableSponsorAD)
        {
        }
    }
}