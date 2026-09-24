namespace EngineMessages
{
    public sealed class CollisoinShape : global::Google.Protobuf.IMessage<global::EngineMessages.CollisoinShape>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.CollisoinShape>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.CollisoinShape>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.CollisoinShape> _parser;
        public const int TypeFieldNumber = 1;
        private global::EngineMessages.CollisionShapeType type_;
        public const int ParametersFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_parameters_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> parameters_;
        public const int TransFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_trans_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> trans_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.CollisoinShape> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.CollisionShapeType Type
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
        public global::Google.Protobuf.Collections.RepeatedField<float> Parameters => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Trans => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CollisoinShape()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CollisoinShape(global::EngineMessages.CollisoinShape other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.CollisoinShape Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.CollisoinShape other)
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
        public void MergeFrom(global::EngineMessages.CollisoinShape other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}