namespace EngineMessages
{
    public sealed class SlTestShotParams : global::Google.Protobuf.IMessage<global::EngineMessages.SlTestShotParams>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.SlTestShotParams>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.SlTestShotParams>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.SlTestShotParams> _parser;
        public const int ParamsFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_params_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> params_;
        public const int BallPositionFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_ballPosition_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> ballPosition_;
        public const int TargetPositionFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_targetPosition_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> targetPosition_;
        public const int RotationFieldNumber = 4;
        private float rotation_;
        public const int AlterTouchFieldNumber = 5;
        private bool alterTouch_;
        public const int ForceShootFieldNumber = 6;
        private bool forceShoot_;
        public const int ForceShootVCurveFieldNumber = 7;
        private float forceShootVCurve_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.SlTestShotParams> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Params => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> BallPosition => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> TargetPosition => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Rotation
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool AlterTouch
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
        public bool ForceShoot
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
        public float ForceShootVCurve
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
        public SlTestShotParams()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SlTestShotParams(global::EngineMessages.SlTestShotParams other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.SlTestShotParams Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.SlTestShotParams other)
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
        public void MergeFrom(global::EngineMessages.SlTestShotParams other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}