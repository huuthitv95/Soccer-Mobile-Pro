namespace Coffee.UISoftMask
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class TerminalMaskingShape : global::UnityEngine.UI.MaskableGraphic, global::UnityEngine.UI.ILayoutElement, global::UnityEngine.UI.ILayoutIgnorer, global::UnityEngine.UI.IMaskable
    {
        private static global::UnityEngine.Material s_SharedTerminalMaterial;
        private global::UnityEngine.UI.Mask _mask;
        private global::UnityEngine.UI.Mask _parentMask;
        private bool _shouldRecalculateStencil;
        private int _stencilBits;
        public override bool raycastTarget
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        float global::UnityEngine.UI.ILayoutElement.minWidth => 0f;

        float global::UnityEngine.UI.ILayoutElement.preferredWidth => 0f;

        float global::UnityEngine.UI.ILayoutElement.flexibleWidth => 0f;

        float global::UnityEngine.UI.ILayoutElement.minHeight => 0f;

        float global::UnityEngine.UI.ILayoutElement.preferredHeight => 0f;

        float global::UnityEngine.UI.ILayoutElement.flexibleHeight => 0f;

        int global::UnityEngine.UI.ILayoutElement.layoutPriority => 0;

        bool global::UnityEngine.UI.ILayoutIgnorer.ignoreLayout => false;

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        void global::UnityEngine.UI.ILayoutElement.CalculateLayoutInputHorizontal()
        {
        }

        void global::UnityEngine.UI.ILayoutElement.CalculateLayoutInputVertical()
        {
        }

        void global::UnityEngine.UI.IMaskable.RecalculateMasking()
        {
        }

        public override global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        private void RecalculateStencilIfNeeded()
        {
        }
    }
}