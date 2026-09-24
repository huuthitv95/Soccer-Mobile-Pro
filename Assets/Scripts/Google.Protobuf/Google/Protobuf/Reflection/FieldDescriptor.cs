namespace Google.Protobuf.Reflection
{
    public sealed class FieldDescriptor : global::Google.Protobuf.Reflection.DescriptorBase, global::System.IComparable<global::Google.Protobuf.Reflection.FieldDescriptor>
    {
        private global::Google.Protobuf.Reflection.EnumDescriptor enumType;
        private global::Google.Protobuf.Reflection.MessageDescriptor messageType;
        private global::Google.Protobuf.Reflection.FieldType fieldType;
        private readonly string propertyName;
        private global::Google.Protobuf.Reflection.IFieldAccessor accessor;
        public global::Google.Protobuf.Reflection.MessageDescriptor ContainingType { get; }
        public global::Google.Protobuf.Reflection.OneofDescriptor ContainingOneof { get; }
        public string JsonName { get; }
        internal global::Google.Protobuf.Reflection.FieldDescriptorProto Proto { get; }
        public override string Name => null;
        public global::Google.Protobuf.Reflection.IFieldAccessor Accessor => null;
        public bool IsRepeated => false;
        public bool IsMap => false;
        public global::Google.Protobuf.Reflection.FieldType FieldType => global::Google.Protobuf.Reflection.FieldType.Double;
        public int FieldNumber => 0;
        public global::Google.Protobuf.Reflection.EnumDescriptor EnumType => null;
        public global::Google.Protobuf.Reflection.MessageDescriptor MessageType => null;

        internal FieldDescriptor(global::Google.Protobuf.Reflection.FieldDescriptorProto proto, global::Google.Protobuf.Reflection.FileDescriptor file, global::Google.Protobuf.Reflection.MessageDescriptor parent, int index, string propertyName) : base(null, null, 0)
        {
        }

        private static global::Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(global::Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type)
        {
            return global::Google.Protobuf.Reflection.FieldType.Double;
        }

        public int CompareTo(global::Google.Protobuf.Reflection.FieldDescriptor other)
        {
            return 0;
        }

        internal void CrossLink()
        {
        }

        private global::Google.Protobuf.Reflection.IFieldAccessor CreateAccessor()
        {
            return null;
        }
    }
}