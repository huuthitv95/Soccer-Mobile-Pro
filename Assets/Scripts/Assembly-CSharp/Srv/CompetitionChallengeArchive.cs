namespace Srv
{
    public sealed class CompetitionChallengeArchive : global::Google.Protobuf.IMessage<global::Srv.CompetitionChallengeArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.CompetitionChallengeArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.CompetitionChallengeArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.CompetitionChallengeArchive> _parser;
        public const int IdFieldNumber = 1;
        private int id_;
        public const int MissionArchiveFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_missionArchive_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> missionArchive_;
        public const int StageRewardMissionArchiveFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_stageRewardMissionArchive_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> stageRewardMissionArchive_;
        public const int ClaimedTeamsFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_claimedTeams_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> claimedTeams_;
        public const int CoinRewardFieldNumber = 5;
        private int coinReward_;
        public const int TeamRewardFieldNumber = 6;
        private int teamReward_;
        public const int FirstOpenFieldNumber = 7;
        private bool firstOpen_;
        public const int CompletionTimesFieldNumber = 8;
        private int completionTimes_;
        public const int ClaimedPlayersFieldNumber = 9;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_claimedPlayers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> claimedPlayers_;
        public const int PlayerRewardsAvailableFieldNumber = 10;
        private int playerRewardsAvailable_;
        public const int RefreshRVFieldNumber = 11;
        private bool refreshRV_;
        public const int CupIdFieldNumber = 12;
        private int cupId_;
        public const int FirstRoundMarkFieldNumber = 13;
        private bool firstRoundMark_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.CompetitionChallengeArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Id
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
        public global::Google.Protobuf.Collections.RepeatedField<int> MissionArchive => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> StageRewardMissionArchive => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        [global::System.Obsolete]
        public global::Google.Protobuf.Collections.RepeatedField<int> ClaimedTeams => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        [global::System.Obsolete]
        public int CoinReward
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
        [global::System.Obsolete]
        public int TeamReward
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
        public bool FirstOpen
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
        public int CompletionTimes
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
        [global::System.Obsolete]
        public global::Google.Protobuf.Collections.RepeatedField<int> ClaimedPlayers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        [global::System.Obsolete]
        public int PlayerRewardsAvailable
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
        public bool RefreshRV
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
        public bool FirstRoundMark
        {
            get
            {
                return false;
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
        public CompetitionChallengeArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CompetitionChallengeArchive(global::Srv.CompetitionChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.CompetitionChallengeArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.CompetitionChallengeArchive other)
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
        public void MergeFrom(global::Srv.CompetitionChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}