namespace Coffee.UISoftMask
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class SoftMask : global::UnityEngine.UI.Mask, global::UnityEngine.UI.IMeshModifier, global::UnityEngine.UI.IMaskable, global::Coffee.UISoftMask.IMaskingShapeContainerOwner, global::UnityEngine.ISerializationCallbackReceiver
    {
        public enum DownSamplingRate
        {
            None = 0,
            x1 = 1,
            x2 = 2,
            x4 = 4,
            x8 = 8
        }

        public enum MaskingMode
        {
            SoftMasking = 0,
            AntiAliasing = 1,
            Normal = 2
        }

        public static global::System.Action<global::Coffee.UISoftMask.SoftMask> onRenderSoftMaskBuffer;
        private static readonly global::UnityEngine.Camera.MonoOrStereoscopicEye[] s_MonoEyes;
        private static readonly global::UnityEngine.Camera.MonoOrStereoscopicEye[] s_StereoEyes;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UISoftMask.SoftMask.MaskingMode m_MaskingMode;
        [global::UnityEngine.SerializeField]
        private bool m_AlphaHitTest;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UISoftMaskInternal.MinMax01 m_SoftnessRange;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UISoftMask.SoftMask.DownSamplingRate m_DownSamplingRate;
        [global::UnityEngine.SerializeField]
        private float m_AntiAliasingThreshold;
        [global::System.Obsolete]
        [global::UnityEngine.SerializeField]
        internal float m_Alpha;
        [global::System.Obsolete]
        [global::UnityEngine.SerializeField]
        internal float m_Softness;
        [global::UnityEngine.SerializeField]
        [global::System.Obsolete]
        private bool m_PartOfParent;
        private global::UnityEngine.CanvasGroup _canvasGroup;
        private global::UnityEngine.Rendering.CommandBuffer _cb;
        private global::System.Collections.Generic.List<global::Coffee.UISoftMask.SoftMask> _children;
        private bool _hasResolutionChanged;
        private bool _hasSoftMaskBufferDrawn;
        private global::UnityEngine.Mesh _mesh;
        private global::UnityEngine.MaterialPropertyBlock _mpb;
        private global::System.Action _onBeforeCanvasRebuild;
        private global::System.Action _onCanvasViewChanged;
        private global::Coffee.UISoftMask.SoftMask _parent;
        private global::UnityEngine.Matrix4x4 _prevTransformMatrix;
        private global::System.Action _renderSoftMaskBuffer;
        private global::UnityEngine.Canvas _rootCanvas;
        private global::UnityEngine.Events.UnityAction _setSoftMaskDirty;
        private global::Coffee.UISoftMask.MaskingShapeContainer _shapeContainer;
        internal global::UnityEngine.RenderTexture _softMaskBuffer;
        private global::UnityEngine.Events.UnityAction _updateParentSoftMask;
        private global::Coffee.UISoftMask.CanvasViewChangeTrigger _viewChangeTrigger;
        private global::System.Collections.Generic.List<global::Coffee.UISoftMask.SoftMask> children => null;

        public global::Coffee.UISoftMask.SoftMask.MaskingMode maskingMode
        {
            get
            {
                return global::Coffee.UISoftMask.SoftMask.MaskingMode.SoftMasking;
            }

            set
            {
            }
        }

        public global::Coffee.UISoftMask.SoftMask.DownSamplingRate downSamplingRate
        {
            get
            {
                return global::Coffee.UISoftMask.SoftMask.DownSamplingRate.None;
            }

            set
            {
            }
        }

        public float antiAliasingThreshold
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool alphaHitTest
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int softMaskDepth => 0;

        [global::System.Obsolete]
        public bool partOfParent
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public float softness
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool hasSoftMaskBuffer => false;
        public global::UnityEngine.RenderTexture softMaskBuffer => null;

        public global::Coffee.UISoftMaskInternal.MinMax01 softnessRange
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public float alpha
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color clearColor { get; set; }
        public bool isDirty { get; private set; }
        public bool allowRenderScale => false;
        public bool allowDynamicResolution => false;

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

        protected override void OnDidApplyAnimationProperties()
        {
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected void OnTransformChildrenChanged()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        void global::UnityEngine.UI.IMaskable.RecalculateMasking()
        {
        }

        void global::Coffee.UISoftMask.IMaskingShapeContainerOwner.Register(global::Coffee.UISoftMask.MaskingShapeContainer container)
        {
        }

        void global::UnityEngine.UI.IMeshModifier.ModifyMesh(global::UnityEngine.Mesh mesh)
        {
        }

        void global::UnityEngine.UI.IMeshModifier.ModifyMesh(global::UnityEngine.UI.VertexHelper verts)
        {
        }

        private void SetDirtyAndNotifyIfBufferSizeChanged()
        {
        }

        private void AddSoftMaskableOnChildren()
        {
        }

        private void OnBeforeCanvasRebuild()
        {
        }

        private void UpdateCanvasViewChangeTrigger(global::Coffee.UISoftMask.CanvasViewChangeTrigger trigger)
        {
        }

        public override bool IsRaycastLocationValid(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera)
        {
            return false;
        }

        public override global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        private void SetDirtyAndNotify()
        {
        }

        private void OnCanvasViewChanged()
        {
        }

        public void SetSoftMaskDirty()
        {
        }

        public bool SoftMaskingEnabled()
        {
            return false;
        }

        public bool AntiAliasingEnabled()
        {
            return false;
        }

        internal global::Coffee.UISoftMask.SoftMask.MaskingMode GetActualMaskingMode()
        {
            return global::Coffee.UISoftMask.SoftMask.MaskingMode.SoftMasking;
        }

        private void UpdateParentSoftMask()
        {
        }

        private void UpdateParentSoftMask(global::Coffee.UISoftMask.SoftMask newParent)
        {
        }

        private void UpdateAntiAlias()
        {
        }

        private bool IsInScreen()
        {
            return false;
        }

        private void RenderSoftMaskBuffer()
        {
        }

        private void RenderSoftMaskBuffer(global::UnityEngine.Rendering.CommandBuffer cb, global::UnityEngine.Camera.MonoOrStereoscopicEye eye)
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }

        void global::UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        {
        }
    }
}