namespace Cinemachine.Utility
{
	internal class GaussianWindow1D_Vector3 : global::Cinemachine.Utility.GaussianWindow1d<global::UnityEngine.Vector3>
	{
		public GaussianWindow1D_Vector3(float sigma, int maxKernelRadius = 10)
			: base(0f, 0)
		{
		}

		protected override global::UnityEngine.Vector3 Compute(int windowPos)
		{
			return default;
		}
	}
}
