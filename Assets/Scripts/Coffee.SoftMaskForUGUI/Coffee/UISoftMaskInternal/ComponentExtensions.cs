namespace Coffee.UISoftMaskInternal
{
    internal static class ComponentExtensions
    {
        public static T[] GetComponentsInChildren<T>(this global::UnityEngine.Component self, int depth)
            where T : global::UnityEngine.Component
        {
            return null;
        }

        public static void GetComponentsInChildren<T>(this global::UnityEngine.Component self, global::System.Collections.Generic.List<T> results, int depth)
            where T : global::UnityEngine.Component
        {
        }

        private static void GetComponentsInChildren_Internal<T>(this global::UnityEngine.Component self, global::System.Collections.Generic.List<T> results, int depth)
            where T : global::UnityEngine.Component
        {
        }

        public static T GetOrAddComponent<T>(this global::UnityEngine.Component self)
            where T : global::UnityEngine.Component
        {
            return null;
        }

        public static T GetRootComponent<T>(this global::UnityEngine.Component self)
            where T : global::UnityEngine.Component
        {
            return null;
        }

        public static T GetComponentInParent<T>(this global::UnityEngine.Component self, bool includeSelf, global::UnityEngine.Transform stopAfter, global::System.Predicate<T> valid)
            where T : global::UnityEngine.Component
        {
            return null;
        }

        public static void AddComponentOnChildren<T>(this global::UnityEngine.Component self, global::UnityEngine.HideFlags hideFlags, bool includeSelf)
            where T : global::UnityEngine.Component
        {
        }

        public static void AddComponentOnChildren<T>(this global::UnityEngine.Component self, bool includeSelf)
            where T : global::UnityEngine.Component
        {
        }

        public static T GetComponentInParent<T>(this global::UnityEngine.Component self, bool includeInactive)
            where T : global::UnityEngine.Component
        {
            return null;
        }
    }
}