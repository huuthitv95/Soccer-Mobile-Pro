namespace Srv
{
    public sealed class IAPStoreArchive : global::Google.Protobuf.IMessage<global::Srv.IAPStoreArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.IAPStoreArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.IAPStoreArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.IAPStoreArchive> _parser;
        public const int PurchaseRecordsFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<string, int>.Codec _map_purchaseRecords_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, int> purchaseRecords_;
        public const int PendingOrdersFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<string, string>.Codec _map_pendingOrders_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, string> pendingOrders_;
        public const int PurchasedIAPPlayersFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_purchasedIAPPlayers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> purchasedIAPPlayers_;
        public const int StadiumPurchaseRecordsFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_stadiumPurchaseRecords_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> stadiumPurchaseRecords_;
        public const int FreeCoinClaimCountFieldNumber = 5;
        private int freeCoinClaimCount_;
        public const int LastFreeCoinRefreshTmFieldNumber = 6;
        private long lastFreeCoinRefreshTm_;
        public const int AppliedIapGrantIdsFieldNumber = 7;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_appliedIapGrantIds_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> appliedIapGrantIds_;
        public const int PlayerCareerFreeCoinClaimCountFieldNumber = 8;
        private int playerCareerFreeCoinClaimCount_;
        public const int PlayerCareerLastFreeCoinRefreshTmFieldNumber = 9;
        private long playerCareerLastFreeCoinRefreshTm_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.IAPStoreArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, int> PurchaseRecords => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, string> PendingOrders => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PurchasedIAPPlayers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> StadiumPurchaseRecords => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int FreeCoinClaimCount
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
        public long LastFreeCoinRefreshTm
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
        public global::Google.Protobuf.Collections.RepeatedField<string> AppliedIapGrantIds => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int PlayerCareerFreeCoinClaimCount
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
        public long PlayerCareerLastFreeCoinRefreshTm
        {
            get
            {
                return 0L;
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
        public IAPStoreArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public IAPStoreArchive(global::Srv.IAPStoreArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.IAPStoreArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.IAPStoreArchive other)
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
        public void MergeFrom(global::Srv.IAPStoreArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}