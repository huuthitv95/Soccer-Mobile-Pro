namespace Srv
{
    public sealed class CustomLeagueTemplate : global::Google.Protobuf.IMessage<global::Srv.CustomLeagueTemplate>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.CustomLeagueTemplate>, global::Google.Protobuf.IDeepCloneable<global::Srv.CustomLeagueTemplate>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.CustomLeagueTemplate> _parser;
        public const int IdFieldNumber = 1;
        private int id_;
        public const int HasCustomLogoFieldNumber = 2;
        private bool hasCustomLogo_;
        public const int NumOfTeamFieldNumber = 3;
        private int numOfTeam_;
        public const int ScheduleTemplateFieldNumber = 4;
        private string scheduleTemplate_;
        public const int CupTypeFieldNumber = 5;
        private int cupType_;
        public const int HasCustomCupIconFieldNumber = 6;
        private bool hasCustomCupIcon_;
        public const int HasCustomSuperCupIconFieldNumber = 7;
        private bool hasCustomSuperCupIcon_;
        public const int LogoFieldNumber = 8;
        private string logo_;
        public const int CupLogoFieldNumber = 9;
        private string cupLogo_;
        public const int SuperCupLogoFieldNumber = 10;
        private string superCupLogo_;
        public const int LeagueTeamsFieldNumber = 11;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_leagueTeams_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> leagueTeams_;
        public const int CupTeamsFieldNumber = 12;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_cupTeams_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> cupTeams_;
        public const int NameFieldNumber = 13;
        private string name_;
        public const int LeagueTrophyFieldNumber = 14;
        private string leagueTrophy_;
        public const int CupTrophyFieldNumber = 15;
        private string cupTrophy_;
        public const int SuperCupTrophyFieldNumber = 16;
        private string superCupTrophy_;
        public const int CupNameFieldNumber = 17;
        private string cupName_;
        public const int SuperCupNameFieldNumber = 18;
        private string superCupName_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.CustomLeagueTemplate> Parser => null;

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
        public bool HasCustomLogo
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
        public int NumOfTeam
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
        public string ScheduleTemplate
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int CupType
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
        public bool HasCustomCupIcon
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
        public bool HasCustomSuperCupIcon
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
        public string Logo
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string CupLogo
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string SuperCupLogo
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> LeagueTeams => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> CupTeams => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string Name
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string LeagueTrophy
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string CupTrophy
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string SuperCupTrophy
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string CupName
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string SuperCupName
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
        public CustomLeagueTemplate()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CustomLeagueTemplate(global::Srv.CustomLeagueTemplate other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.CustomLeagueTemplate Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.CustomLeagueTemplate other)
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
        public void MergeFrom(global::Srv.CustomLeagueTemplate other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}