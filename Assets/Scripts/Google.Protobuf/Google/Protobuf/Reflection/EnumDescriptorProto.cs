namespace Google.Protobuf.Reflection
{
    internal sealed class EnumDescriptorProto : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.EnumDescriptorProto>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.EnumDescriptorProto>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.EnumDescriptorProto>
    {
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static class Types
        {
            internal sealed class EnumReservedRange : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>
            {
                private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _parser;
                private global::Google.Protobuf.UnknownFieldSet _unknownFields;
                private int start_;
                private int end_;
                [global::System.Diagnostics.DebuggerNonUserCode]
                public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> Parser => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

                [global::System.Diagnostics.DebuggerNonUserCode]
                public int Start
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
                public int End
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
                public EnumReservedRange()
                {
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public EnumReservedRange(global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other)
                {
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange Clone()
                {
                    return null;
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public override bool Equals(object other)
                {
                    return false;
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public bool Equals(global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other)
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

        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.EnumDescriptorProto> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private string name_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.EnumValueDescriptorProto> _repeated_value_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.EnumValueDescriptorProto> value_;
        private global::Google.Protobuf.Reflection.EnumOptions options_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _repeated_reservedRange_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> reservedRange_;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_reservedName_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> reservedName_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.EnumDescriptorProto> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string Name
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
        public global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.EnumValueDescriptorProto> Value => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.EnumOptions Options => null;

        private global::Google.Protobuf.Reflection.MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public EnumDescriptorProto()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public EnumDescriptorProto(global::Google.Protobuf.Reflection.EnumDescriptorProto other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.EnumDescriptorProto Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.Reflection.EnumDescriptorProto other)
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