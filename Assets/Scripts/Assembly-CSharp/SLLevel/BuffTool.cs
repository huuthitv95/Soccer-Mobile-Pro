namespace SLLevel
{
    public struct BuffTool : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::SLLevel.Vector3? Position => null;
        public global::SLLevel.BuffType BuffType => global::SLLevel.BuffType.Power;

        public static global::SLLevel.BuffTool GetRootAsBuffTool(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.BuffTool GetRootAsBuffTool(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.BuffTool obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.BuffTool __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateBuffType(global::SLLevel.BuffType buffType)
        {
            return false;
        }

        public static void StartBuffTool(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> positionOffset)
        {
        }

        public static void AddBuffType(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.BuffType buffType)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.BuffTool> EndBuffTool(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}