namespace Facebook.Unity
{
	internal class ComponentFactory
	{
		internal enum IfNotExist
		{
			AddNew = 0,
			ReturnNull = 1
		}

		private static global::UnityEngine.GameObject facebookGameObject;

		private static global::UnityEngine.GameObject FacebookGameObject => null;

		public static T GetComponent<T>(global::Facebook.Unity.ComponentFactory.IfNotExist ifNotExist = global::Facebook.Unity.ComponentFactory.IfNotExist.AddNew) where T : global::UnityEngine.MonoBehaviour
		{
			return null;
		}

		public static T AddComponent<T>() where T : global::UnityEngine.MonoBehaviour
		{
			return null;
		}
	}
}
