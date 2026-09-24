namespace UnityEngine.UI
{
    public class LayoutRebuilder : global::UnityEngine.UI.ICanvasElement
    {
        private global::UnityEngine.RectTransform m_ToRebuild;
        private int m_CachedHashFromTransform;
        private static global::UnityEngine.UI.ObjectPool<global::UnityEngine.UI.LayoutRebuilder> s_Rebuilders;
        public global::UnityEngine.Transform transform => null;

        private void Initialize(global::UnityEngine.RectTransform controller)
        {
        }

        private void Clear()
        {
        }

        static LayoutRebuilder()
        {
        }

        private static void ReapplyDrivenProperties(global::UnityEngine.RectTransform driven)
        {
        }

        public bool IsDestroyed()
        {
            return false;
        }

        private static void StripDisabledBehavioursFromList(global::System.Collections.Generic.List<global::UnityEngine.Component> components)
        {
        }

        public static void ForceRebuildLayoutImmediate(global::UnityEngine.RectTransform layoutRoot)
        {
        }

        public void Rebuild(global::UnityEngine.UI.CanvasUpdate executing)
        {
        }

        private void PerformLayoutControl(global::UnityEngine.RectTransform rect, global::UnityEngine.Events.UnityAction<global::UnityEngine.Component> action)
        {
        }

        private void PerformLayoutCalculation(global::UnityEngine.RectTransform rect, global::UnityEngine.Events.UnityAction<global::UnityEngine.Component> action)
        {
        }

        public static void MarkLayoutForRebuild(global::UnityEngine.RectTransform rect)
        {
        }

        private static bool ValidController(global::UnityEngine.RectTransform layoutRoot, global::System.Collections.Generic.List<global::UnityEngine.Component> comps)
        {
            return false;
        }

        private static void MarkLayoutRootForRebuild(global::UnityEngine.RectTransform controller)
        {
        }

        public void LayoutComplete()
        {
        }

        public void GraphicUpdateComplete()
        {
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override string ToString()
        {
            return null;
        }
    }
}