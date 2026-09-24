namespace SLLevel
{
    public struct DribbleToEntry : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::SLLevel.Vector3? Position => null;
        public global::SLLevel.Area? TriggerArea => null;

        public static global::SLLevel.DribbleToEntry GetRootAsDribbleToEntry(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.DribbleToEntry GetRootAsDribbleToEntry(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.DribbleToEntry obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.DribbleToEntry __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static void StartDribbleToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> PositionOffset)
        {
        }

        public static void AddTriggerArea(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Area> TriggerAreaOffset)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.DribbleToEntry> EndDribbleToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}