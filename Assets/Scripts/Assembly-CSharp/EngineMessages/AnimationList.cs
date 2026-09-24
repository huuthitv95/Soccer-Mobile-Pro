namespace EngineMessages
{
    public sealed class AnimationList : global::Google.Protobuf.IMessage<global::EngineMessages.AnimationList>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.AnimationList>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.AnimationList>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.AnimationList> _parser;
        public const int NamesFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_names_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> names_;
        public const int Types_FieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_types_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> types_;
        public const int FramesFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_frames_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> frames_;
        public const int TouchFramesFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_touchFrames_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> touchFrames_;
        public const int TouchPosesFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_touchPoses_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> touchPoses_;
        public const int OffsetTranslationFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_offsetTranslation_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> offsetTranslation_;
        public const int OffsetRotationFieldNumber = 7;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_offsetRotation_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> offsetRotation_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.AnimationList> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<string> Names => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<string> Types_ => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Frames => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> TouchFrames => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> TouchPoses => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> OffsetTranslation => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> OffsetRotation => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public AnimationList()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public AnimationList(global::EngineMessages.AnimationList other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.AnimationList Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.AnimationList other)
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
        public void MergeFrom(global::EngineMessages.AnimationList other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}