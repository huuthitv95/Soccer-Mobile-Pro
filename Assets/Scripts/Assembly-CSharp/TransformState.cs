public class TransformState : HFSM<TimelinePlayerControler, string>
{
    private global::UnityEngine.Vector3 pos;
    private global::UnityEngine.Quaternion quaternion;
    private string nextState;
    private global::System.Func<string> nextStateGetter;
    public TransformState(TimelinePlayerControler ctr, string name, string nextState, global::UnityEngine.Vector3 pos = default(global::UnityEngine.Vector3), global::UnityEngine.Quaternion quaternion = default(global::UnityEngine.Quaternion), global::System.Func<string> nextStateGetter = null) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void SetTransform(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion quaternion)
    {
    }

    public override void OnEnter(Fsm<TimelinePlayerControler, string> fsm)
    {
    }
}