public class AITestMode : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private string _configName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform _ball;
    [global::UnityEngine.SerializeField]
    private GoalNet[] _goalNets;
    [global::UnityEngine.SerializeField]
    private global::Common.PlayerBoneHolder _playerPrefab;
    [global::UnityEngine.SerializeField]
    private AutoInputSystem _autoInput;
    [global::UnityEngine.SerializeField]
    private AITestSimpleCameraFollow _cameraFollow;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform _preSwitchFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color _teammateColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color _opponentColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color _selectedMarkerColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color _preSwitchFlagColor;
    private readonly global::System.Collections.Generic.Dictionary<int, global::Common.PlayerBoneHolder> _playerBoneIndex;
    private AITestModeConfig _config;
    private AITestFrameRenderer _frameRenderer;
    private AITestMatchRunner _runner;
    private AITestMatchLogger _logger;
    private global::UnityEngine.Coroutine _runCoroutine;
    private global::Common.PlayerBoneHolder[, ] _players;
    private global::Common.PlayerBoneHolder _ballHoldingPlayerBone;
    private global::Common.PlayerBoneHolder _preSwitchPlayerBone;
    private global::UnityEngine.Transform _selectedPlayerMarker;
    private int _preSwitchPlayerId;
    private bool _showTacticUI;
    private bool _showResult;
    private bool _showBatchSummary;
    private bool _batchMode;
    private int _batchCount;
    private int _batchesPerYield;
    private int _currentBatchMatch;
    private global::System.Collections.Generic.List<int[]> _batchResults;
    private int _selectedStrategyIndex;
    private static readonly string[] StrategyNames;
    private static readonly string[] StrategyDescriptions;
    private bool _paramsSynced;
    private float _paramA_D_shoot;
    private float _paramA_D_avoid;
    private float _paramA_Y_mid;
    private float _paramB_D_shoot;
    private float _paramB_D_detect;
    private float _paramB_detect_angle;
    private float _paramB_Y_sideline;
    private float _paramB_inner_cut_angle;
    private int _paramB_cut_duration;
    private float _paramC_D_shoot;
    private float _paramC_D_avoid;
    private float _paramC_Y_mid;
    private string _exportMessage;
    private float _exportMessageShowTime;
    public global::UnityEngine.Transform BallTransform => null;
    public global::UnityEngine.Transform FollowTarget => null;
    public global::Common.PlayerBoneHolder BallHoldingPlayerBone => null;
    public GoalNet[] GoalNets => null;
    public global::EngineMessages.MatchPhase CurrentMatchPhase => global::EngineMessages.MatchPhase.PreMatch;
    public global::EngineMessages.GameMode CurrentGameMode => global::EngineMessages.GameMode.Normal;
    public int SetPieceTeamId => 0;
    public global::Common.PlayerBoneHolder[, ] Players => null;
    public int BallHoldingPlayer => 0;
    public int BallHoldingTeam => 0;
    public int MatchTime => 0;
    public int OffensiveTeam => 0;
    public int OpponentTeamId => 0;
    public int StarterPlayerCount => 0;
    public int UserTeamId => 0;
    public bool IsRunning => false;
    public float DeltaTime => 0f;

    private void Update()
    {
    }

    private void OnGUI()
    {
    }

    private void DrawTacticUI()
    {
    }

    private void DrawStrategyParameters(int strategyIndex)
    {
    }

    private void SyncParametersFromAutoInput()
    {
    }

    private void ApplyParametersToAutoInput()
    {
    }

    private void DrawMatchScoreboard()
    {
    }

    private void DrawSingleResult()
    {
    }

    private void DrawBatchSummary()
    {
    }

    private void DrawScoreLine(float areaWidth)
    {
    }

    private static void FullScreenBackdrop()
    {
    }

    private static void DialogBackground(float x, float y, float w, float h)
    {
    }

    private void OnDestroy()
    {
    }

    private void Awake()
    {
    }

    private void OnApplicationQuit()
    {
    }

    public void StartMatch()
    {
    }

    public global::UnityEngine.Vector2 GetTeamAttackDirection(int team)
    {
        return default;
    }

    public void StopMatch()
    {
    }

    private void CollectInput(global::EngineMessages.InputData eventList)
    {
    }

    private void InitBall()
    {
    }

    private void InitInput()
    {
    }

    private void InitPlayers(AITestTeamDataConfig homeTeam, AITestTeamDataConfig awayTeam)
    {
    }

    private void InitRuntimePlayers(AITestTeamDataConfig homeTeam, AITestTeamDataConfig awayTeam)
    {
    }

    private void OnBallHoldingPlayerChanged(AITestRuntimePlayer player)
    {
    }

    private void OnScCommEvent(OpCode code, global::EngineMessages.IntValues data)
    {
    }

    private void OnGameOver(global::EngineMessages.MatchStatistics finalStatistics)
    {
    }

    private void OnFrameUpdated(global::EngineMessages.FrameDetail frameDetail, float deltaTime)
    {
    }

    private void SubscribeRunner()
    {
    }

    private void UnsubscribeRunner()
    {
    }

    private void StopRunningMatch()
    {
    }

    private void UpdateInputState()
    {
    }

    private void ClearPlayers()
    {
    }

    private void CorrectInputWithCamera(global::EngineMessages.InputData eventList)
    {
    }

    private global::UnityEngine.Transform GetInputCameraTransform()
    {
        return null;
    }

    private void HideFlagStick(global::Common.PlayerBoneHolder player)
    {
    }

    private void ApplyTeamColor(global::Common.PlayerBoneHolder player, global::UnityEngine.Color color)
    {
    }

    private void EnsureSelectedPlayerMarker()
    {
    }

    private void EnsurePreSwitchFlag()
    {
    }

    private void HidePreSwitchFlag()
    {
    }

    private void OnPreSwitchPlayerChanged(AITestRuntimePlayer player)
    {
    }

    private void UpdateSelectedPlayerMarker(global::EngineMessages.FrameDetail frameDetail)
    {
    }

    private void UpdatePreSwitchFlag(global::EngineMessages.FrameDetail frameDetail)
    {
    }
}