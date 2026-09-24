public class Win_Prematch : global::Common.WindowBase
{
    private const int PlayerCareerStartMatchType = 600;
    private const int TourEventStartMatchTypeBase = 500;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_play;
    [global::UnityEngine.HideInInspector]
    public global::UnityEngine.UI.Button BtnPlay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image btnPlayBG;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image btnPlayIcon;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Button btn_quit;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.GameObject mask;
    [global::UnityEngine.SerializeField]
    public GUITeam UI_home;
    [global::UnityEngine.SerializeField]
    public GUITeam UI_away;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Button btnChooseMyTeam;
    public global::UnityEngine.UI.Button btnChooseOppTeam;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Text round;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnHomeJersey;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnAwayJersey;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnChangeBall;
    [global::UnityEngine.SerializeField]
    private GUICupPreMatch CupPreMatch;
    [global::UnityEngine.SerializeField]
    private GUILeaguePreMatch LeaguePreMatch;
    [global::UnityEngine.SerializeField]
    private GUIFriendlyPreMatch FirendlyPreMatch;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject homePlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject awayPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform weatherNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform timeNode;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform ball;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnChangeStadium;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnDifficulty;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image difficultyIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text difficultyText;
    public IMatchManager mgr;
    public global::UnityEngine.UI.Button btnMatchSetting;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image stadiumBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text stadiumName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject friendlyBtns;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform matchInfoPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image bg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Graphic[] btns;
    [global::UnityEngine.SerializeField]
    public EuropeanCupTheme europeanCupTheme;
    public static global::System.Action OnCupWindowOpenAction;
    private global::UnityEngine.Vector3 homePlayerPos;
    private global::UnityEngine.Vector3 awayPlayerPos;
    private int currentJerseyId;
    private int currentBallId;
    private bool enableAppearanceShop;
    private static readonly global::UnityEngine.Color NormalButtonBGColor;
    private static readonly global::UnityEngine.Color ChallengeButtonBGColor;
    private static readonly global::UnityEngine.Color ChallengeButtonIconColor;
    private static readonly global::UnityEngine.Color NormalButtonIconColor;
    public bool SkipFomationFlag;
    private global::System.Collections.Generic.List<int> homeJerseys;
    private global::System.Collections.Generic.List<int> awayJerseys;
    private static bool StartMatchWithoutPreMatchMark;
    private bool StartMatchMark;
    public override void OnOpen(object parameter)
    {
    }

    public void ChangeHairRQ(int offset = 2)
    {
    }

    private void UpdateWeatherIcon(CupMatchBase match)
    {
    }

    private void UpdateTimeIcon(CupMatchBase match)
    {
    }

    private void OnBtnLockerClick(CupMatchBase match, AppearanceShop.ShopItemType defaultType)
    {
    }

    private int GetUserHomeJerseyId(CupMatchBase match)
    {
        return 0;
    }

    private int GetUserAwayJerseyId(CupMatchBase match)
    {
        return 0;
    }

    private static int GetAppearanceProfileJerseyId(CupMatchBase match, int jerseyId)
    {
        return 0;
    }

    public static void CheckRepeatedPlayer(CupMatchBase match)
    {
    }

    private void UpdateStadiumInfo(CupMatchBase match)
    {
    }

    private void InitDifficultyButton(CupMatchBase match)
    {
    }

    private void RefreshDifficultyButton(IMatchManager matchManager, Win_DifficultyOption.DifficultyMode mode)
    {
    }

    public Win_Prematch Fill(CupMatchBase match, string activityType = null)
    {
        return null;
    }

    public void ResetJersey(CupMatchBase match)
    {
    }

    private void InitializeTourEventJerseys(CupMatchBase match, global::FL.TourEvent.TourEventMatch tourEventMatch)
    {
    }

    private global::System.Collections.Generic.List<int> BuildDefaultHomeJerseyCandidates(CupMatchBase match)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> BuildDefaultAwayJerseyCandidates(CupMatchBase match)
    {
        return null;
    }

    private int GetAlternativeJersey(int selectedJersey, global::System.Collections.Generic.List<int> candidates)
    {
        return 0;
    }

    public void UpdateTeamsInfo(CupMatchBase match, bool isFirstOpen, GUITeam UI_home = null, GUITeam UI_away = null, bool SpecialJersey = true)
    {
    }

    private global::System.Collections.Generic.KeyValuePair<ClubPlayer, ClubPlayer> GetAppearancePlayer(CupMatchBase match)
    {
        return default;
    }

    private void OnEnable()
    {
    }

    private void ResetPlayerPos()
    {
    }

    private void ResetPlayerAction()
    {
    }

    private global::System.Collections.IEnumerator WaitForGameobjectActive(global::UnityEngine.GameObject go, global::UnityEngine.Events.UnityAction action)
    {
        return null;
    }

    public void SetUniformVisible(bool visible)
    {
    }

    public static void StartMatch(CupMatchBase match, global::System.Action OnStartMatch)
    {
    }

    public static void StartMatchWithoutPreMatch(CupMatchBase match)
    {
    }

    public void Update()
    {
    }

    public void ShowPlayer()
    {
    }

    public void HidePlayer()
    {
    }

    private bool HandlePlayerCareerPlay(CupMatchBase match)
    {
        return false;
    }

    public void HandlePlayButtonClick(CupMatchBase match)
    {
    }

    private global::System.Collections.IEnumerator ClearAndStartMatch(CupMatchBase match)
    {
        return null;
    }

    public void StartMatch(CupMatchBase match)
    {
    }

    public override void OnClose()
    {
    }

    public bool CloseWindow()
    {
        return false;
    }

    private void SetUpForSpecialCup(CupMatchBase match)
    {
    }
}