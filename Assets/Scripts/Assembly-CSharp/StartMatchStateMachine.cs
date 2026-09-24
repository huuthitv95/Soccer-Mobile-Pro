public class StartMatchStateMachine : HFSM<TimelinePlayerControler, string>
{
    private const float FlagWaveWarmUpDuration = 3f;
    private const string StartMatchWarmUpCamera = "startMatchWarmUp";
    private float timer;
    private global::UnityEngine.Vector3 StartPos;
    private global::UnityEngine.Quaternion StartQuotation;
    private static StartMatchStateMachine leader;
    private ScreenTimeTracker screenTimeTracker;
    private ScreenTimeTracker screenTimeTracker_walk;
    private global::FL.PlayerCareer playerCareer;
    private static global::UnityEngine.Vector3 currentLocalScale;
    private global::StartMatchTimeline.EntranceStateMachine entrance;
    private bool useEntrance;
    public StartMatchStateMachine(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void Start()
    {
    }

    public override void Kill()
    {
    }

    private void OnShutdonw()
    {
    }

    private void ShowMatchStartInfo()
    {
    }

    private void CloseMatchStartInfo()
    {
    }

    public override void Shutdown()
    {
    }
}