namespace Srv
{
    public sealed class DynamicCupData : global::Google.Protobuf.IMessage<global::Srv.DynamicCupData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.DynamicCupData>, global::Google.Protobuf.IDeepCloneable<global::Srv.DynamicCupData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.DynamicCupData> _parser;
        public const int YearFieldNumber = 1;
        private int year_;
        public const int PromotionFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.ListInt>.Codec _map_promotion_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.ListInt> promotion_;
        public const int BaseCupTypeFieldNumber = 3;
        private string baseCupType_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.DynamicCupData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Year
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
        public global::Google.Protobuf.Collections.MapField<string, global::Srv.ListInt> Promotion => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string BaseCupType
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
        public DynamicCupData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public DynamicCupData(global::Srv.DynamicCupData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.DynamicCupData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.DynamicCupData other)
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
        public void MergeFrom(global::Srv.DynamicCupData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}