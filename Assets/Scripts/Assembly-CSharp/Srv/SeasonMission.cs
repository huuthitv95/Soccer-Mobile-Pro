namespace Srv
{
    public sealed class SeasonMission : global::Google.Protobuf.IMessage<global::Srv.SeasonMission>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.SeasonMission>, global::Google.Protobuf.IDeepCloneable<global::Srv.SeasonMission>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.SeasonMission> _parser;
        public const int MissionTypeFieldNumber = 1;
        private int missionType_;
        public const int IsClaimedFieldNumber = 2;
        private bool isClaimed_;
        public const int ProgressFieldNumber = 3;
        private int progress_;
        public const int TargetFieldNumber = 4;
        private int target_;
        public const int RewardFieldNumber = 5;
        private int reward_;
        public const int IsCompleteFieldNumber = 6;
        private bool isComplete_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.SeasonMission> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int MissionType
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
        public bool IsClaimed
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
        public int Progress
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
        public int Target
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
        public int Reward
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
        public bool IsComplete
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public string GetMissionDescription()
        {
            return null;
        }

        public bool IsPlayerMission()
        {
            return false;
        }

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SeasonMission()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SeasonMission(global::Srv.SeasonMission other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.SeasonMission Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.SeasonMission other)
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
        public void MergeFrom(global::Srv.SeasonMission other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}