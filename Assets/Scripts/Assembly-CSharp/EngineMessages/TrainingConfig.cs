namespace EngineMessages
{
    public sealed class TrainingConfig : global::Google.Protobuf.IMessage<global::EngineMessages.TrainingConfig>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.TrainingConfig>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.TrainingConfig>
    {
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static class Types
        {
            public enum Type
            {
                None = 0,
                Dribble = 1,
                Passing = 2,
                Through = 3,
                Shot = 4,
                Press = 5,
                Switch = 6,
                Sliding = 7,
                Offense = 8,
                Defense = 9
            }

            public sealed class Step : global::Google.Protobuf.IMessage<global::EngineMessages.TrainingConfig.Types.Step>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.TrainingConfig.Types.Step>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.TrainingConfig.Types.Step>
            {
                private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.TrainingConfig.Types.Step> _parser;
                public const int SelectPlayerFieldNumber = 1;
                private int selectPlayer_;
                public const int LimittimeFieldNumber = 2;
                private int limittime_;
                public const int LimitareaFieldNumber = 3;
                private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_limitarea_codec;
                private readonly global::Google.Protobuf.Collections.RepeatedField<float> limitarea_;
                public const int PlayerActions1FieldNumber = 4;
                private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_playerActions1_codec;
                private readonly global::Google.Protobuf.Collections.RepeatedField<float> playerActions1_;
                public const int PlayerActions2FieldNumber = 5;
                private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_playerActions2_codec;
                private readonly global::Google.Protobuf.Collections.RepeatedField<float> playerActions2_;
                public const int ObjectiveFieldNumber = 6;
                private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_objective_codec;
                private readonly global::Google.Protobuf.Collections.RepeatedField<float> objective_;
                [global::System.Diagnostics.DebuggerNonUserCode]
                public static global::Google.Protobuf.MessageParser<global::EngineMessages.TrainingConfig.Types.Step> Parser => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

                [global::System.Diagnostics.DebuggerNonUserCode]
                public int SelectPlayer
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
                public int Limittime
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
                public global::Google.Protobuf.Collections.RepeatedField<float> Limitarea => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                public global::Google.Protobuf.Collections.RepeatedField<float> PlayerActions1 => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                public global::Google.Protobuf.Collections.RepeatedField<float> PlayerActions2 => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                public global::Google.Protobuf.Collections.RepeatedField<float> Objective => null;

                private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
                {
                    return null;
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public Step()
                {
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public Step(global::EngineMessages.TrainingConfig.Types.Step other)
                {
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public global::EngineMessages.TrainingConfig.Types.Step Clone()
                {
                    return null;
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public override bool Equals(object other)
                {
                    return false;
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public bool Equals(global::EngineMessages.TrainingConfig.Types.Step other)
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
                public void MergeFrom(global::EngineMessages.TrainingConfig.Types.Step other)
                {
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
                {
                }
            }
        }

        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.TrainingConfig> _parser;
        public const int TypeFieldNumber = 1;
        private global::EngineMessages.TrainingConfig.Types.Type type_;
        public const int BallPosFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_ballPos_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> ballPos_;
        public const int Poses1FieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_poses1_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> poses1_;
        public const int Poses2FieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_poses2_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> poses2_;
        public const int StepsFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.TrainingConfig.Types.Step> _repeated_steps_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.TrainingConfig.Types.Step> steps_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.TrainingConfig> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.TrainingConfig.Types.Type Type
        {
            get
            {
                return global::EngineMessages.TrainingConfig.Types.Type.None;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> BallPos => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Poses1 => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Poses2 => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.TrainingConfig.Types.Step> Steps => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TrainingConfig()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TrainingConfig(global::EngineMessages.TrainingConfig other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.TrainingConfig Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.TrainingConfig other)
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
        public void MergeFrom(global::EngineMessages.TrainingConfig other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}