namespace EngineMessages
{
    public sealed class CineBallTouch : global::Google.Protobuf.IMessage<global::EngineMessages.CineBallTouch>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.CineBallTouch>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.CineBallTouch>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.CineBallTouch> _parser;
        public const int TickFieldNumber = 1;
        private int tick_;
        public const int PositionFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_position_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> position_;
        public const int MomentumFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_momentum_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> momentum_;
        public const int RotationFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_rotation_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> rotation_;
        public const int BiasFieldNumber = 5;
        private float bias_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.CineBallTouch> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Tick
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
        public global::Google.Protobuf.Collections.RepeatedField<float> Position => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Momentum => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Rotation => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Bias
        {
            get
            {
                return 0f;
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
        public CineBallTouch()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CineBallTouch(global::EngineMessages.CineBallTouch other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.CineBallTouch Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.CineBallTouch other)
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
        public void MergeFrom(global::EngineMessages.CineBallTouch other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}