namespace Google.Protobuf.Reflection
{
    internal sealed class SingleFieldAccessor : global::Google.Protobuf.Reflection.FieldAccessorBase
    {
        private readonly global::System.Action<global::Google.Protobuf.IMessage, object> setValueDelegate;
        private readonly global::System.Action<global::Google.Protobuf.IMessage> clearDelegate;
        internal SingleFieldAccessor(global::System.Reflection.PropertyInfo property, global::Google.Protobuf.Reflection.FieldDescriptor descriptor) : base(null, null)
        {
        }

        public override void Clear(global::Google.Protobuf.IMessage message)
        {
        }

        public override void SetValue(global::Google.Protobuf.IMessage message, object value)
        {
        }
    }
}