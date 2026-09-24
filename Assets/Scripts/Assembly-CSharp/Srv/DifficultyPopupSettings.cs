namespace Srv
{
    public sealed class DifficultyPopupSettings : global::Google.Protobuf.IMessage<global::Srv.DifficultyPopupSettings>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.DifficultyPopupSettings>, global::Google.Protobuf.IDeepCloneable<global::Srv.DifficultyPopupSettings>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.DifficultyPopupSettings> _parser;
        public const int LastPopupTmFieldNumber = 1;
        private long lastPopupTm_;
        public const int CumulativeGDFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_cumulativeGD_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> cumulativeGD_;
        public const int WinningStreakFieldNumber = 3;
        private int winningStreak_;
        public const int MatchesAfterDifficultyAdjustFieldNumber = 4;
        private int matchesAfterDifficultyAdjust_;
        public const int UncompletedMatchGDFieldNumber = 5;
        private int uncompletedMatchGD_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.DifficultyPopupSettings> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public long LastPopupTm
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
        public global::Google.Protobuf.Collections.RepeatedField<int> CumulativeGD => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int WinningStreak
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
        public int MatchesAfterDifficultyAdjust
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
        public int UncompletedMatchGD
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
        public DifficultyPopupSettings()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public DifficultyPopupSettings(global::Srv.DifficultyPopupSettings other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.DifficultyPopupSettings Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.DifficultyPopupSettings other)
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
        public void MergeFrom(global::Srv.DifficultyPopupSettings other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}