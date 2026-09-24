public class CameraSetting : MatchListener, InputListener, ReplayHandler, IMatchCameraSwitchHandler
{
    private sealed class InputAxes
    {
        public global::EngineMessages.InputEvent Horizontal;
        public global::EngineMessages.InputEvent Vertical;
    }

    public enum MatchCameraMode
    {
        Parallel = 0,
        Vertical = 1,
        Broadcast = 2,
        Dynamic = 3,
        ShortRange = 4,
        LongRange = 5,
        DynamicParallel = 6,
        ProCamera = 7
    }

    public enum CameraDirection
    {
        Forward = 0,
        Back = 1,
        Left = 2,
        Right = 3
    }

    [global::UnityEngine.SerializeField]
    private GameCameraController gameCameraController;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform freekickInputFlag;
    private readonly global::System.Collections.Generic.Dictionary<int, CameraSetting.InputAxes> inputAxesByDevice;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform target;
    private global::UnityEngine.Vector3 offset;
    public static global::UnityEngine.Camera ControlCamera;
    public static CameraSetting Instance;
    private CameraType _cameraType;
    private global::System.Collections.Generic.Stack<CameraType> previousType;
    private CameraSetting.MatchCameraMode currentMode;
    [global::UnityEngine.SerializeField]
    private int team;
    [global::UnityEngine.SerializeField]
    private int teamPos;
    private IMatch aiMatch;
    private IMatch _aiMatch;
    private float offsetScale;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera m_camera;
    private bool useSmooth;
    [global::UnityEngine.SerializeField]
    private float placementRotateSpeed;
    private float placementCameraHeight;
    private bool canRotate;
    private global::UnityEngine.Quaternion placementQuatLeft;
    private global::UnityEngine.Quaternion placementQuatRight;
    private float toBallDis;
    private global::EngineMessages.GameMode currentGameMode;
    private global::UnityEngine.Quaternion Direction;
    private float lenghtLookatPos2Player;
    private global::UnityEngine.Vector3 playerPos;
    private float lengthPos2Player;
    private float maxLengthPos2Player;
    private float minLengthPos2Player;
    private float freekickInput_lenghtLookatPos2Player;
    private global::UnityEngine.Vector3 freekickInput_playerPos;
    private float freekickInput_lengthPos2Player;
    private float freekickInput_maxLengthPos2Player;
    private float freekickInput_minLengthPos2Player;
    private global::UnityEngine.Quaternion freekickInput_Direction;
    private float freekickInput_height;
    private global::System.Action OnTimelineOverAction;
    private global::UnityEngine.Vector2 _lastTouch;
    private bool touchUI;
    private float delayCheckInput;
    private global::System.Action OnKickBall;
    private global::System.Action OnShootKickBall;
    private global::System.Action OnSlideInput;
    private global::EngineMessages.InputFunction pressEvent;
    private bool needUpdate;
    private bool matchLeaveTimeline;
    private global::System.Lazy<ScreenTimeTracker> screenTimeTracker;
    private global::UnityEngine.Coroutine co;
    private bool HandleHighlight;
    private byte m_needImmediateUpdate;
    private bool checkShootOver;
    private int shootStep;
    private CameraType cameraType
    {
        get
        {
            return CameraType.SideMiddle;
        }

        set
        {
        }
    }

    public CameraSetting.MatchCameraMode CurrentMode => CameraSetting.MatchCameraMode.Parallel;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;
    public global::EngineMessages.GameMode CurrentGameMode => global::EngineMessages.GameMode.Normal;
    public CameraSetting.CameraDirection CurrentDir => CameraSetting.CameraDirection.Forward;
    public override InputListener GetInputListener => null;
    public override ReplayHandler GetReplayHandler => null;

    private void NotifyCameraTypeChange(bool OnDisable = false)
    {
    }

    public bool IsProCamera()
    {
        return false;
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private bool IsPlayerCareerMatch(IMatch match)
    {
        return false;
    }

    public void UpdateCloserScale(int mode = -1, bool exitSpecialCamera = false)
    {
    }

    private void Awake()
    {
    }

    private void Start()
    {
    }

    private void OnValidate()
    {
    }

    public void UpdateCamera()
    {
    }

    public void ResetCameraPos()
    {
    }

    public void SetType(CameraType type)
    {
    }

    public void RevertType()
    {
    }

    private void SetTarget()
    {
    }

    public void SetTarget(int teamId, int playerPos)
    {
    }

    private CameraType getLastType()
    {
        return CameraType.SideMiddle;
    }

    public void SetPlacementCamera(global::UnityEngine.Vector3 ballPos, global::UnityEngine.Vector3 target, global::EngineMessages.GameMode mode, bool userControl = false, bool faceLeft = true, int takerid = 0, bool isMy = true)
    {
    }

    private void SetOutsidePenaltyPlayerVisable(bool visable, global::Common.PlayerBoneHolder[, ] players, int teamPlayerCount, bool faceLeft, int takerid = 0)
    {
    }

    public void AdjustCameraHeight(float norOffset)
    {
    }

    private void QuitPlacementCamera()
    {
    }

    private void AdjustFreekickInput(global::UnityEngine.Vector2 dir)
    {
    }

    public void OnPlacementCameraRotate(float offset)
    {
    }

    private global::UnityEngine.Vector2 ConvertLookDirToKickDir()
    {
        return default;
    }

    public void KickBall()
    {
    }

    public void HandleInput(global::EngineMessages.InputData eventlist)
    {
    }

    private void CorrectInputWithCamera(global::EngineMessages.InputData eventlist)
    {
    }

    private void CorrectInputWithCamera(global::EngineMessages.InputEvent horizontal, global::EngineMessages.InputEvent vertical, global::UnityEngine.Vector2 axisX, global::UnityEngine.Vector2 axisY)
    {
    }

    public override void OnUpdate(IMatch match)
    {
    }

    private void LateUpdate()
    {
    }

    public override void OnMatchReset(IMatch match)
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    private void OnSlideInputNotify(object obj)
    {
    }

    public void OnTimelineOver(TimelineType type)
    {
    }

    private void OnTimelineStart(TimelineType type)
    {
    }

    private void OnPrepareSetPieceOver(global::EngineMessages.PrepareSetPieceEvent prepareSetPiece)
    {
    }

    public void OnReplayStart()
    {
    }

    public void UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail)
    {
    }

    public void SetHandleHighlight(bool value)
    {
    }

    public void UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void OnReplayEnd()
    {
    }

    private void MarkNeedImmediateUpdate(byte frames = 5)
    {
    }

    private void UpdateCameraImmed()
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public void OnCameraSwitch(GameCameraManager.CameraMode mode)
    {
    }

    public global::UnityEngine.Camera GetCamera()
    {
        return null;
    }

    public void OnReplayReset()
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }
}