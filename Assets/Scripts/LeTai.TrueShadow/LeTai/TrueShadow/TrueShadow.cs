namespace LeTai.TrueShadow
{
    public class TrueShadow : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.IMeshModifier, global::UnityEngine.UI.ICanvasElement
    {
        private global::System.Action checkHierarchyDirtiedDelegate;
        private global::LeTai.TrueShadow.IChangeTracker[] transformTrackers;
        private global::LeTai.TrueShadow.ChangeTracker<int>[] hierachyTrackers;
        private global::LeTai.TrueShadow.PluginInterfaces.ITrueShadowCasterMaterialProvider casterMaterialProvider;
        private global::LeTai.TrueShadow.PluginInterfaces.ITrueShadowCasterMaterialPropertiesModifier casterMaterialPropertiesModifier;
        private global::LeTai.TrueShadow.PluginInterfaces.ITrueShadowCasterMeshModifier casterMeshModifier;
        private global::LeTai.TrueShadow.PluginInterfaces.ITrueShadowCasterClearColorProvider casterClearColorProvider;
        private global::LeTai.TrueShadow.PluginInterfaces.ITrueShadowRendererMaterialProvider rendererMaterialProvider;
        private global::LeTai.TrueShadow.PluginInterfaces.ITrueShadowRendererMaterialModifier rendererMaterialModifier;
        private global::LeTai.TrueShadow.PluginInterfaces.ITrueShadowRendererMeshModifier rendererMeshModifier;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.Color32> meshColors;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.Color32> meshColorsOpaque;
        private static readonly global::UnityEngine.Color DEFAULT_COLOR;
        [global::UnityEngine.SerializeField]
        private float size;
        [global::LeTai.TrueShadow.SpreadSlider]
        [global::UnityEngine.SerializeField]
        private float spread;
        [global::UnityEngine.SerializeField]
        private bool useGlobalAngle;
        [global::LeTai.TrueShadow.Knob]
        [global::UnityEngine.SerializeField]
        private float offsetAngle;
        [global::UnityEngine.SerializeField]
        private float offsetDistance;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 offset;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color color;
        [global::LeTai.TrueShadow.InsetToggle]
        [global::UnityEngine.SerializeField]
        private bool inset;
        [global::UnityEngine.SerializeField]
        private global::LeTai.TrueShadow.BlendMode blendMode;
        [global::UnityEngine.SerializeField]
        private bool useCasterAlpha;
        [global::UnityEngine.SerializeField]
        private bool ignoreCasterColor;
        [global::UnityEngine.SerializeField]
        private global::LeTai.TrueShadow.ColorBleedMode colorBleedMode;
        [global::UnityEngine.SerializeField]
        private bool disableFitCompensation;
        [global::UnityEngine.SerializeField]
        private bool shadowAsSibling;
        [global::UnityEngine.SerializeField]
        private bool cutout;
        [global::UnityEngine.SerializeField]
        private bool baked;
        [global::UnityEngine.SerializeField]
        private bool modifiedFromInspector;
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::UnityEngine.Sprite> bakedShadows;
        internal global::LeTai.TrueShadow.ShadowRenderer shadowRenderer;
        private global::LeTai.TrueShadow.ShadowContainer shadowContainer;
        private int customHash;
        private bool textureDirty;
        private bool layoutDirty;
        private int shadowIndex;
        public bool UsingRendererMaterialProvider => false;

        public float Size
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float Spread
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool UseGlobalAngle
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float OffsetAngle
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float OffsetDistance
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color Color
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public bool UseCasterAlpha
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool IgnoreCasterColor
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool Inset
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::LeTai.TrueShadow.BlendMode BlendMode
        {
            get
            {
                return global::LeTai.TrueShadow.BlendMode.Normal;
            }

            set
            {
            }
        }

        public global::LeTai.TrueShadow.ColorBleedMode ColorBleedMode
        {
            get
            {
                return global::LeTai.TrueShadow.ColorBleedMode.ImageColor;
            }

            set
            {
            }
        }

        public bool DisableFitCompensation
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color ClearColor => default;

        public bool ShadowAsSibling
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int CustomHash
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 Offset => default;

        public bool Cutout
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        internal global::UnityEngine.Mesh SpriteMesh { get; set; }
        internal global::UnityEngine.UI.Graphic Graphic { get; set; }
        internal global::UnityEngine.CanvasRenderer CanvasRenderer { get; set; }
        internal global::UnityEngine.RectTransform RectTransform { get; private set; }
        internal global::UnityEngine.Texture Content => null;
        internal global::LeTai.TrueShadow.ShadowContainer ShadowContainer => null;
        internal bool HierachyDirty { get; private set; }

        global::UnityEngine.Transform global::UnityEngine.UI.ICanvasElement.transform => null;

        private void InitInvalidator()
        {
        }

        private void TerminateInvalidator()
        {
        }

        private void OnGraphicMaterialDirty()
        {
        }

        internal void CheckTransformDirtied()
        {
        }

        internal void CheckHierarchyDirtied()
        {
        }

        internal void ForgetSiblingIndexChanges()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        public void ModifyMesh(global::UnityEngine.Mesh mesh)
        {
        }

        public void ModifyMesh(global::UnityEngine.UI.VertexHelper verts)
        {
        }

        private void SetLayoutTextureDirty()
        {
        }

        private void InitializePlugins()
        {
        }

        private void TerminatePlugins()
        {
        }

        public void RefreshPlugins()
        {
        }

        private void HandleCasterMaterialReplaced()
        {
        }

        private void HandleRendererMaterialReplaced()
        {
        }

        private void HandleCasterMaterialModified()
        {
        }

        private void HandleRendererMaterialModified()
        {
        }

        public virtual global::UnityEngine.Material GetShadowCastingMaterial()
        {
            return null;
        }

        public virtual void ModifyShadowCastingMaterialProperties(global::UnityEngine.MaterialPropertyBlock propertyBlock)
        {
        }

        public virtual void ModifyShadowCastingMesh(global::UnityEngine.Mesh mesh)
        {
        }

        private void MakeOpaque(global::UnityEngine.Mesh mesh)
        {
        }

        public virtual global::UnityEngine.Material GetShadowRenderingMaterial()
        {
            return null;
        }

        public virtual void ModifyShadowRendererMaterial(global::UnityEngine.Material baseMaterial)
        {
        }

        public virtual void ModifyShadowRendererMesh(global::UnityEngine.UI.VertexHelper vertexHelper)
        {
        }

        private void OnGlobalAngleChanged(float angle)
        {
        }

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        public void ApplySerializedData()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDestroy()
        {
        }

        private bool ShouldPerformWorks()
        {
            return false;
        }

        private void LateUpdate()
        {
        }

        public void Rebuild(global::UnityEngine.UI.CanvasUpdate executing)
        {
        }

        private void OnWillRenderCanvas()
        {
        }

        public void LayoutComplete()
        {
        }

        public void GraphicUpdateComplete()
        {
        }

        public void SetTextureDirty()
        {
        }

        public void SetLayoutDirty()
        {
        }

        public void SetHierachyDirty()
        {
        }

        internal void UnSetHierachyDirty()
        {
        }
    }
}