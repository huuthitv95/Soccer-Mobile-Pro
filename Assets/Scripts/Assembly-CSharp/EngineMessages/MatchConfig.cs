namespace EngineMessages
{
    public sealed class MatchConfig : global::Google.Protobuf.IMessage<global::EngineMessages.MatchConfig>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.MatchConfig>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.MatchConfig>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.MatchConfig> _parser;
        public const int InputOverlayFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.InputOverlay> _repeated_inputOverlay_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.InputOverlay> inputOverlay_;
        public const int TeamDataFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.TeamData> _repeated_teamData_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.TeamData> teamData_;
        public const int ModeFieldNumber = 3;
        private global::EngineMessages.MatchMode mode_;
        public const int MatchStateFieldNumber = 4;
        private global::EngineMessages.MatchState matchState_;
        public const int BallPositionFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_ballPosition_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> ballPosition_;
        public const int BallMomentumFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_ballMomentum_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> ballMomentum_;
        public const int BallTargetFieldNumber = 7;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_ballTarget_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> ballTarget_;
        public const int PlayerCountFieldNumber = 8;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_playerCount_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> playerCount_;
        public const int ConfigStringFieldNumber = 9;
        private string configString_;
        public const int RestartBallTakerFieldNumber = 10;
        private global::EngineMessages.RestartBallTaker restartBallTaker_;
        public const int MatchProgressFieldNumber = 11;
        private global::EngineMessages.MatchProgress matchProgress_;
        public const int UserControllersFieldNumber = 12;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.DeviceController> _repeated_userControllers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.DeviceController> userControllers_;
        public const int FirstLegScoresFieldNumber = 13;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_firstLegScores_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> firstLegScores_;
        public const int HasExtraTimeFieldNumber = 14;
        private bool hasExtraTime_;
        public const int HasPenaltiesFieldNumber = 15;
        private bool hasPenalties_;
        public const int StartPhaseFieldNumber = 16;
        private global::EngineMessages.MatchPhase startPhase_;
        public const int HeroIdFieldNumber = 17;
        private int heroId_;
        public const int BuffHeroStrengthenFieldNumber = 18;
        private bool buffHeroStrengthen_;
        public const int BuffLastDitchTimeFieldNumber = 19;
        private uint buffLastDitchTime_;
        public const int DebugFieldNumber = 20;
        private bool debug_;
        public const int TrainingFieldNumber = 21;
        private bool training_;
        public const int NoviceFieldNumber = 29;
        private bool novice_;
        public const int DefaultLastDitchTimeFieldNumber = 22;
        private uint defaultLastDitchTime_;
        public const int ShootParamFieldNumber = 23;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_shootParam_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> shootParam_;
        public const int CineTotalTickFieldNumber = 24;
        private int cineTotalTick_;
        public const int CineBallTouchTickFieldNumber = 25;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_cineBallTouchTick_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> cineBallTouchTick_;
        public const int CineBallTouchDataFieldNumber = 26;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_cineBallTouchData_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> cineBallTouchData_;
        public const int CineOfficialsFieldNumber = 27;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.PlayerData> _repeated_cineOfficials_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerData> cineOfficials_;
        public const int CineSfxFieldNumber = 28;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_cineSfx_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> cineSfx_;
        public const int StadiumInfoFieldNumber = 30;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_stadiumInfo_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> stadiumInfo_;
        public const int ToolsFieldNumber = 31;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.TrainingTool> _repeated_tools_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.TrainingTool> tools_;
        public const int StartTeamIdFieldNumber = 32;
        private int startTeamId_;
        public const int TrainingConfigFieldNumber = 33;
        private global::EngineMessages.TrainingConfig trainingConfig_;
        public const int AutoPlayCountFieldNumber = 34;
        private int autoPlayCount_;
        public const int CheckingLastDitchTimeFieldNumber = 35;
        private uint checkingLastDitchTime_;
        public const int RandomSeedFieldNumber = 36;
        private uint randomSeed_;
        public const int TestCasesFieldNumber = 37;
        private string testCases_;
        public const int PlayersWithStarFieldNumber = 38;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_playersWithStar_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> playersWithStar_;
        public const int PosesWithStarFieldNumber = 39;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_posesWithStar_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> posesWithStar_;
        public const int MatchStartDelayFieldNumber = 40;
        private uint matchStartDelay_;
        public const int BallServiceFieldNumber = 41;
        private global::EngineMessages.BallService ballService_;
        public const int ShootSnapRadiusFieldNumber = 42;
        private float shootSnapRadius_;
        public const int GolfTargetFieldNumber = 43;
        private global::EngineMessages.GolfTarget golfTarget_;
        public const int DelayedConfigsFieldNumber = 44;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.StringMap> _repeated_delayedConfigs_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.StringMap> delayedConfigs_;
        public const int WoodworkFieldNumber = 45;
        private bool woodwork_;
        public const int InputCountLimitFieldNumber = 46;
        private int inputCountLimit_;
        public const int PersonalizedAnimationsFieldNumber = 47;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_personalizedAnimations_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> personalizedAnimations_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.MatchConfig> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.InputOverlay> InputOverlay => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.TeamData> TeamData => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchMode Mode
        {
            get
            {
                return global::EngineMessages.MatchMode.Normal;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchState MatchState
        {
            get
            {
                return global::EngineMessages.MatchState.Playing;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> BallPosition => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> BallMomentum => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> BallTarget => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PlayerCount => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string ConfigString
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
        public global::EngineMessages.RestartBallTaker RestartBallTaker
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
        public global::EngineMessages.MatchProgress MatchProgress
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
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.DeviceController> UserControllers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> FirstLegScores => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool HasExtraTime
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
        public bool HasPenalties
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
        public global::EngineMessages.MatchPhase StartPhase
        {
            get
            {
                return global::EngineMessages.MatchPhase.PreMatch;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int HeroId
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
        public bool BuffHeroStrengthen
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
        public uint BuffLastDitchTime
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Debug
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
        public bool Training
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
        public bool Novice
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
        public uint DefaultLastDitchTime
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> ShootParam => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int CineTotalTick
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
        public global::Google.Protobuf.Collections.RepeatedField<int> CineBallTouchTick => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> CineBallTouchData => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerData> CineOfficials => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> CineSfx => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> StadiumInfo => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.TrainingTool> Tools => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int StartTeamId
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
        public global::EngineMessages.TrainingConfig TrainingConfig
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
        public int AutoPlayCount
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
        public uint CheckingLastDitchTime
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public uint RandomSeed
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string TestCases
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
        public global::Google.Protobuf.Collections.RepeatedField<int> PlayersWithStar => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> PosesWithStar => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public uint MatchStartDelay
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.BallService BallService
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
        public float ShootSnapRadius
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.GolfTarget GolfTarget
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
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.StringMap> DelayedConfigs => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Woodwork
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
        public int InputCountLimit
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
        public global::Google.Protobuf.Collections.RepeatedField<string> PersonalizedAnimations => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchConfig()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchConfig(global::EngineMessages.MatchConfig other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchConfig Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.MatchConfig other)
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
        public void MergeFrom(global::EngineMessages.MatchConfig other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}