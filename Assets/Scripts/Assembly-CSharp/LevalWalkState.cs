public class LevalWalkState : HFSM<TimelinePlayerControler, string>
{
    public global::UnityEngine.Vector3 endPos;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<TimelineAnimationState, TimelineAnimationStateTransition>> TransitionHelp;
    private float speed;
    public LevalWalkState(string name, TimelinePlayerControler owner) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void Init(global::UnityEngine.Vector3 endPos, bool isWin, bool celebration, bool skipIdle, bool TransitionFromAI)
    {
    }

    public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
    {
    }

    public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }
}