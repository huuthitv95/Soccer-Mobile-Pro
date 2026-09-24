namespace Srv
{
    public sealed class ClubTeamData : global::Google.Protobuf.IMessage<global::Srv.ClubTeamData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.ClubTeamData>, global::Google.Protobuf.IDeepCloneable<global::Srv.ClubTeamData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.ClubTeamData> _parser;
        public const int IdFieldNumber = 1;
        private int id_;
        public const int FormationInUseFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.FormationData> _repeated_formationInUse_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> formationInUse_;
        public const int PlayersFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_players_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> players_;
        public const int CupQualificationFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_cupQualification_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> cupQualification_;
        public const int LeagueQualificationFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_leagueQualification_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> leagueQualification_;
        public const int CanRestoreMoraleFieldNumber = 6;
        private bool canRestoreMorale_;
        public const int RankStateFieldNumber = 7;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_rankState_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> rankState_;
        public const int SeriousInjuryValueFieldNumber = 8;
        private float seriousInjuryValue_;
        public const int InjuryValueFieldNumber = 9;
        private float injuryValue_;
        public const int SlightInjuryValueFieldNumber = 10;
        private float slightInjuryValue_;
        public const int HomeJerseyFieldNumber = 11;
        private int homeJersey_;
        public const int AwayJerseyFieldNumber = 12;
        private int awayJersey_;
        public const int AblityFieldNumber = 13;
        private int ablity_;
        public const int CanRestoreStaminaFieldNumber = 14;
        private bool canRestoreStamina_;
        public const int PlayerLoanContractFieldNumber = 15;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.IntPairs> _repeated_playerLoanContract_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.IntPairs> playerLoanContract_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.ClubTeamData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Id
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> FormationInUse => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Players => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<string> CupQualification => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<string> LeagueQualification => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool CanRestoreMorale
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
        public global::Google.Protobuf.Collections.MapField<int, int> RankState => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float SeriousInjuryValue
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
        public float InjuryValue
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
        public float SlightInjuryValue
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
        public int Ablity
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
        public bool CanRestoreStamina
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.IntPairs> PlayerLoanContract => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ClubTeamData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ClubTeamData(global::Srv.ClubTeamData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ClubTeamData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.ClubTeamData other)
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
        public void MergeFrom(global::Srv.ClubTeamData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}