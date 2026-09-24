public class MatchReplayManager : MatchListener, ReplayHandler, IMatchCameraSwitchHandler
{
    private enum ReplayStep
    {
        Recording = 0,
        AdditionalRecording = 1,
        WaitCelebration = 2,
        Playing = 3
    }

    private class FoulReplayTrigger : MatchReplayManager.MatchReplayTrigger
    {
        private int playerid;
        private global::UnityEngine.Transform player;
        private IMatch aiMatch;
        private global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector3> playersPosition;
        private bool SkipReplay;
        private int foulFrame;
        private bool showCard;
        public FoulReplayTrigger(MatchReplayManager mgr, IMatch aiMatch) : base(mgr)
        {
        }

        private void OnTimelineOver(TimelineType type)
        {
        }

        private void OnTimelineStart(TimelineType type)
        {
        }

        public override void CheckConstraint(OpCode code, object message, IMatch match)
        {
        }

        public void DoReplay(IMatch match, bool waitStand)
        {
        }

        private global::System.Collections.IEnumerator WaitInjuredMsg(IMatch match, bool waitStand)
        {
            return null;
        }

        private global::System.Collections.IEnumerator Replay(IMatch match, bool waitStand)
        {
            return null;
        }

        public override void Reset()
        {
        }

        public override void Update(float dt)
        {
        }
    }

    private class GoalTrigger : MatchReplayManager.MatchReplayTrigger
    {
        private global::UnityEngine.Vector3 pos;
        private global::UnityEngine.Transform goalPlayer;
        private int goalPlayerId;
        private bool isUser;
        private int goalTime;
        private bool isPenalty;
        private bool isCorner;
        public GoalTrigger(MatchReplayManager mgr) : base(mgr)
        {
        }

        public override void CheckConstraint(OpCode code, object message, IMatch match)
        {
        }

        public override void Update(float dt)
        {
        }

        public override void Reset()
        {
        }

        private void StartReplay(IMatch match)
        {
        }

        private global::System.Collections.IEnumerator Replay(IMatch match)
        {
            return null;
        }

        public void SaveGoalHighlight(IMatch match)
        {
        }

        private bool checkIsPenalty()
        {
            return false;
        }

        private global::System.Collections.IEnumerator Penalty(IMatch match)
        {
            return null;
        }

        private global::System.Collections.IEnumerator LongRange(IMatch match)
        {
            return null;
        }
    }

    private class OffsideReplayTrigger : MatchReplayManager.MatchReplayTrigger
    {
        private float posX;
        private int time;
        private global::UnityEngine.Transform player;
        public OffsideReplayTrigger(MatchReplayManager mgr) : base(mgr)
        {
        }

        public override void CheckConstraint(OpCode code, object message, IMatch match)
        {
        }

        public void DoReplay(IMatch match)
        {
        }

        private global::System.Collections.IEnumerator ShowLine(IMatch match)
        {
            return null;
        }

        private global::System.Collections.IEnumerator Replay(IMatch match)
        {
            return null;
        }

        public override void Reset()
        {
        }

        public override void Update(float dt)
        {
        }
    }

    private abstract class MatchReplayTrigger
    {
        protected MatchReplayManager mgr;
        public abstract void CheckConstraint(OpCode code, object message, IMatch match);
        public abstract void Update(float dt);
        public abstract void Reset();
        public MatchReplayTrigger(MatchReplayManager mgr)
        {
        }

        protected void CheckShootSlowShot(global::System.Collections.Generic.LinkedListNode<ReplayFrameData> data)
        {
        }

        protected global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.LinkedListNode<ReplayFrameData>, global::System.Collections.Generic.LinkedListNode<ReplayFrameData>> CalculateGoalReplayRange(float endOffset)
        {
            return default;
        }

        protected void SetUpTargetGroup(global::UnityEngine.Transform ball, global::UnityEngine.Transform shootPlayer)
        {
        }

        protected global::System.Action<global::System.Collections.Generic.LinkedListNode<ReplayFrameData>> LookAtWeightLerp()
        {
            return null;
        }

        protected global::System.Collections.IEnumerator GoalCameraReplay(IMatch match, global::UnityEngine.Vector3 SidelinePosition, global::UnityEngine.Transform ShootPlayer, float offset)
        {
            return null;
        }

        private void CheckCameraLimit(global::System.Collections.Generic.LinkedListNode<ReplayFrameData> frame, global::System.Action<global::System.Collections.Generic.LinkedListNode<ReplayFrameData>> OnStep)
        {
        }

        protected global::System.Collections.IEnumerator GoalCameraReplay(IMatch match, global::UnityEngine.Vector3 SidelinePosition, global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.LinkedListNode<ReplayFrameData>, global::System.Collections.Generic.LinkedListNode<ReplayFrameData>> Range, global::UnityEngine.Transform lookat, global::System.Action<global::System.Collections.Generic.LinkedListNode<ReplayFrameData>> OnStep)
        {
            return null;
        }

        protected global::UnityEngine.Transform GetSuitableGoalnet(float x, IMatch match)
        {
            return null;
        }

        protected global::System.Collections.IEnumerator KickoffCircleCameraReplay(IMatch match, global::UnityEngine.Vector3 SidelinePosition, global::UnityEngine.Transform goalPlayer)
        {
            return null;
        }

        protected global::System.Collections.IEnumerator GoalpostCameraReplay(IMatch match, global::UnityEngine.Transform goalPlayer, global::UnityEngine.Vector3 SidelinePosition, bool isShoot)
        {
            return null;
        }

        protected global::System.Collections.Generic.List<int> CheckInessentialPlayer(global::UnityEngine.Vector3 cameraPos, global::UnityEngine.Vector3 dir, global::UnityEngine.Vector3 targetPlayer, global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector3> playersPosition = null)
        {
            return null;
        }

        protected float CheckCover(global::UnityEngine.Vector3 dir, global::UnityEngine.Vector3 org, global::UnityEngine.Vector3 targetPlayer, global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector3> playersPosition = null)
        {
            return 0f;
        }

        protected global::UnityEngine.Vector3 CheckBoundary(global::UnityEngine.Vector3 pos)
        {
            return default;
        }

        protected global::System.Collections.IEnumerator PlayerBackCameraReplay(IMatch match, int goalPlayerId, global::UnityEngine.Vector3 SidelinePosition, global::UnityEngine.Transform goalPlayer, bool isShoot)
        {
            return null;
        }

        protected global::System.Collections.IEnumerator CloseRange(IMatch match, int goalPlayerId, global::UnityEngine.Vector3 SidelinePosition, global::UnityEngine.Transform goalPlayer, bool isShoot)
        {
            return null;
        }
    }

    private class ShootReplayTrigger : MatchReplayManager.MatchReplayTrigger
    {
        private enum States
        {
            Start = 0,
            FreeKick = 1,
            Pass = 2,
            Shoot = 3,
            OverSide = 4
        }

        private MatchReplayManager.ShootReplayTrigger.States FreeKick_ShootState;
        private MatchReplayManager.ShootReplayTrigger.States normalShootState;
        private float timer;
        private global::System.Collections.Generic.LinkedListNode<ReplayFrameData> start;
        private global::System.Collections.Generic.LinkedListNode<ReplayFrameData> end;
        private global::UnityEngine.Vector3 pos;
        private global::UnityEngine.Transform goalPlayer;
        private int goalPlayerId;
        private int shootTeam;
        private bool touchGoalpost;
        public ShootReplayTrigger(MatchReplayManager mgr) : base(mgr)
        {
        }

        public override void CheckConstraint(OpCode code, object message, IMatch match)
        {
        }

        public override void Update(float dt)
        {
        }

        private void ReplayFreekickShoot(IMatch match)
        {
        }

        private void ReplayNormalShoot(IMatch match)
        {
        }

        private global::System.Collections.IEnumerator ReplayFreekickShoot(IMatch match, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> start, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> end)
        {
            return null;
        }

        private global::System.Collections.IEnumerator NormalShoot(IMatch match)
        {
            return null;
        }

        public void SaveShootHighlight(IMatch match, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> start, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> end, global::UnityEngine.Vector3 shootPos, global::UnityEngine.Transform shootPlayer)
        {
        }

        public override void Reset()
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject uiRoot;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnShowSkip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNextAngleView;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.Camera[] cameras;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.Camera[] camerasMirror;
    [global::UnityEngine.SerializeField]
    private TestSample _msgCenter;
    private global::UnityEngine.Camera selectCamera;
    private MatchReplayManager.ReplayStep step;
    private global::System.Collections.Generic.LinkedList<ReplayFrameData> messages;
    private float celebrateDuration;
    private global::UnityEngine.Vector3 playerPos;
    private static float aiframeDt;
    private global::UnityEngine.Coroutine co;
    private float ReplaySpeed;
    private bool isPause;
    private int currentRandomIndex;
    private IMatch match;
    private global::UnityEngine.Vector3? lastBallPos;
    private global::System.Action ReplayAction;
    private bool needChangeVideoType;
    private float skipCountdown;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera mainCamera;
    [global::UnityEngine.SerializeField]
    private global::Cinemachine.CinemachineVirtualCamera goalCamera;
    [global::UnityEngine.SerializeField]
    private global::Cinemachine.CinemachineVirtualCamera kickoffCircle;
    [global::UnityEngine.SerializeField]
    private global::Cinemachine.CinemachineVirtualCamera goalpostCamera;
    [global::UnityEngine.SerializeField]
    private global::Cinemachine.CinemachineVirtualCamera playerBackCamera;
    [global::UnityEngine.SerializeField]
    private global::Cinemachine.CinemachineTargetGroup TargetGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.LineRenderer offsideLine;
    [global::UnityEngine.SerializeField]
    private global::Cinemachine.CinemachineVirtualCamera offsideCamera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject tempGo;
    private global::System.Collections.Generic.List<MatchReplayManager.MatchReplayTrigger> replayTriggers;
    private global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector3> playersPosition;
    private float duration => 0f;
    private global::UnityEngine.Vector3 Target => default;
    public override ReplayHandler GetReplayHandler => null;
    public int ReplayFrameCount => 0;
    public static global::UnityEngine.Camera Camera { get; private set; }
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;

    private void Start()
    {
    }

    private void UpdateFullFrame(global::EngineMessages.FrameDetail frameDetail)
    {
    }

    private void OnPrepareSetPieceOver(global::EngineMessages.PrepareSetPieceEvent prepareSetPiece)
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    private global::System.Collections.IEnumerator WaitAdditionalRecording()
    {
        return null;
    }

    public void DebugReplay()
    {
    }

    public void DoReplay(global::System.Collections.Generic.LinkedListNode<ReplayFrameData> start, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> end)
    {
    }

    private global::System.Collections.IEnumerator Replay(IMatch match, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> start, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> end)
    {
        return null;
    }

    private global::System.Collections.IEnumerator WaitSplash(global::System.Action fadein = null)
    {
        return null;
    }

    private global::System.Collections.IEnumerator StopReplay(IMatch match)
    {
        return null;
    }

    private void StopReplay()
    {
    }

    public void SkipActiveReplayImmediately(bool clearPendingInterstitial = false)
    {
    }

    private global::System.Collections.IEnumerator DoReplay(IMatch match, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> start, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> end, global::System.Action<global::System.Collections.Generic.LinkedListNode<ReplayFrameData>> action = null, global::System.Func<global::System.Collections.Generic.LinkedListNode<ReplayFrameData>, global::System.Collections.IEnumerator> eAction = null)
    {
        return null;
    }

    public void StartReplayCamera()
    {
    }

    private void SwitchReplayCameraAngle()
    {
    }

    public void ShowReplayUI()
    {
    }

    private void HideReplayUI()
    {
    }

    public void StopRelayCamera()
    {
    }

    public void UpdateCamera(bool smooth = true)
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    private global::System.Collections.Generic.LinkedListNode<ReplayFrameData> CalculateOffset(global::System.Collections.Generic.LinkedListNode<ReplayFrameData> data, int offset)
    {
        return null;
    }

    private void OnTimelineOver(TimelineType type)
    {
    }

    private void SkipReplay()
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }

    private void Update()
    {
    }

    public global::System.Collections.Generic.LinkedListNode<ReplayFrameData> FindKeyFramLast(global::System.Collections.Generic.LinkedListNode<ReplayFrameData> start, global::System.Func<ReplayFrameData, bool> condition)
    {
        return null;
    }

    private global::System.Collections.Generic.LinkedListNode<ReplayFrameData> RemoveNeedless(global::System.Collections.Generic.LinkedListNode<ReplayFrameData> start, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> end)
    {
        return null;
    }

    private global::System.Collections.Generic.LinkedListNode<ReplayFrameData> RemoveNeedless(global::System.Collections.Generic.LinkedListNode<ReplayFrameData> start, global::System.Collections.Generic.LinkedListNode<ReplayFrameData> end, global::System.Func<ReplayFrameData, bool> condition)
    {
        return null;
    }

    public override void OnUpdate(IMatch match)
    {
    }

    private void ShowVideoBtn()
    {
    }

    private void ShowSkipMatchBtn()
    {
    }

    private void ShowRequestSubstitutionBtn(PlayerCareerInMatchManager playerCareerManager)
    {
    }

    private void HideSkipMatchBtn()
    {
    }

    private bool ShowRestoreStaminaBtn()
    {
        return false;
    }

    private void HideRestoreStaminaBtn()
    {
    }

    private bool ShowBoostMoraleBtn()
    {
        return false;
    }

    private void HideBoostMoraleBtn()
    {
    }

    void ReplayHandler.OnReplayStart()
    {
    }

    void ReplayHandler.UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail)
    {
    }

    void ReplayHandler.OnReplayEnd()
    {
    }

    void ReplayHandler.UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
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

    public ReplayFrameData GetReplayFrameDataAt(int index)
    {
        return null;
    }

    public global::EngineMessages.FrameDetail GetReplayFrameAt(int index)
    {
        return default;
    }

    private void Awake()
    {
    }

    public void CheckConstraint(OpCode code, object message, IMatch match)
    {
    }
}