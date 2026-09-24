namespace Srv
{
    public sealed class PlayerTemporaryBoostRecord : global::Google.Protobuf.IMessage<global::Srv.PlayerTemporaryBoostRecord>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.PlayerTemporaryBoostRecord>, global::Google.Protobuf.IDeepCloneable<global::Srv.PlayerTemporaryBoostRecord>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.PlayerTemporaryBoostRecord> _parser;
        public const int AbilityRecordFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_abilityRecord_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> abilityRecord_;
        public const int StaminaRecordFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_staminaRecord_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> staminaRecord_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.PlayerTemporaryBoostRecord> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, int> AbilityRecord => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> StaminaRecord => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerTemporaryBoostRecord()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerTemporaryBoostRecord(global::Srv.PlayerTemporaryBoostRecord other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PlayerTemporaryBoostRecord Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.PlayerTemporaryBoostRecord other)
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
        public void MergeFrom(global::Srv.PlayerTemporaryBoostRecord other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}