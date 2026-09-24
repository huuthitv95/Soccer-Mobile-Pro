namespace Coffee.UIEffects
{
    public class UISyncEffect : global::Coffee.UIEffects.BaseMaterialEffect
    {
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.BaseMeshEffect m_TargetEffect;
        public global::Coffee.UIEffects.BaseMeshEffect targetEffect
        {
            get
            {
                return null;
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

        public override global::UnityEngine.Hash128 GetMaterialHash(global::UnityEngine.Material baseMaterial)
        {
            return default;
        }

        public override void ModifyMaterial(global::UnityEngine.Material newMaterial, global::UnityEngine.UI.Graphic graphic)
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh, global::UnityEngine.UI.Graphic graphic)
        {
        }
    }
}