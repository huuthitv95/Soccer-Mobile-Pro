public class MatchStartSubInTimeline : HFSM<TimelinePlayerControler, string>
{
    private float timer;
    public static void OnStart(AISampleBase aiSample)
    {
    }

    public static void OnEnd(AISampleBase aiSample)
    {
    }

    public MatchStartSubInTimeline(TimelinePlayerControler ctr) : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    public void Start()
    {
    }

    public void OnShutdonw()
    {
    }

    public override void Shutdown()
    {
    }
}