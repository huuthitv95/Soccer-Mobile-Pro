public class LeaveMatchStateMachine : HFSM<TimelinePlayerControler, string>
{
    private const float Walk1SkipTimer = 5.01f;
    private const float Walk2SkipTimer = 5.01f;
    private const float EndSkipTimer = 18f;
    private const float FistBumpFinishNormalizedTime = 0.98f;
    private const float FistBumpFallbackTimer = 8.2f;
    private static bool forceCompleteShutdown;
    private float timer;
    private global::UnityEngine.Vector3 pos;
    private bool isFistBumpState;
    private ScreenTimeTracker screenTimeTracker;
    private bool IsLeader => false;

    public LeaveMatchStateMachine(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void Start(bool isWin, TimelineType type)
    {
    }

    public override void Update(float elapseSeconds, float realElapseSeconds)
    {
    }

    private void CompleteShutdown()
    {
    }

    private void ShutdownOtherLeaveTimelines()
    {
    }

    private void OnShutdown()
    {
    }

    public override void Shutdown()
    {
    }
}