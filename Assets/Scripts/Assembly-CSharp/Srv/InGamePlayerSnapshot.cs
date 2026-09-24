namespace Srv
{
    public sealed class InGamePlayerSnapshot : global::Google.Protobuf.IMessage<global::Srv.InGamePlayerSnapshot>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.InGamePlayerSnapshot>, global::Google.Protobuf.IDeepCloneable<global::Srv.InGamePlayerSnapshot>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.InGamePlayerSnapshot> _parser;
        public const int DatabaseIdFieldNumber = 1;
        private int databaseId_;
        public const int PlayingTimeFieldNumber = 3;
        private int playingTime_;
        public const int IngameFatiguesFieldNumber = 4;
        private float ingameFatigues_;
        public const int BeforeGameFatiguesFieldNumber = 5;
        private float beforeGameFatigues_;
        public const int SwitchableFieldNumber = 6;
        private bool switchable_;
        public const int BenchedFieldNumber = 7;
        private bool benched_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.InGamePlayerSnapshot> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int DatabaseId
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
        public int PlayingTime
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
        public float IngameFatigues
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
        public float BeforeGameFatigues
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
        public bool Switchable
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
        public bool Benched
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
        public InGamePlayerSnapshot()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public InGamePlayerSnapshot(global::Srv.InGamePlayerSnapshot other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.InGamePlayerSnapshot Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.InGamePlayerSnapshot other)
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
        public void MergeFrom(global::Srv.InGamePlayerSnapshot other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}