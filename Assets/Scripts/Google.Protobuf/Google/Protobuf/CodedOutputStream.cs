namespace Google.Protobuf
{
    public sealed class CodedOutputStream : global::System.IDisposable
    {
        public sealed class OutOfSpaceException : global::System.IO.IOException
        {
            internal OutOfSpaceException()
            {
            }
        }

        private const int LittleEndian64Size = 8;
        private const int LittleEndian32Size = 4;
        internal static readonly global::System.Text.Encoding Utf8Encoding;
        public static readonly int DefaultBufferSize;
        private readonly bool leaveOpen;
        private readonly byte[] buffer;
        private readonly int limit;
        private int position;
        private readonly global::System.IO.Stream output;
        public int SpaceLeft => 0;

        public static int ComputeFloatSize(float value)
        {
            return 0;
        }

        public static int ComputeUInt64Size(ulong value)
        {
            return 0;
        }

        public static int ComputeInt64Size(long value)
        {
            return 0;
        }

        public static int ComputeInt32Size(int value)
        {
            return 0;
        }

        public static int ComputeFixed64Size(ulong value)
        {
            return 0;
        }

        public static int ComputeFixed32Size(uint value)
        {
            return 0;
        }

        public static int ComputeBoolSize(bool value)
        {
            return 0;
        }

        public static int ComputeStringSize(string value)
        {
            return 0;
        }

        public static int ComputeMessageSize(global::Google.Protobuf.IMessage value)
        {
            return 0;
        }

        public static int ComputeBytesSize(global::Google.Protobuf.ByteString value)
        {
            return 0;
        }

        public static int ComputeUInt32Size(uint value)
        {
            return 0;
        }

        public static int ComputeEnumSize(int value)
        {
            return 0;
        }

        public static int ComputeLengthSize(int length)
        {
            return 0;
        }

        public static int ComputeRawVarint32Size(uint value)
        {
            return 0;
        }

        public static int ComputeRawVarint64Size(ulong value)
        {
            return 0;
        }

        public static int ComputeTagSize(int fieldNumber)
        {
            return 0;
        }

        public CodedOutputStream(byte[] flatArray)
        {
        }

        private CodedOutputStream(byte[] buffer, int offset, int length)
        {
        }

        private CodedOutputStream(global::System.IO.Stream output, byte[] buffer, bool leaveOpen)
        {
        }

        public CodedOutputStream(global::System.IO.Stream output)
        {
        }

        public CodedOutputStream(global::System.IO.Stream output, bool leaveOpen)
        {
        }

        public CodedOutputStream(global::System.IO.Stream output, int bufferSize, bool leaveOpen)
        {
        }

        public void WriteDouble(double value)
        {
        }

        public void WriteFloat(float value)
        {
        }

        public void WriteUInt64(ulong value)
        {
        }

        public void WriteInt64(long value)
        {
        }

        public void WriteInt32(int value)
        {
        }

        public void WriteFixed64(ulong value)
        {
        }

        public void WriteFixed32(uint value)
        {
        }

        public void WriteBool(bool value)
        {
        }

        public void WriteString(string value)
        {
        }

        public void WriteMessage(global::Google.Protobuf.IMessage value)
        {
        }

        public void WriteBytes(global::Google.Protobuf.ByteString value)
        {
        }

        public void WriteUInt32(uint value)
        {
        }

        public void WriteEnum(int value)
        {
        }

        public void WriteLength(int length)
        {
        }

        public void WriteTag(int fieldNumber, global::Google.Protobuf.WireFormat.WireType type)
        {
        }

        public void WriteTag(uint tag)
        {
        }

        public void WriteRawTag(byte b1)
        {
        }

        public void WriteRawTag(byte b1, byte b2)
        {
        }

        internal void WriteRawVarint32(uint value)
        {
        }

        internal void WriteRawVarint64(ulong value)
        {
        }

        internal void WriteRawLittleEndian32(uint value)
        {
        }

        internal void WriteRawLittleEndian64(ulong value)
        {
        }

        internal void WriteRawByte(byte value)
        {
        }

        internal void WriteRawBytes(byte[] value)
        {
        }

        internal void WriteRawBytes(byte[] value, int offset, int length)
        {
        }

        private void RefreshBuffer()
        {
        }

        public void Dispose()
        {
        }

        public void Flush()
        {
        }

        public void CheckNoSpaceLeft()
        {
        }
    }
}