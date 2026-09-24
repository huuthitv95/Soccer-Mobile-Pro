namespace EngineMessages
{
    public sealed class ShootEvent : global::Google.Protobuf.IMessage<global::EngineMessages.ShootEvent>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.ShootEvent>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.ShootEvent>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.ShootEvent> _parser;
        public const int DifficultyFieldNumber = 1;
        private int difficulty_;
        public const int AttributeFieldNumber = 2;
        private int attribute_;
        public const int PowerFieldNumber = 3;
        private int power_;
        public const int DirectionFieldNumber = 4;
        private global::EngineMessages.ShootDirection direction_;
        public const int DistanceFieldNumber = 5;
        private int distance_;
        public const int ResultFieldNumber = 6;
        private global::EngineMessages.ShootResult result_;
        public const int ShooterIdFieldNumber = 7;
        private int shooterId_;
        public const int BlockerIdFieldNumber = 8;
        private int blockerId_;
        public const int ShotTypeFieldNumber = 9;
        private global::EngineMessages.ShootType shotType_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.ShootEvent> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Difficulty
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
        public int Attribute
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
        public int Power
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
        public global::EngineMessages.ShootDirection Direction
        {
            get
            {
                return global::EngineMessages.ShootDirection.None;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Distance
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
        public global::EngineMessages.ShootResult Result
        {
            get
            {
                return global::EngineMessages.ShootResult.Goal;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int ShooterId
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
        public int BlockerId
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
        public global::EngineMessages.ShootType ShotType
        {
            get
            {
                return global::EngineMessages.ShootType.Normal;
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
        public ShootEvent()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ShootEvent(global::EngineMessages.ShootEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.ShootEvent Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.ShootEvent other)
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
        public void MergeFrom(global::EngineMessages.ShootEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}