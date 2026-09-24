namespace TMPro
{
    public class TMP_UpdateRegistry
    {
        private static global::TMPro.TMP_UpdateRegistry s_Instance;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;
        private global::System.Collections.Generic.HashSet<int> m_LayoutQueueLookup;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;
        private global::System.Collections.Generic.HashSet<int> m_GraphicQueueLookup;
        public static global::TMPro.TMP_UpdateRegistry instance => null;

        protected TMP_UpdateRegistry()
        {
        }

        public static void RegisterCanvasElementForLayoutRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        private bool InternalRegisterCanvasElementForLayoutRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
            return false;
        }

        public static void RegisterCanvasElementForGraphicRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        private bool InternalRegisterCanvasElementForGraphicRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
            return false;
        }

        private void PerformUpdateForCanvasRendererObjects()
        {
        }

        private void PerformUpdateForMeshRendererObjects()
        {
        }

        public static void UnRegisterCanvasElementForRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        private void InternalUnRegisterCanvasElementForLayoutRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        private void InternalUnRegisterCanvasElementForGraphicRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }
    }
}