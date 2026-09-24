namespace Coffee.UIEffects
{
    [global::UnityEngine.DisallowMultipleComponent]
    public abstract class BaseMaterialEffect : global::Coffee.UIEffects.BaseMeshEffect, global::Coffee.UIEffects.IParameterTexture, global::UnityEngine.UI.IMaterialModifier
    {
        protected static readonly global::UnityEngine.Hash128 k_InvalidHash;
        protected static readonly global::System.Collections.Generic.List<global::UnityEngine.UIVertex> s_TempVerts;
        private static readonly global::System.Text.StringBuilder s_StringBuilder;
        private global::UnityEngine.Hash128 _effectMaterialHash;
        public int parameterIndex { get; set; }
        public virtual global::Coffee.UIEffects.ParameterTexture paramTex => null;

        public void SetMaterialDirty()
        {
        }

        public virtual global::UnityEngine.Hash128 GetMaterialHash(global::UnityEngine.Material baseMaterial)
        {
            return default;
        }

        public global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        public virtual global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial, global::UnityEngine.UI.Graphic graphic)
        {
            return null;
        }

        public virtual void ModifyMaterial(global::UnityEngine.Material newMaterial, global::UnityEngine.UI.Graphic graphic)
        {
        }

        protected void SetShaderVariants(global::UnityEngine.Material newMaterial, params object[] variants)
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }
    }
}