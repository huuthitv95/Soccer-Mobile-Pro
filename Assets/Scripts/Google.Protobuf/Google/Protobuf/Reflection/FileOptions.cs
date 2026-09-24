namespace Google.Protobuf.Reflection
{
    internal sealed class FileOptions : global::Google.Protobuf.IMessage<global::Google.Protobuf.Reflection.FileOptions>, global::Google.Protobuf.IMessage, global::System.IEquatable<global::Google.Protobuf.Reflection.FileOptions>, global::Google.Protobuf.IDeepCloneable<global::Google.Protobuf.Reflection.FileOptions>
    {
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static class Types
        {
            internal enum OptimizeMode
            {
                Speed = 1,
                CodeSize = 2,
                LiteRuntime = 3
            }
        }

        private static readonly global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.FileOptions> _parser;
        private global::Google.Protobuf.UnknownFieldSet _unknownFields;
        private string javaPackage_;
        private string javaOuterClassname_;
        private bool javaMultipleFiles_;
        private bool javaGenerateEqualsAndHash_;
        private bool javaStringCheckUtf8_;
        private global::Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode optimizeFor_;
        private string goPackage_;
        private bool ccGenericServices_;
        private bool javaGenericServices_;
        private bool pyGenericServices_;
        private bool phpGenericServices_;
        private bool deprecated_;
        private bool ccEnableArenas_;
        private string objcClassPrefix_;
        private string csharpNamespace_;
        private string swiftPrefix_;
        private string phpClassPrefix_;
        private string phpNamespace_;
        private string phpMetadataNamespace_;
        private string rubyPackage_;
        private static readonly global::Google.Protobuf.FieldCodec<global::Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
        private readonly global::Google.Protobuf.Collections.RepeatedField<global::Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.MessageParser<global::Google.Protobuf.Reflection.FileOptions> Parser => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static global::Google.Protobuf.Reflection.MessageDescriptor Descriptor => null;

        [global::System.Diagnostics.DebuggerNonUserCode]
        global::Google.Protobuf.Reflection.MessageDescriptor global::Google.Protobuf.IMessage.Descriptor => pb_003A_003AGoogle_002EProtobuf_002EIMessage_002Eget_Descriptor();
        internal global::Google.Protobuf.Reflection.CustomOptions CustomOptions { get; private set; }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string JavaPackage
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
        public string JavaOuterClassname
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
        public bool JavaMultipleFiles
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
        [global::System.Obsolete]
        public bool JavaGenerateEqualsAndHash
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
        public bool JavaStringCheckUtf8
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
        public global::Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode OptimizeFor => (global::Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode)0;

        [global::System.Diagnostics.DebuggerNonUserCode]
        public string GoPackage
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
        public bool CcGenericServices
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
        public bool JavaGenericServices
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
        public bool PyGenericServices
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
        public bool PhpGenericServices
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
        public bool Deprecated
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
        public bool CcEnableArenas
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
        public string ObjcClassPrefix
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
        public string CsharpNamespace
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
        public string SwiftPrefix
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
        public string PhpClassPrefix
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
        public string PhpNamespace
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
        public string PhpMetadataNamespace
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
        public string RubyPackage
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
        public FileOptions()
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public FileOptions(global::Google.Protobuf.Reflection.FileOptions other)
        {
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::Google.Protobuf.Reflection.FileOptions Clone()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(global::Google.Protobuf.Reflection.FileOptions other)
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