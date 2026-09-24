public class CelebrationMate : HFSM<TimelinePlayerControler, string>
{
    private global::UnityEngine.Vector3 boneScale;
    public CelebrationMate(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void Start(string name, global::UnityEngine.Vector3 targetPos, global::UnityEngine.Quaternion targetRotation, global::UnityEngine.Transform mate)
    {
    }

    public override void Update(float elapseSeconds, float realElapseSeconds)
    {
    }

    public override void Kill()
    {
    }

    public void OnShutdonw()
    {
    }

    public override void Shutdown()
    {
    }
}