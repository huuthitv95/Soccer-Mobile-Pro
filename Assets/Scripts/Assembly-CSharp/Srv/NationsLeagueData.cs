namespace Srv
{
    public sealed class NationsLeagueData : global::Google.Protobuf.IMessage<global::Srv.NationsLeagueData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.NationsLeagueData>, global::Google.Protobuf.IDeepCloneable<global::Srv.NationsLeagueData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.NationsLeagueData> _parser;
        public const int RoundFieldNumber = 1;
        private int round_;
        public const int RankFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_rank_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> rank_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.NationsLeagueData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Round
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
        public global::Google.Protobuf.Collections.RepeatedField<int> Rank => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public NationsLeagueData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public NationsLeagueData(global::Srv.NationsLeagueData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.NationsLeagueData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.NationsLeagueData other)
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
        public void MergeFrom(global::Srv.NationsLeagueData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}