namespace Srv
{
    public sealed class LeagueCupBracketData : global::Google.Protobuf.IMessage<global::Srv.LeagueCupBracketData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.LeagueCupBracketData>, global::Google.Protobuf.IDeepCloneable<global::Srv.LeagueCupBracketData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.LeagueCupBracketData> _parser;
        public const int VersionFieldNumber = 1;
        private int version_;
        public const int TeamsFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_teams_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> teams_;
        public const int LegacyFieldNumber = 3;
        private bool legacy_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.LeagueCupBracketData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Version
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
        public global::Google.Protobuf.Collections.RepeatedField<int> Teams => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Legacy
        {
            get
            {
                return false;
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
        public LeagueCupBracketData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public LeagueCupBracketData(global::Srv.LeagueCupBracketData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.LeagueCupBracketData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.LeagueCupBracketData other)
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
        public void MergeFrom(global::Srv.LeagueCupBracketData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}