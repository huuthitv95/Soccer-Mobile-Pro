namespace Srv
{
    public sealed class SeasonData : global::Google.Protobuf.IMessage<global::Srv.SeasonData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.SeasonData>, global::Google.Protobuf.IDeepCloneable<global::Srv.SeasonData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.SeasonData> _parser;
        public const int FixtureFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.FixtureList>.Codec _map_fixture_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.FixtureList> fixture_;
        public const int CurrentDateFieldNumber = 2;
        private long currentDate_;
        public const int PlayerManagerIdFieldNumber = 3;
        private int playerManagerId_;
        public const int TeamManagerIdFieldNumber = 4;
        private int teamManagerId_;
        public const int UserTeamIdFieldNumber = 5;
        private int userTeamId_;
        public const int UnlockedLeagueFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_unlockedLeague_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> unlockedLeague_;
        public const int CurrentYearFieldNumber = 7;
        private int currentYear_;
        public const int LastLeagueFieldNumber = 8;
        private string lastLeague_;
        public const int RecordTmFieldNumber = 9;
        private long recordTm_;
        public const int VersionFieldNumber = 10;
        private int version_;
        public const int ScoutFieldNumber = 11;
        private global::Srv.ScoutArchive scout_;
        public const int FinancialFieldNumber = 12;
        private global::Srv.FinancialArchive financial_;
        public const int PlayerHonorFieldNumber = 13;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_playerHonor_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> playerHonor_;
        public const int TransferArchiveFieldNumber = 14;
        private global::Srv.TransferArchive transferArchive_;
        public const int LogArchiveFieldNumber = 15;
        private global::Srv.MasterLeagueLogEvent logArchive_;
        public const int SeasonCounterFieldNumber = 16;
        private int seasonCounter_;
        public const int TeamdatabaseFieldNumber = 17;
        private global::Srv.ClubTeamDatabase teamdatabase_;
        public const int PlayerdatabaseFieldNumber = 18;
        private global::Srv.ClubPlayerDatabase playerdatabase_;
        public const int LeagueDatabasesFieldNumber = 19;
        private static readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.LeagueData>.Codec _map_leagueDatabases_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.LeagueData> leagueDatabases_;
        public const int CupDatabasesFieldNumber = 20;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.WorldCupData>.Codec _map_cupDatabases_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.WorldCupData> cupDatabases_;
        public const int PatchMarkFieldNumber = 21;
        private int patchMark_;
        public const int CurTrainingTypeFieldNumber = 22;
        private int curTrainingType_;
        public const int TrainingCycleFieldNumber = 23;
        private int trainingCycle_;
        public const int CanRefeshTrainingTypeFieldNumber = 24;
        private bool canRefeshTrainingType_;
        public const int EditableDataFieldNumber = 25;
        private global::Srv.ExternalDataSetting editableData_;
        public const int StadiumIdFieldNumber = 26;
        private int stadiumId_;
        public const int TrainingMarkFieldNumber = 27;
        private int trainingMark_;
        public const int RetirementPlayersFieldNumber = 28;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_retirementPlayers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> retirementPlayers_;
        public const int DifficultyValueFieldNumber = 29;
        private int difficultyValue_;
        public const int EnablePlayerContractFieldNumber = 30;
        private bool enablePlayerContract_;
        public const int PlayerDisciplineRecordFieldNumber = 31;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerDisciplineRecord>.Codec _map_playerDisciplineRecord_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerDisciplineRecord> playerDisciplineRecord_;
        public const int AppearanceProfileFieldNumber = 32;
        private global::Srv.UserAppearanceProfile appearanceProfile_;
        public const int FreeCoinBtnStateFieldNumber = 33;
        private bool freeCoinBtnState_;
        public const int RetirementRecordFieldNumber = 34;
        private global::Srv.PlayerRetirement retirementRecord_;
        public const int PlayerPotentialRecordFieldNumber = 35;
        private static readonly global::Google.Protobuf.Collections.MapField<int, float>.Codec _map_playerPotentialRecord_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, float> playerPotentialRecord_;
        public const int PopupFlagsFieldNumber = 36;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_popupFlags_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> popupFlags_;
        public const int PopupRecordFieldNumber = 37;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_popupRecord_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> popupRecord_;
        public const int ModeDifficultyFieldNumber = 38;
        private int modeDifficulty_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.SeasonData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, global::Srv.FixtureList> Fixture => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public long CurrentDate
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
        public global::Google.Protobuf.Collections.RepeatedField<string> UnlockedLeague => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int CurrentYear
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
        public string LastLeague
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
        public int Version
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
        public global::Srv.ScoutArchive Scout
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
        public global::Srv.FinancialArchive Financial
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
        public global::Google.Protobuf.Collections.MapField<int, int> PlayerHonor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.TransferArchive TransferArchive
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
        public global::Srv.MasterLeagueLogEvent LogArchive
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
        public int SeasonCounter
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
        public global::Google.Protobuf.Collections.MapField<string, global::Srv.LeagueData> LeagueDatabases => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.WorldCupData> CupDatabases => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int PatchMark
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
        public int CurTrainingType
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
        public int TrainingCycle
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
        public bool CanRefeshTrainingType
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ExternalDataSetting EditableData
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
        public int StadiumId
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
        public int TrainingMark
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
        public global::Google.Protobuf.Collections.RepeatedField<int> RetirementPlayers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int DifficultyValue
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
        public bool EnablePlayerContract
        {
            get
            {
                return false;
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
        public bool FreeCoinBtnState
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PlayerRetirement RetirementRecord
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
        public global::Google.Protobuf.Collections.MapField<int, float> PlayerPotentialRecord => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PopupFlags => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PopupRecord => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int ModeDifficulty
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public void Init(bool useTransfer)
        {
        }

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SeasonData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SeasonData(global::Srv.SeasonData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.SeasonData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.SeasonData other)
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
        public void MergeFrom(global::Srv.SeasonData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}