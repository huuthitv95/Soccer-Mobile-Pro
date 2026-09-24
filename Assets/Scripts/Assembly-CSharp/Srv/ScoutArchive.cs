namespace Srv
{
    public sealed class ScoutArchive : global::Google.Protobuf.IMessage<global::Srv.ScoutArchive>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.ScoutArchive>, global::Google.Protobuf.IDeepCloneable<global::Srv.ScoutArchive>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.ScoutArchive> _parser;
        public const int CurrentPlayersFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_currentPlayers_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> currentPlayers_;
        public const int RefreshTimesFieldNumber = 2;
        private int refreshTimes_;
        public const int NeedRefreshFieldNumber = 3;
        private bool needRefresh_;
        public const int SignSplendidFieldNumber = 4;
        private bool signSplendid_;
        public const int NewPlayerTipFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_newPlayerTip_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> newPlayerTip_;
        public const int LockAutoRefreshFieldNumber = 6;
        private bool lockAutoRefresh_;
        public const int FreeRefreshTimesFieldNumber = 7;
        private int freeRefreshTimes_;
        public const int WatchListFieldNumber = 8;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_watchList_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> watchList_;
        public const int BargainCountsFieldNumber = 9;
        private static readonly global::Google.Protobuf.Collections.MapField<int, int>.Codec _map_bargainCounts_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, int> bargainCounts_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.ScoutArchive> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, int> CurrentPlayers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int RefreshTimes
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
        public bool NeedRefresh
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
        public bool SignSplendid
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
        public global::Google.Protobuf.Collections.RepeatedField<int> NewPlayerTip => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool LockAutoRefresh
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
        public int FreeRefreshTimes
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
        public global::Google.Protobuf.Collections.RepeatedField<int> WatchList => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, int> BargainCounts => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ScoutArchive()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ScoutArchive(global::Srv.ScoutArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ScoutArchive Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.ScoutArchive other)
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
        public void MergeFrom(global::Srv.ScoutArchive other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}