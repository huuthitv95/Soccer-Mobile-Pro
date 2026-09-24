namespace EngineMessages
{
    public sealed class SlGameOver : global::Google.Protobuf.IMessage<global::EngineMessages.SlGameOver>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.SlGameOver>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.SlGameOver>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.SlGameOver> _parser;
        public const int TickFieldNumber = 1;
        private int tick_;
        public const int WinFieldNumber = 2;
        private bool win_;
        public const int OffsideFieldNumber = 3;
        private bool offside_;
        public const int FpsFieldNumber = 4;
        private float fps_;
        public const int FailReasonFieldNumber = 5;
        private global::EngineMessages.FailReason failReason_;
        public const int FailStateFieldNumber = 6;
        private global::EngineMessages.FailState failState_;
        public const int OppLastTouchPlayerIdFieldNumber = 7;
        private int oppLastTouchPlayerId_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.SlGameOver> Parser => null;

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
        public bool Win
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
        public bool Offside
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
        public float Fps
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
        public global::EngineMessages.FailReason FailReason
        {
            get
            {
                return global::EngineMessages.FailReason.FailNone;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.FailState FailState
        {
            get
            {
                return global::EngineMessages.FailState.FsUnkown;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int OppLastTouchPlayerId
        {
            get
            {
                return 0;
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
        public SlGameOver()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SlGameOver(global::EngineMessages.SlGameOver other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.SlGameOver Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.SlGameOver other)
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
        public void MergeFrom(global::EngineMessages.SlGameOver other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}