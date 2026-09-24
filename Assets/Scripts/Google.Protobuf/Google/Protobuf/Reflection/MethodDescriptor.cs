namespace Google.Protobuf.Reflection
{
    public sealed class MethodDescriptor : global::Google.Protobuf.Reflection.DescriptorBase
    {
        private readonly global::Google.Protobuf.Reflection.MethodDescriptorProto proto;
        private readonly global::Google.Protobuf.Reflection.ServiceDescriptor service;
        private global::Google.Protobuf.Reflection.MessageDescriptor inputType;
        private global::Google.Protobuf.Reflection.MessageDescriptor outputType;
        internal global::Google.Protobuf.Reflection.MethodDescriptorProto Proto => null;
        public override string Name => null;

        internal MethodDescriptor(global::Google.Protobuf.Reflection.MethodDescriptorProto proto, global::Google.Protobuf.Reflection.FileDescriptor file, global::Google.Protobuf.Reflection.ServiceDescriptor parent, int index) : base(null, null, 0)
        {
        }

        internal void CrossLink()
        {
        }
    }
}