namespace Srv
{
    public sealed class CustomTeamChallengeArchive : global::Google.Protobuf.IMessage<global::Srv.CustomTeamChallengeArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.CustomTeamChallengeArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.CustomTeamChallengeArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.CustomTeamChallengeArchive> _parser;
        public const int TeamFieldNumber = 1;
        private global::Srv.CustomTeam team_;
        public const int LastTimeFieldNumber = 2;
        private long lastTime_;
        public const int PlayerPoolFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_playerPool_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> playerPool_;
        public const int SpecialPlayerStateFieldNumber = 5;
        private int specialPlayerState_;
        public const int FormationIdFieldNumber = 6;
        private int formationId_;
        public const int StartFieldNumber = 7;
        private bool start_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.CustomTeamChallengeArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.CustomTeam Team
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
        public long LastTime
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PlayerPool => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int SpecialPlayerState
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
        public int FormationId
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
        public bool Start
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
        public CustomTeamChallengeArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public CustomTeamChallengeArchive(global::Srv.CustomTeamChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.CustomTeamChallengeArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.CustomTeamChallengeArchive other)
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
        public void MergeFrom(global::Srv.CustomTeamChallengeArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}