public class AITestMatchRunner
{
    private class MessageBuffer
    {
        public OpCode opcode { get; set; }
        public object content { get; set; }
    }

    private const float FrameTime = 0.01f;
    private const int FinalStatisticsTimeoutMilliseconds = 3000;
    private readonly global::System.Collections.Generic.Queue<AITestMatchRunner.MessageBuffer> _messages;
    private readonly global::System.Collections.Generic.List<global::EngineMessages.InputMessage> _pendingInputMessages;
    private readonly int[] _scores;
    private readonly int[] _designatedTeamPossessionPlayerIds;
    private readonly int[] _penaltyChanceCounts;
    private readonly int[] _penaltyGoalCounts;
    private readonly int[] _successfulDribbleCounts;
    private readonly bool[] _pendingPenaltySetPiece;
    private readonly global::System.Collections.Generic.Dictionary<int, AITestRuntimePlayer> _runtimePlayerIndex;
    private AITestModeConfig _config;
    private global::EngineMessages.InputData _eventList;
    private global::EngineMessages.MatchConfig _matchConfig;
    private AITestRuntimePlayer[][] _runtimePlayers;
    private global::EngineMessages.MatchPhase _currentMatchPhase;
    private global::EngineMessages.GameMode _currentGameMode;
    private int _setPieceTeamId;
    private bool _clearReady;
    private bool _running;
    private float _timer;
    private int _receivedFrameCount;
    private int _requestFrameCount;
    private int _requestFrameCountPlus;
    private int _playedFrameCount;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<global::EngineMessages.FrameDetail, float> m_FrameUpdated;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action m_InputStateChanged;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<AITestRuntimePlayer> m_BallHoldingPlayerChanged;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<AITestRuntimePlayer> m_PreSwitchPlayerChanged;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<OpCode, global::EngineMessages.IntValues> m_ScCommEvent;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<global::EngineMessages.MatchStatistics> m_GameOver;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<global::EngineMessages.ShootEvent> m_ShootEventOccurred;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<global::EngineMessages.PassEvent> m_PassEventOccurred;
    private int _ffTotalMsgsReceived;
    public AITestRuntimePlayer BallHoldingPlayerObject { get; private set; }
    public AITestModeConfig Config => null;
    public global::EngineMessages.MatchPhase CurrentMatchPhase => global::EngineMessages.MatchPhase.PreMatch;
    public global::EngineMessages.GameMode CurrentGameMode => global::EngineMessages.GameMode.Normal;
    public int SetPieceTeamId => 0;
    public int BallHoldingPlayer { get; private set; }
    public int PreSwitchPlayer { get; private set; }
    public int BallHoldingTeam { get; private set; }
    public int MatchTime { get; private set; }
    public int OffensiveTeam { get; private set; }
    public int OpponentTeamId { get; private set; }
    public int StarterPlayerCount => 0;
    public int UserTeamId { get; private set; }
    public bool IsRunning => false;
    public float DeltaTime { get; private set; }
    public int[] DesignatedTeamPossessionPlayerIds => null;
    public int[] Scores => null;
    public int[] PenaltyChanceCounts => null;
    public int[] PenaltyGoalCounts => null;
    public int[] SuccessfulDribbleCounts => null;
    public int PressInputCount { get; private set; }
    public int TeamPressInputCount { get; private set; }
    public int SwitchPlayerInputCount { get; private set; }

    public event global::System.Action<global::EngineMessages.FrameDetail, float> FrameUpdated
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

    public event global::System.Action InputStateChanged
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

    public event global::System.Action<AITestRuntimePlayer> BallHoldingPlayerChanged
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

    public event global::System.Action<AITestRuntimePlayer> PreSwitchPlayerChanged
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

    public event global::System.Action<OpCode, global::EngineMessages.IntValues> ScCommEvent
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

    public event global::System.Action<global::EngineMessages.MatchStatistics> GameOver
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

    public event global::System.Action<global::EngineMessages.ShootEvent> ShootEventOccurred
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

    public event global::System.Action<global::EngineMessages.PassEvent> PassEventOccurred
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

    public void EnqueueInputMessage(OpCode opcode, global::Google.Protobuf.IMessage message)
    {
    }

    public void Initialize(AITestModeConfig config, global::EngineMessages.MatchConfig matchConfig, AITestTeamDataConfig homeTeam, AITestTeamDataConfig awayTeam)
    {
    }

    public AITestRuntimePlayer GetPlayerByClubPlayerId(int id)
    {
        return null;
    }

    public AITestRuntimePlayer GetPlayerById(int id)
    {
        return null;
    }

    public global::System.Collections.IEnumerator Run(global::System.Action<global::EngineMessages.InputData> collectInput, global::System.Func<float> deltaTimeProvider)
    {
        return null;
    }

    public global::System.Collections.IEnumerator FastForwardRender(global::System.Action<global::EngineMessages.InputData> collectInput, int batchesPerYieldParam = 25)
    {
        return null;
    }

    private static float TicksToMs(long ticks)
    {
        return 0f;
    }

    private static float TicksToMs(double ticks)
    {
        return 0f;
    }

    public void Stop()
    {
    }

    private void HandleFrameDetail(global::EngineMessages.FrameDetail frameDetail)
    {
    }

    private void HandleMessage(AITestMatchRunner.MessageBuffer message)
    {
    }

    private void InitRuntimePlayers(AITestTeamDataConfig homeTeam, AITestTeamDataConfig awayTeam)
    {
    }

    private void OnDesignatedTeamPossessionPlayerChanged(global::EngineMessages.IntValues data)
    {
    }

    private void OnMatchPhaseChanged(global::EngineMessages.MatchPhase matchPhase)
    {
    }

    private void OnMatchScoreChanged(global::EngineMessages.MatchScoreChanged matchScore)
    {
    }

    private void UpdateScoresFromGameOver(global::EngineMessages.GameOver gameOver)
    {
    }

    private void OnPossessionPlayerChanged(global::EngineMessages.IntValues data)
    {
    }

    private void OnNextSwitchPlayerChanged(global::EngineMessages.IntValues data)
    {
    }

    private void OnTeamOffDefTransition(global::EngineMessages.IntValues data)
    {
    }

    private void OnStartSetPieceEvent(global::EngineMessages.StartSetPieceEvent setPieceEvent)
    {
    }

    private void OnStopSetPieceEvent()
    {
    }

    private void OnDribbleSuccess(global::EngineMessages.IntValues data)
    {
    }

    private void ProcessMessages(int needUpdateFrame)
    {
    }

    private global::EngineMessages.MatchStatistics RequestFinalStatistics()
    {
        return null;
    }

    private void ReceiveMessage(global::Common.GameMessage message)
    {
    }

    private void RecordInputStatistics(global::EngineMessages.InputData inputData)
    {
    }

    private static bool IsTeamIdValid(int teamId)
    {
        return false;
    }

    private void RequestData(int needFrameCount, global::System.Action<global::EngineMessages.InputData> collectInput)
    {
    }

    private void ResetRuntimeState()
    {
    }
}