namespace Coffee.UIEffects
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class UIEffect : global::Coffee.UIEffects.BaseMaterialEffect, global::UnityEngine.UI.IMaterialModifier
    {
        private enum BlurEx
        {
            None = 0,
            Ex = 1
        }

        private const uint k_ShaderId = 16u;
        private static readonly global::Coffee.UIEffects.ParameterTexture s_ParamTex;
        [global::UnityEngine.SerializeField]
        private float m_EffectFactor;
        [global::UnityEngine.SerializeField]
        private float m_ColorFactor;
        [global::UnityEngine.SerializeField]
        private float m_BlurFactor;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.EffectMode m_EffectMode;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.ColorMode m_ColorMode;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.BlurMode m_BlurMode;
        [global::UnityEngine.SerializeField]
        private bool m_AdvancedBlur;
        public global::UnityEngine.AdditionalCanvasShaderChannels uvMaskChannel => global::UnityEngine.AdditionalCanvasShaderChannels.None;

        public float effectFactor
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float colorFactor
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float blurFactor
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::Coffee.UIEffects.EffectMode effectMode
        {
            get
            {
                return global::Coffee.UIEffects.EffectMode.None;
            }

            set
            {
            }
        }

        public global::Coffee.UIEffects.ColorMode colorMode
        {
            get
            {
                return global::Coffee.UIEffects.ColorMode.Multiply;
            }

            set
            {
            }
        }

        public global::Coffee.UIEffects.BlurMode blurMode
        {
            get
            {
                return global::Coffee.UIEffects.BlurMode.None;
            }

            set
            {
            }
        }

        public override global::Coffee.UIEffects.ParameterTexture paramTex => null;

        public bool advancedBlur
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

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

        private static void GetBounds(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> verts, int start, int count, ref global::UnityEngine.Rect posBounds, ref global::UnityEngine.Rect uvBounds, bool global)
        {
        }
    }
}