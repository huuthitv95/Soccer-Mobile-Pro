namespace Srv
{
    public sealed class MasterLeagueLogEvent : global::Google.Protobuf.IMessage<global::Srv.MasterLeagueLogEvent>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.MasterLeagueLogEvent>, global::Google.Protobuf.IDeepCloneable<global::Srv.MasterLeagueLogEvent>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.MasterLeagueLogEvent> _parser;
        public const int IncomeFieldNumber = 7;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_income_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> income_;
        public const int ExpenditureFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_expenditure_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> expenditure_;
        public const int SignCounterFieldNumber = 2;
        private int signCounter_;
        public const int SignAblityFieldNumber = 3;
        private int signAblity_;
        public const int ReleaseCounterFieldNumber = 4;
        private int releaseCounter_;
        public const int ReleaseAblityFieldNumber = 5;
        private int releaseAblity_;
        public const int ScoutRefreshCounterFieldNumber = 6;
        private int scoutRefreshCounter_;
        public const int SignPlayerByPosFieldNumber = 8;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_signPlayerByPos_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> signPlayerByPos_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.MasterLeagueLogEvent> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, int> Income => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, int> Expenditure => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int SignCounter
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
        public int SignAblity
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
        public int ReleaseCounter
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
        public int ReleaseAblity
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
        public int ScoutRefreshCounter
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
        public global::Google.Protobuf.Collections.MapField<int, int> SignPlayerByPos => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MasterLeagueLogEvent()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public MasterLeagueLogEvent(global::Srv.MasterLeagueLogEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.MasterLeagueLogEvent Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.MasterLeagueLogEvent other)
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
        public void MergeFrom(global::Srv.MasterLeagueLogEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}