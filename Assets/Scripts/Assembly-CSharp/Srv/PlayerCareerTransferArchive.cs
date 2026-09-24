namespace Srv
{
    public sealed class PlayerCareerTransferArchive : global::Google.Protobuf.IMessage<global::Srv.PlayerCareerTransferArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.PlayerCareerTransferArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.PlayerCareerTransferArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.PlayerCareerTransferArchive> _parser;
        public const int SeasonYearFieldNumber = 1;
        private int seasonYear_;
        public const int CurrentEventFieldNumber = 2;
        private global::Srv.PlayerCareerTransferEvent currentEvent_;
        public const int AgreementsFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.PlayerCareerTransferAgreement> _repeated_agreements_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.PlayerCareerTransferAgreement> agreements_;
        public const int PendingTeamIdFieldNumber = 4;
        private int pendingTeamId_;
        public const int PendingLeagueProtoIdFieldNumber = 5;
        private int pendingLeagueProtoId_;
        public const int DeadlineResolvedFieldNumber = 6;
        private bool deadlineResolved_;
        public const int FinalOfferRefreshTimesFieldNumber = 7;
        private int finalOfferRefreshTimes_;
        public const int PendingAgreementFieldNumber = 8;
        private global::Srv.PlayerCareerTransferAgreement pendingAgreement_;
        public const int EventCounterFieldNumber = 9;
        private int eventCounter_;
        public const int PendingTransferJerseySelectionFieldNumber = 10;
        private bool pendingTransferJerseySelection_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.PlayerCareerTransferArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int SeasonYear
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
        public global::Srv.PlayerCareerTransferEvent CurrentEvent
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.PlayerCareerTransferAgreement> Agreements => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int PendingTeamId
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
        public int PendingLeagueProtoId
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
        public bool DeadlineResolved
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
        public int FinalOfferRefreshTimes
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
        public global::Srv.PlayerCareerTransferAgreement PendingAgreement
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
        public int EventCounter
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
        public bool PendingTransferJerseySelection
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
        public PlayerCareerTransferArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerCareerTransferArchive(global::Srv.PlayerCareerTransferArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PlayerCareerTransferArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.PlayerCareerTransferArchive other)
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
        public void MergeFrom(global::Srv.PlayerCareerTransferArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}