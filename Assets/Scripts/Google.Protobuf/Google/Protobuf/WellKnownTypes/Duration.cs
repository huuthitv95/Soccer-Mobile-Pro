namespace Google.Protobuf.WellKnownTypes
{
    public sealed class Duration : global::Google.Protobuf.IMessage<global::Google.Protobuf.WellKnownTypes.Duration>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.WellKnownTypes.Duration>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.WellKnownTypes.Duration>, global::Google.Protobuf.ICustomDiagnosticMessage
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.Duration> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private long seconds_;
        private int nanos_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.WellKnownTypes.Duration> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public long Seconds
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Nanos
        {
            get
            {
                return 0;
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
        public Duration()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public Duration(global::Google.Protobuf.WellKnownTypes.Duration other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.WellKnownTypes.Duration Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.WellKnownTypes.Duration other)
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

        internal static bool IsNormalized(long seconds, int nanoseconds)
        {
            return false;
        }

        internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
        {
            return null;
        }

        public string ToDiagnosticString()
        {
            return null;
        }

        internal static void AppendNanoseconds(global::System.Text.StringBuilder builder, int nanos)
        {
        }
    }
}