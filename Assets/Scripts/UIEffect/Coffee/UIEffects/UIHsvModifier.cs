namespace Coffee.UIEffects
{
    public class UIHsvModifier : global::Coffee.UIEffects.BaseMaterialEffect
    {
        private const uint k_ShaderId = 48u;
        private static readonly global::Coffee.UIEffects.ParameterTexture s_ParamTex;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_TargetColor;
        [global::UnityEngine.SerializeField]
        private float m_Range;
        [global::UnityEngine.SerializeField]
        private float m_Hue;
        [global::UnityEngine.SerializeField]
        private float m_Saturation;
        [global::UnityEngine.SerializeField]
        private float m_Value;
        public global::UnityEngine.Color targetColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public float range
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float saturation
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float value
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float hue
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public override global::Coffee.UIEffects.ParameterTexture paramTex => null;

        public override global::UnityEngine.Hash128 GetMaterialHash(global::UnityEngine.Material material)
        {
            return default;
        }

        public override void ModifyMaterial(global::UnityEngine.Material newMaterial, global::UnityEngine.UI.Graphic graphic)
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh, global::UnityEngine.UI.Graphic graphic)
        {
        }

        protected override void SetEffectParamsDirty()
        {
        }
    }
}