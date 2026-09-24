namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public abstract class Graphic : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.ICanvasElement
    {
        protected static global::UnityEngine.Material s_DefaultUI;
        protected static global::UnityEngine.Texture2D s_WhiteTexture;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.Material m_Material;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_Color;
        [global::System.NonSerialized]
        protected bool m_SkipLayoutUpdate;
        [global::System.NonSerialized]
        protected bool m_SkipMaterialUpdate;
        [global::UnityEngine.SerializeField]
        private bool m_RaycastTarget;
        private bool m_RaycastTargetCache;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector4 m_RaycastPadding;
        [global::System.NonSerialized]
        private global::UnityEngine.RectTransform m_RectTransform;
        [global::System.NonSerialized]
        private global::UnityEngine.CanvasRenderer m_CanvasRenderer;
        [global::System.NonSerialized]
        private global::UnityEngine.Canvas m_Canvas;
        [global::System.NonSerialized]
        private bool m_VertsDirty;
        [global::System.NonSerialized]
        private bool m_MaterialDirty;
        [global::System.NonSerialized]
        protected global::UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback;
        [global::System.NonSerialized]
        protected global::UnityEngine.Events.UnityAction m_OnDirtyVertsCallback;
        [global::System.NonSerialized]
        protected global::UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback;
        [global::System.NonSerialized]
        protected static global::UnityEngine.Mesh s_Mesh;
        [global::System.NonSerialized]
        private static readonly global::UnityEngine.UI.VertexHelper s_VertexHelper;
        [global::System.NonSerialized]
        protected global::UnityEngine.Mesh m_CachedMesh;
        [global::System.NonSerialized]
        protected global::UnityEngine.Vector2[] m_CachedUvs;
        [global::System.NonSerialized]
        private readonly global::UnityEngine.UI.CoroutineTween.TweenRunner<global::UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunner;
        public static global::UnityEngine.Material defaultGraphicMaterial => null;

        public virtual global::UnityEngine.Color color
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public virtual bool raycastTarget
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector4 raycastPadding
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        protected bool useLegacyMeshGeneration { get; set; }
        public int depth => 0;
        public global::UnityEngine.RectTransform rectTransform => null;
        public global::UnityEngine.Canvas canvas => null;
        public global::UnityEngine.CanvasRenderer canvasRenderer => null;
        public virtual global::UnityEngine.Material defaultMaterial => null;

        public virtual global::UnityEngine.Material material
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public virtual global::UnityEngine.Material materialForRendering => null;
        public virtual global::UnityEngine.Texture mainTexture => null;
        protected static global::UnityEngine.Mesh workerMesh => null;

        global::UnityEngine.Transform global::UnityEngine.UI.ICanvasElement.transform => null;

        public virtual void SetAllDirty()
        {
        }

        public virtual void SetLayoutDirty()
        {
        }

        public virtual void SetVerticesDirty()
        {
        }

        public virtual void SetMaterialDirty()
        {
        }

        public void SetRaycastDirty()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected override void OnBeforeTransformParentChanged()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        private void CacheCanvas()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDestroy()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        public virtual void OnCullingChanged()
        {
        }

        public virtual void Rebuild(global::UnityEngine.UI.CanvasUpdate update)
        {
        }

        public virtual void LayoutComplete()
        {
        }

        public virtual void GraphicUpdateComplete()
        {
        }

        protected virtual void UpdateMaterial()
        {
        }

        protected virtual void UpdateGeometry()
        {
        }

        private void DoMeshGeneration()
        {
        }

        private void DoLegacyMeshGeneration()
        {
        }

        [global::System.Obsolete]
        protected virtual void OnFillVBO(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> vbo)
        {
        }

        [global::System.Obsolete]
        protected virtual void OnPopulateMesh(global::UnityEngine.Mesh m)
        {
        }

        protected virtual void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        public virtual void SetNativeSize()
        {
        }

        public virtual bool Raycast(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera)
        {
            return false;
        }

        public global::UnityEngine.Vector2 PixelAdjustPoint(global::UnityEngine.Vector2 point)
        {
            return default;
        }

        public global::UnityEngine.Rect GetPixelAdjustedRect()
        {
            return default;
        }

        public virtual void CrossFadeColor(global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
        {
        }

        public virtual void CrossFadeColor(global::UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
        {
        }

        private static global::UnityEngine.Color CreateColorFromAlpha(float alpha)
        {
            return default;
        }

        public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
        {
        }

        public void RegisterDirtyLayoutCallback(global::UnityEngine.Events.UnityAction action)
        {
        }

        public void UnregisterDirtyLayoutCallback(global::UnityEngine.Events.UnityAction action)
        {
        }

        public void RegisterDirtyVerticesCallback(global::UnityEngine.Events.UnityAction action)
        {
        }

        public void UnregisterDirtyVerticesCallback(global::UnityEngine.Events.UnityAction action)
        {
        }

        public void RegisterDirtyMaterialCallback(global::UnityEngine.Events.UnityAction action)
        {
        }

        public void UnregisterDirtyMaterialCallback(global::UnityEngine.Events.UnityAction action)
        {
        }
    }
}