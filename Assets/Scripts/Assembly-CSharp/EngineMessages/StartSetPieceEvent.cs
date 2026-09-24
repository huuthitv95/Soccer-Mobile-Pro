namespace EngineMessages
{
    public sealed class StartSetPieceEvent : global::Google.Protobuf.IMessage<global::EngineMessages.StartSetPieceEvent>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.StartSetPieceEvent>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.StartSetPieceEvent>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.StartSetPieceEvent> _parser;
        public const int GamemodeFieldNumber = 1;
        private global::EngineMessages.GameMode gamemode_;
        public const int TeamidFieldNumber = 2;
        private int teamid_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.StartSetPieceEvent> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.GameMode Gamemode
        {
            get
            {
                return global::EngineMessages.GameMode.Normal;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Teamid
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
        public StartSetPieceEvent()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public StartSetPieceEvent(global::EngineMessages.StartSetPieceEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.StartSetPieceEvent Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.StartSetPieceEvent other)
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
        public void MergeFrom(global::EngineMessages.StartSetPieceEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}