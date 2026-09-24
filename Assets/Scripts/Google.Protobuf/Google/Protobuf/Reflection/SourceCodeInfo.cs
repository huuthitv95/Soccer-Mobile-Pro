namespace Google.Protobuf.Reflection
{
    internal sealed class SourceCodeInfo : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.SourceCodeInfo>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.SourceCodeInfo>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.SourceCodeInfo>
    {
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static class Types
        {
            internal sealed class Location : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>
            {
                private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _parser;
                private global::Google.Protobuf.UnknownFieldSet _unknownFields;
                private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_path_codec;
                private readonly global::Google.Protobuf.Collections.RepeatedField<int> path_;
                private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_span_codec;
                private readonly global::Google.Protobuf.Collections.RepeatedField<int> span_;
                private string leadingComments_;
                private string trailingComments_;
                private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_leadingDetachedComments_codec;
                private readonly global::Google.Protobuf.Collections.RepeatedField<string> leadingDetachedComments_;
                [global::System.Diagnostics.DebuggerNonUserCode]
                public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> Parser => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

                [global::System.Diagnostics.DebuggerNonUserCode]
                public string LeadingComments
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
                public string TrailingComments
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
                public Location()
                {
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public Location(global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other)
                {
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location Clone()
                {
                    return null;
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public override bool Equals(object other)
                {
                    return false;
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public bool Equals(global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other)
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
                public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
                {
                }
            }
        }

        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.SourceCodeInfo> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _repeated_location_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> location_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.SourceCodeInfo> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SourceCodeInfo()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public SourceCodeInfo(global::Google.Protobuf.Reflection.SourceCodeInfo other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.SourceCodeInfo Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.Reflection.SourceCodeInfo other)
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
        public void MergeFrom(global::Google.Protobuf.CodedInputStream input)
        {
        }
    }
}