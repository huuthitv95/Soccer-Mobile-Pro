namespace EngineMessages
{
    public sealed class InputData : global::Google.Protobuf.IMessage<global::EngineMessages.InputData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.InputData>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.InputData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.InputData> _parser;
        public const int EventsFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.InputEvent> _repeated_events_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.InputEvent> events_;
        public const int NeedFramecountFieldNumber = 2;
        private int needFramecount_;
        public const int MsgsFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.InputMessage> _repeated_msgs_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.InputMessage> msgs_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.InputData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.InputEvent> Events => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int NeedFramecount
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
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.InputMessage> Msgs => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public InputData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public InputData(global::EngineMessages.InputData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.InputData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.InputData other)
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
        public void MergeFrom(global::EngineMessages.InputData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}