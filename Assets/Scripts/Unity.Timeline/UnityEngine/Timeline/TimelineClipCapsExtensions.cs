namespace UnityEngine.Timeline
{
	internal static class TimelineClipCapsExtensions
	{
		public static bool SupportsLooping(this global::UnityEngine.Timeline.TimelineClip clip)
		{
			return false;
		}

		public static bool SupportsExtrapolation(this global::UnityEngine.Timeline.TimelineClip clip)
		{
			return false;
		}

		public static bool SupportsClipIn(this global::UnityEngine.Timeline.TimelineClip clip)
		{
			return false;
		}

		public static bool SupportsSpeedMultiplier(this global::UnityEngine.Timeline.TimelineClip clip)
		{
			return false;
		}

		public static bool SupportsBlending(this global::UnityEngine.Timeline.TimelineClip clip)
		{
			return false;
		}

		public static bool HasAll(this global::UnityEngine.Timeline.ClipCaps caps, global::UnityEngine.Timeline.ClipCaps flags)
		{
			return false;
		}

		public static bool HasAny(this global::UnityEngine.Timeline.ClipCaps caps, global::UnityEngine.Timeline.ClipCaps flags)
		{
			return false;
		}
	}
}
