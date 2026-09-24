namespace Common
{
    public class FastDepthOfField : global::UnityEngine.MonoBehaviour
    {
        public enum RenderTextureSize
        {
            ClosestPowerOfTwo = 0,
            NextPowerOfTwo = 1,
            PreviousPowerOfTwo = 2
        }

        private enum DOFShaderPass
        {
            MipmapGeneration = 0,
            DepthOfField = 1,
            DepthOfField_Debug = 2
        }

        public float focusDistance;
        public float focusRange;
        public float maxTexLOD;
        public global::Common.FastDepthOfField.RenderTextureSize renderTextureSize;
        public bool debug;
        private global::UnityEngine.Material dofMaterial;
        private global::UnityEngine.RenderTexture dofRenderTexture;
        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void Start()
        {
        }

        private void OnRenderImage(global::UnityEngine.RenderTexture source, global::UnityEngine.RenderTexture destination)
        {
        }
    }
}