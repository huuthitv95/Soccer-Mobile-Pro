namespace Google.Protobuf.Reflection
{
    internal sealed class FieldDescriptorProto : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.FieldDescriptorProto>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.FieldDescriptorProto>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.FieldDescriptorProto>
    {
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static class Types
        {
            internal enum Type
            {
                Double = 1,
                Float = 2,
                Int64 = 3,
                Uint64 = 4,
                Int32 = 5,
                Fixed64 = 6,
                Fixed32 = 7,
                Bool = 8,
                String = 9,
                Group = 10,
                Message = 11,
                Bytes = 12,
                Uint32 = 13,
                Enum = 14,
                Sfixed32 = 15,
                Sfixed64 = 16,
                Sint32 = 17,
                Sint64 = 18
            }

            internal enum Label
            {
                Optional = 1,
                Required = 2,
                Repeated = 3
            }
        }

        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.FieldDescriptorProto> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private string name_;
        private int number_;
        private global::Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label label_;
        private global::Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type_;
        private string typeName_;
        private string extendee_;
        private string defaultValue_;
        private int oneofIndex_;
        private string jsonName_;
        private global::Google.Protobuf.Reflection.FieldOptions options_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.FieldDescriptorProto> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string Name
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Number
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label Label => (global::Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label)0;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type Type => (global::Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type)0;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string TypeName
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string Extendee
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string DefaultValue
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int OneofIndex
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string JsonName
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.FieldOptions Options => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FieldDescriptorProto()
        {
        }

        private void OnConstruction()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FieldDescriptorProto(global::Google.Protobuf.Reflection.FieldDescriptorProto other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.FieldDescriptorProto Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.Reflection.FieldDescriptorProto other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
        {
            return 0;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void WriteTo(global::Google.Protobuf.CodedOutputStream output)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int CalculateSize()
        {
            return 0;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}