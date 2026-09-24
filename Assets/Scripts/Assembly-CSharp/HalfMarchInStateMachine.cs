public class HalfMarchInStateMachine : HFSM<TimelinePlayerControler, string>
{
    private float timer;
    private global::UnityEngine.Vector3 StartPos;
    private global::UnityEngine.Quaternion StartQuotation;
    private static HalfMarchInStateMachine leader;
    public HalfMarchInStateMachine(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void Start()
    {
    }

    public override void Kill()
    {
    }

    private void OnShutdonw()
    {
    }

    public override void Shutdown()
    {
    }
}