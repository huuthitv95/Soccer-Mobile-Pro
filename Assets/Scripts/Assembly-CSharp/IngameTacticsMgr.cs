public class IngameTacticsMgr : MatchListener, IFLHandler
{
    public class IngameTacticsData
    {
        public AISampleBase AIMatch;
        public int UserSubstitutionsCounter;
        public global::System.Collections.Generic.List<InGamePlayer> UserPendingOutPlayer;
        public global::System.Collections.Generic.List<int> UserPendingInPlayer;
        public int OppSubstitutionsCounter;
        public global::System.Collections.Generic.List<InGamePlayer> OppPendingOutPlayer;
        public const int limit = 5;
        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> toBeConfirmedMsg;
        public bool canRestoreStamina;
        public int userTeamId;
        private bool needShowEnergyEffct;
        private bool showEnergyEffctForAllTeams;
        public static global::System.Action OnChangeBallTaker;
        public static int currentPenalty;
        public static int currentFreeKick;
        public static int currentCornerL;
        public static int currentCornerR;
        public static bool needRequestChangeBallTaker;
        public void RestoreStamina(bool restoreBothTeams = false)
        {
        }

        public bool CheckShowEnergyEffct()
        {
            return false;
        }

        public static global::EngineMessages.RestartBallTaker GenerateBallTakerMsg(TeamsData team, AISampleBase aimatch, PlayerDisciplineDatabase disciplineDatabase)
        {
            return null;
        }

        public static void RequestChangeBallTaker(int teamid, TeamsData team, AISampleBase aimatch, PlayerDisciplineDatabase disciplineDatabase, bool notify = true)
        {
        }

        public static void DelayedRequestChangeBallTaker(int teamid, TeamsData team, AISampleBase aimatch, PlayerDisciplineDatabase disciplineDatabase)
        {
        }
    }

    public TestSample AiMatch;
    [global::UnityEngine.SerializeField]
    private GUIAutoSwitchPlayerTip autoSwitchTip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup messageBoard;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup injuredMessageBoard;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> oldFormation;
    private global::System.Collections.Generic.List<ClubPlayer> oldPlayerOrder;
    private global::System.Collections.Generic.List<int> latestStarter;
    public IngameTacticsMgr.IngameTacticsData data;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> pendingResult;
    private SubstitutionChecker UserSubstitutionChecker;
    private SubstitutionChecker AISubstitutionChecker;
    private bool DelayCheckChangeFormation;
    private float checkTimer;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> OrgFormation;
    private TeamsData User;
    private TeamsData Opp;
    private float matchDuration;
    private global::UnityEngine.Events.UnityAction OnMatchResume;
    private bool backgroundRequest;
    private float timer;
    private float tipTimer;
    private float tipInterval;
    private global::System.Collections.Generic.List<int> homePenaltyScore;
    private global::System.Collections.Generic.List<int> awayPenaltyScore;
    private global::UnityEngine.Coroutine injureCoroutine;
    private ClubPlayer injuredPlayer;
    private InGamePlayer foulPlayer;
    private const float MaxSlidingInjuryValuePerMatch = 10f;
    private float team1CurrentSlidingInjuryValue;
    private float team2CurrentSlidingInjuryValue;
    private float lastSlidedTime;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;

    public void SwitchGKForAITeamSendOff()
    {
    }

    public void SwitchGKForMyTeamSendOff()
    {
    }

    public void RestoreStamina(bool restoreBothTeams = false)
    {
    }

    public bool CanRestoreStamina()
    {
        return false;
    }

    public void OpenSwitchPlayerWindow(global::EngineMessages.AllFatigues fatigue)
    {
    }

    private void CheckRequestChangeFormation()
    {
    }

    private void RequestChangeFormation(int teamId, TeamsData team)
    {
    }

    private void RequestSwitchPlayer(int teamId, InGamePlayer quit, InGamePlayer enter)
    {
    }

    private bool CheckRequestSwitchPlayer()
    {
        return false;
    }

    public override void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    private void OnWindowClose()
    {
    }

    public void OpenFormationView()
    {
    }

    private void Start()
    {
    }

    private void OnSwitchPlayer(global::EngineMessages.SwtichPlayer msg)
    {
    }

    private void Update()
    {
    }

    private void CheckDelayChangeFormation()
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public bool CanRequestPlayerDeparture(int playerId)
    {
        return false;
    }

    private bool TryGetPlayerDeparturePlayers(int playerId, bool validateRequest, out InGamePlayer outPlayer, out InGamePlayer inGamePlayer)
    {
        outPlayer = null;
        inGamePlayer = null;
        return false;
    }

    private bool IsPendingSubstitutionPlayer(int playerId)
    {
        return false;
    }

    private void HandlePlayerDeparture(global::FLMessageSystem.IngameMessages.RequestPlayerDeparture msg)
    {
    }

    void IFLHandler.OnFLClientMessage(FLClientOpCode opCode, object content)
    {
    }

    public override void OnUpdate(IMatch match)
    {
    }

    private void OnUpdate3()
    {
    }

    private void OnUpdate2()
    {
    }

    private void OnUpdate1()
    {
    }

    private void OnTimelineOver(TimelineType type)
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public override void OnSaveShnapsot(global::Srv.ClientMatchSnapshot archive)
    {
    }

    public override void OnLoadShnapsot(global::Srv.ClientMatchSnapshot archive)
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }
}