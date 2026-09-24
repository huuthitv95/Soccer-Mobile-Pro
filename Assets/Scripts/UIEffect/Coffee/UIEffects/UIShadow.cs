namespace Coffee.UIEffects
{
    public class UIShadow : global::Coffee.UIEffects.BaseMeshEffect, global::Coffee.UIEffects.IParameterTexture
    {
        private static readonly global::System.Collections.Generic.List<global::Coffee.UIEffects.UIShadow> tmpShadows;
        private static readonly global::System.Collections.Generic.List<global::UnityEngine.UIVertex> s_Verts;
        private int _graphicVertexCount;
        private global::Coffee.UIEffects.UIEffect _uiEffect;
        [global::UnityEngine.SerializeField]
        private float m_BlurFactor;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.ShadowStyle m_Style;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_EffectColor;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Vector2 m_EffectDistance;
        [global::UnityEngine.SerializeField]
        private bool m_UseGraphicAlpha;
        private const float kMaxEffectDistance = 600f;
        public global::UnityEngine.Color effectColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Vector2 effectDistance
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public bool useGraphicAlpha
        {
            get
            {
                return false;
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

        public global::Coffee.UIEffects.ShadowStyle style
        {
            get
            {
                return global::Coffee.UIEffects.ShadowStyle.None;
            }

            set
            {
            }
        }

        public int parameterIndex { get; set; }
        public global::Coffee.UIEffects.ParameterTexture paramTex { get; private set; }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh, global::UnityEngine.UI.Graphic graphic)
        {
        }

        private void ApplyShadow(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> verts, global::UnityEngine.Color color, ref int start, ref int end, global::UnityEngine.Vector2 distance, global::Coffee.UIEffects.ShadowStyle style, bool alpha)
        {
        }

        private void ApplyShadowZeroAlloc(global::System.Collections.Generic.List<global::UnityEngine.UIVertex> verts, global::UnityEngine.Color color, ref int start, ref int end, float x, float y, bool alpha)
        {
        }
    }
}