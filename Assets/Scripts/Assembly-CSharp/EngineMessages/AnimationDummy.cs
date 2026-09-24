namespace EngineMessages
{
    public sealed class AnimationDummy : global::Google.Protobuf.IMessage<global::EngineMessages.AnimationDummy>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.AnimationDummy>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.AnimationDummy>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.AnimationDummy> _parser;
        public const int IsTouchFieldNumber = 1;
        private bool isTouch_;
        public const int PositionFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_position_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> position_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.AnimationDummy> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool IsTouch
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Position => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public AnimationDummy()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public AnimationDummy(global::EngineMessages.AnimationDummy other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.AnimationDummy Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.AnimationDummy other)
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
        public void MergeFrom(global::EngineMessages.AnimationDummy other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}