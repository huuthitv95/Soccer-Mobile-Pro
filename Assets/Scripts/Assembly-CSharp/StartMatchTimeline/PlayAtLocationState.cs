namespace StartMatchTimeline
{
	public class PlayAtLocationState : HFSM<TimelinePlayerControler, string>
	{
		public PlayAtLocationState(TimelinePlayerControler ctr, string id, string animName, global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot, bool driveCamera, float fov)
			: base((string)null, (TimelinePlayerControler)null, (string)null, (global::System.Collections.Generic.List<IFsmState<TimelinePlayerControler, string>>)null, (string)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null, (global::System.Action<HFSM<TimelinePlayerControler, string>>)null)
		{
		}
	}
}
