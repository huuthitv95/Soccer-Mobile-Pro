namespace Google.Protobuf.WellKnownTypes
{
    public sealed class Value : global::Google.Protobuf.IMessage<global::Google.Protobuf.WellKnownTypes.Value>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.WellKnownTypes.Value>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.WellKnownTypes.Value>
    {
        public enum KindOneofCase
        {
            None = 0,
            NullValue = 1,
            NumberValue = 2,
            StringValue = 3,
            BoolValue = 4,
            StructValue = 5,
            ListValue = 6
        }

        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.Value> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private object kind_;
        private global::Google.Protobuf.WellKnownTypes.Value.KindOneofCase kindCase_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.Value> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.WellKnownTypes.NullValue NullValue
        {
            get
            {
                return global::Google.Protobuf.WellKnownTypes.NullValue.NullValue;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public double NumberValue
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string StringValue
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
        public bool BoolValue
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
        public global::Google.Protobuf.WellKnownTypes.Struct StructValue
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
        public global::Google.Protobuf.WellKnownTypes.ListValue ListValue
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
        public global::Google.Protobuf.WellKnownTypes.Value.KindOneofCase KindCase => global::Google.Protobuf.WellKnownTypes.Value.KindOneofCase.None;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public Value()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public Value(global::Google.Protobuf.WellKnownTypes.Value other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.WellKnownTypes.Value Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.WellKnownTypes.Value other)
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

        public static global::Google.Protobuf.WellKnownTypes.Value ForNull()
        {
            return null;
        }
    }
}