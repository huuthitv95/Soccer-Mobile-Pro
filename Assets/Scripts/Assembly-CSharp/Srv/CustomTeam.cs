namespace Srv
{
    public sealed class CustomTeam : global::Google.Protobuf.IMessage<global::Srv.CustomTeam>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.CustomTeam>, global::Google.Protobuf.IDeepCloneable<global::Srv.CustomTeam>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.CustomTeam> _parser;
        public const int FormationFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.FormationData> _repeated_formation_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> formation_;
        public const int PlayersFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_players_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> players_;
        public const int CaptainFieldNumber = 4;
        private int captain_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.CustomTeam> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> Formation => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Players => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Captain
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
        public CustomTeam()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CustomTeam(global::Srv.CustomTeam other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.CustomTeam Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.CustomTeam other)
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
        public void MergeFrom(global::Srv.CustomTeam other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}