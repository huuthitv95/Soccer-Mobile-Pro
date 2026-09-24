namespace EngineMessages
{
    public sealed class BallOverSideEvent : global::Google.Protobuf.IMessage<global::EngineMessages.BallOverSideEvent>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.BallOverSideEvent>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.BallOverSideEvent>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.BallOverSideEvent> _parser;
        public const int SidelinePositionFieldNumber = 1;
        private global::EngineMessages.FloatValues sidelinePosition_;
        public const int BallownerTeamidFieldNumber = 2;
        private int ballownerTeamid_;
        public const int SetpieceModeFieldNumber = 3;
        private int setpieceMode_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.BallOverSideEvent> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.FloatValues SidelinePosition
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
        public int BallownerTeamid
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
        public int SetpieceMode
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
        public BallOverSideEvent()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public BallOverSideEvent(global::EngineMessages.BallOverSideEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.BallOverSideEvent Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.BallOverSideEvent other)
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
        public void MergeFrom(global::EngineMessages.BallOverSideEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}