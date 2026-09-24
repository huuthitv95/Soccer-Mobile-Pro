namespace Google.Protobuf.WellKnownTypes
{
    public sealed class Field : global::Google.Protobuf.IMessage<global::Google.Protobuf.WellKnownTypes.Field>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.WellKnownTypes.Field>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.WellKnownTypes.Field>
    {
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static class Types
        {
            public enum Kind
            {
                TypeUnknown = 0,
                TypeDouble = 1,
                TypeFloat = 2,
                TypeInt64 = 3,
                TypeUint64 = 4,
                TypeInt32 = 5,
                TypeFixed64 = 6,
                TypeFixed32 = 7,
                TypeBool = 8,
                TypeString = 9,
                TypeGroup = 10,
                TypeMessage = 11,
                TypeBytes = 12,
                TypeUint32 = 13,
                TypeEnum = 14,
                TypeSfixed32 = 15,
                TypeSfixed64 = 16,
                TypeSint32 = 17,
                TypeSint64 = 18
            }

            public enum Cardinality
            {
                Unknown = 0,
                Optional = 1,
                Required = 2,
                Repeated = 3
            }
        }

        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.Field> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private global::Google.Protobuf.WellKnownTypes.Field.Types.Kind kind_;
        private global::Google.Protobuf.WellKnownTypes.Field.Types.Cardinality cardinality_;
        private int number_;
        private string name_;
        private string typeUrl_;
        private int oneofIndex_;
        private bool packed_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> options_;
        private string jsonName_;
        private string defaultValue_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.Field> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.WellKnownTypes.Field.Types.Kind Kind => global::Google.Protobuf.WellKnownTypes.Field.Types.Kind.TypeUnknown;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.WellKnownTypes.Field.Types.Cardinality Cardinality => global::Google.Protobuf.WellKnownTypes.Field.Types.Cardinality.Unknown;

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
        public string TypeUrl
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
        public bool Packed
        {
            get
            {
                return false;
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

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public Field()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public Field(global::Google.Protobuf.WellKnownTypes.Field other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.WellKnownTypes.Field Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.WellKnownTypes.Field other)
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