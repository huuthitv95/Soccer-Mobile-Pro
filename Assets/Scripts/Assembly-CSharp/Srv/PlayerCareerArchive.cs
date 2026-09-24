namespace Srv
{
    public sealed class PlayerCareerArchive : global::Google.Protobuf.IMessage<global::Srv.PlayerCareerArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.PlayerCareerArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.PlayerCareerArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.PlayerCareerArchive> _parser;
        public const int SeasonDataFieldNumber = 1;
        private global::Srv.SeasonData seasonData_;
        public const int UserPlayerDataFieldNumber = 2;
        private global::Srv.UserPlayerDataArchive userPlayerData_;
        public const int CurrentLeagueFieldNumber = 3;
        private string currentLeague_;
        public const int CurrencyFieldNumber = 4;
        private int currency_;
        public const int SeasonMissionFieldNumber = 5;
        private global::Srv.SeasonMissionGroup seasonMission_;
        public const int LeagueTeamsRecordsFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.LeagueTeamsRecord> _repeated_leagueTeamsRecords_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.LeagueTeamsRecord> leagueTeamsRecords_;
        public const int PlayerCareerFieldNumber = 7;
        private global::Srv.PlayerCareerTransferArchive playerCareer_;
        public const int SeasonStatsFieldNumber = 8;
        private global::Srv.PlayerCareerSeasonStatsArchive seasonStats_;
        public const int RetirementFieldNumber = 9;
        private global::Srv.PlayerCareerRetirementArchive retirement_;
        public const int MainViewCoinRVCountFieldNumber = 10;
        private int mainViewCoinRVCount_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.PlayerCareerArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.SeasonData SeasonData
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
        public global::Srv.UserPlayerDataArchive UserPlayerData
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
        public string CurrentLeague
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
        public int Currency
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
        public global::Srv.SeasonMissionGroup SeasonMission
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.LeagueTeamsRecord> LeagueTeamsRecords => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PlayerCareerTransferArchive PlayerCareer
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
        public global::Srv.PlayerCareerSeasonStatsArchive SeasonStats
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
        public global::Srv.PlayerCareerRetirementArchive Retirement
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
        public int MainViewCoinRVCount
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
        public PlayerCareerArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerCareerArchive(global::Srv.PlayerCareerArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PlayerCareerArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.PlayerCareerArchive other)
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
        public void MergeFrom(global::Srv.PlayerCareerArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}