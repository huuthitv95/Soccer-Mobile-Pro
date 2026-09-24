namespace LeTai.Effects
{
	public interface IBlurAlgorithm
	{
		void Configure(global::LeTai.Effects.BlurConfig config);

		void Blur(global::UnityEngine.Rendering.CommandBuffer cmd, global::UnityEngine.Rendering.RenderTargetIdentifier src, global::UnityEngine.Rect srcCropRegion, global::UnityEngine.RenderTexture target);
	}
}
