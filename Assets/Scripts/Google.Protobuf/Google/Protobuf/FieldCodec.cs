namespace Google.Protobuf
{
    public static class FieldCodec
    {
        public static global::Google.Protobuf.FieldCodec<string> ForString(uint tag)
        {
            return null;
        }

        public static global::Google.Protobuf.FieldCodec<bool> ForBool(uint tag)
        {
            return null;
        }

        public static global::Google.Protobuf.FieldCodec<int> ForInt32(uint tag)
        {
            return null;
        }

        public static global::Google.Protobuf.FieldCodec<float> ForFloat(uint tag)
        {
            return null;
        }

        public static global::Google.Protobuf.FieldCodec<T> ForEnum<T>(uint tag, global::System.Func<T, int> toInt32, global::System.Func<int, T> fromInt32)
        {
            return null;
        }

        public static global::Google.Protobuf.FieldCodec<T> ForMessage<T>(uint tag, global::Google.Protobuf.MessageParser<T> parser)
            where T : global::Google.Protobuf.IMessage<T>
        {
            return null;
        }
    }

    public sealed class FieldCodec<T>
    {
        private static readonly global::System.Collections.Generic.EqualityComparer<T> EqualityComparer;
        private static readonly T DefaultDefault;
        private static readonly bool TypeSupportsPacking;
        private readonly int tagSize;
        internal bool PackedRepeatedField { get; }
        internal global::System.Action<global::Google.Protobuf.CodedOutputStream, T> ValueWriter { get; }
        internal global::System.Func<T, int> ValueSizeCalculator { get; }
        internal global::System.Func<global::Google.Protobuf.CodedInputStream, T> ValueReader { get; }
        internal int FixedSize { get; }
        internal uint Tag { get; }
        internal T DefaultValue { get; }

        static FieldCodec()
        {
        }

        internal static bool IsPackedRepeatedField(uint tag)
        {
            return false;
        }

        internal FieldCodec(global::System.Func<global::Google.Protobuf.CodedInputStream, T> reader, global::System.Action<global::Google.Protobuf.CodedOutputStream, T> writer, global::System.Func<T, int> sizeCalculator, uint tag)
        {
        }

        internal FieldCodec(global::System.Func<global::Google.Protobuf.CodedInputStream, T> reader, global::System.Action<global::Google.Protobuf.CodedOutputStream, T> writer, global::System.Func<T, int> sizeCalculator, uint tag, T defaultValue)
        {
        }

        public void WriteTagAndValue(global::Google.Protobuf.CodedOutputStream output, T value)
        {
        }

        public T Read(global::Google.Protobuf.CodedInputStream input)
        {
            return default;
        }

        public int CalculateSizeWithTag(T value)
        {
            return 0;
        }

        private bool IsDefault(T value)
        {
            return false;
        }
    }
}