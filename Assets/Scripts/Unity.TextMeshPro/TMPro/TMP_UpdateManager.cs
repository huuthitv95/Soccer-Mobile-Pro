namespace TMPro
{
    public class TMP_UpdateManager
    {
        private static global::TMPro.TMP_UpdateManager s_Instance;
        private readonly global::System.Collections.Generic.HashSet<int> m_LayoutQueueLookup;
        private readonly global::System.Collections.Generic.List<global::TMPro.TMP_Text> m_LayoutRebuildQueue;
        private readonly global::System.Collections.Generic.HashSet<int> m_GraphicQueueLookup;
        private readonly global::System.Collections.Generic.List<global::TMPro.TMP_Text> m_GraphicRebuildQueue;
        private readonly global::System.Collections.Generic.HashSet<int> m_InternalUpdateLookup;
        private readonly global::System.Collections.Generic.List<global::TMPro.TMP_Text> m_InternalUpdateQueue;
        private readonly global::System.Collections.Generic.HashSet<int> m_CullingUpdateLookup;
        private readonly global::System.Collections.Generic.List<global::TMPro.TMP_Text> m_CullingUpdateQueue;
        private static global::Unity.Profiling.ProfilerMarker k_RegisterTextObjectForUpdateMarker;
        private static global::Unity.Profiling.ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker;
        private static global::Unity.Profiling.ProfilerMarker k_RegisterTextElementForCullingUpdateMarker;
        private static global::Unity.Profiling.ProfilerMarker k_UnregisterTextObjectForUpdateMarker;
        private static global::Unity.Profiling.ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker;
        private static global::TMPro.TMP_UpdateManager instance => null;

        private TMP_UpdateManager()
        {
        }

        internal static void RegisterTextObjectForUpdate(global::TMPro.TMP_Text textObject)
        {
        }

        private void InternalRegisterTextObjectForUpdate(global::TMPro.TMP_Text textObject)
        {
        }

        public static void RegisterTextElementForLayoutRebuild(global::TMPro.TMP_Text element)
        {
        }

        private void InternalRegisterTextElementForLayoutRebuild(global::TMPro.TMP_Text element)
        {
        }

        public static void RegisterTextElementForGraphicRebuild(global::TMPro.TMP_Text element)
        {
        }

        private void InternalRegisterTextElementForGraphicRebuild(global::TMPro.TMP_Text element)
        {
        }

        public static void RegisterTextElementForCullingUpdate(global::TMPro.TMP_Text element)
        {
        }

        private void InternalRegisterTextElementForCullingUpdate(global::TMPro.TMP_Text element)
        {
        }

        private void OnCameraPreCull()
        {
        }

        private void DoRebuilds()
        {
        }

        internal static void UnRegisterTextObjectForUpdate(global::TMPro.TMP_Text textObject)
        {
        }

        public static void UnRegisterTextElementForRebuild(global::TMPro.TMP_Text element)
        {
        }

        private void InternalUnRegisterTextElementForGraphicRebuild(global::TMPro.TMP_Text element)
        {
        }

        private void InternalUnRegisterTextElementForLayoutRebuild(global::TMPro.TMP_Text element)
        {
        }

        private void InternalUnRegisterTextObjectForUpdate(global::TMPro.TMP_Text textObject)
        {
        }
    }
}