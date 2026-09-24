namespace EngineMessages
{
    public sealed class TeamData : global::Google.Protobuf.IMessage<global::EngineMessages.TeamData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.TeamData>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.TeamData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.TeamData> _parser;
        public const int TeamidFieldNumber = 1;
        private int teamid_;
        public const int FormationXmlFieldNumber = 2;
        private string formationXml_;
        public const int TacticsXmlFieldNumber = 4;
        private string tacticsXml_;
        public const int PlayersFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.PlayerData> _repeated_players_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerData> players_;
        public const int PlayingStyleFieldNumber = 7;
        private global::EngineMessages.PlayingStyle playingStyle_;
        public const int BallTakersFieldNumber = 8;
        private global::EngineMessages.RestartBallTaker ballTakers_;
        public const int ControlStyleFieldNumber = 9;
        private global::EngineMessages.ControlStyle controlStyle_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.TeamData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

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

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string FormationXml
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
        public string TacticsXml
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
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerData> Players => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.PlayingStyle PlayingStyle
        {
            get
            {
                return global::EngineMessages.PlayingStyle.Defensive2;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.RestartBallTaker BallTakers
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
        public global::EngineMessages.ControlStyle ControlStyle
        {
            get
            {
                return global::EngineMessages.ControlStyle.Balance;
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
        public TeamData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TeamData(global::EngineMessages.TeamData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.TeamData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.TeamData other)
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
        public void MergeFrom(global::EngineMessages.TeamData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}