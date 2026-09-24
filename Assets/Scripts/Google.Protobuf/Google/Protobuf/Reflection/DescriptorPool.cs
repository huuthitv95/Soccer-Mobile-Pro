namespace Google.Protobuf.Reflection
{
    internal sealed class DescriptorPool
    {
        private struct DescriptorIntPair : global::System.IEquatable<global::Google.Protobuf.Reflection.DescriptorPool.DescriptorIntPair>
        {
            private readonly int number;
            private readonly global::Google.Protobuf.Reflection.IDescriptor descriptor;
            internal DescriptorIntPair(global::Google.Protobuf.Reflection.IDescriptor descriptor, int number)
            {
                this.number = 0;
                this.descriptor = null;
            }

            public bool Equals(global::Google.Protobuf.Reflection.DescriptorPool.DescriptorIntPair other)
            {
                return false;
            }

            public override bool Equals(object obj)
            {
                return false;
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }

        private readonly global::System.Collections.Generic.IDictionary<string, global::Google.Protobuf.Reflection.IDescriptor> descriptorsByName;
        private readonly global::System.Collections.Generic.IDictionary<global::Google.Protobuf.Reflection.DescriptorPool.DescriptorIntPair, global::Google.Protobuf.Reflection.FieldDescriptor> fieldsByNumber;
        private readonly global::System.Collections.Generic.IDictionary<global::Google.Protobuf.Reflection.DescriptorPool.DescriptorIntPair, global::Google.Protobuf.Reflection.EnumValueDescriptor> enumValuesByNumber;
        private readonly global::System.Collections.Generic.HashSet<global::Google.Protobuf.Reflection.FileDescriptor> dependencies;
        private static readonly global::System.Text.RegularExpressions.Regex ValidationRegex;
        internal DescriptorPool(global::Google.Protobuf.Reflection.FileDescriptor[] dependencyFiles)
        {
        }

        private void ImportPublicDependencies(global::Google.Protobuf.Reflection.FileDescriptor file)
        {
        }

        internal T FindSymbol<T>(string fullName)
            where T : class
        {
            return null;
        }

        internal void AddPackage(string fullName, global::Google.Protobuf.Reflection.FileDescriptor file)
        {
        }

        internal void AddSymbol(global::Google.Protobuf.Reflection.IDescriptor descriptor)
        {
        }

        private static void ValidateSymbolName(global::Google.Protobuf.Reflection.IDescriptor descriptor)
        {
        }

        internal global::Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(global::Google.Protobuf.Reflection.MessageDescriptor messageDescriptor, int number)
        {
            return null;
        }

        internal void AddFieldByNumber(global::Google.Protobuf.Reflection.FieldDescriptor field)
        {
        }

        internal void AddEnumValueByNumber(global::Google.Protobuf.Reflection.EnumValueDescriptor enumValue)
        {
        }

        internal global::Google.Protobuf.Reflection.IDescriptor LookupSymbol(string name, global::Google.Protobuf.Reflection.IDescriptor relativeTo)
        {
            return null;
        }
    }
}