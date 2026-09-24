namespace LeTai.TrueShadow
{
    public class ShadowRenderer : global::UnityEngine.MonoBehaviour, global::UnityEngine.UI.ILayoutIgnorer, global::UnityEngine.UI.IMaterialModifier, global::UnityEngine.UI.IMeshModifier
    {
        private static readonly global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Material> MASK_MATERIALS_CACHE;
        private static bool needRedraw;
        private global::LeTai.TrueShadow.TrueShadow shadow;
        private global::UnityEngine.RectTransform rt;
        private global::UnityEngine.UI.RawImage graphic;
        private global::UnityEngine.Texture shadowTexture;
        private bool willBeDestroyed;
        public bool ignoreLayout => false;
        internal global::UnityEngine.CanvasRenderer CanvasRenderer { get; private set; }

        internal static void ClearMaskMaterialCache()
        {
        }

        public global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        internal static void QueueRedraw()
        {
        }

        public static void Initialize(global::LeTai.TrueShadow.TrueShadow shadow, ref global::LeTai.TrueShadow.ShadowRenderer renderer)
        {
        }

        public void UpdateMaterial()
        {
        }

        internal void ReLayout()
        {
        }

        public void SetTexture(global::UnityEngine.Texture texture)
        {
        }

        public void SetMaterialDirty()
        {
        }

        public void ModifyMesh(global::UnityEngine.UI.VertexHelper vertexHelper)
        {
        }

        public void ModifyMesh(global::UnityEngine.Mesh mesh)
        {
        }

        protected virtual void LateUpdate()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        public void Dispose()
        {
        }
    }
}