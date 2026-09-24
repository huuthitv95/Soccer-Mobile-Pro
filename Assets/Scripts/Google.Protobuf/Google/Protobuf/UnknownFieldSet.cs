namespace Google.Protobuf
{
    public sealed class UnknownFieldSet
    {
        private readonly global::System.Collections.Generic.IDictionary<int, global::Google.Protobuf.UnknownField> fields;
        private int lastFieldNumber;
        private global::Google.Protobuf.UnknownField lastField;
        internal UnknownFieldSet()
        {
        }

        internal bool HasField(int field)
        {
            return false;
        }

        public void WriteTo(global::Google.Protobuf.CodedOutputStream output)
        {
        }

        public int CalculateSize()
        {
            return 0;
        }

        public override bool Equals(object other)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        private global::Google.Protobuf.UnknownField GetOrAddField(int number)
        {
            return null;
        }

        internal global::Google.Protobuf.UnknownFieldSet AddOrReplaceField(int number, global::Google.Protobuf.UnknownField field)
        {
            return null;
        }

        private void MergeFieldFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }

        public static global::Google.Protobuf.UnknownFieldSet MergeFieldFrom(global::Google.Protobuf.UnknownFieldSet unknownFields, global::Google.Protobuf.CodedInputStream input)
        {
            return null;
        }

        private global::Google.Protobuf.UnknownFieldSet MergeFrom(global::Google.Protobuf.UnknownFieldSet other)
        {
            return null;
        }

        public static global::Google.Protobuf.UnknownFieldSet MergeFrom(global::Google.Protobuf.UnknownFieldSet unknownFields, global::Google.Protobuf.UnknownFieldSet other)
        {
            return null;
        }

        private global::Google.Protobuf.UnknownFieldSet MergeField(int number, global::Google.Protobuf.UnknownField field)
        {
            return null;
        }

        public static global::Google.Protobuf.UnknownFieldSet Clone(global::Google.Protobuf.UnknownFieldSet other)
        {
            return null;
        }
    }
}