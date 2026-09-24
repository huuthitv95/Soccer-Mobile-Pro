namespace Unity.SharpZipLib.Core
{
	internal static class Empty
	{
		internal static class EmptyArray<T>
		{
			public static readonly T[] Value;
		}

		public static T[] Array<T>()
		{
			return null;
		}
	}
}
