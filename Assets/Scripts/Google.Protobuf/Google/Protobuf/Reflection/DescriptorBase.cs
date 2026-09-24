namespace Google.Protobuf.Reflection
{
	public abstract class DescriptorBase : global::Google.Protobuf.Reflection.IDescriptor
	{
		private readonly global::Google.Protobuf.Reflection.FileDescriptor file;

		private readonly string fullName;

		private readonly int index;

		public abstract string Name { get; }

		public string FullName => null;

		public global::Google.Protobuf.Reflection.FileDescriptor File => null;

		internal DescriptorBase(global::Google.Protobuf.Reflection.FileDescriptor file, string fullName, int index)
		{
		}
	}
}
