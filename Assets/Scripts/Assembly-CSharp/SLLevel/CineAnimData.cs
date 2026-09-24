namespace SLLevel
{
    public struct CineAnimData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public string Name => null;
        public int Id => 0;
        public int Tick => 0;
        public global::SLLevel.Vector3? Position => null;
        public float Angle => 0f;

        public static global::SLLevel.CineAnimData GetRootAsCineAnimData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.CineAnimData GetRootAsCineAnimData(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.CineAnimData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.CineAnimData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public global::System.ArraySegment<byte>? GetNameBytes()
        {
            return null;
        }

        public byte[] GetNameArray()
        {
            return null;
        }

        public bool MutateId(int Id)
        {
            return false;
        }

        public bool MutateTick(int Tick)
        {
            return false;
        }

        public bool MutateAngle(float Angle)
        {
            return false;
        }

        public static void StartCineAnimData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddName(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.StringOffset NameOffset)
        {
        }

        public static void AddId(global::FlatBuffers.FlatBufferBuilder builder, int Id)
        {
        }

        public static void AddTick(global::FlatBuffers.FlatBufferBuilder builder, int Tick)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> PositionOffset)
        {
        }

        public static void AddAngle(global::FlatBuffers.FlatBufferBuilder builder, float Angle)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.CineAnimData> EndCineAnimData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}