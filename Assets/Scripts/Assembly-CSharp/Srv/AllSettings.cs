namespace Srv
{
    public sealed class AllSettings : global::Google.Protobuf.IMessage<global::Srv.AllSettings>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.AllSettings>, global::Google.Protobuf.IDeepCloneable<global::Srv.AllSettings>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.AllSettings> _parser;
        public const int SyncdataFieldNumber = 1;
        private global::Srv.SyncData syncdata_;
        public const int ArchivesVersionFieldNumber = 3;
        private int archivesVersion_;
        public const int UserDataFieldNumber = 4;
        private global::Srv.UserSetting userData_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.AllSettings> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.SyncData Syncdata
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
        public int ArchivesVersion
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
        public global::Srv.UserSetting UserData
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
        public AllSettings()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public AllSettings(global::Srv.AllSettings other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.AllSettings Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.AllSettings other)
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
        public void MergeFrom(global::Srv.AllSettings other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}