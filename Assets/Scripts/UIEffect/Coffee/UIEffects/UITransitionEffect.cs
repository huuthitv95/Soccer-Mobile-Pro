namespace Coffee.UIEffects
{
    public class UITransitionEffect : global::Coffee.UIEffects.BaseMaterialEffect
    {
        public enum EffectMode
        {
            Fade = 1,
            Cutoff = 2,
            Dissolve = 3
        }

        private const uint k_ShaderId = 40u;
        private static readonly int k_TransitionTexId;
        private static readonly global::Coffee.UIEffects.ParameterTexture s_ParamTex;
        private bool _lastKeepAspectRatio;
        private static global::UnityEngine.Texture _defaultTransitionTexture;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.UITransitionEffect.EffectMode m_EffectMode;
        [global::UnityEngine.SerializeField]
        private float m_EffectFactor;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Texture m_TransitionTexture;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UIEffects.EffectArea m_EffectArea;
        [global::UnityEngine.SerializeField]
        private bool m_KeepAspectRatio;
        [global::UnityEngine.SerializeField]
        private float m_DissolveWidth;
        [global::UnityEngine.SerializeField]
        private float m_DissolveSoftness;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_DissolveColor;
        [global::UnityEngine.SerializeField]
        private bool m_PassRayOnHidden;
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

        public global::Coffee.UIEffects.UITransitionEffect.EffectMode effectMode
        {
            get
            {
                return (global::Coffee.UIEffects.UITransitionEffect.EffectMode)0;
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

        public override global::Coffee.UIEffects.ParameterTexture paramTex => null;

        public float dissolveWidth
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float dissolveSoftness
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color dissolveColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public bool passRayOnHidden
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::Coffee.UIEffects.EffectPlayer effectPlayer => null;

        public void Show(bool reset = true)
        {
        }

        public void Hide(bool reset = true)
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

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
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