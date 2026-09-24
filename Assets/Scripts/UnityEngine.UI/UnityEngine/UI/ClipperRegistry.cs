namespace UnityEngine.UI
{
    public class ClipperRegistry
    {
        private static global::UnityEngine.UI.ClipperRegistry s_Instance;
        private readonly global::UnityEngine.UI.Collections.IndexedSet<global::UnityEngine.UI.IClipper> m_Clippers;
        public static global::UnityEngine.UI.ClipperRegistry instance => null;

        protected ClipperRegistry()
        {
        }

        public void Cull()
        {
        }

        public static void Register(global::UnityEngine.UI.IClipper c)
        {
        }

        public static void Unregister(global::UnityEngine.UI.IClipper c)
        {
        }

        public static void Disable(global::UnityEngine.UI.IClipper c)
        {
        }
    }
}