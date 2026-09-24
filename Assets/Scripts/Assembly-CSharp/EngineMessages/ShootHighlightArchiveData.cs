namespace EngineMessages
{
    public struct ShootHighlightArchiveData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int HomeJersey => 0;
        public int AwayJersey => 0;
        public int PlayersLength => 0;
        public int ShootPlayerIdx => 0;
        public float ShootPosX => 0f;
        public float ShootPosY => 0f;
        public float ShootPosZ => 0f;
        public int FramesLength => 0;
        public int PlayersStateLength => 0;

        public static global::EngineMessages.ShootHighlightArchiveData GetRootAsShootHighlightArchiveData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::EngineMessages.ShootHighlightArchiveData GetRootAsShootHighlightArchiveData(global::FlatBuffers.ByteBuffer _bb, global::EngineMessages.ShootHighlightArchiveData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::EngineMessages.ShootHighlightArchiveData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateHomeJersey(int homeJersey)
        {
            return false;
        }

        public bool MutateAwayJersey(int awayJersey)
        {
            return false;
        }

        public int Players(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetPlayersBytes()
        {
            return null;
        }

        public int[] GetPlayersArray()
        {
            return null;
        }

        public bool MutatePlayers(int j, int players)
        {
            return false;
        }

        public bool MutateShootPlayerIdx(int shootPlayerIdx)
        {
            return false;
        }

        public bool MutateShootPosX(float shootPosX)
        {
            return false;
        }

        public bool MutateShootPosY(float shootPosY)
        {
            return false;
        }

        public bool MutateShootPosZ(float shootPosZ)
        {
            return false;
        }

        public global::EngineMessages.CompactFrameDetail? Frames(int j)
        {
            return null;
        }

        public int PlayersState(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetPlayersStateBytes()
        {
            return null;
        }

        public int[] GetPlayersStateArray()
        {
            return null;
        }

        public bool MutatePlayersState(int j, int playersState)
        {
            return false;
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.ShootHighlightArchiveData> CreateShootHighlightArchiveData(global::FlatBuffers.FlatBufferBuilder builder, int homeJersey = 0, int awayJersey = 0, global::FlatBuffers.VectorOffset playersOffset = default(global::FlatBuffers.VectorOffset), int shootPlayerIdx = 0, float shootPosX = 0f, float shootPosY = 0f, float shootPosZ = 0f, global::FlatBuffers.VectorOffset framesOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset playersStateOffset = default(global::FlatBuffers.VectorOffset))
        {
            return default;
        }

        public static void StartShootHighlightArchiveData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddHomeJersey(global::FlatBuffers.FlatBufferBuilder builder, int homeJersey)
        {
        }

        public static void AddAwayJersey(global::FlatBuffers.FlatBufferBuilder builder, int awayJersey)
        {
        }

        public static void AddPlayers(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset playersOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePlayersVector(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePlayersVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static void StartPlayersVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddShootPlayerIdx(global::FlatBuffers.FlatBufferBuilder builder, int shootPlayerIdx)
        {
        }

        public static void AddShootPosX(global::FlatBuffers.FlatBufferBuilder builder, float shootPosX)
        {
        }

        public static void AddShootPosY(global::FlatBuffers.FlatBufferBuilder builder, float shootPosY)
        {
        }

        public static void AddShootPosZ(global::FlatBuffers.FlatBufferBuilder builder, float shootPosZ)
        {
        }

        public static void AddFrames(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset framesOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateFramesVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.CompactFrameDetail>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateFramesVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.CompactFrameDetail>[] data)
        {
            return default;
        }

        public static void StartFramesVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPlayersState(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset playersStateOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePlayersStateVector(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePlayersStateVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static void StartPlayersStateVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.ShootHighlightArchiveData> EndShootHighlightArchiveData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}