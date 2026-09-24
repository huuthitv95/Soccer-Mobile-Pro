namespace EngineMessages
{
    public sealed class BallService : global::Google.Protobuf.IMessage<global::EngineMessages.BallService>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::EngineMessages.BallService>, global::Google.Protobuf.IDeepCloneable<global::EngineMessages.BallService>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::EngineMessages.BallService> _parser;
        public const int PositionsFieldNumber = 1;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_positions_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> positions_;
        public const int DestinationsFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_destinations_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> destinations_;
        public const int PowersFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<float> _repeated_powers_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<float> powers_;
        public const int DelaysFieldNumber = 4;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_delays_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> delays_;
        public const int IndicesFieldNumber = 5;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_indices_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> indices_;
        public const int DurationFieldNumber = 6;
        private int duration_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::EngineMessages.BallService> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Positions => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Destinations => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<float> Powers => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Delays => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> Indices => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int Duration
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
        public BallService()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public BallService(global::EngineMessages.BallService other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::EngineMessages.BallService Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::EngineMessages.BallService other)
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
        public void MergeFrom(global::EngineMessages.BallService other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}