namespace LeTai.TrueShadow
{
    public class ShadowFactory
    {
        private static global::LeTai.TrueShadow.ShadowFactory instance;
        private readonly global::System.Collections.Generic.Dictionary<int, global::LeTai.TrueShadow.ShadowContainer> shadowCache;
        private readonly global::UnityEngine.Rendering.CommandBuffer cmd;
        private readonly global::UnityEngine.MaterialPropertyBlock materialProps;
        private readonly global::LeTai.Effects.ScalableBlur blurProcessor;
        private readonly global::LeTai.Effects.ScalableBlurConfig blurConfig;
        private global::UnityEngine.Material cutoutMaterial;
        private global::UnityEngine.Material imprintPostProcessMaterial;
        private global::UnityEngine.Material shadowPostProcessMaterial;
        private static readonly global::UnityEngine.Rect UNIT_RECT;
        private static readonly global::UnityEngine.Vector4 ALPHA8_TEXTURE_BIAS;
        public static global::LeTai.TrueShadow.ShadowFactory Instance => null;
        public int CachedCount => 0;
        private global::UnityEngine.Material CutoutMaterial => null;
        private global::UnityEngine.Material ImprintPostProcessMaterial => null;
        private global::UnityEngine.Material ShadowPostProcessMaterial => null;

        private ShadowFactory()
        {
        }

        internal void Get(global::LeTai.TrueShadow.ShadowSettingSnapshot snapshot, ref global::LeTai.TrueShadow.ShadowContainer container)
        {
        }

        internal void ReleaseContainer(ref global::LeTai.TrueShadow.ShadowContainer container)
        {
        }

        private global::LeTai.TrueShadow.ShadowContainer GenerateShadow(global::LeTai.TrueShadow.ShadowSettingSnapshot snapshot)
        {
            return null;
        }

        private global::UnityEngine.RenderTexture GenColoredTexture(int hash)
        {
            return null;
        }
    }
}