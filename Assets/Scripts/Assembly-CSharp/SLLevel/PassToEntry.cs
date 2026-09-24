namespace SLLevel
{
    public struct PassToEntry : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int Id => 0;
        public global::SLLevel.Area? TriggerArea => null;
        public global::SLLevel.Vector3? Position => null;

        public static global::SLLevel.PassToEntry GetRootAsPassToEntry(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.PassToEntry GetRootAsPassToEntry(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.PassToEntry obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.PassToEntry __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateId(int Id)
        {
            return false;
        }

        public static void StartPassToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddId(global::FlatBuffers.FlatBufferBuilder builder, int Id)
        {
        }

        public static void AddTriggerArea(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Area> TriggerAreaOffset)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> PositionOffset)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.PassToEntry> EndPassToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}