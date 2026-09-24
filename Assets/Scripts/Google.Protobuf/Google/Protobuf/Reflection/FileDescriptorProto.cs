namespace Google.Protobuf.Reflection
{
    internal sealed class FileDescriptorProto : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.FileDescriptorProto>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.FileDescriptorProto>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.FileDescriptorProto>
    {
        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.FileDescriptorProto> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private string name_;
        private string package_;
        private static readonly global::Google.Protobuf.FieldCodec<string> _repeated_dependency_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<string> dependency_;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_publicDependency_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> publicDependency_;
        private static readonly global::Google.Protobuf.FieldCodec<int> _repeated_weakDependency_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<int> weakDependency_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.DescriptorProto> _repeated_messageType_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.DescriptorProto> messageType_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.EnumDescriptorProto> enumType_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.ServiceDescriptorProto> _repeated_service_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.ServiceDescriptorProto> service_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.FieldDescriptorProto> extension_;
        private global::Google.Protobuf.Reflection.FileOptions options_;
        private global::Google.Protobuf.Reflection.SourceCodeInfo sourceCodeInfo_;
        private string syntax_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.FileDescriptorProto> Parser => null;

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
        public string Package
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
        public global::Google.Protobuf.Collections.RepeatedField<string> Dependency => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<int> PublicDependency => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.DescriptorProto> MessageType => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.EnumDescriptorProto> EnumType => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.ServiceDescriptorProto> Service => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.FileOptions Options => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.SourceCodeInfo SourceCodeInfo => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string Syntax
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
        public FileDescriptorProto()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FileDescriptorProto(global::Google.Protobuf.Reflection.FileDescriptorProto other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.FileDescriptorProto Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.Reflection.FileDescriptorProto other)
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