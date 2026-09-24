namespace Common
{
	public static class JsonUtil
	{
		[global::System.Serializable]
		private class Wrapper<T>
		{
			public T[] Items;
		}

		public static T[] FromJson<T>(string json)
		{
			return null;
		}

		public static string ToJson<T>(T[] array)
		{
			return null;
		}

		public static string ToJson<T>(T[] array, bool prettyPrint)
		{
			return null;
		}
	}
}
