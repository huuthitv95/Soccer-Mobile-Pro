namespace EngineMessages
{
    public sealed class PlayerScore : global::Google.Protobuf.IMessage<global::EngineMessages.PlayerScore>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.PlayerScore>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.PlayerScore>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.PlayerScore> _parser;
        public const int PlayerIdFieldNumber = 1;
        private int playerId_;
        public const int PositionScoreFieldNumber = 2;
        private float positionScore_;
        public const int PassScoreFieldNumber = 3;
        private float passScore_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.PlayerScore> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int PlayerId
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
        public float PositionScore
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float PassScore
        {
            get
            {
                return 0f;
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
        public PlayerScore()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerScore(global::EngineMessages.PlayerScore other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.PlayerScore Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.PlayerScore other)
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
        public void MergeFrom(global::EngineMessages.PlayerScore other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}