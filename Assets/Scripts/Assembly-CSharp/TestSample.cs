public class TestSample : global::UnityEngine.MonoBehaviour, IMatch, ReplayHandler
{
    private class StartMatchHelper
    {
        private AISampleBase.AISampleCallBack aISampleCallBack;
        private TestSample owner;
        public global::System.Collections.IEnumerator CheatAction()
        {
            return null;
        }

        public global::System.Collections.IEnumerator Init()
        {
            return null;
        }

        public StartMatchHelper(TestSample owner, AISampleBase.AISampleCallBack aISampleCallBack)
        {
        }

        public global::System.Collections.IEnumerator OnStartAI()
        {
            return null;
        }
    }

    private class MomentChallengeStartFlow
    {
        private enum State
        {
            None = 0,
            WaitClose = 1,
            Completed = 2
        }

        private TestSample.MomentChallengeStartFlow.State state;
        private global::FL.MomentChallenge.ChallegeTarget challegeTarget;
        private global::FLDataTable.MomentChallengeLevelConfig currentLevel;
        public bool CheckPauseAI(AISampleBase aiSample)
        {
            return false;
        }

        public MomentChallengeStartFlow()
        {
        }

        public MomentChallengeStartFlow(global::FLDataTable.MomentChallengeLevelConfig levelConfig)
        {
        }

        public void CheckGoal(AISampleBase aISample)
        {
        }
    }

    private struct ShotLogger
    {
        private bool enable;
        private EventLog.Param[] parameters;
        private TestSample match;
        public void OnShotResult(global::EngineMessages.ShootEvent message)
        {
        }

        public ShotLogger(TestSample match)
        {
            enable = false;
            parameters = null;
            this.match = null;
        }
    }

    [global::UnityEngine.SerializeField]
    private DebugPreset presetDebug;
    public MatchReplay matchReplay;
    [global::UnityEngine.SerializeField]
    private StadiumDecoration stadiumDecoration;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform climate;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSetting;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.GameObject uiCanvas;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button.ButtonClickedEvent OnReplayBtnClilk;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform highlightUI;
    public static bool videoBtnState;
    [global::UnityEngine.SerializeField]
    private AISampleBase _aiSample;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<global::EngineMessages.FrameDetail> m_frameUpdator;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<global::Common.PlayerBoneHolder[, ]> m_playerUpdators;
    private global::UnityEngine.Rect recordingRect;
    private global::UnityEngine.Rect recordingDotRect;
    private global::UnityEngine.GUIStyle recStyle;
    private global::UnityEngine.GUIStyle reddotStyle;
    [global::UnityEngine.SerializeField]
    private UIPlayingStyle playingStyle;
    public bool enablePlayingStyle;
    [global::UnityEngine.SerializeField]
    private UIPlayingStyle oppoPlayingStyle;
    [global::UnityEngine.SerializeField]
    private PlayingStyleMarker playingStyleMarker;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform scoreboardNode;
    private NormalMatchScoreboard normalMatchScoreboard;
    private TestSample.ShotLogger shotLogger;
    private PlayerPassEvent playerPassEvent;
    private bool debugReplay;
    private bool waitPauseStatistics;
    private bool lastTouchInputState;
    private bool controllerDisconnectPausedMatch;
    public static int lastActiveOfUserTimes;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text momentChallengeTargetText;
    private TestSample.MomentChallengeStartFlow momentChallengeStartFlow;
    private bool marchInOver;
    private bool showingTeach;
    private float uiCameraDepth;
    private bool showInjured;
    private int timelineFrameCounter;
    private string[] fomationInUse;
    private char[] timeString;
    private int qualityValue;
    private int qualityRecordCount;
    private float lastQualityUpdateTime;
    private int lastTime;
    private global::System.Collections.Generic.List<Win_Statistics.MatchStatistics> matchStatistics;
    private byte[] lastMatchSnapshot;
    private global::System.Collections.Generic.List<global::EngineMessages.SwtichPlayer> SwtichPlayerCache;
    public global::System.Action OnSwitchPlayerFinish;
    private bool gameOver;
    private global::System.Action OnStatisticsReceived;
    private global::System.Action<global::EngineMessages.MatchStatistics> MatchStatisticsMerger;
    public bool Ishalftime;
    private bool goalKickoffFlag;
    private global::System.Action penaltyLeaveAction;
    private bool aiGameOver;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> sendoffPlayers;
    private int _pauseTime;
    private AudioAdTrigger.OnceOnlyTrigger audioAdTrigger;
    private static bool ShowInterstitialAfterReplay;
    private static bool Match_goalInterstitial;
    private int matchGoalAdCounter;
    private int matchReplayAdCounter;
    private static string replayUIName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image[] bgBar;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<bool> m_OnShowHideRadar;
    private float timePassed;
    private int m_FrameCount;
    private int currAIStyle;
    private int currSelfAIStyle;
    private AIPlayingStyleSetting aIPlayingStyleSetting;
    private bool poped;
    public AISampleBase aiSample => null;
    private int UserTeamId => 0;
    private int OpponentId => 0;
    private IMatchManager MatchManager => null;
    private CupMatchBase matchData => null;
    public static bool EnablesMatchSnapshot => false;
    public float lerp_t { get; private set; }
    public int MatchElapsedTime => 0;
    public float TargetGoalNet { get; private set; }
    public float HomeGoalNet { get; private set; }
    private bool ClearReady { get; set; }
    public GamePlayType gamePlayType => GamePlayType.Normal;

    public event global::System.Action<global::EngineMessages.FrameDetail> frameUpdator
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public event global::System.Action<global::Common.PlayerBoneHolder[, ]> playerUpdators
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public event global::System.Action<bool> OnShowHideRadar
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    private void Awake()
    {
    }

    public void ClearVideoRAM()
    {
    }

    private bool IsPlayerCareerMatchSetting()
    {
        return false;
    }

    private void OnStatisticsResumeAction()
    {
    }

    private void OnStatisticsSettingAction()
    {
    }

    private void OnStatisticsQuitAction()
    {
    }

    private void OnStatisticsFormationAction()
    {
    }

    private void StartMatch()
    {
    }

    private void Start()
    {
    }

    private void CheckQuitMatch()
    {
    }

    private void QuitMatchAction()
    {
    }

    private void ConstructRecordIcon()
    {
    }

    private void OnTimelineStart(TimelineType type)
    {
    }

    private void BeforeTimelineOver(TimelineType type)
    {
    }

    private void OnTimelineOver(TimelineType type)
    {
    }

    private void SendActiveEvent()
    {
    }

    private void OnApplicationQuit()
    {
    }

    private void OnGUI()
    {
    }

    public void ApplyPlayerTexture(global::UnityEngine.GameObject gameObject, ClubPlayer player)
    {
    }

    private string GetTimeString(int minute, int second)
    {
        return null;
    }

    private void UpdateFrame(global::EngineMessages.FrameDetail frameDetail)
    {
    }

    public void HideSocreBoard()
    {
    }

    public void HideTimeBG()
    {
    }

    public void ShowScoreBoard()
    {
    }

    public void PlayScoreBoardTween()
    {
    }

    private void UpdateScoreboard()
    {
    }

    private void ShowStoppageTime(int minutes)
    {
    }

    public void SaveClientSnapshot()
    {
    }

    private void SaveSnapshot(byte[] buff)
    {
    }

    private void SaveSnapshot(global::Common.GameMessage message)
    {
    }

    private void OnSwitchPlayer(global::EngineMessages.SwtichPlayer msg)
    {
    }

    private void HandleSwitchPlayer(global::System.Collections.Generic.List<global::EngineMessages.SwtichPlayer> datas)
    {
    }

    private void HandleSendOffPlayerWhenSwitch(global::EngineMessages.SwtichPlayer msg, InGamePlayer quit)
    {
    }

    public void FakeSimulateMatch()
    {
    }

    private void OnStartSimulation(in global::FLMessageSystem.IngameMessages.SimulatedMatchMessage simulated)
    {
    }

    private void OnStartSimulation()
    {
    }

    private void OnSimulationEnd(in global::FLMessageSystem.IngameMessages.SimulatedMatchMessage simulated)
    {
    }

    private Win_Statistics OpenStatisticsWin()
    {
        return null;
    }

    private void OnPreMatchSimulationStart(in global::FLMessageSystem.IngameMessages.SimulatedMatchMessage simulated)
    {
    }

    public void RequestEnableInjure(int teamId)
    {
    }

    private void OnMatchFinish(bool ShowHighlight)
    {
    }

    private void SettleMatchInfo()
    {
    }

    private void OnReciveMatchStatistics(global::EngineMessages.MatchStatistics statistics)
    {
    }

    private void ReceiveMessage(AISampleBase.MessageBuffer message)
    {
    }

    private void HandleMessage(AISampleBase.MessageBuffer message)
    {
    }

    private void OnDestroy()
    {
    }

    private void OnApplicationPause(bool pause)
    {
    }

    public void Pause()
    {
    }

    public void Resume()
    {
    }

    public void OnReplayStart()
    {
    }

    public void ShowUI(bool Show)
    {
    }

    public void UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail)
    {
    }

    public void UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public static void MarkShowInterstitialAfterReplay()
    {
    }

    public static void ClearPendingReplayInterstitial()
    {
    }

    private void CheckShowReplayInstersitial()
    {
    }

    public void OnReplayEnd()
    {
    }

    private global::System.Collections.IEnumerator FakeFinishMatchCo(bool win)
    {
        return null;
    }

    public void FakeFinishMatch(bool win)
    {
    }

    public void LoadDebugReplayUI()
    {
    }

    private void SetUpForSpecialCup(CupMatchBase match)
    {
    }

    public static void OnSwitchCameraModel(IMatch aimatch, InGameCameraModel from, InGameCameraModel to, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    public void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel to, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    private void ShowRadar(bool show)
    {
    }

    private void OnGameOptionChange(in global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage msg)
    {
    }

    private void OnInputPauseRequested(int slotId)
    {
    }

    private void OnControllerConnectionChanged(int slotId, bool connected)
    {
    }

    private void ResumeAfterControllerReconnect()
    {
    }

    private void ReturnToMainAfterControllerDisconnect()
    {
    }

    private void TryOpenPauseMenu()
    {
    }

    private void OnPlayingStyleChanged(int ps)
    {
    }

    private void OnOppoPlayingStyleChanged(int ps)
    {
    }

    private void Update()
    {
    }

    public void ChecckResumeFromSnapshot()
    {
    }

    public void UpdateCaptainArmband()
    {
    }

    public void OnReplayReset()
    {
    }

    private int GetTimeSlot(int sec)
    {
        return 0;
    }

    private int GetAIGDTag()
    {
        return 0;
    }

    private void UpdateAIPlayingStyle()
    {
    }

    private void updatePlayingStylePopUp()
    {
    }
}