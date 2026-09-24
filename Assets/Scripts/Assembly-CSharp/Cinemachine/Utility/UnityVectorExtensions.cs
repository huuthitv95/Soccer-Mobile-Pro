namespace Cinemachine.Utility
{
	public static class UnityVectorExtensions
	{
		public const float Epsilon = 0.0001f;

		public static float ClosestPointOnSegment(this global::UnityEngine.Vector3 p, global::UnityEngine.Vector3 s0, global::UnityEngine.Vector3 s1)
		{
			return 0f;
		}

		public static float ClosestPointOnSegment(this global::UnityEngine.Vector2 p, global::UnityEngine.Vector2 s0, global::UnityEngine.Vector2 s1)
		{
			return 0f;
		}

		public static global::UnityEngine.Vector3 ProjectOntoPlane(this global::UnityEngine.Vector3 vector, global::UnityEngine.Vector3 planeNormal)
		{
			return default;
		}

		public static bool AlmostZero(this global::UnityEngine.Vector3 v)
		{
			return false;
		}

		public static float SignedAngle(global::UnityEngine.Vector3 from, global::UnityEngine.Vector3 to, global::UnityEngine.Vector3 refNormal)
		{
			return 0f;
		}

		public static global::UnityEngine.Vector3 SlerpWithReferenceUp(global::UnityEngine.Vector3 vA, global::UnityEngine.Vector3 vB, float t, global::UnityEngine.Vector3 up)
		{
			return default;
		}
	}
}
