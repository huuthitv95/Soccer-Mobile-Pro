public class AISampleBase : global::UnityEngine.MonoBehaviour
{
    public delegate bool CheckReplayMethod(ref global::EngineMessages.InputData eventList);
    internal class AISampleCallBack
    {
        public global::System.Func<global::System.Collections.IEnumerator> cheatAction;
        public global::System.Func<global::System.Collections.IEnumerator> init;
        public global::System.Func<global::System.Collections.IEnumerator> OnStartAI;
        public global::System.Func<global::System.Collections.IEnumerator> OnAIReady;
        public global::System.Func<bool> CheckPause;
        public global::System.Action OnLogic;
        public global::System.Action<int> OnFrameEnd;
        public global::System.Action<AISampleBase.MessageBuffer> HandleMessages;
        public global::System.Action<AISampleBase.MessageBuffer> ReceiveMessage;
        public AISampleBase.CheckReplayMethod checkReplay;
        public global::System.Action<global::EngineMessages.InputData> RecordReplay;
        public global::System.Action<global::EngineMessages.InputData> HandleInput;
        public global::System.Action<global::EngineMessages.MatchStatistics> ReciveMatchStatistics;
    }

    internal class MessageBuffer
    {
        public OpCode opcode { get; set; }
        public object content { get; set; }
    }

    private struct NextFrameDelegates
    {
        private global::System.Action nextFrameDelegates;
        private global::System.Action currnetFrameDelegates;
        public void CheckNextFrameDelegates()
        {
        }

        public void Add(global::System.Action action)
        {
        }
    }

    public enum RestoreProgressState
    {
        None = 0,
        Start = 1,
        Over = 2
    }

    public GameCameraManager gameCameraManager;
    public global::UnityEngine.Transform _ball;
    public GoalNet[] _goalNets;
    public TouchInputSystem touchInput;
    public KeyboardInputSystem keyboardInput;
    public MatchMessagesCenter MatchMessagesCenter;
    public bool ForceFeedbackSildeInput;
    public global::UnityEngine.Transform[] goalCenter;
    private global::System.Collections.Generic.List<IFLHandler> Handlers;
    public global::FLMessageSystem.MessageSystem IngameMessageSystem;
    public MatchStatisticsData statisticsData;
    public PlayerCareerInMatchManager PlayerCareerInMatchManager;
    public global::UnityEngine.Transform stadiumLight;
    private IngameLoader ingameLoader;
    public global::Common.Event<global::EngineMessages.PrepareSetPieceEvent> OnPrepareSetPieceOver;
    public global::Common.Event<global::EngineMessages.AllFatigues> OnPushFatigue;
    public global::Common.Event<global::EngineMessages.SwtichPlayer> OnSwitchedPlayer;
    public DeferredAction DeferredPlayerVisibilityRestore;
    private static global::Common.PlayerBoneHolder _playerSkins;
    public AIConfig aiConfig;
    [global::UnityEngine.HideInInspector]
    public global::Common.PlayerBoneHolder[, ] players;
    public int StarterPlayerCount;
    private global::EngineMessages.MatchPhase currentMatchPhase;
    public int[] Socres;
    public int[] PenaltyScores;
    public int[] DesignatedTeamPossessionPlayerIds;
    public InGameTeamData[] inGameTeams;
    public global::System.Collections.Generic.Dictionary<int, InGamePlayer> inGamePlayerIndex;
    public global::System.Func<string, string> ButtonStringLoader;
    public global::System.Collections.Generic.HashSet<string> disabledButtons;
    public int[] UserPossessionPlayerIds;
    public bool UseProCameraWhenCareerDebug;
    private AIMatchState _currentState;
    public AIMatchStateChangeEvent StateChangeEvent;
    private bool isStop;
    public bool running;
    private bool _isDisconnected;
    private global::System.Collections.Generic.Queue<AISampleBase.MessageBuffer> messages;
    private int receivedFrameCount;
    private int requestFrameCount;
    private int requestFrameCount_plus;
    private int playedFrameCount;
    private AISampleBase.AISampleCallBack aISampleCallBack;
    private global::EngineMessages.MatchPhase m_startPhase;
    private global::EngineMessages.InputData eventList;
    private global::EngineMessages.MatchTimestamp lastMatchTimestamp;
    private bool enableInput;
    private global::System.Collections.Generic.Queue<int> homePossessionRecord;
    private const float aiframeDt = 0.01f;
    private global::Common.VelocityCalculator ballVelocityCalculator;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private OnBallHoderPlayerChangeAction m_OnBallHoderPlayerChange;
    private AISampleBase.NextFrameDelegates nextFrameDelegates;
    public IMatch host { get; private set; }
    public MatchInputRouter MatchInput { get; private set; }
    public bool Destroyed { get; private set; }
    public int matchId { get; set; }
    public int matchVersion { get; set; }
    public FullPlayerStatisticsChecker fullPlayerStatisticsChecker { get; private set; }
    public global::UnityEngine.Transform UICanvas { get; private set; }
    public static global::Common.PlayerBoneHolder playerSkins => null;
    public int UserTeamId { get; private set; }
    public int OpponentId { get; private set; }
    public float lerp_t => 0f;
    public global::EngineMessages.MatchPhase CurrentMatchPhase => global::EngineMessages.MatchPhase.PreMatch;
    public int OffensiveTeam { get; set; }
    public bool Offensive => false;
    public bool FaceRight { get; private set; }
    public InGamePlayer[][] inGamePlayers { get; set; }
    public bool IsPlayerCareerMatch => false;
    public AIMatchState PreviousState { get; private set; }

    public AIMatchState CurrentState
    {
        get
        {
            return AIMatchState.NotStart;
        }

        set
        {
        }
    }

    public bool isStopMatch => false;
    private bool ClearReady { get; set; }
    public bool isReplay { get; private set; }
    public static float deltaTime { get; private set; }
    public static float time { get; private set; }
    public bool EnableInput => false;
    public int LastScorePlayerId { get; set; }
    public int LastAssistPlayerId { get; set; }
    public int LastScoreTeamid { get; set; }
    public bool OwnGoal { get; set; }
    public int BallHoldingTeam { get; protected set; }
    public int BallHoldingPlayer { get; protected set; }
    public InGamePlayer BallHoldingPlayerObject { get; protected set; }
    public int LastBallHoldingPlayer { get; protected set; }
    public InGamePlayer LastBallHoldingPlayerObject { get; protected set; }
    public int LastBallHoldingTeam { get; protected set; }
    public global::UnityEngine.Vector2 BallXZPosition => default;
    public bool BallInDefensiveHalf => false;
    public global::System.Collections.Generic.IEnumerable<int> HomePossessionRecord => null;
    public global::UnityEngine.Vector3 BallVelocity => default;
    public AISampleBase.RestoreProgressState RestoreProgress { get; private set; }
    public int MatchTime { get; private set; }
    public bool HasMatchSnapshot => false;

    public event OnBallHoderPlayerChangeAction OnBallHoderPlayerChange
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

    public void AddHandler(IFLHandler handler)
    {
    }

    public void RemoveHandler(IFLHandler handler)
    {
    }

    public void OnFLClientMessage(FLClientOpCode opCode, object content)
    {
    }

    public void SendFLMessage(FLClientOpCode opCode, object content)
    {
    }

    public void PrepareDestroy()
    {
    }

    public InGamePlayer getPlayerById(int id)
    {
        return null;
    }

    public InGamePlayer getPlayerByClubPlayerId(int id)
    {
        return null;
    }

    public bool IsPlayerSuspended(int pid)
    {
        return false;
    }

    public InGamePlayer[] GetInGamePlayers(int teamid)
    {
        return null;
    }

    private void Update()
    {
    }

    public InGamePlayer GetNearestGamePlayerToPosition(int teamId, global::UnityEngine.Vector3 ballPos, bool ignoreBallCarrier = false, bool checkDir = false)
    {
        return null;
    }

    public InGamePlayer GetNearestGamePlayerToPosition(global::UnityEngine.Vector3 ballPos, bool ignoreBallCarrier = false)
    {
        return null;
    }

    public global::UnityEngine.Transform GetGoalByTeamId(int teamid)
    {
        return null;
    }

    public global::UnityEngine.Transform GetNearestPlayerToBall(int teamId)
    {
        return null;
    }

    public global::UnityEngine.Transform GetNearestPlayerToPosition(int teamId, global::UnityEngine.Vector3 ballPos)
    {
        return null;
    }

    public global::System.Collections.Generic.List<InGamePlayer> GetPlayersByAITeamId(int id)
    {
        return null;
    }

    public void OnAwake(global::System.Action<AISampleBase> InitPlayersAction, AIConfig aiConfig)
    {
    }

    public void Init(int UserTeamId, int OpponentId, IMatch host)
    {
    }

    public void EnablePlayerCareerDebug(bool useProCamera)
    {
    }

    private void HandleHighPriorityMessage(AISampleBase.MessageBuffer msg)
    {
    }

    public global::System.Collections.IEnumerator StopMatch(global::System.Action callback)
    {
        return null;
    }

    internal void RunAI(global::System.Func<global::EngineMessages.MatchConfig> matchConfig, AISampleBase.AISampleCallBack callBack)
    {
    }

    private void OnServerDisconnectHandler(string reason)
    {
    }

    private global::System.Collections.IEnumerator Run(global::System.Func<global::EngineMessages.MatchConfig> matchConfig, AISampleBase.AISampleCallBack callBack)
    {
        return null;
    }

    public void AppendInputMessage(OpCode opcode, global::Google.Protobuf.IMessage message)
    {
    }

    private void RequestData(int needFrameCount)
    {
    }

    private void HandleAllFrame(global::EngineMessages.FrameDetail frameDetail)
    {
    }

    internal void AddFullFrameListener(MatchMessagesCenter.OnFullFrames updateFullFrame)
    {
    }

    private void ReceiveMessage(global::Common.GameMessage message)
    {
    }

    public global::UnityEngine.Vector2 GetTeamAttackDirection(int team)
    {
        return default;
    }

    public global::UnityEngine.Vector2 GetBallHoldingTeamAttackDirection()
    {
        return default;
    }

    private void RecordBallPos()
    {
    }

    private void OnMatchPhaseChanged(global::EngineMessages.MatchPhase matchPhase)
    {
    }

    private global::FLMessageSystem.IngameMessages.CommonIngamePlayerMessage HandleMessage(AISampleBase.MessageBuffer message)
    {
        return null;
    }

    public void RequestPlayerOff(int playerid)
    {
    }

    public void MarkMatchTimeToFinish()
    {
    }

    private void OnTeamOffDefTransition(global::EngineMessages.IntValues data)
    {
    }

    private void OnDesignatedTeamPossessionPlayerChanged(global::EngineMessages.IntValues data)
    {
    }

    public T GetAIMatchListener<T>()
        where T : MatchListener
    {
        return null;
    }

    private void OnDestroy()
    {
    }

    public int GetLeaderId()
    {
        return 0;
    }

    public global::UnityEngine.GameObject InstantiatePlayer()
    {
        return null;
    }

    public void ResetConfig()
    {
    }

    public void AddTimelineStartListener(global::UnityEngine.Events.UnityAction<TimelineType> l)
    {
    }

    public void RemoveTimelineStartListener(global::UnityEngine.Events.UnityAction<TimelineType> l)
    {
    }

    public void AddTimelineEndListener(global::UnityEngine.Events.UnityAction<TimelineType> l)
    {
    }

    public void RemoveTimelineEndListener(global::UnityEngine.Events.UnityAction<TimelineType> l)
    {
    }

    public void AddBeforeTimelineOver(global::UnityEngine.Events.UnityAction<TimelineType> l)
    {
    }

    public void RemoveBeforeTimelineOver(global::UnityEngine.Events.UnityAction<TimelineType> l)
    {
    }

    public bool HasNextPhase()
    {
        return false;
    }

    public void SimulateMatchEnd()
    {
    }
}