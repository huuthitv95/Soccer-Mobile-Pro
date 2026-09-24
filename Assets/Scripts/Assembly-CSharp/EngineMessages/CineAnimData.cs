namespace EngineMessages
{
    public sealed class CineAnimData : global::Google.Protobuf.IMessage<global::EngineMessages.CineAnimData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.CineAnimData>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.CineAnimData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.CineAnimData> _parser;
        public const int NameFieldNumber = 1;
        private string name_;
        public const int InfoFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_info_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> info_;
        public const int SpatialInfoFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_spatialInfo_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> spatialInfo_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.CineAnimData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string Name
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Info => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> SpatialInfo => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CineAnimData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CineAnimData(global::EngineMessages.CineAnimData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.CineAnimData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.CineAnimData other)
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
        public void MergeFrom(global::EngineMessages.CineAnimData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}