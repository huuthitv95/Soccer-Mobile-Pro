internal class Win_HighlightBanner : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform rt;
    public static bool Showing { get; private set; }

    public static void ShowBanner(string from, bool enableSponsorAD, AdsManager.BannerPosition position = AdsManager.BannerPosition.Bottom)
    {
    }

    public static void HideBanner()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }
}