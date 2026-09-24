namespace Srv
{
    public sealed class TeamTactics : global::Google.Protobuf.IMessage<global::Srv.TeamTactics>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.TeamTactics>, global::Google.Protobuf.IDeepCloneable<global::Srv.TeamTactics>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.TeamTactics> _parser;
        public const int CaptainFieldNumber = 1;
        private int captain_;
        public const int PenaltyTakersFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_penaltyTakers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> penaltyTakers_;
        public const int FreekickTakersFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_freekickTakers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> freekickTakers_;
        public const int LeftCornerTakersFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_leftCornerTakers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> leftCornerTakers_;
        public const int RightCornerTakersFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_rightCornerTakers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> rightCornerTakers_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.TeamTactics> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Captain
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
        public global::Google.Protobuf.Collections.RepeatedField<int> PenaltyTakers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> FreekickTakers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> LeftCornerTakers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> RightCornerTakers => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TeamTactics()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TeamTactics(global::Srv.TeamTactics other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.TeamTactics Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.TeamTactics other)
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
        public void MergeFrom(global::Srv.TeamTactics other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}