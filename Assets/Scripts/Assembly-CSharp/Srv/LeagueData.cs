namespace Srv
{
    public sealed class LeagueData : global::Google.Protobuf.IMessage<global::Srv.LeagueData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.LeagueData>, global::Google.Protobuf.IDeepCloneable<global::Srv.LeagueData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.LeagueData> _parser;
        public const int LidFieldNumber = 1;
        private int lid_;
        public const int MatchsFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.MatchData> _repeated_matchs_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.MatchData> matchs_;
        public const int RoundFieldNumber = 3;
        private int round_;
        public const int UserTeamIdFieldNumber = 4;
        private int userTeamId_;
        public const int TeamsFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_teams_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> teams_;
        public const int WinningStreakFieldNumber = 7;
        private int winningStreak_;
        public const int TeamManagerIdFieldNumber = 8;
        private int teamManagerId_;
        public const int PlayerManagerIdFieldNumber = 9;
        private int playerManagerId_;
        public const int ProtoFieldNumber = 10;
        private string proto_;
        public const int TeamsBackUpFieldNumber = 11;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_teamsBackUp_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> teamsBackUp_;
        public const int VariantIdFieldNumber = 12;
        private int variantId_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.LeagueData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Lid
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.MatchData> Matchs => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Round
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
        public int UserTeamId
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
        public global::Google.Protobuf.Collections.RepeatedField<int> Teams => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int WinningStreak
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
        public int TeamManagerId
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
        public int PlayerManagerId
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
        public string Proto
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
        public global::Google.Protobuf.Collections.RepeatedField<int> TeamsBackUp => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int VariantId
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
        public LeagueData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public LeagueData(global::Srv.LeagueData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.LeagueData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.LeagueData other)
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
        public void MergeFrom(global::Srv.LeagueData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}