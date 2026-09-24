namespace EngineMessages
{
    public sealed class GolfTarget : global::Google.Protobuf.IMessage<global::EngineMessages.GolfTarget>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.GolfTarget>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.GolfTarget>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.GolfTarget> _parser;
        public const int PositionFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_position_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> position_;
        public const int RadiusFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_radius_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> radius_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.GolfTarget> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Position => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Radius => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public GolfTarget()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public GolfTarget(global::EngineMessages.GolfTarget other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.GolfTarget Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.GolfTarget other)
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
        public void MergeFrom(global::EngineMessages.GolfTarget other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}