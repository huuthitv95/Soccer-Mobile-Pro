namespace EngineMessages
{
    public struct ExtraFrameData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int OpcodeLength => 0;
        public sbyte EventType => 0;

        public static global::EngineMessages.ExtraFrameData GetRootAsExtraFrameData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::EngineMessages.ExtraFrameData GetRootAsExtraFrameData(global::FlatBuffers.ByteBuffer _bb, global::EngineMessages.ExtraFrameData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::EngineMessages.ExtraFrameData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public int Opcode(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetOpcodeBytes()
        {
            return null;
        }

        public int[] GetOpcodeArray()
        {
            return null;
        }

        public bool MutateOpcode(int j, int opcode)
        {
            return false;
        }

        public bool MutateEventType(sbyte eventType)
        {
            return false;
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.ExtraFrameData> CreateExtraFrameData(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset opcodeOffset = default(global::FlatBuffers.VectorOffset), sbyte eventType = 0)
        {
            return default;
        }

        public static void StartExtraFrameData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddOpcode(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset opcodeOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateOpcodeVector(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateOpcodeVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static void StartOpcodeVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddEventType(global::FlatBuffers.FlatBufferBuilder builder, sbyte eventType)
        {
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.ExtraFrameData> EndExtraFrameData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}