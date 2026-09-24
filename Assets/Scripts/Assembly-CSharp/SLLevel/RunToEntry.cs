namespace SLLevel
{
    public struct RunToEntry : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public float Velocity => 0f;
        public global::SLLevel.Area? TriggerArea => null;

        public static global::SLLevel.RunToEntry GetRootAsRunToEntry(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.RunToEntry GetRootAsRunToEntry(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.RunToEntry obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.RunToEntry __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateVelocity(float Velocity)
        {
            return false;
        }

        public static global::FlatBuffers.Offset<global::SLLevel.RunToEntry> CreateRunToEntry(global::FlatBuffers.FlatBufferBuilder builder, float Velocity = -1f, global::FlatBuffers.Offset<global::SLLevel.Area> TriggerAreaOffset = default(global::FlatBuffers.Offset<global::SLLevel.Area>))
        {
            return default;
        }

        public static void StartRunToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddVelocity(global::FlatBuffers.FlatBufferBuilder builder, float Velocity)
        {
        }

        public static void AddTriggerArea(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Area> TriggerAreaOffset)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.RunToEntry> EndRunToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}