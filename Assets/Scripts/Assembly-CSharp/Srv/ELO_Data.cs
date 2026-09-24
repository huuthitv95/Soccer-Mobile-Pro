namespace Srv
{
    public sealed class ELO_Data : global::Google.Protobuf.IMessage<global::Srv.ELO_Data>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.ELO_Data>, global::Google.Protobuf.IDeepCloneable<global::Srv.ELO_Data>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.ELO_Data> _parser;
        public const int ValueFieldNumber = 1;
        private float value_;
        public const int MatchCountFieldNumber = 2;
        private int matchCount_;
        public const int CurrentStreakFieldNumber = 3;
        private int currentStreak_;
        public const int VersionFieldNumber = 4;
        private int version_;
        public const int UnreliableValueFieldNumber = 5;
        private float unreliableValue_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.ELO_Data> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public float Value
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
        public int MatchCount
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
        public int CurrentStreak
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
        public int Version
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
        public float UnreliableValue
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
        public ELO_Data()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ELO_Data(global::Srv.ELO_Data other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ELO_Data Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.ELO_Data other)
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
        public void MergeFrom(global::Srv.ELO_Data other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}