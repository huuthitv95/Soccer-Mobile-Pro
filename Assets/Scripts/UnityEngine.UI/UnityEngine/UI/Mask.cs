namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class Mask : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.ICanvasRaycastFilter, global::UnityEngine.UI.IMaterialModifier
    {
        [global::System.NonSerialized]
        private global::UnityEngine.RectTransform m_RectTransform;
        [global::UnityEngine.SerializeField]
        private bool m_ShowMaskGraphic;
        [global::System.NonSerialized]
        private global::UnityEngine.UI.Graphic m_Graphic;
        [global::System.NonSerialized]
        private global::UnityEngine.Material m_MaskMaterial;
        [global::System.NonSerialized]
        private global::UnityEngine.Material m_UnmaskMaterial;
        public global::UnityEngine.RectTransform rectTransform => null;

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

        public global::UnityEngine.UI.Graphic graphic => null;

        protected Mask()
        {
        }

        public virtual bool MaskEnabled()
        {
            return false;
        }

        [global::System.Obsolete]
        public virtual void OnSiblingGraphicEnabledDisabled()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public virtual bool IsRaycastLocationValid(global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera)
        {
            return false;
        }

        public virtual global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }
    }
}