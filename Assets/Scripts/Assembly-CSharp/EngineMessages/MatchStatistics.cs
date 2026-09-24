namespace EngineMessages
{
    public sealed class MatchStatistics : global::Common.IRecycleable, global::Google.Protobuf.IMessage<global::EngineMessages.MatchStatistics>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.MatchStatistics>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.MatchStatistics>
    {
        private static global::EngineMessages.MatchStatistics defaultMatchStatistics;
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.MatchStatistics> _parser;
        public const int PossessionFieldNumber = 1;
        private float possession_;
        public const int TeamStatisticsFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_teamStatistics_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> teamStatistics_;
        public const int GoalInfoFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.GoalInfo> _repeated_goalInfo_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.GoalInfo> goalInfo_;
        public const int YellowCardPlayerIdsFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_yellowCardPlayerIds_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> yellowCardPlayerIds_;
        public const int RedCardPlayerIdsFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_redCardPlayerIds_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> redCardPlayerIds_;
        public const int DebugfieldsFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_debugfields_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> debugfields_;
        public const int PlayerStatisticsFieldNumber = 7;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.PlayerStatistics> _repeated_playerStatistics_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerStatistics> playerStatistics_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.MatchStatistics> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Possession
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
        public global::Google.Protobuf.Collections.RepeatedField<int> TeamStatistics => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.GoalInfo> GoalInfo => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> YellowCardPlayerIds => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> RedCardPlayerIds => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Debugfields => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerStatistics> PlayerStatistics => null;

        public void OnCreateFromPool()
        {
        }

        public void OnReleaseToPool()
        {
        }

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchStatistics()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchStatistics(global::EngineMessages.MatchStatistics other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchStatistics Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.MatchStatistics other)
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
        public void MergeFrom(global::EngineMessages.MatchStatistics other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}