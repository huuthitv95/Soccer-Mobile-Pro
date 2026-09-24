namespace Google.Protobuf.WellKnownTypes
{
    public sealed class Type : global::Google.Protobuf.IMessage<global::Google.Protobuf.WellKnownTypes.Type>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.WellKnownTypes.Type>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.WellKnownTypes.Type>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.Type> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private string name_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.WellKnownTypes.Field> _repeated_fields_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.WellKnownTypes.Field> fields_;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_oneofs_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> oneofs_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.WellKnownTypes.Option> options_;
        private global::Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;
        private global::Google.Protobuf.WellKnownTypes.Syntax syntax_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.Type> Parser => null;

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
        public global::Google.Protobuf.WellKnownTypes.SourceContext SourceContext => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.WellKnownTypes.Syntax Syntax => global::Google.Protobuf.WellKnownTypes.Syntax.Proto2;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public Type()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public Type(global::Google.Protobuf.WellKnownTypes.Type other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.WellKnownTypes.Type Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.WellKnownTypes.Type other)
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