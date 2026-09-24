namespace EngineMessages
{
    public sealed class SlPreviewFormation : global::Google.Protobuf.IMessage<global::EngineMessages.SlPreviewFormation>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.SlPreviewFormation>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.SlPreviewFormation>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.SlPreviewFormation> _parser;
        public const int ConfigFieldNumber = 1;
        private string config_;
        public const int BallPositionFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_ballPosition_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> ballPosition_;
        public const int PositionsFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_positions_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> positions_;
        public const int RuntoFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_runto_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> runto_;
        public const int RoleFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_role_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> role_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.SlPreviewFormation> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string Config
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
        public global::Google.Protobuf.Collections.RepeatedField<float> BallPosition => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Positions => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Runto => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Role => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SlPreviewFormation()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SlPreviewFormation(global::EngineMessages.SlPreviewFormation other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.SlPreviewFormation Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.SlPreviewFormation other)
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
        public void MergeFrom(global::EngineMessages.SlPreviewFormation other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}