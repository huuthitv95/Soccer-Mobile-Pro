namespace Srv
{
    public sealed class GlobalGameProgressSettings : global::Google.Protobuf.IMessage<global::Srv.GlobalGameProgressSettings>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.GlobalGameProgressSettings>, global::Google.Protobuf.IDeepCloneable<global::Srv.GlobalGameProgressSettings>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.GlobalGameProgressSettings> _parser;
        public const int PlayerProtoAchivesFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerProtoReducedData>.Codec _map_playerProtoAchives_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerProtoReducedData> playerProtoAchives_;
        public const int CompetitionsHonorFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.CompetitionsHonorDataList>.Codec _map_competitionsHonor_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.CompetitionsHonorDataList> competitionsHonor_;
        public const int PlayerHonorFieldNumber = 3;
        private static readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.CompetitionsHonorDataList>.Codec _map_playerHonor_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, global::Srv.CompetitionsHonorDataList> playerHonor_;
        public const int MissionsFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.Mission> _repeated_missions_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.Mission> missions_;
        public const int EasyStringFieldNumber = 5;
        private static readonly global::Google.Protobuf.Collections.MapField<string, string>.Codec _map_easyString_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, string> easyString_;
        public const int EasyIntFieldNumber = 6;
        private static readonly global::Google.Protobuf.Collections.MapField<string, int>.Codec _map_easyInt_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, int> easyInt_;
        public const int UserTeamDataFieldNumber = 7;
        private global::Srv.UserTeamData userTeamData_;
        public const int UnlockedLegendaryNationalTeamsFieldNumber = 8;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_unlockedLegendaryNationalTeams_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> unlockedLegendaryNationalTeams_;
        public const int RewardRelayArchivesFieldNumber = 9;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.RewardRelayArchive>.Codec _map_rewardRelayArchives_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.RewardRelayArchive> rewardRelayArchives_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.GlobalGameProgressSettings> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerProtoReducedData> PlayerProtoAchives => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, global::Srv.CompetitionsHonorDataList> CompetitionsHonor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, global::Srv.CompetitionsHonorDataList> PlayerHonor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.Mission> Missions => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, string> EasyString => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, int> EasyInt => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.UserTeamData UserTeamData
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
        public global::Google.Protobuf.Collections.MapField<int, int> UnlockedLegendaryNationalTeams => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.RewardRelayArchive> RewardRelayArchives => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public GlobalGameProgressSettings()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public GlobalGameProgressSettings(global::Srv.GlobalGameProgressSettings other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.GlobalGameProgressSettings Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.GlobalGameProgressSettings other)
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
        public void MergeFrom(global::Srv.GlobalGameProgressSettings other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}