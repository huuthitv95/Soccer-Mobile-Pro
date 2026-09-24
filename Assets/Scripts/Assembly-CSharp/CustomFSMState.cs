public class CustomFSMState<T> : HFSM<T, string> where T : class
{
	public CustomFSMState(T owner, string Id)
		: base((string)null, (T)null, (string)null, (global::System.Collections.Generic.List<IFsmState<T, string>>)null, (string)null, (global::System.Action<HFSM<T, string>>)null, (global::System.Action<HFSM<T, string>>)null, (global::System.Action<HFSM<T, string>>)null)
	{
	}
}
