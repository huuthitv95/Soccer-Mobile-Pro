namespace Common
{
	public class GameMessage
	{
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::Google.Protobuf.MessageParser> parsers;

		public ushort OpCode { get; set; }

		public global::Common.ByteBuffer buffer { private get; set; }

		public int Offset { get; set; }

		public global::FlatBuffers.ByteBuffer flatByteBuffer => null;

		public byte[] GetBufferBytes()
		{
			return null;
		}

		public T Parse<T>() where T : global::Google.Protobuf.IMessage<T>
		{
			return default;
		}

		public global::Google.Protobuf.IMessage Parse(global::System.Type t)
		{
			return null;
		}

		public T ParseFromPool<T>() where T : global::Google.Protobuf.IMessage<T>, global::Common.IRecycleable, new()
		{
			return default;
		}
	}
}
