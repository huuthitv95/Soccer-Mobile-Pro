public class LeaveMatchStateHalfMachine : HFSM<TimelinePlayerControler, string>
{
    private float timer;
    private global::UnityEngine.Vector3 pos;
    private ScreenTimeTracker screenTimeTracker;
    private static LeaveMatchStateHalfMachine leader;
    public LeaveMatchStateHalfMachine(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public override void Kill()
    {
    }

    private void OnShutdonw()
    {
    }

    public void Start(bool isWin, TimelineType type)
    {
    }

    public override void Update(float elapseSeconds, float realElapseSeconds)
    {
    }

    public override void Shutdown()
    {
    }
}