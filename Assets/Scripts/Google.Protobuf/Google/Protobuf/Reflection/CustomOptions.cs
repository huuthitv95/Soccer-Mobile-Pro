namespace Google.Protobuf.Reflection
{
	public sealed class CustomOptions
	{
		private struct FieldValue
		{
			private readonly ulong Number;

			private readonly global::Google.Protobuf.ByteString ByteString;

			internal FieldValue(ulong number)
			{
				Number = 0uL;
				ByteString = null;
			}

			internal FieldValue(global::Google.Protobuf.ByteString byteString)
			{
				Number = 0uL;
				ByteString = null;
			}
		}

		internal static readonly global::Google.Protobuf.Reflection.CustomOptions Empty;

		private readonly global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.CustomOptions.FieldValue>> valuesByField;

		private CustomOptions()
		{
		}

		internal global::Google.Protobuf.Reflection.CustomOptions ReadOrSkipUnknownField(global::Google.Protobuf.CodedInputStream input)
		{
			return null;
		}

		private global::Google.Protobuf.Reflection.CustomOptions AddValue(int field, global::Google.Protobuf.Reflection.CustomOptions.FieldValue value)
		{
			return null;
		}
	}
}
