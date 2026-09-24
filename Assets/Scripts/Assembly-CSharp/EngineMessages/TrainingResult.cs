namespace EngineMessages
{
    public sealed class TrainingResult : global::Google.Protobuf.IMessage<global::EngineMessages.TrainingResult>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.TrainingResult>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.TrainingResult>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.TrainingResult> _parser;
        public const int StepFieldNumber = 1;
        private int step_;
        public const int SucceedFieldNumber = 2;
        private bool succeed_;
        public const int ErrorFieldNumber = 3;
        private global::EngineMessages.TrainingResultError error_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.TrainingResult> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Step
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
        public bool Succeed
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
        public global::EngineMessages.TrainingResultError Error
        {
            get
            {
                return global::EngineMessages.TrainingResultError.TreNone;
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
        public TrainingResult()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TrainingResult(global::EngineMessages.TrainingResult other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.TrainingResult Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.TrainingResult other)
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
        public void MergeFrom(global::EngineMessages.TrainingResult other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}