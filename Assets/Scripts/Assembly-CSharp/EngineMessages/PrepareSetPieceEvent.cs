namespace EngineMessages
{
    public sealed class PrepareSetPieceEvent : global::Google.Protobuf.IMessage<global::EngineMessages.PrepareSetPieceEvent>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.PrepareSetPieceEvent>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.PrepareSetPieceEvent>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.PrepareSetPieceEvent> _parser;
        public const int GamemodeFieldNumber = 1;
        private global::EngineMessages.GameMode gamemode_;
        public const int BallPositionFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_ballPosition_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> ballPosition_;
        public const int KickGateDirectionFieldNumber = 3;
        private int kickGateDirection_;
        public const int TeamidFieldNumber = 4;
        private int teamid_;
        public const int TakeridFieldNumber = 5;
        private int takerid_;
        public const int WallPositionFieldNumber = 6;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_wallPosition_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> wallPosition_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.PrepareSetPieceEvent> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.GameMode Gamemode
        {
            get
            {
                return global::EngineMessages.GameMode.Normal;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> BallPosition => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int KickGateDirection
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
        public int Teamid
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
        public int Takerid
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
        public global::Google.Protobuf.Collections.RepeatedField<float> WallPosition => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PrepareSetPieceEvent()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public PrepareSetPieceEvent(global::EngineMessages.PrepareSetPieceEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.PrepareSetPieceEvent Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.PrepareSetPieceEvent other)
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
        public void MergeFrom(global::EngineMessages.PrepareSetPieceEvent other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}