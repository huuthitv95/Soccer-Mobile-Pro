public class Win_RedeemWithMatch : global::Common.WindowBase
{
    private enum RedeemState
    {
        Pending = 0,
        InProgress = 1,
        Complete = 2,
        Expired = 3
    }

    private struct RedeemConfig
    {
        public int HomeTeamId;
        public int AwayTeamId;
        public long MatchTimestamp;
        public int Reward;
        public string Code;
        public long StartTimestamp;
        public long EndTimestamp;
    }

    private const string RedeemArchiveKeyPrefix = "wc_redeem_code_";
    private const int RedeemCodeLength = 8;
    private static readonly char[] MatchDateTrimChars;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject pendingNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject inProgressNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject completeNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject expireNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRedeem;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text expireCountDown;
    [global::UnityEngine.SerializeField]
    private GUITeam homeTeam;
    [global::UnityEngine.SerializeField]
    private GUITeam awayTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchTime;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchDate;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text rewardCount;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField redeemCodeInput;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image countDownBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color[] countDownBgColors;
    private Win_RedeemWithMatch.RedeemConfig currentConfig;
    private Win_RedeemWithMatch.RedeemState currentState;
    private global::UnityEngine.Transform matchInfoNode;
    private global::UnityEngine.Transform countDownNode;
    private int matchInfoSiblingIndex;
    private int countDownSiblingIndex;
    private bool hasConfig;
    private void Awake()
    {
    }

    public static bool HasValidConfig()
    {
        return false;
    }

    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    public override void OnUpdate(float deltaTime)
    {
    }

    private void Refresh()
    {
    }

    private void UpdateState()
    {
    }

    private void UpdateExpireCountDown(Win_RedeemWithMatch.RedeemState state)
    {
    }

    private Win_RedeemWithMatch.RedeemState GetRedeemState()
    {
        return Win_RedeemWithMatch.RedeemState.Pending;
    }

    private void ApplyState(Win_RedeemWithMatch.RedeemState state)
    {
    }

    private void ApplySharedNodeParent(Win_RedeemWithMatch.RedeemState state)
    {
    }

    private void OnRedeemClick()
    {
    }

    private static bool TryLoadConfig(out Win_RedeemWithMatch.RedeemConfig config, bool logError = true)
    {
        config = default;
        return false;
    }

    private static bool TeamExists(int teamId)
    {
        return false;
    }

    private bool IsRedeemed(Win_RedeemWithMatch.RedeemConfig config)
    {
        return false;
    }

    private bool IsRedeemTimeOpen()
    {
        return false;
    }

    private string GetRedeemArchiveKey(Win_RedeemWithMatch.RedeemConfig config)
    {
        return null;
    }

    private static bool IsValidRedeemCode(string code)
    {
        return false;
    }

    private static bool IsRedeemCodeChar(char value)
    {
        return false;
    }

    private global::System.DateTime ToLocalTime(long timestamp)
    {
        return default;
    }

    private void ShowTips(string message)
    {
    }
}