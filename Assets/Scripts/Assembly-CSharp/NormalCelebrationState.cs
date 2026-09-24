public class NormalCelebrationState : HFSM<TimelinePlayerControler, string>
{
    public string NextState;
    private global::System.Collections.Generic.List<string> statesNames;
    private bool isFrame;
    public static string debugAnim;
    public string AssignAnim;
    private bool flag;
    public NormalCelebrationState(string name, TimelinePlayerControler owner, string NextState, global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>> states, string StartState, global::System.Action<HFSM<TimelinePlayerControler, string>> OnLogicAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnEnterAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnExitAction) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
    {
    }

    public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }
}