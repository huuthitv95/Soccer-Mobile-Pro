namespace UnityEngine.UI
{
	internal class ReflectionMethodsCache
	{
		public delegate bool Raycast3DCallback(global::UnityEngine.Ray r, out global::UnityEngine.RaycastHit hit, float f, int i);

		public delegate global::UnityEngine.RaycastHit[] RaycastAllCallback(global::UnityEngine.Ray r, float f, int i);

		public delegate int GetRaycastNonAllocCallback(global::UnityEngine.Ray r, global::UnityEngine.RaycastHit[] results, float f, int i);

		public delegate global::UnityEngine.RaycastHit2D Raycast2DCallback(global::UnityEngine.Vector2 p1, global::UnityEngine.Vector2 p2, float f, int i);

		public delegate global::UnityEngine.RaycastHit2D[] GetRayIntersectionAllCallback(global::UnityEngine.Ray r, float f, int i);

		public delegate int GetRayIntersectionAllNonAllocCallback(global::UnityEngine.Ray r, global::UnityEngine.RaycastHit2D[] results, float f, int i);

		public global::UnityEngine.UI.ReflectionMethodsCache.Raycast3DCallback raycast3D;

		public global::UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback raycast3DAll;

		public global::UnityEngine.UI.ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc;

		public global::UnityEngine.UI.ReflectionMethodsCache.Raycast2DCallback raycast2D;

		public global::UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll;

		public global::UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;

		private static global::UnityEngine.UI.ReflectionMethodsCache s_ReflectionMethodsCache;

		public static global::UnityEngine.UI.ReflectionMethodsCache Singleton => null;
	}
}
