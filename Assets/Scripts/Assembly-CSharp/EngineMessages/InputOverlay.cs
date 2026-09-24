namespace EngineMessages
{
    public sealed class InputOverlay : global::Google.Protobuf.IMessage<global::EngineMessages.InputOverlay>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.InputOverlay>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.InputOverlay>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.InputOverlay> _parser;
        public const int SrcFieldNumber = 2;
        private global::EngineMessages.InputFunction src_;
        public const int DstFieldNumber = 3;
        private global::EngineMessages.InputFunction dst_;
        public const int TimeFieldNumber = 4;
        private int time_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.InputOverlay> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.InputFunction Src
        {
            get
            {
                return global::EngineMessages.InputFunction.Up;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.InputFunction Dst
        {
            get
            {
                return global::EngineMessages.InputFunction.Up;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Time
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
        public InputOverlay()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public InputOverlay(global::EngineMessages.InputOverlay other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.InputOverlay Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.InputOverlay other)
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
        public void MergeFrom(global::EngineMessages.InputOverlay other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}