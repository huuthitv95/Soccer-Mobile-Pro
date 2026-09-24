public class HFSMTransition<T, StateId> where T : class
{
	public StateId to;

	protected global::System.Func<HFSM<T, StateId>, bool> condition;

	public HFSMTransition(StateId to, global::System.Func<HFSM<T, StateId>, bool> condition)
	{
	}

	public virtual bool ShouldTransition(HFSM<T, StateId> fms)
	{
		return false;
	}
}
