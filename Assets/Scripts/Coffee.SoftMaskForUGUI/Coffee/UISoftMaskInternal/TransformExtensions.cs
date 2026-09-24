namespace Coffee.UISoftMaskInternal
{
	internal static class TransformExtensions
	{
		private const float k_DefaultEpsilon = 0.1f;

		private static readonly global::UnityEngine.Vector3[] s_Corners;

		public static int CompareHierarchyIndex(this global::UnityEngine.Transform self, global::UnityEngine.Transform other, global::UnityEngine.Transform stopAt)
		{
			return 0;
		}

		private static global::System.Collections.Generic.List<global::UnityEngine.Transform> GetTransforms(this global::UnityEngine.Transform self, global::UnityEngine.Transform stopAt, global::System.Collections.Generic.List<global::UnityEngine.Transform> results)
		{
			return null;
		}

		public static bool HasChanged(this global::UnityEngine.Transform self, ref global::UnityEngine.Matrix4x4 prev, float epsilon = 0.1f)
		{
			return false;
		}

		public static bool HasChanged(this global::UnityEngine.Transform self, global::UnityEngine.Transform baseTransform, ref global::UnityEngine.Matrix4x4 prev, float epsilon = 0.1f)
		{
			return false;
		}

		private static bool Approximately(global::UnityEngine.Matrix4x4 self, global::UnityEngine.Matrix4x4 other, float epsilon = 0.1f)
		{
			return false;
		}

		public static global::UnityEngine.Bounds GetRelativeBounds(this global::UnityEngine.Transform self, global::UnityEngine.Transform child)
		{
			return default;
		}
	}
}
