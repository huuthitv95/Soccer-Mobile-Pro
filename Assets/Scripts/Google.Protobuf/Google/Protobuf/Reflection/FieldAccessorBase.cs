namespace Google.Protobuf.Reflection
{
	internal abstract class FieldAccessorBase : global::Google.Protobuf.Reflection.IFieldAccessor
	{
		private readonly global::System.Func<global::Google.Protobuf.IMessage, object> getValueDelegate;

		private readonly global::Google.Protobuf.Reflection.FieldDescriptor descriptor;

		public global::Google.Protobuf.Reflection.FieldDescriptor Descriptor => null;

		internal FieldAccessorBase(global::System.Reflection.PropertyInfo property, global::Google.Protobuf.Reflection.FieldDescriptor descriptor)
		{
		}

		public object GetValue(global::Google.Protobuf.IMessage message)
		{
			return null;
		}

		public abstract void Clear(global::Google.Protobuf.IMessage message);

		public abstract void SetValue(global::Google.Protobuf.IMessage message, object value);
	}
}
