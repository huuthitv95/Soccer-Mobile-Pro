namespace Coffee.UISoftMask
{
    internal static class Utils
    {
        public static void UpdateAntiAlias(global::UnityEngine.UI.Graphic graphic, bool enabled, float threshold)
        {
        }

        public static int GetStencilBits(global::UnityEngine.Transform transform, bool includeSelf, bool useStencil, out global::UnityEngine.UI.Mask nearestMask, out global::Coffee.UISoftMask.SoftMask nearestSoftMask)
        {
            nearestMask = null;
            nearestSoftMask = null;
            return 0;
        }

        public static bool AlphaHitTestValid(global::UnityEngine.UI.Graphic src, global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera, float threshold)
        {
            return false;
        }

        private static bool AlphaHitTestValid(global::UnityEngine.UI.Image src, global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera, float threshold)
        {
            return false;
        }

        private static bool AlphaHitTestValid(global::UnityEngine.UI.RawImage src, global::UnityEngine.Vector2 sp, global::UnityEngine.Camera eventCamera, float threshold)
        {
            return false;
        }

        public static int GetHighestBit(int i)
        {
            return 0;
        }
    }
}