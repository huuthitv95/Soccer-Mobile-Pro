public class CelebrationRunState : HFSM<TimelinePlayerControler, string>
{
    public global::UnityEngine.Vector3 endPos;
    public global::UnityEngine.Quaternion endRotation;
    public float speed;
    public string NextState;
    public CelebrationRunState(string name, TimelinePlayerControler owner, string NextState, string StartState, global::System.Action<HFSM<TimelinePlayerControler, string>> OnLogicAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnEnterAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnExitAction) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void SetPath(global::UnityEngine.Vector3 end, global::UnityEngine.Quaternion endRotation, float speed)
    {
    }

    public override void OnUpdate(Fsm<TimelinePlayerControler, string> fsm, float elapseSeconds, float realElapseSeconds)
    {
    }
}