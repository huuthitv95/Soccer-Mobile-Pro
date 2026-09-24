namespace Srv
{
    public sealed class MatchData : global::Google.Protobuf.IMessage<global::Srv.MatchData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.MatchData>, global::Google.Protobuf.IDeepCloneable<global::Srv.MatchData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.MatchData> _parser;
        public const int HomeIdFieldNumber = 1;
        private int homeId_;
        public const int AwayIdFieldNumber = 2;
        private int awayId_;
        public const int HomeScoreFieldNumber = 3;
        private int homeScore_;
        public const int AwayScoreFieldNumber = 4;
        private int awayScore_;
        public const int IsFinishedFieldNumber = 5;
        private bool isFinished_;
        public const int RoundFieldNumber = 6;
        private int round_;
        public const int FirstLegFieldNumber = 7;
        private global::Srv.MatchData firstLeg_;
        public const int HasExtraTimeFieldNumber = 8;
        private bool hasExtraTime_;
        public const int HasPenaltiesFieldNumber = 9;
        private bool hasPenalties_;
        public const int CheckAwayGoalFieldNumber = 10;
        private bool checkAwayGoal_;
        public const int DetailTypeFieldNumber = 11;
        private int detailType_;
        public const int GoalsFieldNumber = 12;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_goals_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> goals_;
        public const int AssistsFieldNumber = 13;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_assists_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> assists_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.MatchData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int HomeId
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
        public int AwayId
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
        public int HomeScore
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
        public int AwayScore
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
        public bool IsFinished
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
        public int Round
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
        public global::Srv.MatchData FirstLeg
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
        public bool HasExtraTime
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
        public bool HasPenalties
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
        public bool CheckAwayGoal
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
        public int DetailType
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
        public global::Google.Protobuf.Collections.MapField<int, int> Goals => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, int> Assists => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MatchData(global::Srv.MatchData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.MatchData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.MatchData other)
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
        public void MergeFrom(global::Srv.MatchData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}