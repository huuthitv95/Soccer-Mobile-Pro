namespace Coffee.UIEffects
{
    public class UIDissolve : global::Coffee.UIEffects.BaseMaterialEffect, global::UnityEngine.UI.IMaterialModifier
    {
        private const uint k_ShaderId = 0u;
        private static readonly global::Coffee.UIEffects.ParameterTexture s_ParamTex;
        private static readonly int k_TransitionTexId;
        private bool _lastKeepAspectRatio;
        private global::Coffee.UIEffects.EffectArea _lastEffectArea;
        private static global::UnityEngine.Texture _defaultTransitionTexture;
        [global::UnityEngine.SerializeField]
        private float m_EffectFactor;
        [global::UnityEngine.SerializeField]
        private float m_Width;
        [global::UnityEngine.SerializeField]
        private float m_Softness;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_Color;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.ColorMode m_ColorMode;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Texture m_TransitionTexture;
        [global::UnityEngine.SerializeField]
        protected global::Coffee.UIEffects.EffectArea m_EffectArea;
        [global::UnityEngine.SerializeField]
        private bool m_KeepAspectRatio;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.EffectPlayer m_Player;
        [global::UnityEngine.SerializeField]
        private bool m_Reverse;
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

        public global::UnityEngine.Color color
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.Texture transitionTexture
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        private static global::UnityEngine.Texture defaultTransitionTexture => null;

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

        public bool keepAspectRatio
        {
            get
            {
                return false;
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

        public override global::Coffee.UIEffects.ParameterTexture paramTex => null;
        public global::Coffee.UIEffects.EffectPlayer effectPlayer => null;

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

        protected override void SetVerticesDirty()
        {
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        public void Play(bool reset = true)
        {
        }

        public void Stop(bool reset = true)
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