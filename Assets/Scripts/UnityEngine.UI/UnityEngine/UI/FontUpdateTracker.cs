namespace UnityEngine.UI
{
    public static class FontUpdateTracker
    {
        private static global::System.Collections.Generic.Dictionary<global::UnityEngine.Font, global::System.Collections.Generic.HashSet<global::UnityEngine.UI.Text>> m_Tracked;
        public static void TrackText(global::UnityEngine.UI.Text t)
        {
        }

        private static void RebuildForFont(global::UnityEngine.Font f)
        {
        }

        public static void UntrackText(global::UnityEngine.UI.Text t)
        {
        }
    }
}