namespace Google.Protobuf.Reflection
{
	public sealed class OneofAccessor
	{
		private readonly global::System.Func<global::Google.Protobuf.IMessage, int> caseDelegate;

		private readonly global::System.Action<global::Google.Protobuf.IMessage> clearDelegate;

		private global::Google.Protobuf.Reflection.OneofDescriptor descriptor;

		internal OneofAccessor(global::System.Reflection.PropertyInfo caseProperty, global::System.Reflection.MethodInfo clearMethod, global::Google.Protobuf.Reflection.OneofDescriptor descriptor)
		{
		}

		public global::Google.Protobuf.Reflection.FieldDescriptor GetCaseFieldDescriptor(global::Google.Protobuf.IMessage message)
		{
			return null;
		}
	}
}
