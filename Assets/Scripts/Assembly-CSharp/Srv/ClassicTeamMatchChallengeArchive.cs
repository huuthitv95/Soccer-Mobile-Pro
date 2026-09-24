namespace Srv
{
    public sealed class ClassicTeamMatchChallengeArchive : global::Google.Protobuf.IMessage<global::Srv.ClassicTeamMatchChallengeArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.ClassicTeamMatchChallengeArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.ClassicTeamMatchChallengeArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.ClassicTeamMatchChallengeArchive> _parser;
        public const int NameFieldNumber = 1;
        private string name_;
        public const int MissionsStateFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_missionsState_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> missionsState_;
        public const int CoinRewardFieldNumber = 3;
        private int coinReward_;
        public const int PlayerRewardTimesFieldNumber = 4;
        private int playerRewardTimes_;
        public const int StateFieldNumber = 5;
        private int state_;
        public const int MissionsCompletionCountFieldNumber = 6;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_missionsCompletionCount_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> missionsCompletionCount_;
        public const int FirstOpenFlagFieldNumber = 7;
        private bool firstOpenFlag_;
        public const int ClaimedPlayersFieldNumber = 8;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_claimedPlayers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> claimedPlayers_;
        public const int PlayerRewardPoolFieldNumber = 9;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_playerRewardPool_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> playerRewardPool_;
        public const int RevealArchiveFieldNumber = 10;
        private global::Srv.RewardRevealArchive revealArchive_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.ClassicTeamMatchChallengeArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string Name
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
        public global::Google.Protobuf.Collections.MapField<int, int> MissionsState => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
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
        public int PlayerRewardTimes
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
        public int State
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
        public global::Google.Protobuf.Collections.MapField<int, int> MissionsCompletionCount => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool FirstOpenFlag
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
        public global::Google.Protobuf.Collections.RepeatedField<int> ClaimedPlayers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PlayerRewardPool => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.RewardRevealArchive RevealArchive
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
        public ClassicTeamMatchChallengeArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ClassicTeamMatchChallengeArchive(global::Srv.ClassicTeamMatchChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ClassicTeamMatchChallengeArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.ClassicTeamMatchChallengeArchive other)
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
        public void MergeFrom(global::Srv.ClassicTeamMatchChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}