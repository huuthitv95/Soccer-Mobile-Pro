namespace SQLite
{
	internal class EnumCacheInfo
	{
		public bool IsEnum { get; private set; }

		public bool StoreAsText { get; private set; }

		public global::System.Collections.Generic.Dictionary<int, string> EnumValues { get; private set; }

		public EnumCacheInfo(global::System.Type type)
		{
		}
	}
}
