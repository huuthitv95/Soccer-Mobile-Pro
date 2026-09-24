namespace Google.Protobuf
{
    public sealed class JsonParser
    {
        public sealed class Settings
        {
            public static global::Google.Protobuf.JsonParser.Settings Default { get; }
            public int RecursionLimit { get; }
            public global::Google.Protobuf.Reflection.TypeRegistry TypeRegistry { get; }
            public bool IgnoreUnknownFields { get; }

            static Settings()
            {
            }

            private Settings(int recursionLimit, global::Google.Protobuf.Reflection.TypeRegistry typeRegistry, bool ignoreUnknownFields)
            {
            }

            public Settings(int recursionLimit)
            {
            }

            public Settings(int recursionLimit, global::Google.Protobuf.Reflection.TypeRegistry typeRegistry)
            {
            }
        }

        private static readonly global::System.Text.RegularExpressions.Regex TimestampRegex;
        private static readonly global::System.Text.RegularExpressions.Regex DurationRegex;
        private static readonly int[] SubsecondScalingFactors;
        private static readonly char[] FieldMaskPathSeparators;
        private static readonly global::Google.Protobuf.JsonParser defaultInstance;
        private static readonly global::System.Collections.Generic.Dictionary<string, global::System.Action<global::Google.Protobuf.JsonParser, global::Google.Protobuf.IMessage, global::Google.Protobuf.JsonTokenizer>> WellKnownTypeHandlers;
        private readonly global::Google.Protobuf.JsonParser.Settings settings;
        public static global::Google.Protobuf.JsonParser Default => null;

        private static void MergeWrapperField(global::Google.Protobuf.JsonParser parser, global::Google.Protobuf.IMessage message, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
        }

        public JsonParser(global::Google.Protobuf.JsonParser.Settings settings)
        {
        }

        internal void Merge(global::Google.Protobuf.IMessage message, global::System.IO.TextReader jsonReader)
        {
        }

        private void Merge(global::Google.Protobuf.IMessage message, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
        }

        private void MergeField(global::Google.Protobuf.IMessage message, global::Google.Protobuf.Reflection.FieldDescriptor field, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
        }

        private void MergeRepeatedField(global::Google.Protobuf.IMessage message, global::Google.Protobuf.Reflection.FieldDescriptor field, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
        }

        private void MergeMapField(global::Google.Protobuf.IMessage message, global::Google.Protobuf.Reflection.FieldDescriptor field, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
        }

        private static bool IsGoogleProtobufValueField(global::Google.Protobuf.Reflection.FieldDescriptor field)
        {
            return false;
        }

        private object ParseSingleValue(global::Google.Protobuf.Reflection.FieldDescriptor field, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
            return null;
        }

        public T Parse<T>(string json)
            where T : global::Google.Protobuf.IMessage, new()
        {
            return default;
        }

        public T Parse<T>(global::System.IO.TextReader jsonReader)
            where T : global::Google.Protobuf.IMessage, new()
        {
            return default;
        }

        private void MergeStructValue(global::Google.Protobuf.IMessage message, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
        }

        private void MergeStruct(global::Google.Protobuf.IMessage message, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
        }

        private void MergeAny(global::Google.Protobuf.IMessage message, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
        }

        private void MergeWellKnownTypeAnyBody(global::Google.Protobuf.IMessage body, global::Google.Protobuf.JsonTokenizer tokenizer)
        {
        }

        private static object ParseMapKey(global::Google.Protobuf.Reflection.FieldDescriptor field, string keyText)
        {
            return null;
        }

        private static object ParseSingleNumberValue(global::Google.Protobuf.Reflection.FieldDescriptor field, global::Google.Protobuf.JsonToken token)
        {
            return null;
        }

        private static void CheckInteger(double value)
        {
        }

        private static object ParseSingleStringValue(global::Google.Protobuf.Reflection.FieldDescriptor field, string text)
        {
            return null;
        }

        private static global::Google.Protobuf.IMessage NewMessageForField(global::Google.Protobuf.Reflection.FieldDescriptor field)
        {
            return null;
        }

        private static T ParseNumericString<T>(string text, global::System.Func<string, global::System.Globalization.NumberStyles, global::System.IFormatProvider, T> parser)
        {
            return default;
        }

        private static void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN)
        {
        }

        private static void MergeTimestamp(global::Google.Protobuf.IMessage message, global::Google.Protobuf.JsonToken token)
        {
        }

        private static void MergeDuration(global::Google.Protobuf.IMessage message, global::Google.Protobuf.JsonToken token)
        {
        }

        private static void MergeFieldMask(global::Google.Protobuf.IMessage message, global::Google.Protobuf.JsonToken token)
        {
        }

        private static string ToSnakeCase(string text)
        {
            return null;
        }
    }
}