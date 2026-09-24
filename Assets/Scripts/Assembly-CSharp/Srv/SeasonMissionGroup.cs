namespace Srv
{
    public sealed class SeasonMissionGroup : global::Google.Protobuf.IMessage<global::Srv.SeasonMissionGroup>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.SeasonMissionGroup>, global::Google.Protobuf.IDeepCloneable<global::Srv.SeasonMissionGroup>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.SeasonMissionGroup> _parser;
        public const int RenewalConditionFieldNumber = 1;
        private global::Srv.SeasonMission renewalCondition_;
        public const int BonusFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.SeasonMission> _repeated_bonus_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.SeasonMission> bonus_;
        public const int HistoryMarkFieldNumber = 3;
        private int historyMark_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.SeasonMissionGroup> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.SeasonMission RenewalCondition
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.SeasonMission> Bonus => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int HistoryMark
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
        public SeasonMissionGroup()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SeasonMissionGroup(global::Srv.SeasonMissionGroup other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.SeasonMissionGroup Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.SeasonMissionGroup other)
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
        public void MergeFrom(global::Srv.SeasonMissionGroup other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}