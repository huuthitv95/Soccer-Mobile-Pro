namespace Coffee.UISoftMask
{
    public class UISoftMaskProjectSettings : global::Coffee.UISoftMaskInternal.PreloadedProjectSettings<global::Coffee.UISoftMask.UISoftMaskProjectSettings>
    {
        private static bool s_UseStereoMock;
        [global::UnityEngine.SerializeField]
        internal bool m_SoftMaskEnabled;
        [global::UnityEngine.SerializeField]
        private bool m_StereoEnabled;
        [global::UnityEngine.SerializeField]
        private global::Coffee.UISoftMaskInternal.TransformSensitivity m_TransformSensitivity;
        [global::UnityEngine.SerializeField]
        private bool m_HideGeneratedComponents;
        [global::UnityEngine.HideInInspector]
        [global::UnityEngine.SerializeField]
        private global::Coffee.UISoftMaskInternal.ShaderVariantRegistry m_ShaderVariantRegistry;
        public static global::Coffee.UISoftMaskInternal.ShaderVariantRegistry shaderRegistry => null;
        public static global::UnityEngine.ShaderVariantCollection shaderVariantCollection => null;
        public static bool softMaskEnabled => false;
        public static bool useStencilOutsideScreen => false;
        public static bool stereoEnabled => false;
        public static global::UnityEngine.HideFlags hideFlagsForTemp => global::UnityEngine.HideFlags.None;

        public static global::Coffee.UISoftMaskInternal.TransformSensitivity transformSensitivity
        {
            get
            {
                return global::Coffee.UISoftMaskInternal.TransformSensitivity.Low;
            }

            set
            {
            }
        }

        public static bool useStereoMock
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        private static void ResetAllSoftMasks()
        {
        }
    }
}