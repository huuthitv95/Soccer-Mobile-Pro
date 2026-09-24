namespace UnityEngine.UI
{
    public class CanvasUpdateRegistry
    {
        private static global::UnityEngine.UI.CanvasUpdateRegistry s_Instance;
        private bool m_PerformingLayoutUpdate;
        private bool m_PerformingGraphicUpdate;
        private string[] m_CanvasUpdateProfilerStrings;
        private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
        private readonly global::UnityEngine.UI.Collections.IndexedSet<global::UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;
        private readonly global::UnityEngine.UI.Collections.IndexedSet<global::UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;
        private static readonly global::System.Comparison<global::UnityEngine.UI.ICanvasElement> s_SortLayoutFunction;
        public static global::UnityEngine.UI.CanvasUpdateRegistry instance => null;

        protected CanvasUpdateRegistry()
        {
        }

        private bool ObjectValidForUpdate(global::UnityEngine.UI.ICanvasElement element)
        {
            return false;
        }

        private void CleanInvalidItems()
        {
        }

        private void PerformUpdate()
        {
        }

        private static int ParentCount(global::UnityEngine.Transform child)
        {
            return 0;
        }

        private static int SortLayoutList(global::UnityEngine.UI.ICanvasElement x, global::UnityEngine.UI.ICanvasElement y)
        {
            return 0;
        }

        public static void RegisterCanvasElementForLayoutRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        public static bool TryRegisterCanvasElementForLayoutRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
            return false;
        }

        private bool InternalRegisterCanvasElementForLayoutRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
            return false;
        }

        public static void RegisterCanvasElementForGraphicRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        public static bool TryRegisterCanvasElementForGraphicRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
            return false;
        }

        private bool InternalRegisterCanvasElementForGraphicRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
            return false;
        }

        public static void UnRegisterCanvasElementForRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        public static void DisableCanvasElementForRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        private void InternalUnRegisterCanvasElementForLayoutRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        private void InternalUnRegisterCanvasElementForGraphicRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        private void InternalDisableCanvasElementForLayoutRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        private void InternalDisableCanvasElementForGraphicRebuild(global::UnityEngine.UI.ICanvasElement element)
        {
        }

        public static bool IsRebuildingLayout()
        {
            return false;
        }

        public static bool IsRebuildingGraphics()
        {
            return false;
        }
    }
}