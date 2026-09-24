namespace UnityEngine.Timeline
{
	internal class SupportsChildTracksAttribute : global::System.Attribute
	{
		public readonly global::System.Type childType;

		public readonly int levels;

		public SupportsChildTracksAttribute(global::System.Type childType = null, int levels = int.MaxValue)
		{
		}
	}
}
