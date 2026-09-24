public class LeaveCelebration : HFSM<TimelinePlayerControler, string>
{
    private global::System.Collections.Generic.List<string> statesNames;
    public string NextState;
    public LeaveCelebration(string name, TimelinePlayerControler owner, string nextState) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
    {
    }

    public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }
}