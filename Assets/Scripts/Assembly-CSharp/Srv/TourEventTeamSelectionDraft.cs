namespace Srv
{
    public sealed class TourEventTeamSelectionDraft : global::Google.Protobuf.IMessage<global::Srv.TourEventTeamSelectionDraft>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.TourEventTeamSelectionDraft>, global::Google.Protobuf.IDeepCloneable<global::Srv.TourEventTeamSelectionDraft>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.TourEventTeamSelectionDraft> _parser;
        public const int TemplateTeamIdFieldNumber = 1;
        private int templateTeamId_;
        public const int CopiedPlayerIdsFieldNumber = 2;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_copiedPlayerIds_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> copiedPlayerIds_;
        public const int FormationFieldNumber = 3;
        private static readonly global::Google.Protobuf.FieldCodec<global::Srv.FormationData> _repeated_formation_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> formation_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.TourEventTeamSelectionDraft> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public int TemplateTeamId
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
        public global::Google.Protobuf.Collections.RepeatedField<int> CopiedPlayerIds => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Srv.FormationData> Formation => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TourEventTeamSelectionDraft()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public TourEventTeamSelectionDraft(global::Srv.TourEventTeamSelectionDraft other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.TourEventTeamSelectionDraft Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.TourEventTeamSelectionDraft other)
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
        public void MergeFrom(global::Srv.TourEventTeamSelectionDraft other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}