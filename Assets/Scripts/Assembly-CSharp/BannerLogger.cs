public class BannerLogger : MonoSingleton<BannerLogger>
{
    private enum BannerPosition
    {
        UI = 0,
        highlight = 1,
        timeline = 2,
        replay = 3,
        Other = 128
    }

    private string currentPosition;
    private global::System.DateTime lastTm;
    private bool enableLog;
    private global::System.DateTime quitTm;
    private BannerLogger.BannerPosition ConvertPosition(string pos)
    {
        return BannerLogger.BannerPosition.UI;
    }

    private void Awake()
    {
    }

    public void LogNeedBanner(string position)
    {
    }

    public void LogShowBanner(string position)
    {
    }

    public void LogHideBanner()
    {
    }

    private void LogDuration(string position)
    {
    }

    private void OnApplicationPause(bool pause)
    {
    }
}