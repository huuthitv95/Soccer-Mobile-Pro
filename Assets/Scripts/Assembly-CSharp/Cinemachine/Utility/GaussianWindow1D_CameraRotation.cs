namespace Cinemachine.Utility
{
	internal class GaussianWindow1D_CameraRotation : global::Cinemachine.Utility.GaussianWindow1d<global::UnityEngine.Vector2>
	{
		public GaussianWindow1D_CameraRotation(float sigma, int maxKernelRadius = 10)
			: base(0f, 0)
		{
		}

		protected override global::UnityEngine.Vector2 Compute(int windowPos)
		{
			return default;
		}
	}
}
