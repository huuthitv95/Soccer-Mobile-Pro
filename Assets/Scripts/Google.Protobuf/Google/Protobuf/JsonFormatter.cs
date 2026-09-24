namespace Google.Protobuf
{
    public sealed class JsonFormatter
    {
        public sealed class Settings
        {
            public static global::Google.Protobuf.JsonFormatter.Settings Default { get; }
            public bool FormatDefaultValues { get; }
            public global::Google.Protobuf.Reflection.TypeRegistry TypeRegistry { get; }
            public bool FormatEnumsAsIntegers { get; }

            static Settings()
            {
            }

            public Settings(bool formatDefaultValues)
            {
            }

            public Settings(bool formatDefaultValues, global::Google.Protobuf.Reflection.TypeRegistry typeRegistry)
            {
            }

            private Settings(bool formatDefaultValues, global::Google.Protobuf.Reflection.TypeRegistry typeRegistry, bool formatEnumsAsIntegers)
            {
            }
        }

        private static class OriginalEnumValueHelper
        {
            private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.Dictionary<object, string>> dictionaries;
            internal static string GetOriginalName(object value)
            {
                return null;
            }

            private static global::System.Collections.Generic.Dictionary<object, string> GetNameMapping(global::System.Type enumType)
            {
                return null;
            }
        }

        private static readonly global::Google.Protobuf.JsonFormatter diagnosticFormatter;
        private static readonly string[] CommonRepresentations;
        private readonly global::Google.Protobuf.JsonFormatter.Settings settings;
        public static global::Google.Protobuf.JsonFormatter Default { get; }
        private bool DiagnosticOnly => false;

        static JsonFormatter()
        {
        }

        public JsonFormatter(global::Google.Protobuf.JsonFormatter.Settings settings)
        {
        }

        public string Format(global::Google.Protobuf.IMessage message)
        {
            return null;
        }

        public void Format(global::Google.Protobuf.IMessage message, global::System.IO.TextWriter writer)
        {
        }

        public static string ToDiagnosticString(global::Google.Protobuf.IMessage message)
        {
            return null;
        }

        private void WriteMessage(global::System.IO.TextWriter writer, global::Google.Protobuf.IMessage message)
        {
        }

        private bool WriteMessageFields(global::System.IO.TextWriter writer, global::Google.Protobuf.IMessage message, bool assumeFirstFieldWritten)
        {
            return false;
        }

        internal static string ToJsonName(string name)
        {
            return null;
        }

        private static void WriteNull(global::System.IO.TextWriter writer)
        {
        }

        private static bool IsDefaultValue(global::Google.Protobuf.Reflection.IFieldAccessor accessor, object value)
        {
            return false;
        }

        public void WriteValue(global::System.IO.TextWriter writer, object value)
        {
        }

        private void WriteWellKnownTypeValue(global::System.IO.TextWriter writer, global::Google.Protobuf.Reflection.MessageDescriptor descriptor, object value)
        {
        }

        private void WriteTimestamp(global::System.IO.TextWriter writer, global::Google.Protobuf.IMessage value)
        {
        }

        private void WriteDuration(global::System.IO.TextWriter writer, global::Google.Protobuf.IMessage value)
        {
        }

        private void WriteFieldMask(global::System.IO.TextWriter writer, global::Google.Protobuf.IMessage value)
        {
        }

        private void WriteAny(global::System.IO.TextWriter writer, global::Google.Protobuf.IMessage value)
        {
        }

        private void WriteDiagnosticOnlyAny(global::System.IO.TextWriter writer, global::Google.Protobuf.IMessage value)
        {
        }

        private void WriteStruct(global::System.IO.TextWriter writer, global::Google.Protobuf.IMessage message)
        {
        }

        private void WriteStructFieldValue(global::System.IO.TextWriter writer, global::Google.Protobuf.IMessage message)
        {
        }

        internal void WriteList(global::System.IO.TextWriter writer, global::System.Collections.IList list)
        {
        }

        internal void WriteDictionary(global::System.IO.TextWriter writer, global::System.Collections.IDictionary dictionary)
        {
        }

        internal static void WriteString(global::System.IO.TextWriter writer, string text)
        {
        }

        private static void HexEncodeUtf16CodeUnit(global::System.IO.TextWriter writer, char c)
        {
        }
    }
}