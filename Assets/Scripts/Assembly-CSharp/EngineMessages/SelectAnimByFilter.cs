namespace EngineMessages
{
    public sealed class SelectAnimByFilter : global::Google.Protobuf.IMessage<global::EngineMessages.SelectAnimByFilter>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.SelectAnimByFilter>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.SelectAnimByFilter>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.SelectAnimByFilter> _parser;
        public const int IncomingVelocityFieldNumber = 1;
        private int incomingVelocity_;
        public const int OutgoingVelocityFieldNumber = 2;
        private int outgoingVelocity_;
        public const int FilterAnglesFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.AngleFilterRange> _repeated_filterAngles_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.AngleFilterRange> filterAngles_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.SelectAnimByFilter> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int IncomingVelocity
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
        public int OutgoingVelocity
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
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.AngleFilterRange> FilterAngles => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SelectAnimByFilter()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SelectAnimByFilter(global::EngineMessages.SelectAnimByFilter other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.SelectAnimByFilter Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.SelectAnimByFilter other)
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
        public void MergeFrom(global::EngineMessages.SelectAnimByFilter other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}