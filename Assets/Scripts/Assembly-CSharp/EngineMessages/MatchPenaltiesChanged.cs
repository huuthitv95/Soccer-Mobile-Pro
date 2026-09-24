namespace EngineMessages
{
    public sealed class MatchPenaltiesChanged : global::Google.Protobuf.IMessage<global::EngineMessages.MatchPenaltiesChanged>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.MatchPenaltiesChanged>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.MatchPenaltiesChanged>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.MatchPenaltiesChanged> _parser;
        public const int TeamIdFieldNumber = 1;
        private int teamId_;
        public const int ScoredFieldNumber = 2;
        private bool scored_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.MatchPenaltiesChanged> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int TeamId
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
        public bool Scored
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
        public MatchPenaltiesChanged()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchPenaltiesChanged(global::EngineMessages.MatchPenaltiesChanged other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchPenaltiesChanged Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.MatchPenaltiesChanged other)
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
        public void MergeFrom(global::EngineMessages.MatchPenaltiesChanged other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}