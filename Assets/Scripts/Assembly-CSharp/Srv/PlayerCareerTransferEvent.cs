namespace Srv
{
    public sealed class PlayerCareerTransferEvent : global::Google.Protobuf.IMessage<global::Srv.PlayerCareerTransferEvent>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.PlayerCareerTransferEvent>, global::Google.Protobuf.IDeepCloneable<global::Srv.PlayerCareerTransferEvent>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.PlayerCareerTransferEvent> _parser;
        public const int EventIdFieldNumber = 1;
        private int eventId_;
        public const int ScheduleTypeFieldNumber = 2;
        private int scheduleType_;
        public const int MaxNegotiationChancesFieldNumber = 4;
        private int maxNegotiationChances_;
        public const int UsedNegotiationChancesFieldNumber = 5;
        private int usedNegotiationChances_;
        public const int ActiveSearchUsedFieldNumber = 6;
        private bool activeSearchUsed_;
        public const int CompletedFieldNumber = 7;
        private bool completed_;
        public const int FinalOfferFieldNumber = 8;
        private bool finalOffer_;
        public const int OffersFieldNumber = 9;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.PlayerCareerTransferOffer> _repeated_offers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.PlayerCareerTransferOffer> offers_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.PlayerCareerTransferEvent> Parser => null;

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
        public int ScheduleType
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
        public int MaxNegotiationChances
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
        public int UsedNegotiationChances
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
        public bool ActiveSearchUsed
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
        public bool Completed
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
        public bool FinalOffer
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.PlayerCareerTransferOffer> Offers => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerCareerTransferEvent()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerCareerTransferEvent(global::Srv.PlayerCareerTransferEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PlayerCareerTransferEvent Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.PlayerCareerTransferEvent other)
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
        public void MergeFrom(global::Srv.PlayerCareerTransferEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}