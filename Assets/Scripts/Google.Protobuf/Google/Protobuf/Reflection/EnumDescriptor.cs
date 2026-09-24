namespace Google.Protobuf.Reflection
{
	public sealed class EnumDescriptor : global::Google.Protobuf.Reflection.DescriptorBase
	{
		private readonly global::Google.Protobuf.Reflection.EnumDescriptorProto proto;

		private readonly global::Google.Protobuf.Reflection.MessageDescriptor containingType;

		private readonly global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.EnumValueDescriptor> values;

		private readonly global::System.Type clrType;

		public override string Name => null;

		internal EnumDescriptor(global::Google.Protobuf.Reflection.EnumDescriptorProto proto, global::Google.Protobuf.Reflection.FileDescriptor file, global::Google.Protobuf.Reflection.MessageDescriptor parent, int index, global::System.Type clrType)
			: base(null, null, 0)
		{
		}

		public global::Google.Protobuf.Reflection.EnumValueDescriptor FindValueByName(string name)
		{
			return null;
		}
	}
}
