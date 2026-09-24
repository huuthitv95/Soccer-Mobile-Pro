public class AdsManager : global::Common.Singleton<AdsManager>
{
    public enum BannerPosition
    {
        Top = 0,
        Bottom = 1,
        TopLeft = 2,
        TopRight = 3,
        BottomLeft = 4,
        BottomRight = 5,
        Center = 6
    }

    public enum InterstitialMode
    {
        Normal = 0,
        Tidy = 1,
        Count = 2
    }

    public enum PromotePosition
    {
        mailBox = 0,
        match_end = 1,
        appopen = 2,
        count = 3
    }

    public struct PromoteProjectItem
    {
        public string simpleName;
        public string fullName;
        public string mailBoxTrackerToken;
        public string matchEndTrackerToken;
        public string appopenTrackerToken;
        public AdsManager.PromotePosition Position;
        public int projectIdx;
        public PromoteProjectItem(string simple, string full, string mailToken, string interstitialToken, string endToken, AdsManager.PromotePosition position, int project_idx)
        {
            simpleName = null;
            fullName = null;
            mailBoxTrackerToken = null;
            matchEndTrackerToken = null;
            appopenTrackerToken = null;
            Position = AdsManager.PromotePosition.mailBox;
            projectIdx = 0;
        }
    }

    private const string AdmobFirstDayEarnSaveKey = "earn_newltv";
    private const string MaxFirstDayEarnSaveKey = "max_earn_newltv";
    public bool Hacked;
    private bool _Initialed;
    private readonly float InterstitialInterval;
    private global::System.DateTime lastInterstitialTime;
    public global::System.DateTime LastShowAdTime;
    public static readonly AdsManager.PromoteProjectItem[] projectItems;
    public static AdsManager.PromoteProjectItem currentPromoteProject;
    public static float AppopenFillRate;
    public static float InterstitialFillRate;
    public static bool InterstitialFirstTimeDisplayed { get; set; }
    public static int InterstitialInputAccumulator { get; set; }
    public static float InterstitialFrequencyAccumulator { get; set; }
    public static float InterstitialFrequencyAccumulatorForRetry { get; set; }

    public bool EnableAD()
    {
        return false;
    }

    public void Init()
    {
    }

    public int GetAdsCodeId()
    {
        return 0;
    }

    public bool WatchVideo(global::System.Action successAction, global::System.Action failExtra, string log)
    {
        return false;
    }

    public void LoadRewardAdH()
    {
    }

    public bool IsRewardAdLoaded()
    {
        return false;
    }

    public void ShowBanner(string from, bool enableSponsor, AdsManager.BannerPosition position = AdsManager.BannerPosition.Bottom)
    {
    }

    public void HideBanner(AdsManager.BannerPosition position = AdsManager.BannerPosition.Bottom, bool onlyAdmob = false)
    {
    }

    public float GetBannerHeightInPixels()
    {
        return 0f;
    }

    public bool IsInterstitialLoaded(AdsManager.InterstitialMode mode)
    {
        return false;
    }

    public bool ShowInterstitialAd(AdsManager.InterstitialMode mode, string from, global::System.Action successAction = null, global::System.Action noSafeClosed = null, bool ignoreInterval = false)
    {
        return false;
    }

    public void CloseNativeOverlayAd()
    {
    }

    public global::System.Collections.IEnumerator DelayShowNativeOverlayAd(AdsManager.InterstitialMode mode, string from, global::System.Action successAction = null, global::System.Action noSafeClosed = null)
    {
        return null;
    }

    public global::System.Collections.IEnumerator DelayShowInterstitialAd(AdsManager.InterstitialMode mode, string from, global::System.Action successAction = null, global::System.Action noSafeClosed = null)
    {
        return null;
    }

    public static void SendLimitCountEventToAdsPlatform(string eventName, string AajustTrackerCode, int limitCount)
    {
    }

    public static void RecordLimitAdsCountLog(string eventName)
    {
    }

    public static void RecordMixedLimitAdsCountLog(string LimitEventName)
    {
    }

    private static int GetFirstDayEarnedValue()
    {
        return 0;
    }

    public static string GetTrackerToken()
    {
        return null;
    }

    public static void RecordFirstCompleteEventCountLog(string LimitEventName)
    {
    }
}