namespace Common
{
	public class Singleton<T> where T : global::Common.Singleton<T>, new()
	{
		private static T _instance;

		private static object syncRoot;

		public static T Instance => null;
	}
}
