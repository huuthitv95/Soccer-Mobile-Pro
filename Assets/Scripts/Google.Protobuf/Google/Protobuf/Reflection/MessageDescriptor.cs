namespace Google.Protobuf.Reflection
{
    public sealed class MessageDescriptor : global::Google.Protobuf.Reflection.DescriptorBase
    {
        public sealed class FieldCollection
        {
            private readonly global::Google.Protobuf.Reflection.MessageDescriptor messageDescriptor;
            // C# has no syntax for parameterized property 'Item'.
            public global::Google.Protobuf.Reflection.FieldDescriptor this[int number]
            {
                get
                {
                    return null;
                }
            }

            internal FieldCollection(global::Google.Protobuf.Reflection.MessageDescriptor messageDescriptor)
            {
            }

            public global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.FieldDescriptor> InDeclarationOrder()
            {
                return null;
            }

            public global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.FieldDescriptor> InFieldNumberOrder()
            {
                return null;
            }

            internal global::System.Collections.Generic.IDictionary<string, global::Google.Protobuf.Reflection.FieldDescriptor> ByJsonName()
            {
                return null;
            }
        }

        private static readonly global::System.Collections.Generic.HashSet<string> WellKnownTypeNames;
        private readonly global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.FieldDescriptor> fieldsInDeclarationOrder;
        private readonly global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.FieldDescriptor> fieldsInNumberOrder;
        private readonly global::System.Collections.Generic.IDictionary<string, global::Google.Protobuf.Reflection.FieldDescriptor> jsonFieldMap;
        private readonly global::Google.Protobuf.Reflection.MessageDescriptor ContainingType;
        private readonly global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.EnumDescriptor> EnumTypes;
        public override string Name => null;
        internal global::Google.Protobuf.Reflection.DescriptorProto Proto { get; }
        public global::System.Type ClrType { get; }
        public global::Google.Protobuf.MessageParser Parser { get; }
        internal bool IsWellKnownType => false;
        internal bool IsWrapperType => false;
        public global::Google.Protobuf.Reflection.MessageDescriptor.FieldCollection Fields { get; }
        public global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.MessageDescriptor> NestedTypes { get; }
        public global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.OneofDescriptor> Oneofs { get; }

        internal MessageDescriptor(global::Google.Protobuf.Reflection.DescriptorProto proto, global::Google.Protobuf.Reflection.FileDescriptor file, global::Google.Protobuf.Reflection.MessageDescriptor parent, int typeIndex, global::Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo) : base(null, null, 0)
        {
        }

        private static global::Google.Protobuf.Collections.ReadOnlyDictionary<string, global::Google.Protobuf.Reflection.FieldDescriptor> CreateJsonFieldMap(global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.FieldDescriptor> fields)
        {
            return null;
        }

        public global::Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(int number)
        {
            return null;
        }

        internal void CrossLink()
        {
        }
    }
}