namespace SLLevel
{
    public struct CinePlayerData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int Id => 0;
        public bool IsLegend => false;
        public global::SLLevel.Vector3? Position => null;
        public float Angle => 0f;
        public int AnimListLength => 0;
        public int StartAnimFrame => 0;

        public static global::SLLevel.CinePlayerData GetRootAsCinePlayerData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.CinePlayerData GetRootAsCinePlayerData(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.CinePlayerData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.CinePlayerData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateId(int Id)
        {
            return false;
        }

        public bool MutateIsLegend(bool IsLegend)
        {
            return false;
        }

        public bool MutateAngle(float Angle)
        {
            return false;
        }

        public global::SLLevel.CineAnimData? AnimList(int j)
        {
            return null;
        }

        public bool MutateStartAnimFrame(int StartAnimFrame)
        {
            return false;
        }

        public static void StartCinePlayerData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddId(global::FlatBuffers.FlatBufferBuilder builder, int Id)
        {
        }

        public static void AddIsLegend(global::FlatBuffers.FlatBufferBuilder builder, bool IsLegend)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> PositionOffset)
        {
        }

        public static void AddAngle(global::FlatBuffers.FlatBufferBuilder builder, float Angle)
        {
        }

        public static void AddAnimList(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset AnimListOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateAnimListVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CineAnimData>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateAnimListVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CineAnimData>[] data)
        {
            return default;
        }

        public static void StartAnimListVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddStartAnimFrame(global::FlatBuffers.FlatBufferBuilder builder, int StartAnimFrame)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.CinePlayerData> EndCinePlayerData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}