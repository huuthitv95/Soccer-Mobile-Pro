namespace UnityEngine.UI.Extensions
{
    public class SoftMaskScript : global::UnityEngine.MonoBehaviour
    {
        private global::UnityEngine.Material mat;
        private global::UnityEngine.Canvas cachedCanvas;
        private global::UnityEngine.Transform cachedCanvasTransform;
        private readonly global::UnityEngine.Vector3[] m_WorldCorners;
        private readonly global::UnityEngine.Vector3[] m_CanvasCorners;
        public global::UnityEngine.RectTransform MaskArea;
        public global::UnityEngine.Texture AlphaMask;
        public float CutOff;
        public bool HardBlend;
        public bool FlipAlphaMask;
        public bool DontClipMaskScalingRect;
        private global::UnityEngine.Vector2 maskOffset;
        private global::UnityEngine.Vector2 maskScale;
        private void Start()
        {
        }

        private void Update()
        {
        }

        private void SetMask()
        {
        }

        public global::UnityEngine.Rect GetCanvasRect()
        {
            return default;
        }
    }
}