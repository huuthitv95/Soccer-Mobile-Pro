namespace SLLevel
{
    public struct CineData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int TotalTick => 0;
        public bool Offside => false;
        public global::SLLevel.Vector3? BallPosition => null;
        public int BallTouchesLength => 0;
        public int Team1DatabaseId => 0;
        public int Team2DatabaseId => 0;
        public int Team1PlayersLength => 0;
        public int Team2PlayersLength => 0;
        public int OfficialsLength => 0;
        public int SfxLength => 0;
        public int HeroId => 0;
        public global::SLLevel.Vector3? CineCameraPos => null;
        public float CineCameraFOV => 0f;

        public static global::SLLevel.CineData GetRootAsCineData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.CineData GetRootAsCineData(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.CineData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.CineData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateTotalTick(int TotalTick)
        {
            return false;
        }

        public bool MutateOffside(bool Offside)
        {
            return false;
        }

        public global::SLLevel.CineBallTouchData? BallTouches(int j)
        {
            return null;
        }

        public bool MutateTeam1DatabaseId(int Team1DatabaseId)
        {
            return false;
        }

        public bool MutateTeam2DatabaseId(int Team2DatabaseId)
        {
            return false;
        }

        public global::SLLevel.CinePlayerData? Team1Players(int j)
        {
            return null;
        }

        public global::SLLevel.CinePlayerData? Team2Players(int j)
        {
            return null;
        }

        public global::SLLevel.CinePlayerData? Officials(int j)
        {
            return null;
        }

        public global::SLLevel.CineSfxData? Sfx(int j)
        {
            return null;
        }

        public bool MutateHeroId(int HeroId)
        {
            return false;
        }

        public bool MutateCineCameraFOV(float CineCameraFOV)
        {
            return false;
        }

        public static void StartCineData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddTotalTick(global::FlatBuffers.FlatBufferBuilder builder, int TotalTick)
        {
        }

        public static void AddOffside(global::FlatBuffers.FlatBufferBuilder builder, bool Offside)
        {
        }

        public static void AddBallPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> BallPositionOffset)
        {
        }

        public static void AddBallTouches(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset BallTouchesOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateBallTouchesVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CineBallTouchData>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateBallTouchesVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CineBallTouchData>[] data)
        {
            return default;
        }

        public static void StartBallTouchesVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddTeam1DatabaseId(global::FlatBuffers.FlatBufferBuilder builder, int Team1DatabaseId)
        {
        }

        public static void AddTeam2DatabaseId(global::FlatBuffers.FlatBufferBuilder builder, int Team2DatabaseId)
        {
        }

        public static void AddTeam1Players(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset Team1PlayersOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateTeam1PlayersVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CinePlayerData>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateTeam1PlayersVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CinePlayerData>[] data)
        {
            return default;
        }

        public static void StartTeam1PlayersVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddTeam2Players(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset Team2PlayersOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateTeam2PlayersVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CinePlayerData>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateTeam2PlayersVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CinePlayerData>[] data)
        {
            return default;
        }

        public static void StartTeam2PlayersVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddOfficials(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset OfficialsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialsVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CinePlayerData>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CinePlayerData>[] data)
        {
            return default;
        }

        public static void StartOfficialsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddSfx(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset SfxOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateSfxVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CineSfxData>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateSfxVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CineSfxData>[] data)
        {
            return default;
        }

        public static void StartSfxVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddHeroId(global::FlatBuffers.FlatBufferBuilder builder, int HeroId)
        {
        }

        public static void AddCineCameraPos(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> CineCameraPosOffset)
        {
        }

        public static void AddCineCameraFOV(global::FlatBuffers.FlatBufferBuilder builder, float CineCameraFOV)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.CineData> EndCineData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }

        public static void FinishCineDataBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CineData> offset)
        {
        }

        public static void FinishSizePrefixedCineDataBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.CineData> offset)
        {
        }
    }
}