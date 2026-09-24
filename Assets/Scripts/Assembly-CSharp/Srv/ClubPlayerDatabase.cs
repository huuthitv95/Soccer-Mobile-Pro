namespace Srv
{
    public sealed class ClubPlayerDatabase : global::Google.Protobuf.IMessage<global::Srv.ClubPlayerDatabase>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.ClubPlayerDatabase>, global::Google.Protobuf.IDeepCloneable<global::Srv.ClubPlayerDatabase>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.ClubPlayerDatabase> _parser;
        public const int DatabaseFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.ClubPlayerData>.Codec _map_database_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.ClubPlayerData> database_;
        public const int FakePlayerProtosFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.FakePlayer>.Codec _map_fakePlayerProtos_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.FakePlayer> fakePlayerProtos_;
        public const int UseTransferFieldNumber = 3;
        private bool useTransfer_;
        public const int FakePlayerCounterFieldNumber = 4;
        private int fakePlayerCounter_;
        public const int UserTeamTacticsFieldNumber = 5;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.TeamTactics>.Codec _map_userTeamTactics_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.TeamTactics> userTeamTactics_;
        public const int PlayerContractFieldNumber = 6;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerContract>.Codec _map_playerContract_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerContract> playerContract_;
        public const int BoostRecordFieldNumber = 7;
        private global::Srv.PlayerTemporaryBoostRecord boostRecord_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.ClubPlayerDatabase> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.ClubPlayerData> Database => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.FakePlayer> FakePlayerProtos => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool UseTransfer
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
        public int FakePlayerCounter
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
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.TeamTactics> UserTeamTactics => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.PlayerContract> PlayerContract => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.PlayerTemporaryBoostRecord BoostRecord
        {
            get
            {
                return null;
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
        public ClubPlayerDatabase()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ClubPlayerDatabase(global::Srv.ClubPlayerDatabase other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ClubPlayerDatabase Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.ClubPlayerDatabase other)
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
        public void MergeFrom(global::Srv.ClubPlayerDatabase other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}