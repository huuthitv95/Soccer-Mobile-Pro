namespace Srv
{
    public sealed class MirroredMatchChallengeArchive : global::Google.Protobuf.IMessage<global::Srv.MirroredMatchChallengeArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.MirroredMatchChallengeArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.MirroredMatchChallengeArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.MirroredMatchChallengeArchive> _parser;
        public const int ChallengeArchiveFieldNumber = 1;
        private global::Srv.ClassicTeamMatchChallengeArchive challengeArchive_;
        public const int LastTimeFieldNumber = 2;
        private long lastTime_;
        public const int ChallengeDifficultyFieldNumber = 3;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_challengeDifficulty_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> challengeDifficulty_;
        public const int SetPiecesChallengeIndexFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_setPiecesChallengeIndex_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> setPiecesChallengeIndex_;
        public const int FullMatchsChallengeIndexFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_fullMatchsChallengeIndex_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> fullMatchsChallengeIndex_;
        public const int NeedAnimtionFieldNumber = 6;
        private bool needAnimtion_;
        public const int CompletedChallengesFieldNumber = 7;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_completedChallenges_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> completedChallenges_;
        public const int PointsStoreFieldNumber = 8;
        private global::Srv.PointsStoreArchive pointsStore_;
        public const int LogArchiveFieldNumber = 9;
        private int logArchive_;
        public const int ReactiveByPointTimesFieldNumber = 10;
        private int reactiveByPointTimes_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.MirroredMatchChallengeArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ClassicTeamMatchChallengeArchive ChallengeArchive
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
        public long LastTime
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
        public global::Google.Protobuf.Collections.MapField<int, int> ChallengeDifficulty => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> SetPiecesChallengeIndex => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> FullMatchsChallengeIndex => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool NeedAnimtion
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
        public global::Google.Protobuf.Collections.RepeatedField<int> CompletedChallenges => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PointsStoreArchive PointsStore
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
        public int LogArchive
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
        public int ReactiveByPointTimes
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
        public MirroredMatchChallengeArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MirroredMatchChallengeArchive(global::Srv.MirroredMatchChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.MirroredMatchChallengeArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.MirroredMatchChallengeArchive other)
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
        public void MergeFrom(global::Srv.MirroredMatchChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}