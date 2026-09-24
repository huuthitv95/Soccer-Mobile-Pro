namespace SLLevel
{
    public struct CineBallTouchData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int Tick => 0;
        public global::SLLevel.Vector3? Position => null;
        public global::SLLevel.Vector3? Momentum => null;
        public global::SLLevel.Vector3? Rotation => null;
        public float Bias => 0f;

        public static global::SLLevel.CineBallTouchData GetRootAsCineBallTouchData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.CineBallTouchData GetRootAsCineBallTouchData(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.CineBallTouchData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.CineBallTouchData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateTick(int Tick)
        {
            return false;
        }

        public bool MutateBias(float Bias)
        {
            return false;
        }

        public static void StartCineBallTouchData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddTick(global::FlatBuffers.FlatBufferBuilder builder, int Tick)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> PositionOffset)
        {
        }

        public static void AddMomentum(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> MomentumOffset)
        {
        }

        public static void AddRotation(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> RotationOffset)
        {
        }

        public static void AddBias(global::FlatBuffers.FlatBufferBuilder builder, float Bias)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.CineBallTouchData> EndCineBallTouchData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}