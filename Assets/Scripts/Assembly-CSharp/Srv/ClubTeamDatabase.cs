namespace Srv
{
    public sealed class ClubTeamDatabase : global::Google.Protobuf.IMessage<global::Srv.ClubTeamDatabase>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.ClubTeamDatabase>, global::Google.Protobuf.IDeepCloneable<global::Srv.ClubTeamDatabase>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.ClubTeamDatabase> _parser;
        public const int DatabaseFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.ClubTeamData>.Codec _map_database_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.ClubTeamData> database_;
        public const int PlayerDatabaseIdFieldNumber = 2;
        private int playerDatabaseId_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.ClubTeamDatabase> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.ClubTeamData> Database => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int PlayerDatabaseId
        {
            get
            {
                return 0;
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
        public ClubTeamDatabase()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ClubTeamDatabase(global::Srv.ClubTeamDatabase other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ClubTeamDatabase Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.ClubTeamDatabase other)
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
        public void MergeFrom(global::Srv.ClubTeamDatabase other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}