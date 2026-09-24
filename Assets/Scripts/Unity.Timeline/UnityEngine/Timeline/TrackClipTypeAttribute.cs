namespace UnityEngine.Timeline
{
	public class TrackClipTypeAttribute : global::System.Attribute
	{
		public readonly global::System.Type inspectedType;

		public readonly bool allowAutoCreate;

		public TrackClipTypeAttribute(global::System.Type clipClass)
		{
		}

		public TrackClipTypeAttribute(global::System.Type clipClass, bool allowAutoCreate)
		{
		}
	}
}
