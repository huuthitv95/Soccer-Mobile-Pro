namespace SLLevel
{
    public struct GolfTarget : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::SLLevel.Vector3? Position => null;
        public int RadiusLength => 0;

        public static global::SLLevel.GolfTarget GetRootAsGolfTarget(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.GolfTarget GetRootAsGolfTarget(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.GolfTarget obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.GolfTarget __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public float Radius(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetRadiusBytes()
        {
            return null;
        }

        public float[] GetRadiusArray()
        {
            return null;
        }

        public bool MutateRadius(int j, float Radius)
        {
            return false;
        }

        public static void StartGolfTarget(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> PositionOffset)
        {
        }

        public static void AddRadius(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset RadiusOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateRadiusVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateRadiusVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartRadiusVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.GolfTarget> EndGolfTarget(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}