namespace Srv
{
    public sealed class CustomLeagueArchive : global::Google.Protobuf.IMessage<global::Srv.CustomLeagueArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.CustomLeagueArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.CustomLeagueArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.CustomLeagueArchive> _parser;
        public const int TemplatesFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.CustomLeagueTemplate> _repeated_templates_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.CustomLeagueTemplate> templates_;
        public const int ArchivesFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.SeasonData>.Codec _map_archives_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.SeasonData> archives_;
        public const int NextIdFieldNumber = 3;
        private int nextId_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.CustomLeagueArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.CustomLeagueTemplate> Templates => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.SeasonData> Archives => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int NextId
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
        public CustomLeagueArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CustomLeagueArchive(global::Srv.CustomLeagueArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.CustomLeagueArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.CustomLeagueArchive other)
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
        public void MergeFrom(global::Srv.CustomLeagueArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}