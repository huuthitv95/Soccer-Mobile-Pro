namespace LeTai.TrueShadow
{
    public class ShadowMaterial : global::UnityEngine.MonoBehaviour, global::LeTai.TrueShadow.PluginInterfaces.ITrueShadowRendererMaterialProvider
    {
        public global::UnityEngine.Material material;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action m_materialReplaced;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action m_materialModified;
        public event global::System.Action materialReplaced
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public event global::System.Action materialModified
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public global::UnityEngine.Material GetTrueShadowRendererMaterial()
        {
            return null;
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void OnValidate()
        {
        }

        public void OnMaterialModified()
        {
        }
    }
}