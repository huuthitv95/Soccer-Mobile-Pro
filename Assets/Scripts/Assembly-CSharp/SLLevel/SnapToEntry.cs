namespace SLLevel
{
    public struct SnapToEntry : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::SLLevel.Vector3? Position => null;
        public global::SLLevel.Area? TriggerArea => null;

        public static global::SLLevel.SnapToEntry GetRootAsSnapToEntry(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.SnapToEntry GetRootAsSnapToEntry(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.SnapToEntry obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.SnapToEntry __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static void StartSnapToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> PositionOffset)
        {
        }

        public static void AddTriggerArea(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Area> TriggerAreaOffset)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.SnapToEntry> EndSnapToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}