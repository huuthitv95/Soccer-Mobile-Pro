public class FllowPlayerState : HFSM<TimelinePlayerControler, string>
{
    public global::UnityEngine.Transform target;
    public string NextState;
    private float speed;
    public FllowPlayerState(string name, TimelinePlayerControler owner, string StartState, string next) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void SetTarget(global::UnityEngine.Transform target)
    {
    }

    private void UpdateSpeed(global::UnityEngine.Transform my)
    {
    }

    public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }
}