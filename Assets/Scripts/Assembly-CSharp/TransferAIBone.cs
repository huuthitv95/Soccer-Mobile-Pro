public class TransferAIBone : HFSM<TimelinePlayerControler, string>
{
    public string NextState;
    public float timer;
    public float blendTime;
    public global::UnityEngine.Transform bones;
    public bool isDone;
    public TransferAIBone(string name, TimelinePlayerControler owner, string NextState, global::System.Action<HFSM<TimelinePlayerControler, string>> OnLogicAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnEnterAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnExitAction) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void SetAnimationInfo(float blendTime, global::UnityEngine.Transform bones)
    {
    }

    public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
    {
    }

    public override void OnLeave(Fsm<TimelinePlayerControler, string> fsm, bool isShutdown)
    {
    }

    public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }
}