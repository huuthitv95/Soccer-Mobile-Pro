namespace Google.Protobuf
{
	public static class ProtoPreconditions
	{
		public static T CheckNotNull<T>(T value, string name) where T : class
		{
			return null;
		}

		internal static T CheckNotNullUnconstrained<T>(T value, string name)
		{
			return default;
		}

		internal static T CheckNotNullUnconstrained<T>(T value, global::System.Func<string> namer)
		{
			return default;
		}
	}
}
