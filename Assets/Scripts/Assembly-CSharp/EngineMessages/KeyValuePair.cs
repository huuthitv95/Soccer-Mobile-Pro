namespace EngineMessages
{
    public struct KeyValuePair : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public string Key => null;
        public string Val => null;

        public static global::EngineMessages.KeyValuePair GetRootAsKeyValuePair(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::EngineMessages.KeyValuePair GetRootAsKeyValuePair(global::FlatBuffers.ByteBuffer _bb, global::EngineMessages.KeyValuePair obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::EngineMessages.KeyValuePair __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public global::System.ArraySegment<byte>? GetKeyBytes()
        {
            return null;
        }

        public byte[] GetKeyArray()
        {
            return null;
        }

        public global::System.ArraySegment<byte>? GetValBytes()
        {
            return null;
        }

        public byte[] GetValArray()
        {
            return null;
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.KeyValuePair> CreateKeyValuePair(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.StringOffset keyOffset = default(global::FlatBuffers.StringOffset), global::FlatBuffers.StringOffset valOffset = default(global::FlatBuffers.StringOffset))
        {
            return default;
        }

        public static void StartKeyValuePair(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddKey(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.StringOffset keyOffset)
        {
        }

        public static void AddVal(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.StringOffset valOffset)
        {
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.KeyValuePair> EndKeyValuePair(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}