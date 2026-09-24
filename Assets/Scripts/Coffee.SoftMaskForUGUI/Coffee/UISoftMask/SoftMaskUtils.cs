namespace Coffee.UISoftMask
{
    internal static class SoftMaskUtils
    {
        public static readonly global::Coffee.UISoftMaskInternal.InternalObjectPool<global::UnityEngine.Rendering.CommandBuffer> commandBufferPool;
        public static readonly global::Coffee.UISoftMaskInternal.InternalObjectPool<global::UnityEngine.MaterialPropertyBlock> materialPropertyBlockPool;
        private static global::UnityEngine.Material s_SoftMaskingMaterialAdd;
        private static global::UnityEngine.Material s_SoftMaskingMaterialSub;
        private static readonly int s_MainTex;
        private static readonly int s_ColorMask;
        private static readonly int s_BlendOp;
        private static readonly int s_ThresholdMin;
        private static readonly int s_ThresholdMax;
        private static readonly int s_RenderScale;
        private static readonly int s_DynamicResolutionScale;
        private static float s_CurrentRenderScale;
        private static global::UnityEngine.Vector2 s_CurrentDynamicResolutionScale;
        private static void InitializeOnLoadMethod()
        {
        }

        public static void UpdateMeshUI(global::UnityEngine.Object obj)
        {
        }

        private static void UpdateSubMeshUI(global::TMPro.TextMeshProUGUI text, bool enabled, bool show, float aa, global::Coffee.UISoftMaskInternal.MinMax01 softness, global::Coffee.UISoftMask.MaskingShape.MaskingMethod method)
        {
        }

        public static void ApplyMaterialPropertyBlock(global::UnityEngine.MaterialPropertyBlock mpb, int depth, global::UnityEngine.Texture texture, global::Coffee.UISoftMaskInternal.MinMax01 threshold, float alpha)
        {
        }

        public static global::UnityEngine.Material GetSoftMaskingMaterial(global::Coffee.UISoftMask.MaskingShape.MaskingMethod method)
        {
            return null;
        }

        private static global::UnityEngine.Material GetSoftMaskingMaterial(ref global::UnityEngine.Material mat, global::UnityEngine.Rendering.BlendOp op)
        {
            return null;
        }
    }
}