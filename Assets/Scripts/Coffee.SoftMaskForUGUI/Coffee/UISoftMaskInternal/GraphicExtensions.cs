namespace Coffee.UISoftMaskInternal
{
    internal static class GraphicExtensions
    {
        private static readonly global::UnityEngine.Vector3[] s_WorldCorners;
        private static readonly global::UnityEngine.Bounds s_ScreenBounds;
        public static global::UnityEngine.Material GetMaterialForRendering(this global::UnityEngine.UI.Graphic self)
        {
            return null;
        }

        public static void GetMaterialsForRendering(this global::UnityEngine.UI.Graphic self, global::System.Collections.Generic.List<global::UnityEngine.Material> result)
        {
        }

        public static bool IsInScreen(this global::UnityEngine.UI.Graphic self)
        {
            return false;
        }

        public static global::UnityEngine.Texture GetActualMainTexture(this global::UnityEngine.UI.Graphic self)
        {
            return null;
        }

        private static global::UnityEngine.Vector2Int GetScreenSize()
        {
            return default;
        }

        public static float GetParentGroupAlpha(this global::UnityEngine.UI.Graphic self)
        {
            return 0f;
        }
    }
}