public class Win_ChallengeTip : global::Common.WindowBase
{
    private enum TipType
    {
        Normal = 0,
        Rewind = 1,
        CoinReward = 2,
        PlayerTip = 3,
        SignPlayer = 4,
        ClaimReward = 5,
        ChooseTeam = 6,
        Medal = 7,
        Goods = 8,
        Team = 9,
        Points = 10,
        PC_CoinReward = 11,
        Count = 12
    }

    [global::System.Serializable]
    private struct ColorGraphicConfig
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Text[] Titles;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Text[] Contents;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Text[] Buttons1;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Text[] Buttons2;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image[] ButtonImages1;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image[] ButtonImages2;
        public void ApplyColorConfig(Win_ChallengeTip.ColorConfig config, Win_ChallengeTip.TipType type)
        {
        }
    }

    [global::System.Serializable]
    private struct ColorConfig
    {
        public global::UnityEngine.Color TitleColor;
        public global::UnityEngine.Color TitleColor2;
        public global::UnityEngine.Color ContentColor;
        public global::UnityEngine.Color ButtonTextColor1;
        public global::UnityEngine.Color ButtonTextColor2;
        public global::UnityEngine.Color ButtonImageColor1;
        public global::UnityEngine.Color ButtonImageColor2;
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text _title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform[] nodes;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject iconClose;
    [global::UnityEngine.SerializeField]
    private Win_ChallengeTip.ColorGraphicConfig colorGraphicConfig;
    [global::UnityEngine.SerializeField]
    private Win_ChallengeTip.ColorConfig colorConfig;
    public override void OnClosing()
    {
    }

    public Win_ChallengeTip ShowMedal()
    {
        return null;
    }

    public Win_ChallengeTip ShowGoods(global::UnityEngine.Texture[] icon, global::FL.SmallBuffer4<int> ids, global::System.Action nextAction)
    {
        return null;
    }

    public Win_ChallengeTip ShowTeams(global::System.Collections.Generic.List<TeamsData> teams)
    {
        return null;
    }

    public Win_ChallengeTip ShowClassicTeams(int team)
    {
        return null;
    }

    private global::UnityEngine.Transform ShowNode(Win_ChallengeTip.TipType type)
    {
        return null;
    }

    public void ShowNormal(string title, string content, global::UnityEngine.Events.UnityAction OnConfirm = null, string btnText = null)
    {
    }

    public void ShowRewind(global::System.Action onVideoSucceed, global::System.Action onSkip)
    {
    }

    public void ShowPoint(int reward, global::System.Action onVideoSucceed, global::System.Action OnGet, bool closeable = false, string videoPos = null)
    {
    }

    public void ShowPCCoinReward(int reward, global::System.Action onVideoSucceed, global::System.Action OnGet, bool closeable = false)
    {
    }

    public void ShowCoinReward(int reward, global::System.Action onVideoSucceed, global::System.Action OnGet, bool closeable = false)
    {
    }

    public void ShowPlayerTip()
    {
    }

    public void ShowPlayerTip(ClubPlayer player)
    {
    }

    public void ShowSignPlayer(global::System.Collections.Generic.List<ClubPlayer> players, global::System.Action<ClubPlayer> OnSign)
    {
    }

    private void ApplyColorConfig(Win_ChallengeTip.TipType type)
    {
    }
}