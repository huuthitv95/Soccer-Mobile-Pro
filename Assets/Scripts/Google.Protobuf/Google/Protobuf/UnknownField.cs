namespace Google.Protobuf
{
    internal sealed class UnknownField
    {
        private global::System.Collections.Generic.List<ulong> varintList;
        private global::System.Collections.Generic.List<uint> fixed32List;
        private global::System.Collections.Generic.List<ulong> fixed64List;
        private global::System.Collections.Generic.List<global::Google.Protobuf.ByteString> lengthDelimitedList;
        public override bool Equals(object other)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        internal void WriteTo(int fieldNumber, global::Google.Protobuf.CodedOutputStream output)
        {
        }

        internal int GetSerializedSize(int fieldNumber)
        {
            return 0;
        }

        internal global::Google.Protobuf.UnknownField MergeFrom(global::Google.Protobuf.UnknownField other)
        {
            return null;
        }

        private static global::System.Collections.Generic.List<T> AddAll<T>(global::System.Collections.Generic.List<T> current, global::System.Collections.Generic.IList<T> extras)
        {
            return null;
        }

        internal global::Google.Protobuf.UnknownField AddVarint(ulong value)
        {
            return null;
        }

        internal global::Google.Protobuf.UnknownField AddFixed32(uint value)
        {
            return null;
        }

        internal global::Google.Protobuf.UnknownField AddFixed64(ulong value)
        {
            return null;
        }

        internal global::Google.Protobuf.UnknownField AddLengthDelimited(global::Google.Protobuf.ByteString value)
        {
            return null;
        }

        private static global::System.Collections.Generic.List<T> Add<T>(global::System.Collections.Generic.List<T> list, T value)
        {
            return null;
        }
    }
}