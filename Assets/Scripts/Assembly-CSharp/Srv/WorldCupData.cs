namespace Srv
{
    public sealed class WorldCupData : global::Google.Protobuf.IMessage<global::Srv.WorldCupData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.WorldCupData>, global::Google.Protobuf.IDeepCloneable<global::Srv.WorldCupData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.WorldCupData> _parser;
        public const int CupIdFieldNumber = 1;
        private int cupId_;
        public const int DataFieldNumber = 2;
        private global::Srv.CupData data_;
        public const int ReplacedTeamFieldNumber = 3;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_replacedTeam_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> replacedTeam_;
        public const int TeamManagerIdFieldNumber = 4;
        private int teamManagerId_;
        public const int PlayerManagerIdFieldNumber = 5;
        private int playerManagerId_;
        public const int CupTypeFieldNumber = 6;
        private string cupType_;
        public const int WinningStreakFieldNumber = 7;
        private int winningStreak_;
        public const int RecordTmFieldNumber = 8;
        private long recordTm_;
        public const int VariantIdFieldNumber = 12;
        private int variantId_;
        public const int PlayerdatabaseFieldNumber = 13;
        private global::Srv.ClubPlayerDatabase playerdatabase_;
        public const int TeamdatabaseFieldNumber = 14;
        private global::Srv.ClubTeamDatabase teamdatabase_;
        public const int GlobalIdFieldNumber = 15;
        private int globalId_;
        public const int PlayerDisciplineRecordFieldNumber = 16;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerDisciplineRecord>.Codec _map_playerDisciplineRecord_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerDisciplineRecord> playerDisciplineRecord_;
        public const int AppearanceProfileFieldNumber = 17;
        private global::Srv.UserAppearanceProfile appearanceProfile_;
        public const int WinningGroupInfoFieldNumber = 18;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_winningGroupInfo_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> winningGroupInfo_;
        public const int NationsLeagueFieldNumber = 19;
        private global::Srv.NationsLeagueData nationsLeague_;
        public const int DynamicCupDataFieldNumber = 20;
        private global::Srv.DynamicCupData dynamicCupData_;
        public const int LeagueCupBracketFieldNumber = 21;
        private global::Srv.LeagueCupBracketData leagueCupBracket_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.WorldCupData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int CupId
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
        public global::Srv.CupData Data
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
        public global::Google.Protobuf.Collections.MapField<int, int> ReplacedTeam => null;

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
        public string CupType
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
        public long RecordTm
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

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

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ClubPlayerDatabase Playerdatabase
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
        public global::Srv.ClubTeamDatabase Teamdatabase
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
        public int GlobalId
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
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerDisciplineRecord> PlayerDisciplineRecord => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.UserAppearanceProfile AppearanceProfile
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
        public global::Google.Protobuf.Collections.RepeatedField<int> WinningGroupInfo => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.NationsLeagueData NationsLeague
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
        public global::Srv.DynamicCupData DynamicCupData
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
        public global::Srv.LeagueCupBracketData LeagueCupBracket
        {
            get
            {
                return null;
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
        public WorldCupData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public WorldCupData(global::Srv.WorldCupData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.WorldCupData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.WorldCupData other)
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
        public void MergeFrom(global::Srv.WorldCupData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}