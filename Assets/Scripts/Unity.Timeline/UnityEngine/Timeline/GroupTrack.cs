namespace UnityEngine.Timeline
{
	[global::System.Serializable]
	[global::UnityEngine.ExcludeFromPreset]
	public class GroupTrack : global::UnityEngine.Timeline.TrackAsset
	{
		public override global::System.Collections.Generic.IEnumerable<global::UnityEngine.Playables.PlayableBinding> outputs => null;

		internal override bool CanCompileClips()
		{
			return false;
		}
	}
}
