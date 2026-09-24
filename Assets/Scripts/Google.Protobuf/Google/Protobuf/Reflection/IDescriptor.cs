namespace Google.Protobuf.Reflection
{
	public interface IDescriptor
	{
		string Name { get; }

		string FullName { get; }

		global::Google.Protobuf.Reflection.FileDescriptor File { get; }
	}
}
