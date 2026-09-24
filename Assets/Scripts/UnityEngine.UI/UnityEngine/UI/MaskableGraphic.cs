namespace UnityEngine.UI
{
    public abstract class MaskableGraphic : global::UnityEngine.UI.Graphic, global::UnityEngine.UI.IClippable, global::UnityEngine.UI.IMaskable, global::UnityEngine.UI.IMaterialModifier
    {
        [global::System.Serializable]
        public class CullStateChangedEvent : global::UnityEngine.Events.UnityEvent<bool>
        {
        }

        [global::System.NonSerialized]
        protected bool m_ShouldRecalculateStencil;
        [global::System.NonSerialized]
        protected global::UnityEngine.Material m_MaskMaterial;
        [global::System.NonSerialized]
        private global::UnityEngine.UI.RectMask2D m_ParentMask;
        [global::UnityEngine.SerializeField]
        private bool m_Maskable;
        private bool m_IsMaskingGraphic;
        [global::System.NonSerialized]
        [global::System.Obsolete]
        protected bool m_IncludeForMasking;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;
        [global::System.NonSerialized]
        [global::System.Obsolete]
        protected bool m_ShouldRecalculate;
        [global::System.NonSerialized]
        protected int m_StencilValue;
        private readonly global::UnityEngine.Vector3[] m_Corners;
        public global::UnityEngine.UI.MaskableGraphic.CullStateChangedEvent onCullStateChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool maskable
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool isMaskingGraphic
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        private global::UnityEngine.Rect rootCanvasRect => default;

        global::UnityEngine.GameObject global::UnityEngine.UI.IClippable.gameObject => null;

        public virtual global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        public virtual void Cull(global::UnityEngine.Rect clipRect, bool validRect)
        {
        }

        private void UpdateCull(bool cull)
        {
        }

        public virtual void SetClipRect(global::UnityEngine.Rect clipRect, bool validRect)
        {
        }

        public virtual void SetClipSoftness(global::UnityEngine.Vector2 clipSoftness)
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        [global::System.Obsolete]
        public virtual void ParentMaskStateChanged()
        {
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        private void UpdateClipParent()
        {
        }

        public virtual void RecalculateClipping()
        {
        }

        public virtual void RecalculateMasking()
        {
        }
    }
}