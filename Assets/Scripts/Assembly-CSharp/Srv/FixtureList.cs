namespace Srv
{
    public sealed class FixtureList : global::Google.Protobuf.IMessage<global::Srv.FixtureList>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.FixtureList>, global::Google.Protobuf.IDeepCloneable<global::Srv.FixtureList>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.FixtureList> _parser;
        public const int ScheduleFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.FixtureData> _repeated_schedule_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.FixtureData> schedule_;
        public const int LeagueArchiveIdFieldNumber = 5;
        private int leagueArchiveId_;
        public const int CupArchiveIdsFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_cupArchiveIds_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> cupArchiveIds_;
        public const int WaitTrainingFieldNumber = 7;
        private bool waitTraining_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.FixtureList> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.FixtureData> Schedule => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int LeagueArchiveId
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
        public global::Google.Protobuf.Collections.RepeatedField<int> CupArchiveIds => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool WaitTraining
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
        public FixtureList()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FixtureList(global::Srv.FixtureList other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.FixtureList Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.FixtureList other)
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
        public void MergeFrom(global::Srv.FixtureList other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}