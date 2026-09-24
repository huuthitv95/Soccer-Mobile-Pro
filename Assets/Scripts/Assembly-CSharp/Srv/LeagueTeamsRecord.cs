namespace Srv
{
    public sealed class LeagueTeamsRecord : global::Google.Protobuf.IMessage<global::Srv.LeagueTeamsRecord>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.LeagueTeamsRecord>, global::Google.Protobuf.IDeepCloneable<global::Srv.LeagueTeamsRecord>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.LeagueTeamsRecord> _parser;
        public const int LeagueProtoIdFieldNumber = 1;
        private int leagueProtoId_;
        public const int RegionalLeagueFieldNumber = 2;
        private string regionalLeague_;
        public const int TeamsFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_teams_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> teams_;
        public const int LeagueLevelFieldNumber = 4;
        private int leagueLevel_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.LeagueTeamsRecord> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int LeagueProtoId
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
        public string RegionalLeague
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
        public global::Google.Protobuf.Collections.RepeatedField<int> Teams => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int LeagueLevel
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
        public LeagueTeamsRecord()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public LeagueTeamsRecord(global::Srv.LeagueTeamsRecord other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.LeagueTeamsRecord Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.LeagueTeamsRecord other)
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
        public void MergeFrom(global::Srv.LeagueTeamsRecord other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}