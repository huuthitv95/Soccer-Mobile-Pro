namespace Srv
{
    public sealed class FinancialArchive : global::Google.Protobuf.IMessage<global::Srv.FinancialArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.FinancialArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.FinancialArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.FinancialArchive> _parser;
        public const int CoinFieldNumber = 1;
        private int coin_;
        public const int IncomeBookFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_incomeBook_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> incomeBook_;
        public const int ExpenseBookFieldNumber = 3;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_expenseBook_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> expenseBook_;
        public const int SeasonBonusDetailInfoFieldNumber = 4;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.IntPairsList>.Codec _map_seasonBonusDetailInfo_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.IntPairsList> seasonBonusDetailInfo_;
        public const int DeficitTipFieldNumber = 5;
        private bool deficitTip_;
        public const int InDeficitFieldNumber = 6;
        private bool inDeficit_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.FinancialArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Coin
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
        public global::Google.Protobuf.Collections.MapField<int, int> IncomeBook => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, int> ExpenseBook => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.IntPairsList> SeasonBonusDetailInfo => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool DeficitTip
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
        public bool InDeficit
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
        public FinancialArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FinancialArchive(global::Srv.FinancialArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.FinancialArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.FinancialArchive other)
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
        public void MergeFrom(global::Srv.FinancialArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}