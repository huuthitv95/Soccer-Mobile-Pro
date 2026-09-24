public class TimelineAnimationState : HFSM<TimelinePlayerControler, string>
{
    private string animation;
    private float blend;
    private int layer;
    private bool applyRootMotion;
    private bool freezeXZOffset;
    private float normalizedTimeOffset;
    private bool isTransitioningFromAI;
    private MotionTransitionHelper transitionHelper;
    public TimelineAnimationState(string name, TimelinePlayerControler owner, string playAnimation, global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>> states, string StartState, global::System.Action<HFSM<TimelinePlayerControler, string>> OnLogicAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnEnterAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnExitAction) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void ChangeAnimation(string anim)
    {
    }

    public void SetAnimationInfo(float blend, int layer, bool applyRootMotion, bool freezeXZOffset = false)
    {
    }

    public TimelineAnimationState(string name, TimelinePlayerControler owner, string playAnimation, float blendTime, bool applyRootMotion, int layer = 0, bool freezeXZOffset = false, bool TransitioningFromAI = false) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void SetTransitioningFromAIFlag(bool flag)
    {
    }

    public void SetNormalizedTimeOffset(float tm)
    {
    }

    public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
    {
    }

    public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }

    public override void OnLeave(Fsm<TimelinePlayerControler, string> fsm, bool isShutdown)
    {
    }
}