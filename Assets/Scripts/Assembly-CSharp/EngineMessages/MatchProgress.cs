namespace EngineMessages
{
    public sealed class MatchProgress : global::Google.Protobuf.IMessage<global::EngineMessages.MatchProgress>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.MatchProgress>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.MatchProgress>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.MatchProgress> _parser;
        public const int TeamIdFieldNumber = 1;
        private int teamId_;
        public const int MatchTimeFieldNumber = 2;
        private int matchTime_;
        public const int MatchScoreFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_matchScore_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> matchScore_;
        public const int PenaltiesFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_penalties_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> penalties_;
        public const int PossessionsFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_possessions_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> possessions_;
        public const int StoppageTimeFieldNumber = 6;
        private int stoppageTime_;
        public const int DatabaseidsFieldNumber = 7;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_databaseids_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> databaseids_;
        public const int ActivesFieldNumber = 8;
        private static readonly global::Google.Protobuf.FieldCodec<bool> _repeated_actives_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<bool> actives_;
        public const int FatiguesFieldNumber = 9;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_fatigues_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> fatigues_;
        public const int InjuredsFieldNumber = 10;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_injureds_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> injureds_;
        public const int CardsFieldNumber = 11;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_cards_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> cards_;
        public const int GoalInfoFieldNumber = 12;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.GoalInfo> _repeated_goalInfo_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.GoalInfo> goalInfo_;
        public const int TeamStatisticsFieldNumber = 13;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_teamStatistics_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> teamStatistics_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.MatchProgress> Parser => null;

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
        public int MatchTime
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
        public global::Google.Protobuf.Collections.RepeatedField<int> MatchScore => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Penalties => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Possessions => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int StoppageTime
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
        public global::Google.Protobuf.Collections.RepeatedField<int> Databaseids => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<bool> Actives => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Fatigues => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Injureds => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Cards => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.GoalInfo> GoalInfo => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> TeamStatistics => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchProgress()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchProgress(global::EngineMessages.MatchProgress other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.MatchProgress Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.MatchProgress other)
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
        public void MergeFrom(global::EngineMessages.MatchProgress other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}