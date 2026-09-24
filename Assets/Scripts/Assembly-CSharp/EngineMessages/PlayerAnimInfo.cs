namespace EngineMessages
{
    public sealed class PlayerAnimInfo : global::Google.Protobuf.IMessage<global::EngineMessages.PlayerAnimInfo>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.PlayerAnimInfo>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.PlayerAnimInfo>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.PlayerAnimInfo> _parser;
        public const int NamesFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_names_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> names_;
        public const int FramesFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_frames_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> frames_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.PlayerAnimInfo> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<string> Names => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Frames => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerAnimInfo()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PlayerAnimInfo(global::EngineMessages.PlayerAnimInfo other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.PlayerAnimInfo Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.PlayerAnimInfo other)
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
        public void MergeFrom(global::EngineMessages.PlayerAnimInfo other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}