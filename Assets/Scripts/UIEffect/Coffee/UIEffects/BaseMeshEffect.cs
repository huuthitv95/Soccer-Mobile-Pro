namespace Coffee.UIEffects
{
    public abstract class BaseMeshEffect : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.IMeshModifier
    {
        private global::UnityEngine.RectTransform _rectTransform;
        private global::UnityEngine.UI.Graphic _graphic;
        private global::Coffee.UIEffects.GraphicConnector _connector;
        internal readonly global::System.Collections.Generic.List<global::Coffee.UIEffects.UISyncEffect> syncEffects;
        protected global::Coffee.UIEffects.GraphicConnector connector => null;
        public global::UnityEngine.UI.Graphic graphic => null;
        protected global::UnityEngine.RectTransform rectTransform => null;

        public virtual void ModifyMesh(global::UnityEngine.Mesh mesh)
        {
        }

        public virtual void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        public virtual void ModifyMesh(global::UnityEngine.UI.VertexHelper vh, global::UnityEngine.UI.Graphic graphic)
        {
        }

        protected virtual void SetVerticesDirty()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected virtual void SetEffectParamsDirty()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }
    }
}