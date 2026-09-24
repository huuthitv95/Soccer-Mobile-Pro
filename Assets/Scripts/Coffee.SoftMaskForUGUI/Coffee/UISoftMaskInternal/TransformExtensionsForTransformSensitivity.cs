namespace Coffee.UISoftMaskInternal
{
	internal static class TransformExtensionsForTransformSensitivity
	{
		private const float k_DefaultEpsilon = 0.1f;

		public static bool HasChanged(this global::UnityEngine.Transform self, ref global::UnityEngine.Matrix4x4 prev, global::Coffee.UISoftMaskInternal.TransformSensitivity sensitivity)
		{
			return false;
		}

		public static bool HasChanged(this global::UnityEngine.Transform self, global::UnityEngine.Transform baseTransform, ref global::UnityEngine.Matrix4x4 prev, global::Coffee.UISoftMaskInternal.TransformSensitivity sensitivity)
		{
			return false;
		}

		private static float Convert(global::Coffee.UISoftMaskInternal.TransformSensitivity self)
		{
			return 0f;
		}

		private static bool HasChanged_Internal(this global::UnityEngine.Transform self, global::UnityEngine.Transform baseTransform, ref global::UnityEngine.Matrix4x4 prev, float epsilon)
		{
			return false;
		}

		private static bool Approximately(global::UnityEngine.Matrix4x4 self, global::UnityEngine.Matrix4x4 other, float epsilon = 0.1f)
		{
			return false;
		}
	}
}
