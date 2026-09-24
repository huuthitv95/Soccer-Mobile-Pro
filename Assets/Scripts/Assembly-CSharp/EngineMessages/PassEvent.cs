namespace EngineMessages
{
    public sealed class PassEvent : global::Google.Protobuf.IMessage<global::EngineMessages.PassEvent>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.PassEvent>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.PassEvent>
    {
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static class Types
        {
            public enum PassType
            {
                LowPass = 0,
                HighPass = 1,
                Cross = 2,
                LowThroughPass = 3,
                HighThroughPass = 4
            }
        }

        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.PassEvent> _parser;
        public const int PassTypeFieldNumber = 1;
        private global::EngineMessages.PassEvent.Types.PassType passType_;
        public const int DifficultyFieldNumber = 2;
        private int difficulty_;
        public const int PowerFieldNumber = 3;
        private int power_;
        public const int DirectionFieldNumber = 4;
        private int direction_;
        public const int PasserIdFieldNumber = 5;
        private int passerId_;
        public const int ReceiverIdFieldNumber = 6;
        private int receiverId_;
        public const int PasserPosFieldNumber = 7;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_passerPos_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> passerPos_;
        public const int ReceiverPosFieldNumber = 8;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_receiverPos_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> receiverPos_;
        public const int PasserPropertyFieldNumber = 9;
        private int passerProperty_;
        public const int ResultFieldNumber = 10;
        private int result_;
        public const int BlockedFieldNumber = 11;
        private bool blocked_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.PassEvent> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.PassEvent.Types.PassType PassType
        {
            get
            {
                return global::EngineMessages.PassEvent.Types.PassType.LowPass;
            }

            set
            {
            }
        }

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
        public int Direction
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
        public int PasserId
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
        public int ReceiverId
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
        public global::Google.Protobuf.Collections.RepeatedField<float> PasserPos => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> ReceiverPos => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int PasserProperty
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
        public int Result
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
        public bool Blocked
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
        public PassEvent()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PassEvent(global::EngineMessages.PassEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.PassEvent Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.PassEvent other)
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
        public void MergeFrom(global::EngineMessages.PassEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}