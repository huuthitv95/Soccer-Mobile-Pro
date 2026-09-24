namespace Coffee.UISoftMaskInternal
{
	internal static class CanvasExtensions
	{
		public static bool ShouldGammaToLinearInShader(this global::UnityEngine.Canvas canvas)
		{
			return false;
		}

		public static bool ShouldGammaToLinearInMesh(this global::UnityEngine.Canvas canvas)
		{
			return false;
		}

		public static bool IsStereoCanvas(this global::UnityEngine.Canvas canvas)
		{
			return false;
		}

		public static void GetViewProjectionMatrix(this global::UnityEngine.Canvas canvas, out global::UnityEngine.Matrix4x4 vpMatrix)
		{
			vpMatrix = default;
		}

		public static void GetViewProjectionMatrix(this global::UnityEngine.Canvas canvas, global::UnityEngine.Camera.MonoOrStereoscopicEye eye, out global::UnityEngine.Matrix4x4 vpMatrix)
		{
			vpMatrix = default;
		}

		public static void GetViewProjectionMatrix(this global::UnityEngine.Canvas canvas, out global::UnityEngine.Matrix4x4 vMatrix, out global::UnityEngine.Matrix4x4 pMatrix)
		{
			vMatrix = default;
			pMatrix = default;
		}

		public static void GetViewProjectionMatrix(this global::UnityEngine.Canvas canvas, global::UnityEngine.Camera.MonoOrStereoscopicEye eye, out global::UnityEngine.Matrix4x4 vMatrix, out global::UnityEngine.Matrix4x4 pMatrix)
		{
			vMatrix = default;
			pMatrix = default;
		}
	}
}
