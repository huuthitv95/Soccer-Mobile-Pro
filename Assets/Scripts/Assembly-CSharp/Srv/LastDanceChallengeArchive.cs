namespace Srv
{
    public sealed class LastDanceChallengeArchive : global::Google.Protobuf.IMessage<global::Srv.LastDanceChallengeArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.LastDanceChallengeArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.LastDanceChallengeArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.LastDanceChallengeArchive> _parser;
        public const int EventIdFieldNumber = 1;
        private int eventId_;
        public const int PointsStoreFieldNumber = 2;
        private global::Srv.PointsStoreArchive pointsStore_;
        public const int FirstOpenFlagFieldNumber = 3;
        private bool firstOpenFlag_;
        public const int CurrentMatchBySlotFieldNumber = 4;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_currentMatchBySlot_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> currentMatchBySlot_;
        public const int SlotStateBySlotFieldNumber = 5;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_slotStateBySlot_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> slotStateBySlot_;
        public const int CompletedMatchIdsFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_completedMatchIds_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> completedMatchIds_;
        public const int AccumulatedCompletionCountFieldNumber = 7;
        private int accumulatedCompletionCount_;
        public const int LastClaimedProgressFieldNumber = 8;
        private int lastClaimedProgress_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.LastDanceChallengeArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int EventId
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
        public global::Google.Protobuf.Collections.MapField<int, int> CurrentMatchBySlot => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, int> SlotStateBySlot => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> CompletedMatchIds => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int AccumulatedCompletionCount
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
        public int LastClaimedProgress
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
        public LastDanceChallengeArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public LastDanceChallengeArchive(global::Srv.LastDanceChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.LastDanceChallengeArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.LastDanceChallengeArchive other)
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
        public void MergeFrom(global::Srv.LastDanceChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}