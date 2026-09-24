namespace Srv
{
    public sealed class UserTeamData : global::Google.Protobuf.IMessage<global::Srv.UserTeamData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.UserTeamData>, global::Google.Protobuf.IDeepCloneable<global::Srv.UserTeamData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.UserTeamData> _parser;
        public const int LastPlayedFieldNumber = 2;
        private global::Srv.GameMode lastPlayed_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.UserTeamData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.GameMode LastPlayed
        {
            get
            {
                return global::Srv.GameMode.WorldCup;
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
        public UserTeamData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public UserTeamData(global::Srv.UserTeamData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.UserTeamData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.UserTeamData other)
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
        public void MergeFrom(global::Srv.UserTeamData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}