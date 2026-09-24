namespace SLLevel
{
    public struct Area : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public float Xmin => 0f;
        public float Xmax => 0f;
        public float Ymin => 0f;
        public float Ymax => 0f;

        public static global::SLLevel.Area GetRootAsArea(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.Area GetRootAsArea(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.Area obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.Area __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateXmin(float xmin)
        {
            return false;
        }

        public bool MutateXmax(float xmax)
        {
            return false;
        }

        public bool MutateYmin(float ymin)
        {
            return false;
        }

        public bool MutateYmax(float ymax)
        {
            return false;
        }

        public static global::FlatBuffers.Offset<global::SLLevel.Area> CreateArea(global::FlatBuffers.FlatBufferBuilder builder, float xmin = -55f, float xmax = 55f, float ymin = -36f, float ymax = 36f)
        {
            return default;
        }

        public static void StartArea(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddXmin(global::FlatBuffers.FlatBufferBuilder builder, float xmin)
        {
        }

        public static void AddXmax(global::FlatBuffers.FlatBufferBuilder builder, float xmax)
        {
        }

        public static void AddYmin(global::FlatBuffers.FlatBufferBuilder builder, float ymin)
        {
        }

        public static void AddYmax(global::FlatBuffers.FlatBufferBuilder builder, float ymax)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.Area> EndArea(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}