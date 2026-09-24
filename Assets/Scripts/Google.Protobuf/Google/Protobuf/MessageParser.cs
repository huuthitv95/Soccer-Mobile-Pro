namespace Google.Protobuf
{
	public class MessageParser
	{
		private global::System.Func<global::Google.Protobuf.IMessage> factory;

		internal bool DiscardUnknownFields { get; }

		internal MessageParser(global::System.Func<global::Google.Protobuf.IMessage> factory, bool discardUnknownFields)
		{
		}

		internal global::Google.Protobuf.IMessage CreateTemplate()
		{
			return null;
		}

		public global::Google.Protobuf.IMessage ParseFrom(byte[] data)
		{
			return null;
		}

		public global::Google.Protobuf.IMessage ParseFrom(byte[] data, int offset, int length)
		{
			return null;
		}

		public global::Google.Protobuf.IMessage ParseFrom(global::Google.Protobuf.ByteString data)
		{
			return null;
		}
	}
	public sealed class MessageParser<T> : global::Google.Protobuf.MessageParser where T : global::Google.Protobuf.IMessage<T>
	{
		private readonly global::System.Func<T> factory;

		public MessageParser(global::System.Func<T> factory)
			: base(null, discardUnknownFields: false)
		{
		}

		internal MessageParser(global::System.Func<T> factory, bool discardUnknownFields)
			: base(null, discardUnknownFields: false)
		{
		}

		internal new T CreateTemplate()
		{
			return default;
		}

		public new T ParseFrom(byte[] data)
		{
			return default;
		}

		public new T ParseFrom(byte[] data, int offset, int length)
		{
			return default;
		}
	}
}
