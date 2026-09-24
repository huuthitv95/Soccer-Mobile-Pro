namespace Srv
{
    public sealed class PlayerRetirement : global::Google.Protobuf.IMessage<global::Srv.PlayerRetirement>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.PlayerRetirement>, global::Google.Protobuf.IDeepCloneable<global::Srv.PlayerRetirement>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.PlayerRetirement> _parser;
        public const int SeasonMatchCountFieldNumber = 1;
        private int seasonMatchCount_;
        public const int PlayerPlayingTimeRecordFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_playerPlayingTimeRecord_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> playerPlayingTimeRecord_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.PlayerRetirement> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int SeasonMatchCount
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
        public global::Google.Protobuf.Collections.MapField<int, int> PlayerPlayingTimeRecord => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerRetirement()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerRetirement(global::Srv.PlayerRetirement other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PlayerRetirement Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.PlayerRetirement other)
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
        public void MergeFrom(global::Srv.PlayerRetirement other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}