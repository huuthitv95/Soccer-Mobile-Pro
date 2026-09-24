namespace Google.Protobuf.Reflection
{
	public interface IFieldAccessor
	{
		global::Google.Protobuf.Reflection.FieldDescriptor Descriptor { get; }

		void Clear(global::Google.Protobuf.IMessage message);

		object GetValue(global::Google.Protobuf.IMessage message);

		void SetValue(global::Google.Protobuf.IMessage message, object value);
	}
}
