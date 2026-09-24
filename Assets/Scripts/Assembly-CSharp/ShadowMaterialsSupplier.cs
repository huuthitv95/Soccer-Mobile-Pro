public abstract class ShadowMaterialsSupplier : global::UnityEngine.MonoBehaviour
{
	protected internal struct ShadowInfo
	{
		public float shadowAlpha;

		public global::UnityEngine.Vector4[] lightDirs;

		public float HFallOff;

		public float VFallOff;
	}

	protected static global::UnityEngine.Shader shadowShader;

	public abstract global::UnityEngine.Material[] ShareMaterials { get; }

	protected global::UnityEngine.Material[] CreateMaterial(ShadowMaterialsSupplier.ShadowInfo info)
	{
		return null;
	}

	protected static global::UnityEngine.Material[] CreateMaterialStatic(ShadowMaterialsSupplier.ShadowInfo info)
	{
		return null;
	}
}
