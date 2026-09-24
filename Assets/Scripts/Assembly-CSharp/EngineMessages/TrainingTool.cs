namespace EngineMessages
{
    public sealed class TrainingTool : global::Google.Protobuf.IMessage<global::EngineMessages.TrainingTool>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.TrainingTool>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.TrainingTool>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.TrainingTool> _parser;
        public const int TypeFieldNumber = 1;
        private int type_;
        public const int ShapeTypeFieldNumber = 2;
        private global::EngineMessages.CollisionShapeType shapeType_;
        public const int ShapeParametersFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_shapeParameters_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> shapeParameters_;
        public const int ShapesFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.CollisoinShape> _repeated_shapes_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.CollisoinShape> shapes_;
        public const int GoalsFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<global::EngineMessages.CollisoinShape> _repeated_goals_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.CollisoinShape> goals_;
        public const int TransFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_trans_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> trans_;
        public const int MassFieldNumber = 7;
        private float mass_;
        public const int FrictionFieldNumber = 8;
        private float friction_;
        public const int RestitutionFieldNumber = 9;
        private float restitution_;
        public const int TouchableFieldNumber = 10;
        private bool touchable_;
        public const int GoalableFieldNumber = 11;
        private bool goalable_;
        public const int BrokenableFieldNumber = 12;
        private bool brokenable_;
        public const int CollisionFieldNumber = 13;
        private bool collision_;
        public const int MovementFieldNumber = 14;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_movement_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> movement_;
        public const int RotationsFieldNumber = 15;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_rotations_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> rotations_;
        public const int SwingsFieldNumber = 16;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_swings_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> swings_;
        public const int GoalTypeFieldNumber = 17;
        private global::EngineMessages.GoalType goalType_;
        public const int ToolTypeFieldNumber = 18;
        private global::EngineMessages.ToolType toolType_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.TrainingTool> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Type
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
        public global::EngineMessages.CollisionShapeType ShapeType
        {
            get
            {
                return global::EngineMessages.CollisionShapeType.Box;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> ShapeParameters => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.CollisoinShape> Shapes => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::EngineMessages.CollisoinShape> Goals => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Trans => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Mass
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
        public float Friction
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
        public float Restitution
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
        public bool Touchable
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
        public bool Goalable
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
        public bool Brokenable
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
        public bool Collision
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
        public global::Google.Protobuf.Collections.RepeatedField<float> Movement => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Rotations => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Swings => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.GoalType GoalType
        {
            get
            {
                return global::EngineMessages.GoalType.GoalNormal;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.ToolType ToolType
        {
            get
            {
                return global::EngineMessages.ToolType.ToolNormal;
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
        public TrainingTool()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TrainingTool(global::EngineMessages.TrainingTool other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.TrainingTool Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.TrainingTool other)
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
        public void MergeFrom(global::EngineMessages.TrainingTool other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}