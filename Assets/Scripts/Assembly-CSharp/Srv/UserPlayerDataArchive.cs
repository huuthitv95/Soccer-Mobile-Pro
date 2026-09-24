namespace Srv
{
    public sealed class UserPlayerDataArchive : global::Google.Protobuf.IMessage<global::Srv.UserPlayerDataArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.UserPlayerDataArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.UserPlayerDataArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.UserPlayerDataArchive> _parser;
        public const int PlayerTypeFieldNumber = 1;
        private int playerType_;
        public const int AppearanceIdFieldNumber = 2;
        private int appearanceId_;
        public const int KitNameFieldNumber = 3;
        private string kitName_;
        public const int CoachTrustPointFieldNumber = 4;
        private int coachTrustPoint_;
        public const int CoachTrustReachedTierMaskFieldNumber = 5;
        private int coachTrustReachedTierMask_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.UserPlayerDataArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int PlayerType
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
        public int AppearanceId
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
        public string KitName
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
        public int CoachTrustPoint
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
        public int CoachTrustReachedTierMask
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
        public UserPlayerDataArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public UserPlayerDataArchive(global::Srv.UserPlayerDataArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.UserPlayerDataArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.UserPlayerDataArchive other)
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
        public void MergeFrom(global::Srv.UserPlayerDataArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}