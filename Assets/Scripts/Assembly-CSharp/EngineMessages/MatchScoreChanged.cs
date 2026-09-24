namespace EngineMessages
{
    public sealed class MatchScoreChanged : global::Google.Protobuf.IMessage<global::EngineMessages.MatchScoreChanged>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.MatchScoreChanged>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.MatchScoreChanged>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.MatchScoreChanged> _parser;
        public const int ScoresFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_scores_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> scores_;
        public const int PenaltiesScoresFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_penaltiesScores_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> penaltiesScores_;
        public const int FirstLegScoresFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_firstLegScores_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> firstLegScores_;
        public const int GoalInfoFieldNumber = 4;
        private global::EngineMessages.GoalInfo goalInfo_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.MatchScoreChanged> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Scores => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PenaltiesScores => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> FirstLegScores => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.GoalInfo GoalInfo
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
        public MatchScoreChanged()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchScoreChanged(global::EngineMessages.MatchScoreChanged other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchScoreChanged Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.MatchScoreChanged other)
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
        public void MergeFrom(global::EngineMessages.MatchScoreChanged other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}