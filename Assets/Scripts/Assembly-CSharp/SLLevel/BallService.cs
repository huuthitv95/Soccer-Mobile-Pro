namespace SLLevel
{
    public struct BallService : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int PositionsLength => 0;
        public int DestinationsLength => 0;
        public int PowersLength => 0;
        public int DelaysLength => 0;
        public int IndicesLength => 0;
        public int Duration => 0;

        public static global::SLLevel.BallService GetRootAsBallService(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.BallService GetRootAsBallService(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.BallService obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.BallService __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public float Positions(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetPositionsBytes()
        {
            return null;
        }

        public float[] GetPositionsArray()
        {
            return null;
        }

        public bool MutatePositions(int j, float Positions)
        {
            return false;
        }

        public float Destinations(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetDestinationsBytes()
        {
            return null;
        }

        public float[] GetDestinationsArray()
        {
            return null;
        }

        public bool MutateDestinations(int j, float Destinations)
        {
            return false;
        }

        public float Powers(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetPowersBytes()
        {
            return null;
        }

        public float[] GetPowersArray()
        {
            return null;
        }

        public bool MutatePowers(int j, float Powers)
        {
            return false;
        }

        public int Delays(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetDelaysBytes()
        {
            return null;
        }

        public int[] GetDelaysArray()
        {
            return null;
        }

        public bool MutateDelays(int j, int Delays)
        {
            return false;
        }

        public int Indices(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetIndicesBytes()
        {
            return null;
        }

        public int[] GetIndicesArray()
        {
            return null;
        }

        public bool MutateIndices(int j, int Indices)
        {
            return false;
        }

        public bool MutateDuration(int Duration)
        {
            return false;
        }

        public static global::FlatBuffers.Offset<global::SLLevel.BallService> CreateBallService(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset PositionsOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset DestinationsOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset PowersOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset DelaysOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset IndicesOffset = default(global::FlatBuffers.VectorOffset), int Duration = 0)
        {
            return default;
        }

        public static void StartBallService(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddPositions(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset PositionsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePositionsVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePositionsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartPositionsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddDestinations(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset DestinationsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateDestinationsVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateDestinationsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartDestinationsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPowers(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset PowersOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePowersVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePowersVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartPowersVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddDelays(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset DelaysOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateDelaysVector(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateDelaysVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static void StartDelaysVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddIndices(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset IndicesOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateIndicesVector(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateIndicesVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static void StartIndicesVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddDuration(global::FlatBuffers.FlatBufferBuilder builder, int Duration)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.BallService> EndBallService(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}