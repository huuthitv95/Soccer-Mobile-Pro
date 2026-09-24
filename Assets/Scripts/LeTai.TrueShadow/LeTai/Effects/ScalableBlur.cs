namespace LeTai.Effects
{
    public class ScalableBlur : global::LeTai.Effects.IBlurAlgorithm
    {
        private global::UnityEngine.Material material;
        private global::LeTai.Effects.ScalableBlurConfig config;
        private static readonly int BLUE_NOISE_ID;
        private static readonly int TARGET_SIZE_ID;
        private readonly global::UnityEngine.Texture2D blueNoise;
        private const int BLUR_PASS = 0;
        private const int CROP_BLUR_PASS = 1;
        private const int DITHER_BLUR_PASS = 2;
        private global::UnityEngine.Material Material
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public void Configure(global::LeTai.Effects.BlurConfig config)
        {
        }

        public void Blur(global::UnityEngine.Rendering.CommandBuffer cmd, global::UnityEngine.Rendering.RenderTargetIdentifier src, global::UnityEngine.Rect srcCropRegion, global::UnityEngine.RenderTexture target)
        {
        }

        protected virtual void BlurAtDepth(global::UnityEngine.Rendering.CommandBuffer cmd, int depth, global::UnityEngine.RenderTexture baseTexture)
        {
        }

        private static void CreateTempRenderTextureFrom(global::UnityEngine.Rendering.CommandBuffer cmd, int nameId, global::UnityEngine.RenderTexture src, int downsampleFactor)
        {
        }

        private static void CleanupIntermediateRT(global::UnityEngine.Rendering.CommandBuffer cmd, int amount)
        {
        }
    }
}