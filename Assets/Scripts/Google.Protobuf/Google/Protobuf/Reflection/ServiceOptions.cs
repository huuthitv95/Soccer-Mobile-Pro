namespace Google.Protobuf.Reflection
{
    internal sealed class ServiceOptions : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.ServiceOptions>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.ServiceOptions>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.ServiceOptions>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.ServiceOptions> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private bool deprecated_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.ServiceOptions> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();
        internal global::Google.Protobuf.Reflection.CustomOptions CustomOptions { get; private set; }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Deprecated
        {
            get
            {
                return false;
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
        public ServiceOptions()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ServiceOptions(global::Google.Protobuf.Reflection.ServiceOptions other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.ServiceOptions Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.Reflection.ServiceOptions other)
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