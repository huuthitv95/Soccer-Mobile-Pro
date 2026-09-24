namespace Srv
{
    public sealed class FixtureData : global::Google.Protobuf.IMessage<global::Srv.FixtureData>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.FixtureData>, global::Google.Protobuf.IDeepCloneable<global::Srv.FixtureData>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.FixtureData> _parser;
        public const int DateTimestampFieldNumber = 1;
        private int dateTimestamp_;
        public const int MatchTypeFieldNumber = 2;
        private int matchType_;
        public const int RoundFieldNumber = 3;
        private int round_;
        public const int DateTimestampLFieldNumber = 4;
        private long dateTimestampL_;
        public const int MatchInfoFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.IntPairs> _repeated_matchInfo_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.IntPairs> matchInfo_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.FixtureData> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int DateTimestamp
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
        public int MatchType
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
        public long DateTimestampL
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.IntPairs> MatchInfo => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FixtureData()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FixtureData(global::Srv.FixtureData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.FixtureData Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.FixtureData other)
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
        public void MergeFrom(global::Srv.FixtureData other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}