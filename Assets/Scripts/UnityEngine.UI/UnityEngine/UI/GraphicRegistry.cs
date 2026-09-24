namespace UnityEngine.UI
{
    public class GraphicRegistry
    {
        private static global::UnityEngine.UI.GraphicRegistry s_Instance;
        private readonly global::System.Collections.Generic.Dictionary<global::UnityEngine.Canvas, global::UnityEngine.UI.Collections.IndexedSet<global::UnityEngine.UI.Graphic>> m_Graphics;
        private readonly global::System.Collections.Generic.Dictionary<global::UnityEngine.Canvas, global::UnityEngine.UI.Collections.IndexedSet<global::UnityEngine.UI.Graphic>> m_RaycastableGraphics;
        private static readonly global::System.Collections.Generic.List<global::UnityEngine.UI.Graphic> s_EmptyList;
        public static global::UnityEngine.UI.GraphicRegistry instance => null;

        protected GraphicRegistry()
        {
        }

        public static void RegisterGraphicForCanvas(global::UnityEngine.Canvas c, global::UnityEngine.UI.Graphic graphic)
        {
        }

        public static void RegisterRaycastGraphicForCanvas(global::UnityEngine.Canvas c, global::UnityEngine.UI.Graphic graphic)
        {
        }

        public static void UnregisterGraphicForCanvas(global::UnityEngine.Canvas c, global::UnityEngine.UI.Graphic graphic)
        {
        }

        public static void UnregisterRaycastGraphicForCanvas(global::UnityEngine.Canvas c, global::UnityEngine.UI.Graphic graphic)
        {
        }

        public static void DisableGraphicForCanvas(global::UnityEngine.Canvas c, global::UnityEngine.UI.Graphic graphic)
        {
        }

        public static void DisableRaycastGraphicForCanvas(global::UnityEngine.Canvas c, global::UnityEngine.UI.Graphic graphic)
        {
        }

        public static global::System.Collections.Generic.IList<global::UnityEngine.UI.Graphic> GetGraphicsForCanvas(global::UnityEngine.Canvas canvas)
        {
            return null;
        }

        public static global::System.Collections.Generic.IList<global::UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(global::UnityEngine.Canvas canvas)
        {
            return null;
        }
    }
}