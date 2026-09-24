namespace ExternalDataPacketProto
{
    public sealed class ExternalDataPacket : global::Google.Protobuf.IMessage<global::ExternalDataPacketProto.ExternalDataPacket>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::ExternalDataPacketProto.ExternalDataPacket>, global::Google.Protobuf.IDeepCloneable<global::ExternalDataPacketProto.ExternalDataPacket>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::ExternalDataPacketProto.ExternalDataPacket> _parser;
        public const int CompetitionNameFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<int, string>.Codec _map_competitionName_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, string> competitionName_;
        public const int TeamNameFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<int, string>.Codec _map_teamName_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, string> teamName_;
        public const int TeamAbbrFieldNumber = 3;
        private static readonly global::Google.Protobuf.Collections.MapField<int, string>.Codec _map_teamAbbr_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, string> teamAbbr_;
        public const int TeamHomeJerseyFieldNumber = 4;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::ExternalDataPacketProto.colorData>.Codec _map_teamHomeJersey_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::ExternalDataPacketProto.colorData> teamHomeJersey_;
        public const int TeamAwayJerseyFieldNumber = 5;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::ExternalDataPacketProto.colorData>.Codec _map_teamAwayJersey_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::ExternalDataPacketProto.colorData> teamAwayJersey_;
        public const int TeamHomeGKJerseyFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_teamHomeGKJersey_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> teamHomeGKJersey_;
        public const int TeamAwayGKJerseyFieldNumber = 7;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_teamAwayGKJersey_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> teamAwayGKJersey_;
        public const int PlayerNameFieldNumber = 8;
        private static readonly global::Google.Protobuf.Collections.MapField<int, string>.Codec _map_playerName_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, string> playerName_;
        public const int CompetitionIconFieldNumber = 9;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_competitionIcon_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> competitionIcon_;
        public const int TeamIconFieldNumber = 10;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_teamIcon_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> teamIcon_;
        public const int PlayerIconFieldNumber = 11;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_playerIcon_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> playerIcon_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::ExternalDataPacketProto.ExternalDataPacket> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, string> CompetitionName => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, string> TeamName => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, string> TeamAbbr => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::ExternalDataPacketProto.colorData> TeamHomeJersey => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::ExternalDataPacketProto.colorData> TeamAwayJersey => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> TeamHomeGKJersey => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> TeamAwayGKJersey => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, string> PlayerName => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> CompetitionIcon => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> TeamIcon => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PlayerIcon => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ExternalDataPacket()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ExternalDataPacket(global::ExternalDataPacketProto.ExternalDataPacket other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::ExternalDataPacketProto.ExternalDataPacket Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::ExternalDataPacketProto.ExternalDataPacket other)
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
        public void MergeFrom(global::ExternalDataPacketProto.ExternalDataPacket other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}