namespace Srv
{
    public sealed class UserSetting : global::Google.Protobuf.IMessage<global::Srv.UserSetting>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.UserSetting>, global::Google.Protobuf.IDeepCloneable<global::Srv.UserSetting>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.UserSetting> _parser;
        public const int InstallVersionFieldNumber = 1;
        private string installVersion_;
        public const int LoginVersionFieldNumber = 2;
        private int loginVersion_;
        public const int ABTestFieldNumber = 3;
        private static readonly global::Google.Protobuf.Collections.MapField<string, string>.Codec _map_aBTest_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, string> aBTest_;
        public const int EasyStringFieldNumber = 4;
        private static readonly global::Google.Protobuf.Collections.MapField<string, string>.Codec _map_easyString_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, string> easyString_;
        public const int EasyIntFieldNumber = 5;
        private static readonly global::Google.Protobuf.Collections.MapField<string, int>.Codec _map_easyInt_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, int> easyInt_;
        public const int ABTestNextStartFieldNumber = 6;
        private static readonly global::Google.Protobuf.Collections.MapField<string, string>.Codec _map_aBTestNextStart_codec;
        private readonly global::Google.Protobuf.Collections.MapField<string, string> aBTestNextStart_;
        public const int CheatedFieldNumber = 7;
        private bool cheated_;
        public const int ButtonConfigFieldNumber = 8;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.IngameButtonConfig> _repeated_buttonConfig_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.IngameButtonConfig> buttonConfig_;
        public const int AppearanceShopFieldNumber = 9;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.AppearanceShopArchive>.Codec _map_appearanceShop_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.AppearanceShopArchive> appearanceShop_;
        public const int ELODatasFieldNumber = 10;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.ELO_Data>.Codec _map_eLODatas_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.ELO_Data> eLODatas_;
        public const int DifficultyPopupSettingsFieldNumber = 11;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.DifficultyPopupSettings> _repeated_difficultyPopupSettings_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.DifficultyPopupSettings> difficultyPopupSettings_;
        public const int UserTacticsArchivesFieldNumber = 12;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.UserTacticsArchive>.Codec _map_userTacticsArchives_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.UserTacticsArchive> userTacticsArchives_;
        public const int PopupsFieldNumber = 13;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PopupArchive>.Codec _map_popups_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PopupArchive> popups_;
        public const int IAPDatasFieldNumber = 14;
        private global::Srv.IAPStoreArchive iAPDatas_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.UserSetting> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string InstallVersion
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
        public int LoginVersion
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
        public global::Google.Protobuf.Collections.MapField<string, string> ABTest => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, string> EasyString => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, int> EasyInt => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<string, string> ABTestNextStart => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Cheated
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.IngameButtonConfig> ButtonConfig => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.AppearanceShopArchive> AppearanceShop => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.ELO_Data> ELODatas => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.DifficultyPopupSettings> DifficultyPopupSettings => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.UserTacticsArchive> UserTacticsArchives => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.PopupArchive> Popups => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.IAPStoreArchive IAPDatas
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
        public UserSetting()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public UserSetting(global::Srv.UserSetting other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.UserSetting Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.UserSetting other)
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
        public void MergeFrom(global::Srv.UserSetting other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}