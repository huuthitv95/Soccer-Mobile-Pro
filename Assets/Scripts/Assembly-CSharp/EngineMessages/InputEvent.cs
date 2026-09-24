namespace EngineMessages
{
    public sealed class InputEvent : global::Google.Protobuf.IMessage<global::EngineMessages.InputEvent>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.InputEvent>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.InputEvent>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.InputEvent> _parser;
        public const int DeviceIdFieldNumber = 1;
        private int deviceId_;
        public const int TypeFieldNumber = 2;
        private global::EngineMessages.InputEventType type_;
        public const int FuncFieldNumber = 3;
        private global::EngineMessages.InputFunction func_;
        public const int FuncOverlayFieldNumber = 4;
        private global::EngineMessages.InputFunction funcOverlay_;
        public const int JaxisFieldNumber = 5;
        private global::EngineMessages.JoystickAxis jaxis_;
        public const int JaxisvalueFieldNumber = 6;
        private float jaxisvalue_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.InputEvent> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int DeviceId
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
        public global::EngineMessages.InputEventType Type
        {
            get
            {
                return global::EngineMessages.InputEventType.KeyDown;
            }

            set
            {
            }
        }

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
        public global::EngineMessages.InputFunction FuncOverlay
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
        public global::EngineMessages.JoystickAxis Jaxis
        {
            get
            {
                return global::EngineMessages.JoystickAxis.Horizontal;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Jaxisvalue
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
        public InputEvent()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public InputEvent(global::EngineMessages.InputEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.InputEvent Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.InputEvent other)
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
        public void MergeFrom(global::EngineMessages.InputEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}