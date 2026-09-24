namespace EngineMessages
{
    public sealed class AnimationParam : global::Google.Protobuf.IMessage<global::EngineMessages.AnimationParam>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.AnimationParam>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.AnimationParam>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.AnimationParam> _parser;
        public const int AnimNameFieldNumber = 1;
        private string animName_;
        public const int FrameFieldNumber = 2;
        private int frame_;
        public const int ReloadFieldNumber = 3;
        private bool reload_;
        public const int AnimAngleVelocityFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_animAngleVelocity_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> animAngleVelocity_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.AnimationParam> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string AnimName
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Frame
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
        public bool Reload
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
        public global::Google.Protobuf.Collections.RepeatedField<float> AnimAngleVelocity => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public AnimationParam()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public AnimationParam(global::EngineMessages.AnimationParam other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.AnimationParam Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.AnimationParam other)
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
        public void MergeFrom(global::EngineMessages.AnimationParam other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}