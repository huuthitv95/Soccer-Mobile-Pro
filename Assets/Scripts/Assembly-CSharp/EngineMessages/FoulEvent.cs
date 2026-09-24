namespace EngineMessages
{
    public sealed class FoulEvent : global::Google.Protobuf.IMessage<global::EngineMessages.FoulEvent>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.FoulEvent>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.FoulEvent>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.FoulEvent> _parser;
        public const int FoulPositionFieldNumber = 1;
        private global::EngineMessages.FloatValues foulPosition_;
        public const int FoulTypeFieldNumber = 2;
        private int foulType_;
        public const int FoulPlayerIdFieldNumber = 3;
        private int foulPlayerId_;
        public const int FoulPlayerTeamIdFieldNumber = 4;
        private int foulPlayerTeamId_;
        public const int FoulVictimIdFieldNumber = 5;
        private int foulVictimId_;
        public const int GameModeFieldNumber = 6;
        private global::EngineMessages.GameMode gameMode_;
        public const int FoulFrameFieldNumber = 7;
        private int foulFrame_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.FoulEvent> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.FloatValues FoulPosition
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
        public int FoulType
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
        public int FoulPlayerId
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
        public int FoulPlayerTeamId
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
        public int FoulVictimId
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
        public global::EngineMessages.GameMode GameMode
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
        public int FoulFrame
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
        public FoulEvent()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FoulEvent(global::EngineMessages.FoulEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.FoulEvent Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.FoulEvent other)
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
        public void MergeFrom(global::EngineMessages.FoulEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}