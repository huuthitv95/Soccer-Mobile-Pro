namespace Srv
{
    public sealed class SyncData : global::Google.Protobuf.IMessage<global::Srv.SyncData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.SyncData>, global::Google.Protobuf.IDeepCloneable<global::Srv.SyncData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.SyncData> _parser;
        public const int VerionFieldNumber = 1;
        private int verion_;
        public const int IntDataFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_intData_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> intData_;
        public const int InstallVersionFieldNumber = 3;
        private string installVersion_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.SyncData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Verion
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
        public global::Google.Protobuf.Collections.RepeatedField<int> IntData => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string InstallVersion
        {
            get
            {
                return null;
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
        public SyncData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SyncData(global::Srv.SyncData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.SyncData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.SyncData other)
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
        public void MergeFrom(global::Srv.SyncData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}