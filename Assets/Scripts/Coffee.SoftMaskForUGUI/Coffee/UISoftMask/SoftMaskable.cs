namespace Coffee.UISoftMask
{
    public class SoftMaskable : global::UnityEngine.MonoBehaviour, global::UnityEngine.UI.IMaterialModifier, global::UnityEngine.UI.IMaskable
    {
        private static readonly int s_SoftMaskableStereo;
        private static readonly int s_SoftMaskOutsideColor;
        private static readonly int s_SoftMaskTex;
        private static readonly int s_SoftMaskColor;
        private static readonly int s_AllowDynamicResolution;
        private static readonly int s_AllowRenderScale;
        private static readonly int s_SoftMaskingPower;
        private const float k_PowerMin = 0.5f;
        private const float k_PowerMax = 5f;
        [global::UnityEngine.SerializeField]
        private bool m_IgnoreSelf;
        [global::UnityEngine.SerializeField]
        private bool m_IgnoreChildren;
        [global::UnityEngine.SerializeField]
        private float m_Power;
        private global::System.Action _checkGraphic;
        private global::UnityEngine.UI.MaskableGraphic _graphic;
        private global::UnityEngine.Material _maskableMaterial;
        private bool _shouldRecalculateStencil;
        private global::UnityEngine.UI.Mask _mask;
        private global::Coffee.UISoftMask.SoftMask _softMask;
        private int _softMaskDepth;
        private int _stencilBits;
        public bool ignoreSelf
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool ignoreChildren
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool ignored => false;

        public float power
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        private bool isTerminal => false;

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnDestroy()
        {
        }

        private void OnTransformChildrenChanged()
        {
        }

        private void OnTransformParentChanged()
        {
        }

        void global::UnityEngine.UI.IMaskable.RecalculateMasking()
        {
        }

        global::UnityEngine.Material global::UnityEngine.UI.IMaterialModifier.GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
        {
            return null;
        }

        private void RecalculateStencilIfNeeded()
        {
        }

        private void CheckGraphic()
        {
        }

        public void SetMaterialDirty()
        {
        }

        public void SetMaterialDirtyForChildren()
        {
        }

        internal void ReleaseMaterial()
        {
        }

        private void UpdateHideFlags()
        {
        }
    }
}