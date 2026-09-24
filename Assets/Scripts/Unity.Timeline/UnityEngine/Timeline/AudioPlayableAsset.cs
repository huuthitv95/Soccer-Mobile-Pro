namespace UnityEngine.Timeline
{
	[global::System.Serializable]
	public class AudioPlayableAsset : global::UnityEngine.Playables.PlayableAsset, global::UnityEngine.Timeline.ITimelineClipAsset
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.AudioClip m_Clip;

		[global::UnityEngine.SerializeField]
		private bool m_Loop;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.HideInInspector]
		private float m_bufferingTime;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Timeline.AudioClipProperties m_ClipProperties;

		internal float bufferingTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.AudioClip clip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override double duration => 0.0;

		public override global::System.Collections.Generic.IEnumerable<global::UnityEngine.Playables.PlayableBinding> outputs => null;

		public global::UnityEngine.Timeline.ClipCaps clipCaps => global::UnityEngine.Timeline.ClipCaps.None;

		public override global::UnityEngine.Playables.Playable CreatePlayable(global::UnityEngine.Playables.PlayableGraph graph, global::UnityEngine.GameObject go)
		{
			return default;
		}
	}
}
