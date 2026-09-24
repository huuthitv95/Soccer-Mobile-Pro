namespace Srv
{
    public sealed class ExternalDataSetting : global::Google.Protobuf.IMessage<global::Srv.ExternalDataSetting>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Srv.ExternalDataSetting>, global::Google.Protobuf.IDeepCloneable<global::Srv.ExternalDataSetting>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Srv.ExternalDataSetting> _parser;
        public const int NamesFieldNumber = 1;
        private static readonly global::Google.Protobuf.Collections.MapField<int, string>.Codec _map_names_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, string> names_;
        public const int PathFieldNumber = 2;
        private static readonly global::Google.Protobuf.Collections.MapField<int, string>.Codec _map_path_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, string> path_;
        public const int DetailInfoFieldNumber = 3;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.IntStrMap>.Codec _map_detailInfo_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.IntStrMap> detailInfo_;
        public const int CoatNumberFieldNumber = 4;
        private static readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.IntStrMap>.Codec _map_coatNumber_codec;
        private readonly global::Google.Protobuf.Collections.MapField<int, global::Srv.IntStrMap> coatNumber_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Srv.ExternalDataSetting> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, string> Names => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, string> Path => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.IntStrMap> DetailInfo => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.MapField<int, global::Srv.IntStrMap> CoatNumber => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ExternalDataSetting()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public ExternalDataSetting(global::Srv.ExternalDataSetting other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Srv.ExternalDataSetting Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Srv.ExternalDataSetting other)
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
        public void MergeFrom(global::Srv.ExternalDataSetting other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}