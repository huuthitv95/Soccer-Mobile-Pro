public class TimelineAnimationStateTransition : HFSMTransition<TimelinePlayerControler, string>
{
	private float normalizedTime;

	private int layer;

	private string forceAnim;

	public TimelineAnimationStateTransition(string to, float normalizedTime, global::System.Func<HFSM<TimelinePlayerControler, string>, bool> condition = null, int layer = 0, string forceAnim = null)
		: base((string)null, (global::System.Func<HFSM<TimelinePlayerControler, string>, bool>)null)
	{
	}

	public override bool ShouldTransition(HFSM<TimelinePlayerControler, string> state)
	{
		return false;
	}
}
