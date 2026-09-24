namespace Srv
{
    public sealed class CupData : global::Google.Protobuf.IMessage<global::Srv.CupData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.CupData>, global::Google.Protobuf.IDeepCloneable<global::Srv.CupData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.CupData> _parser;
        public const int MatchsFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.MatchData> _repeated_matchs_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.MatchData> matchs_;
        public const int RoundFieldNumber = 2;
        private int round_;
        public const int UserTeamIdFieldNumber = 3;
        private int userTeamId_;
        public const int DifficultyFieldNumber = 4;
        private int difficulty_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.CupData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.MatchData> Matchs => null;

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
        public int UserTeamId
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
        public int Difficulty
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
        public CupData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CupData(global::Srv.CupData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.CupData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.CupData other)
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
        public void MergeFrom(global::Srv.CupData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}