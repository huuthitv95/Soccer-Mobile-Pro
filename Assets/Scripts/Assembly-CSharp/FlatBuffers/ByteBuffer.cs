namespace FlatBuffers
{
    public class ByteBuffer
    {
        private global::FlatBuffers.ByteBufferAllocator _buffer;
        private int _pos;
        private static global::System.Collections.Generic.Dictionary<global::System.Type, int> genericSizes;
        public int Position
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int Length => 0;

        public ByteBuffer(global::FlatBuffers.ByteBufferAllocator allocator, int position)
        {
        }

        public ByteBuffer(int size)
        {
        }

        public ByteBuffer(byte[] buffer)
        {
        }

        public ByteBuffer(byte[] buffer, int pos)
        {
        }

        public void Reset()
        {
        }

        public global::FlatBuffers.ByteBuffer Duplicate()
        {
            return null;
        }

        public void GrowFront(int newSize)
        {
        }

        public byte[] ToArray(int pos, int len)
        {
            return null;
        }

        public static int SizeOf<T>()
        {
            return 0;
        }

        public static bool IsSupportedType<T>()
        {
            return false;
        }

        public static int ArraySize<T>(T[] x)
        {
            return 0;
        }

        public T[] ToArray<T>(int pos, int len)
            where T : struct
        {
            return null;
        }

        public byte[] ToSizedArray()
        {
            return null;
        }

        public int ToSizedArray(byte[] buffer)
        {
            return 0;
        }

        public int SizeOfSizedArray()
        {
            return 0;
        }

        public byte[] ToFullArray()
        {
            return null;
        }

        public global::System.ArraySegment<byte> ToArraySegment(int pos, int len)
        {
            return default;
        }

        public global::System.IO.MemoryStream ToMemoryStream(int pos, int len)
        {
            return null;
        }

        public static ushort ReverseBytes(ushort input)
        {
            return 0;
        }

        public static uint ReverseBytes(uint input)
        {
            return 0u;
        }

        public static ulong ReverseBytes(ulong input)
        {
            return 0uL;
        }

        private void AssertOffsetAndLength(int offset, int length)
        {
        }

        public void PutSbyte(int offset, sbyte value)
        {
        }

        public void PutByte(int offset, byte value)
        {
        }

        public void PutByte(int offset, byte value, int count)
        {
        }

        public void Put(int offset, byte value)
        {
        }

        public void PutStringUTF8(int offset, string value)
        {
        }

        public void PutShort(int offset, short value)
        {
        }

        public void PutUshort(int offset, ushort value)
        {
        }

        public void PutInt(int offset, int value)
        {
        }

        public void PutUint(int offset, uint value)
        {
        }

        public void PutLong(int offset, long value)
        {
        }

        public void PutUlong(int offset, ulong value)
        {
        }

        public void PutFloat(int offset, float value)
        {
        }

        public void PutDouble(int offset, double value)
        {
        }

        public sbyte GetSbyte(int index)
        {
            return 0;
        }

        public byte Get(int index)
        {
            return 0;
        }

        public string GetStringUTF8(int startPos, int len)
        {
            return null;
        }

        public short GetShort(int offset)
        {
            return 0;
        }

        public ushort GetUshort(int offset)
        {
            return 0;
        }

        public int GetInt(int offset)
        {
            return 0;
        }

        public uint GetUint(int offset)
        {
            return 0u;
        }

        public long GetLong(int offset)
        {
            return 0L;
        }

        public ulong GetUlong(int offset)
        {
            return 0uL;
        }

        public float GetFloat(int offset)
        {
            return 0f;
        }

        public double GetDouble(int offset)
        {
            return 0.0;
        }

        public int Put<T>(int offset, T[] x, int srcOffset = 0, int srcLength = 0)
            where T : struct
        {
            return 0;
        }
    }
}