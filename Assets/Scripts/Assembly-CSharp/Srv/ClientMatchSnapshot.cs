namespace Srv
{
    public sealed class ClientMatchSnapshot : global::Google.Protobuf.IMessage<global::Srv.ClientMatchSnapshot>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.ClientMatchSnapshot>, global::Google.Protobuf.IDeepCloneable<global::Srv.ClientMatchSnapshot>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.ClientMatchSnapshot> _parser;
        public const int MatchIdFieldNumber = 1;
        private int matchId_;
        public const int HomeJerseyFieldNumber = 2;
        private int homeJersey_;
        public const int AwayJerseyFieldNumber = 3;
        private int awayJersey_;
        public const int CurrentTimeFieldNumber = 4;
        private int currentTime_;
        public const int HomeScoreFieldNumber = 5;
        private int homeScore_;
        public const int AwayScoreFieldNumber = 6;
        private int awayScore_;
        public const int RedCardFieldNumber = 7;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_redCard_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> redCard_;
        public const int YellowCardFieldNumber = 8;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_yellowCard_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> yellowCard_;
        public const int HomeFormationInUseFieldNumber = 9;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.FormationData> _repeated_homeFormationInUse_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> homeFormationInUse_;
        public const int AwayFormationInUseFieldNumber = 10;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.FormationData> _repeated_awayFormationInUse_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> awayFormationInUse_;
        public const int PlayerSnapshotFieldNumber = 11;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.InGamePlayerSnapshot> _repeated_playerSnapshot_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.InGamePlayerSnapshot> playerSnapshot_;
        public const int UserSubstitutionsCounterFieldNumber = 12;
        private int userSubstitutionsCounter_;
        public const int OppSubstitutionsCounterFieldNumber = 13;
        private int oppSubstitutionsCounter_;
        public const int HomeEableInjureFieldNumber = 14;
        private bool homeEableInjure_;
        public const int AwayEableInjureFieldNumber = 15;
        private bool awayEableInjure_;
        public const int InjuredPlayerFieldNumber = 16;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_injuredPlayer_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> injuredPlayer_;
        public const int HomeGoalInfoFieldNumber = 17;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.GoalInfoSnapshot> _repeated_homeGoalInfo_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.GoalInfoSnapshot> homeGoalInfo_;
        public const int AwayGoalInfoFieldNumber = 18;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.GoalInfoSnapshot> _repeated_awayGoalInfo_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.GoalInfoSnapshot> awayGoalInfo_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.ClientMatchSnapshot> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int MatchId
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
        public int HomeJersey
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
        public int AwayJersey
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
        public int CurrentTime
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
        public int HomeScore
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
        public int AwayScore
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
        public global::Google.Protobuf.Collections.RepeatedField<int> RedCard => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> YellowCard => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> HomeFormationInUse => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> AwayFormationInUse => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.InGamePlayerSnapshot> PlayerSnapshot => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int UserSubstitutionsCounter
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
        public int OppSubstitutionsCounter
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
        public bool HomeEableInjure
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
        public bool AwayEableInjure
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
        public global::Google.Protobuf.Collections.RepeatedField<int> InjuredPlayer => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.GoalInfoSnapshot> HomeGoalInfo => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.GoalInfoSnapshot> AwayGoalInfo => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ClientMatchSnapshot()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ClientMatchSnapshot(global::Srv.ClientMatchSnapshot other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ClientMatchSnapshot Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.ClientMatchSnapshot other)
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
        public void MergeFrom(global::Srv.ClientMatchSnapshot other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}