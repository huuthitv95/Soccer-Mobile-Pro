public class TimelineMgr : MatchListener, IMatchCameraSwitchHandler
{
    private int championId;
    private bool substitutedOutTipShown;
    public int leaveTimelineStep;
    public global::UnityEngine.Transform runAnimBone;
    public global::UnityEngine.Transform walk_leave_normalBone;
    public global::UnityEngine.Transform lookAtTarget;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Animator TimelineCamera;
    public static TimelineMgr Instance;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject timelineUI;
    public global::UnityEngine.GameObject linesMenSubstitution;
    public global::UnityEngine.GameObject redCardProto;
    public global::UnityEngine.GameObject yellowCardProto;
    private IMatch _aiMatch;
    public StartTimelineEvent BeforeTimelineOver;
    public StartTimelineEvent OnTimelineOver;
    public StartTimelineEvent OnTimelineStart;
    public global::System.Collections.Generic.List<TimelinePlayerControler> PlayerCtrs;
    [global::UnityEngine.SerializeField]
    private TestSample aiMatch;
    private global::UnityEngine.UI.Button btnSkip;
    public bool SkipReplay;
    private global::UnityEngine.Coroutine co;
    private float timer;
    private bool scored;
    private bool needInjureTimeline;
    private int assaultedPlayerId;
    private int InjuredPlayer;
    public global::System.Collections.Generic.List<global::EngineMessages.SwtichPlayer> SwtichPlayerDatas;
    public global::UnityEngine.Transform CameraTransform => null;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;
    public TimelineType CurrentType { get; set; }

    private void OnHalfTime(AISampleBase aISampleBase)
    {
    }

    private bool ShouldShowSubstitutedOutTip(AISampleBase aISampleBase)
    {
        return false;
    }

    private void TryShowSubstitutedOutTip(AISampleBase aISampleBase)
    {
    }

    public bool TryShowSubstitutedOutTipBeforeStatistics(AISampleBase aISampleBase, global::System.Action onClosed)
    {
        return false;
    }

    private bool ShowSubstitutedOutTip(bool isRedCardSentOff, global::System.Action onClosed = null)
    {
        return false;
    }

    private void SkipMatchPresentationAfterSubstitutedOutTipClosed()
    {
    }

    private void HideSubstitutedOutTip(bool withAnim)
    {
    }

    private void OnFullTime(AISampleBase aISampleBase)
    {
    }

    private void CheckChampionId()
    {
    }

    public void NotifyAllPlayerLeaveField()
    {
    }

    public void SetCameraAnimationEnable(bool enable)
    {
    }

    public void PlayCameraAnimation(string anim)
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public void NoticeTimelineOver(TimelineType type)
    {
    }

    private void Awake()
    {
    }

    private void Update()
    {
    }

    private void ShowSkipMatchBtn(string pos)
    {
    }

    private void ShowRequestSubstitutionBtn(PlayerCareerInMatchManager playerCareerManager)
    {
    }

    private void ShowVideoBtn()
    {
    }

    private bool ShowRestoreStaminaBtn(bool cehckFatigues = true)
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

    private void HideSkipMatchBtn()
    {
    }

    private void TimelineStart()
    {
    }

    private void StartMatchStartSubInTimeline()
    {
    }

    private void OnMatchStateChange(AIMatchState from, AIMatchState to)
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public void StartSubstitutionTimeline(global::System.Collections.Generic.List<global::EngineMessages.SwtichPlayer> datas)
    {
    }

    private void SkipTimeline()
    {
    }

    public void OnCameraSwitch(GameCameraManager.CameraMode mode)
    {
    }

    public global::UnityEngine.Camera GetCamera()
    {
        return null;
    }

    public override void PreDestroy(IMatch match)
    {
    }

    public override void OnMatchDestroy(IMatch match)
    {
    }

    public void PauseCameraAnim()
    {
    }

    public void ResumeCameraAnim()
    {
    }
}