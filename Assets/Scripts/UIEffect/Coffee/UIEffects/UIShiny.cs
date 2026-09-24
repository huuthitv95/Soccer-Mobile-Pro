namespace Coffee.UIEffects
{
    public class UIShiny : global::Coffee.UIEffects.BaseMaterialEffect
    {
        [global::UnityEngine.SerializeField]
        private bool onlyMask;
        private const uint k_ShaderId = 8u;
        private static readonly global::Coffee.UIEffects.ParameterTexture s_ParamTex;
        private float _lastRotation;
        private global::Coffee.UIEffects.EffectArea _lastEffectArea;
        [global::UnityEngine.SerializeField]
        private float m_EffectFactor;
        [global::UnityEngine.SerializeField]
        private float m_Width;
        [global::UnityEngine.SerializeField]
        private float m_Rotation;
        [global::UnityEngine.SerializeField]
        private float m_Softness;
        [global::UnityEngine.SerializeField]
        private float m_Brightness;
        [global::UnityEngine.SerializeField]
        private float m_Gloss;
        [global::UnityEngine.SerializeField]
        protected global::Coffee.UIEffects.EffectArea m_EffectArea;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.EffectPlayer m_Player;
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

        public float width
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float softness
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float brightness
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float gloss
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float rotation
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::Coffee.UIEffects.EffectArea effectArea
        {
            get
            {
                return global::Coffee.UIEffects.EffectArea.RectTransform;
            }

            set
            {
            }
        }

        public override global::Coffee.UIEffects.ParameterTexture paramTex => null;
        public global::Coffee.UIEffects.EffectPlayer effectPlayer => null;

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
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

        public void Play(bool reset = true)
        {
        }

        public void Stop(bool reset = true)
        {
        }

        protected override void SetEffectParamsDirty()
        {
        }

        protected override void SetVerticesDirty()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }
    }
}