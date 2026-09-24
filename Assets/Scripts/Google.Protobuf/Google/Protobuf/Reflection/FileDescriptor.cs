namespace Google.Protobuf.Reflection
{
    public sealed class FileDescriptor : global::Google.Protobuf.Reflection.IDescriptor
    {
        private readonly global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.EnumDescriptor> EnumTypes;
        private readonly global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.FileDescriptor> Dependencies;
        private readonly global::Google.Protobuf.ByteString SerializedData;
        internal global::Google.Protobuf.Reflection.FileDescriptorProto Proto { get; }
        public string Name => null;
        public string Package => null;
        public global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.MessageDescriptor> MessageTypes { get; }
        public global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.ServiceDescriptor> Services { get; }
        public global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.FileDescriptor> PublicDependencies { get; }

        string global::Google.Protobuf.Reflection.IDescriptor.FullName => null;

        global::Google.Protobuf.Reflection.FileDescriptor global::Google.Protobuf.Reflection.IDescriptor.File => null;
        internal global::Google.Protobuf.Reflection.DescriptorPool DescriptorPool { get; }

        static FileDescriptor()
        {
        }

        private FileDescriptor(global::Google.Protobuf.ByteString descriptorData, global::Google.Protobuf.Reflection.FileDescriptorProto proto, global::Google.Protobuf.Reflection.FileDescriptor[] dependencies, global::Google.Protobuf.Reflection.DescriptorPool pool, bool allowUnknownDependencies, global::Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
        {
        }

        internal string ComputeFullName(global::Google.Protobuf.Reflection.MessageDescriptor parent, string name)
        {
            return null;
        }

        private static global::System.Collections.Generic.IList<global::Google.Protobuf.Reflection.FileDescriptor> DeterminePublicDependencies(global::Google.Protobuf.Reflection.FileDescriptor @this, global::Google.Protobuf.Reflection.FileDescriptorProto proto, global::Google.Protobuf.Reflection.FileDescriptor[] dependencies, bool allowUnknownDependencies)
        {
            return null;
        }

        private static global::Google.Protobuf.Reflection.FileDescriptor BuildFrom(global::Google.Protobuf.ByteString descriptorData, global::Google.Protobuf.Reflection.FileDescriptorProto proto, global::Google.Protobuf.Reflection.FileDescriptor[] dependencies, bool allowUnknownDependencies, global::Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
        {
            return null;
        }

        private void CrossLink()
        {
        }

        public static global::Google.Protobuf.Reflection.FileDescriptor FromGeneratedCode(byte[] descriptorData, global::Google.Protobuf.Reflection.FileDescriptor[] dependencies, global::Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public static void ForceReflectionInitialization<T>()
        {
        }
    }
}