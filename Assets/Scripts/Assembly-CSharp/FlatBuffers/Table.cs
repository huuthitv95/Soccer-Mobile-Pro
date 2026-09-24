namespace FlatBuffers
{
	public struct Table
	{
		public int bb_pos;

		public global::FlatBuffers.ByteBuffer bb;

		public global::FlatBuffers.ByteBuffer ByteBuffer => null;

		public int __offset(int vtableOffset)
		{
			return 0;
		}

		public static int __offset(int vtableOffset, int offset, global::FlatBuffers.ByteBuffer bb)
		{
			return 0;
		}

		public int __indirect(int offset)
		{
			return 0;
		}

		public static int __indirect(int offset, global::FlatBuffers.ByteBuffer bb)
		{
			return 0;
		}

		public string __string(int offset)
		{
			return null;
		}

		public int __vector_len(int offset)
		{
			return 0;
		}

		public int __vector(int offset)
		{
			return 0;
		}

		public global::System.ArraySegment<byte>? __vector_as_arraysegment(int offset)
		{
			return null;
		}

		public T[] __vector_as_array<T>(int offset) where T : struct
		{
			return null;
		}

		public T __union<T>(int offset) where T : struct, global::FlatBuffers.IFlatbufferObject
		{
			return default;
		}

		public static bool __has_identifier(global::FlatBuffers.ByteBuffer bb, string ident)
		{
			return false;
		}

		public static int CompareStrings(int offset_1, int offset_2, global::FlatBuffers.ByteBuffer bb)
		{
			return 0;
		}

		public static int CompareStrings(int offset_1, byte[] key, global::FlatBuffers.ByteBuffer bb)
		{
			return 0;
		}
	}
}
