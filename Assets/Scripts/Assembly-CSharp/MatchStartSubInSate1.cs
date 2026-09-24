public class MatchStartSubInSate1 : HFSM<TimelinePlayerControler, string>
{
    private global::UnityEngine.GameObject subOutGo;
    private global::UnityEngine.Animator subOutAnimator;
    private bool isSubInPlayer;
    public MatchStartSubInSate1(TimelinePlayerControler ctr, string name = "StartMatch_SubIn1") : base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
    {
    }

    private void DestroySubOut()
    {
    }

    public override void Kill()
    {
    }

    public override void Shutdown()
    {
    }
}