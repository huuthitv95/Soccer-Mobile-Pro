namespace UnityEngine.Timeline
{
	public class TrackBindingTypeAttribute : global::System.Attribute
	{
		public readonly global::System.Type type;

		public readonly global::UnityEngine.Timeline.TrackBindingFlags flags;

		public TrackBindingTypeAttribute(global::System.Type type)
		{
		}

		public TrackBindingTypeAttribute(global::System.Type type, global::UnityEngine.Timeline.TrackBindingFlags flags)
		{
		}
	}
}
