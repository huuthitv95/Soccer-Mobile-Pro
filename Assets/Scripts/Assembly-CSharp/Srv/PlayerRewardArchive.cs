namespace Srv
{
    public sealed class PlayerRewardArchive : global::Google.Protobuf.IMessage<global::Srv.PlayerRewardArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.PlayerRewardArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.PlayerRewardArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.PlayerRewardArchive> _parser;
        public const int PlayerRewardPoolFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_playerRewardPool_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> playerRewardPool_;
        public const int SigningChancesFieldNumber = 2;
        private int signingChances_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.PlayerRewardArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PlayerRewardPool => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int SigningChances
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
        public PlayerRewardArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerRewardArchive(global::Srv.PlayerRewardArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PlayerRewardArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.PlayerRewardArchive other)
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
        public void MergeFrom(global::Srv.PlayerRewardArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}