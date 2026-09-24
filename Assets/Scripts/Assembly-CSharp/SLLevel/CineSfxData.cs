namespace SLLevel
{
    public struct CineSfxData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int Tick => 0;
        public int OpCode => 0;

        public static global::SLLevel.CineSfxData GetRootAsCineSfxData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.CineSfxData GetRootAsCineSfxData(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.CineSfxData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.CineSfxData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateTick(int Tick)
        {
            return false;
        }

        public bool MutateOpCode(int OpCode)
        {
            return false;
        }

        public static global::FlatBuffers.Offset<global::SLLevel.CineSfxData> CreateCineSfxData(global::FlatBuffers.FlatBufferBuilder builder, int Tick = 0, int OpCode = 0)
        {
            return default;
        }

        public static void StartCineSfxData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddTick(global::FlatBuffers.FlatBufferBuilder builder, int Tick)
        {
        }

        public static void AddOpCode(global::FlatBuffers.FlatBufferBuilder builder, int OpCode)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.CineSfxData> EndCineSfxData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}