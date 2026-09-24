namespace EngineMessages
{
    public sealed class SlInput : global::Google.Protobuf.IMessage<global::EngineMessages.SlInput>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.SlInput>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.SlInput>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.SlInput> _parser;
        public const int FuncFieldNumber = 1;
        private global::EngineMessages.InputFunction func_;
        public const int VecFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_vec_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> vec_;
        public const int AngleFieldNumber = 3;
        private float angle_;
        public const int VcurveFieldNumber = 4;
        private float vcurve_;
        public const int PlayerIdFieldNumber = 5;
        private int playerId_;
        public const int TargetIdFieldNumber = 6;
        private int targetId_;
        public const int FrameCountFieldNumber = 7;
        private uint frameCount_;
        public const int SequenceIdFieldNumber = 8;
        private uint sequenceId_;
        public const int FeintFieldNumber = 9;
        private bool feint_;
        public const int ForceShootFieldNumber = 10;
        private bool forceShoot_;
        public const int PlayerAutoPlayFieldNumber = 11;
        private bool playerAutoPlay_;
        public const int PlayerScoresFieldNumber = 12;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.PlayerScore> _repeated_playerScores_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerScore> playerScores_;
        public const int OffsidePlayersFieldNumber = 13;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_offsidePlayers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> offsidePlayers_;
        public const int FeintTypeFieldNumber = 14;
        private int feintType_;
        public const int PowerfulFieldNumber = 15;
        private bool powerful_;
        public const int DistanceLimitFieldNumber = 16;
        private float distanceLimit_;
        public const int OneTouchFieldNumber = 17;
        private bool oneTouch_;
        public const int ChipFieldNumber = 18;
        private bool chip_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.SlInput> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.InputFunction Func
        {
            get
            {
                return global::EngineMessages.InputFunction.Up;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Vec => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Angle
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
        public float Vcurve
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
        public int PlayerId
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
        public int TargetId
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
        public uint FrameCount
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public uint SequenceId
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Feint
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
        public bool PlayerAutoPlay
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
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.PlayerScore> PlayerScores => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> OffsidePlayers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int FeintType
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
        public bool Powerful
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
        public float DistanceLimit
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
        public bool OneTouch
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
        public bool Chip
        {
            get
            {
                return false;
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
        public SlInput()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SlInput(global::EngineMessages.SlInput other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.SlInput Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.SlInput other)
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
        public void MergeFrom(global::EngineMessages.SlInput other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}