namespace UnityEngine.UI
{
    public abstract class BaseMeshEffect : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.IMeshModifier
    {
        [global::System.NonSerialized]
        private global::UnityEngine.UI.Graphic m_Graphic;
        protected global::UnityEngine.UI.Graphic graphic => null;

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        public virtual void ModifyMesh(global::UnityEngine.Mesh mesh)
        {
        }

        public abstract void ModifyMesh(global::UnityEngine.UI.VertexHelper vh);
    }
}