namespace Google.Protobuf.Reflection
{
	public sealed class TypeRegistry
	{
		private readonly global::System.Collections.Generic.Dictionary<string, global::Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap;

		public static global::Google.Protobuf.Reflection.TypeRegistry Empty { get; }

		private TypeRegistry(global::System.Collections.Generic.Dictionary<string, global::Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap)
		{
		}

		public global::Google.Protobuf.Reflection.MessageDescriptor Find(string fullName)
		{
			return null;
		}
	}
}
