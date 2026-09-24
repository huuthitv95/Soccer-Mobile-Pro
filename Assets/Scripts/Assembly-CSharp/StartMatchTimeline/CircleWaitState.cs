namespace StartMatchTimeline
{
	public class CircleWaitState : HFSM<TimelinePlayerControler, string>
	{
		private static readonly string[] Anims;

		public CircleWaitState(TimelinePlayerControler owner, string name, global::System.Action<HFSM<TimelinePlayerControler, string>> OnLogicAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnEnterAction, global::System.Action<HFSM<TimelinePlayerControler, string>> OnExitAction)
			: base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
		{
		}
	}
}
