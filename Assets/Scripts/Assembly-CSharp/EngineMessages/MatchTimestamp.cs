namespace EngineMessages
{
    public sealed class MatchTimestamp : global::Google.Protobuf.IMessage<global::EngineMessages.MatchTimestamp>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.MatchTimestamp>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.MatchTimestamp>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.MatchTimestamp> _parser;
        public const int PhaseFieldNumber = 1;
        private global::EngineMessages.MatchPhase phase_;
        public const int StateFieldNumber = 2;
        private global::EngineMessages.MatchState state_;
        public const int BallPositionFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_ballPosition_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> ballPosition_;
        public const int ProgressFieldNumber = 4;
        private global::EngineMessages.MatchProgress progress_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.MatchTimestamp> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchPhase Phase
        {
            get
            {
                return global::EngineMessages.MatchPhase.PreMatch;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchState State
        {
            get
            {
                return global::EngineMessages.MatchState.Playing;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> BallPosition => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchProgress Progress
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
        public MatchTimestamp()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchTimestamp(global::EngineMessages.MatchTimestamp other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchTimestamp Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.MatchTimestamp other)
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
        public void MergeFrom(global::EngineMessages.MatchTimestamp other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}