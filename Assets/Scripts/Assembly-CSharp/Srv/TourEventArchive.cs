namespace Srv
{
    public sealed class TourEventArchive : global::Google.Protobuf.IMessage<global::Srv.TourEventArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.TourEventArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.TourEventArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.TourEventArchive> _parser;
        public const int EventIdFieldNumber = 1;
        private int eventId_;
        public const int SelectedTeamTemplateIdFieldNumber = 2;
        private int selectedTeamTemplateId_;
        public const int ShellTeamIdFieldNumber = 3;
        private int shellTeamId_;
        public const int PlayerTeamFieldNumber = 4;
        private global::Srv.CustomTeam playerTeam_;
        public const int CopiedPlayerIdsFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_copiedPlayerIds_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> copiedPlayerIds_;
        public const int CurrentChapterIdFieldNumber = 6;
        private int currentChapterId_;
        public const int CurrentNodeIdFieldNumber = 7;
        private int currentNodeId_;
        public const int CurrentFatigueFieldNumber = 8;
        private int currentFatigue_;
        public const int LastRechargeTimeFieldNumber = 9;
        private long lastRechargeTime_;
        public const int DailyRechargeCountFieldNumber = 10;
        private int dailyRechargeCount_;
        public const int NodeStatesFieldNumber = 11;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_nodeStates_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> nodeStates_;
        public const int ClaimedChapterRewardsFieldNumber = 12;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_claimedChapterRewards_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> claimedChapterRewards_;
        public const int PointsStoreFieldNumber = 13;
        private global::Srv.PointsStoreArchive pointsStore_;
        public const int PendingReplacementSlotIndexFieldNumber = 14;
        private int pendingReplacementSlotIndex_;
        public const int PendingReplacementPlayerIdFieldNumber = 15;
        private int pendingReplacementPlayerId_;
        public const int PendingRewardNodeIdFieldNumber = 16;
        private int pendingRewardNodeId_;
        public const int FirstOpenFlagFieldNumber = 17;
        private bool firstOpenFlag_;
        public const int CompletedLoopCountFieldNumber = 18;
        private int completedLoopCount_;
        public const int TeamSelectionDraftsFieldNumber = 19;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.TourEventTeamSelectionDraft> _repeated_teamSelectionDrafts_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.TourEventTeamSelectionDraft> teamSelectionDrafts_;
        public const int NodeRuntimeDataFieldNumber = 20;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.TourEventNodeRuntimeData> _repeated_nodeRuntimeData_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.TourEventNodeRuntimeData> nodeRuntimeData_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.TourEventArchive> Parser => null;

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
        public int SelectedTeamTemplateId
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
        public int ShellTeamId
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
        public global::Srv.CustomTeam PlayerTeam
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
        public global::Google.Protobuf.Collections.RepeatedField<int> CopiedPlayerIds => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int CurrentChapterId
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
        public int CurrentNodeId
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
        public int CurrentFatigue
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
        public long LastRechargeTime
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
        public int DailyRechargeCount
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
        public global::Google.Protobuf.Collections.MapField<int, int> NodeStates => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> ClaimedChapterRewards => null;

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
        public int PendingReplacementSlotIndex
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
        public int PendingReplacementPlayerId
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
        public int PendingRewardNodeId
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
        public int CompletedLoopCount
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.TourEventTeamSelectionDraft> TeamSelectionDrafts => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.TourEventNodeRuntimeData> NodeRuntimeData => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TourEventArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TourEventArchive(global::Srv.TourEventArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.TourEventArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.TourEventArchive other)
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
        public void MergeFrom(global::Srv.TourEventArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}