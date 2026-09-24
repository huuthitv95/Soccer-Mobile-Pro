namespace LeTai
{
    public static class ExtensionMethods
    {
        private static global::UnityEngine.Mesh fullscreenTriangle;
        private static global::UnityEngine.Mesh FullscreenTriangle => null;

        public static global::UnityEngine.Vector4 ToMinMaxVector(this global::UnityEngine.Rect self)
        {
            return default;
        }

        public static void BlitFullscreenTriangle(this global::UnityEngine.Rendering.CommandBuffer cmd, global::UnityEngine.Rendering.RenderTargetIdentifier source, global::UnityEngine.Rendering.RenderTargetIdentifier destination, global::UnityEngine.Material material, int pass = 0)
        {
        }

        internal static bool Approximately(this global::UnityEngine.Rect self, global::UnityEngine.Rect other)
        {
            return false;
        }

        private static bool QuickApproximate(float a, float b)
        {
            return false;
        }

        public static global::UnityEngine.Vector3 WithZ(this global::UnityEngine.Vector2 self, float z)
        {
            return default;
        }

        public static global::UnityEngine.Color WithA(this global::UnityEngine.Color self, float a)
        {
            return default;
        }

        public static void NextFrames(this global::UnityEngine.MonoBehaviour behaviour, global::System.Action action, int nFrames = 1)
        {
        }

        private static global::System.Collections.IEnumerator NextFrame(global::System.Action action, int nFrames)
        {
            return null;
        }

        public static void SetKeyword(this global::UnityEngine.Material material, string keyword, bool enabled)
        {
        }

        public static global::UnityEngine.Vector2 Frac(this global::UnityEngine.Vector2 vec)
        {
            return default;
        }

        public static global::UnityEngine.Vector2 LocalToScreenPoint(this global::UnityEngine.RectTransform rt, global::UnityEngine.Vector3 localPoint, global::UnityEngine.Camera referenceCamera = null)
        {
            return default;
        }

        public static global::UnityEngine.Vector2 ScreenToCanvasSize(this global::UnityEngine.RectTransform rt, global::UnityEngine.Vector2 size, global::UnityEngine.Camera referenceCamera = null)
        {
            return default;
        }
    }
}