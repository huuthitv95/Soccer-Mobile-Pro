namespace Google.Protobuf.WellKnownTypes
{
    public sealed class FieldMask : global::Google.Protobuf.IMessage<global::Google.Protobuf.WellKnownTypes.FieldMask>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.WellKnownTypes.FieldMask>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.WellKnownTypes.FieldMask>, global::Google.Protobuf.ICustomDiagnosticMessage
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.FieldMask> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_paths_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> paths_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.FieldMask> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<string> Paths => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FieldMask()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FieldMask(global::Google.Protobuf.WellKnownTypes.FieldMask other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.WellKnownTypes.FieldMask Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.WellKnownTypes.FieldMask other)
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

        internal static string ToJson(global::System.Collections.Generic.IList<string> paths, bool diagnosticOnly)
        {
            return null;
        }

        private static bool ValidatePath(string input)
        {
            return false;
        }

        public string ToDiagnosticString()
        {
            return null;
        }
    }
}