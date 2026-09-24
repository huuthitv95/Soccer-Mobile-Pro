namespace Cinemachine.Utility
{
	internal class GaussianWindow1D_Quaternion : global::Cinemachine.Utility.GaussianWindow1d<global::UnityEngine.Quaternion>
	{
		public GaussianWindow1D_Quaternion(float sigma, int maxKernelRadius = 10)
			: base(0f, 0)
		{
		}

		protected override global::UnityEngine.Quaternion Compute(int windowPos)
		{
			return default;
		}
	}
}
