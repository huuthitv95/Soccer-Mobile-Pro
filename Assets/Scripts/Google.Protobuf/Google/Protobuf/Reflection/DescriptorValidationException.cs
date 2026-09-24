namespace Google.Protobuf.Reflection
{
	public sealed class DescriptorValidationException : global::System.Exception
	{
		private readonly string name;

		private readonly string description;

		internal DescriptorValidationException(global::Google.Protobuf.Reflection.IDescriptor problemDescriptor, string description)
		{
		}
	}
}
