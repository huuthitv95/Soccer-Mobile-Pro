public class CelebrationStateMachine : HFSM<TimelinePlayerControler, string>
{
    private float timer;
    private global::UnityEngine.Transform lookAtBone;
    private global::UnityEngine.Events.UnityAction<IFsmState<TimelinePlayerControler, string>, IFsmState<TimelinePlayerControler, string>> celebrationStateChangeAction;
    private CelebrationHelper Helper;
    private global::UnityEngine.Vector3 boneScale;
    private global::UnityEngine.Vector2 camreaPosOffset;
    private global::UnityEngine.Coroutine co;
    private CelebrationStateMachine leader;
    private ScreenTimeTracker screenTimeTracker;
    public CelebrationStateMachine(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    private bool CheckMirror(global::UnityEngine.Vector3 targetPosition, bool isNormalMirrorRule)
    {
        return false;
    }

    private global::UnityEngine.Quaternion CalculateRotationOffset(global::UnityEngine.Vector3 targetPosition, float offset)
    {
        return default;
    }

    public static global::UnityEngine.Vector3 CalculateTargetPos(global::UnityEngine.Transform player, bool wide)
    {
        return default;
    }

    private global::UnityEngine.Vector3 MirrorVectorOverPlane(global::UnityEngine.Vector3 A, global::UnityEngine.Vector3 C, global::UnityEngine.Vector3 D)
    {
        return default;
    }

    public void Start(CelebrationHelper helper)
    {
    }

    public override void Update(float elapseSeconds, float realElapseSeconds)
    {
    }

    public override void Kill()
    {
    }

    private void ClearCelebrationCallbacks()
    {
    }

    private void OnShutdonw()
    {
    }

    public override void Shutdown()
    {
    }
}