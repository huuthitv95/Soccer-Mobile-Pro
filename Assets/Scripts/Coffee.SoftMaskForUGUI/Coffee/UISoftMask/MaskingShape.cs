namespace Coffee.UISoftMask
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class MaskingShape : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.IMeshModifier, global::UnityEngine.UI.IMaterialModifier, global::System.IComparable<global::Coffee.UISoftMask.MaskingShape>, global::UnityEngine.UI.IMaskable
    {
        public enum MaskingMethod
        {
            Additive = 0,
            Subtract = 1
        }

        [global::UnityEngine.SerializeField]
        private global::Coffee.UISoftMask.MaskingShape.MaskingMethod m_MaskingMethod;
        [global::UnityEngine.SerializeField]
        private bool m_ShowMaskGraphic;
        [global::UnityEngine.SerializeField]
        private bool m_AlphaHitTest;
        [global::UnityEngine.SerializeField]
        private float m_AntiAliasingThreshold;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UISoftMaskInternal.MinMax01 m_SoftnessRange;
        private bool _antiAliasingRegistered;
        private global::Coffee.UISoftMask.MaskingShapeContainer _container;
        private global::UnityEngine.UI.Graphic _graphic;
        private global::UnityEngine.UI.Mask _mask;
        private global::UnityEngine.Material _maskMaterial;
        private global::UnityEngine.Mesh _mesh;
        private global::UnityEngine.MaterialPropertyBlock _mpb;
        private global::UnityEngine.Matrix4x4 _prevTransformMatrix;
        private global::UnityEngine.Events.UnityAction _setContainerDirty;
        private bool _shouldRecalculateStencil;
        private int _stencilBits;
        private global::System.Action _updateAntiAliasing;
        private global::UnityEngine.Events.UnityAction _updateContainer;
        public global::UnityEngine.UI.Graphic graphic => null;
        public bool hasTransformChanged => false;

        public global::Coffee.UISoftMask.MaskingShape.MaskingMethod maskingMethod
        {
            get
            {
                return global::Coffee.UISoftMask.MaskingShape.MaskingMethod.Additive;
            }

            set
            {
            }
        }

        public bool showMaskGraphic
        {
            get
            {
                return false;
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

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
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

        protected override void OnTransformParentChanged()
        {
        }

        int global::System.IComparable<global::Coffee.UISoftMask.MaskingShape>.CompareTo(global::Coffee.UISoftMask.MaskingShape other)
        {
            return 0;
        }

        void global::UnityEngine.UI.IMaskable.RecalculateMasking()
        {
        }

        global::UnityEngine.Material global::UnityEngine.UI.IMaterialModifier.GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        void global::UnityEngine.UI.IMeshModifier.ModifyMesh(global::UnityEngine.Mesh mesh)
        {
        }

        void global::UnityEngine.UI.IMeshModifier.ModifyMesh(global::UnityEngine.UI.VertexHelper verts)
        {
        }

        internal bool AntiAliasingEnabled()
        {
            return false;
        }

        internal bool SoftMaskEnabled()
        {
            return false;
        }

        private void RecalculateStencilIfNeeded()
        {
        }

        private void SetContainerDirty()
        {
        }

        private void SetMaterialDirty()
        {
        }

        private void UpdateContainer()
        {
        }

        internal bool IsInside(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera, float threshold = 0.01f)
        {
            return false;
        }

        internal void DrawSoftMaskBuffer(global::UnityEngine.Rendering.CommandBuffer cb, int depth)
        {
        }

        private void RegisterAntiAliasingIfNeeded()
        {
        }

        private void UpdateAntiAliasing()
        {
        }
    }
}