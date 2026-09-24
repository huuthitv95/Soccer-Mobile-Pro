namespace Google.Protobuf
{
    public sealed class ByteString : global::System.Collections.Generic.IEnumerable<byte>, global::System.Collections.IEnumerable, global::System.IEquatable<global::Google.Protobuf.ByteString>
    {
        private static readonly global::Google.Protobuf.ByteString empty;
        private readonly byte[] bytes;
        public static global::Google.Protobuf.ByteString Empty => null;
        public int Length => 0;

        internal static global::Google.Protobuf.ByteString AttachBytes(byte[] bytes)
        {
            return null;
        }

        private ByteString(byte[] bytes)
        {
        }

        public string ToBase64()
        {
            return null;
        }

        public static global::Google.Protobuf.ByteString FromBase64(string bytes)
        {
            return null;
        }

        public static global::Google.Protobuf.ByteString CopyFrom(params byte[] bytes)
        {
            return null;
        }

        public static global::Google.Protobuf.ByteString CopyFrom(byte[] bytes, int offset, int count)
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerator<byte> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public global::Google.Protobuf.CodedInputStream CreateCodedInput()
        {
            return null;
        }

        public static bool operator ==(global::Google.Protobuf.ByteString lhs, global::Google.Protobuf.ByteString rhs)
        {
            return false;
        }

        public static bool operator !=(global::Google.Protobuf.ByteString lhs, global::Google.Protobuf.ByteString rhs)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public bool Equals(global::Google.Protobuf.ByteString other)
        {
            return false;
        }

        internal void WriteRawBytesTo(global::Google.Protobuf.CodedOutputStream outputStream)
        {
        }
    }
}