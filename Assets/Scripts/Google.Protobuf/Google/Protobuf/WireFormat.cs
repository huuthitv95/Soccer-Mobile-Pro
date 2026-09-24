namespace Google.Protobuf
{
	public static class WireFormat
	{
		public enum WireType : uint
		{
			Varint = 0u,
			Fixed64 = 1u,
			LengthDelimited = 2u,
			StartGroup = 3u,
			EndGroup = 4u,
			Fixed32 = 5u
		}

		public static global::Google.Protobuf.WireFormat.WireType GetTagWireType(uint tag)
		{
			return global::Google.Protobuf.WireFormat.WireType.Varint;
		}

		public static int GetTagFieldNumber(uint tag)
		{
			return 0;
		}

		public static uint MakeTag(int fieldNumber, global::Google.Protobuf.WireFormat.WireType wireType)
		{
			return 0u;
		}
	}
}
