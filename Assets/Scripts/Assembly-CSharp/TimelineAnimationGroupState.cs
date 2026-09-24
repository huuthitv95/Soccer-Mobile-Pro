public class TimelineAnimationGroupState : HFSM<TimelinePlayerControler, string>
{
    public string NextState;
    private global::System.Collections.Generic.List<string> statesNames;
    public TimelineAnimationGroupState(string name, TimelinePlayerControler owner, string nextState, global::System.Collections.Generic.List<string> anims, float loopTimes = 1f, bool TransitioningFromAI = false) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
    {
    }

    public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }
}