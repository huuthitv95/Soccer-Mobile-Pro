namespace Google.Protobuf.Reflection
{
    internal sealed class UninterpretedOption : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.UninterpretedOption>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.UninterpretedOption>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.UninterpretedOption>
    {
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static class Types
        {
            internal sealed class NamePart : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>
            {
                private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _parser;
                private global::Google.Protobuf.UnknownFieldSet _unknownFields;
                private string namePart_;
                private bool isExtension_;
                [global::System.Diagnostics.DebuggerNonUserCode]
                public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> Parser => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

                [global::System.Diagnostics.DebuggerNonUserCode]
                global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

                [global::System.Diagnostics.DebuggerNonUserCode]
                public string NamePart_
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
                public bool IsExtension
                {
                    get
                    {
                        return false;
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
                public NamePart()
                {
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public NamePart(global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other)
                {
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart Clone()
                {
                    return null;
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public override bool Equals(object other)
                {
                    return false;
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public bool Equals(global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other)
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

        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.UninterpretedOption> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _repeated_name_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> name_;
        private string identifierValue_;
        private ulong positiveIntValue_;
        private long negativeIntValue_;
        private double doubleValue_;
        private global::Google.Protobuf.ByteString stringValue_;
        private string aggregateValue_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.UninterpretedOption> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string IdentifierValue
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
        public ulong PositiveIntValue
        {
            get
            {
                return 0uL;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public long NegativeIntValue
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
        public double DoubleValue
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.ByteString StringValue
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
        public string AggregateValue
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
        public UninterpretedOption()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public UninterpretedOption(global::Google.Protobuf.Reflection.UninterpretedOption other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.UninterpretedOption Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.Reflection.UninterpretedOption other)
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