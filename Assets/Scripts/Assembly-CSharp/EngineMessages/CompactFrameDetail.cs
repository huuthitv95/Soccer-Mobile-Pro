namespace EngineMessages
{
    public struct CompactFrameDetail : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int BallPosRotationLength => 0;
        public int PlayercountLength => 0;
        public int PlayerPosLength => 0;
        public int PlayerRotationLength => 0;
        public int OfficialPosLength => 0;
        public int OfficialRotationLength => 0;
        public int SelectedPlayerIdsLength => 0;
        public ulong MatchTime => 0uL;
        public int GoalNetVerticesLength => 0;
        public global::EngineMessages.ExtraFrameData? Extra => null;

        public static global::EngineMessages.CompactFrameDetail GetRootAsCompactFrameDetail(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::EngineMessages.CompactFrameDetail GetRootAsCompactFrameDetail(global::FlatBuffers.ByteBuffer _bb, global::EngineMessages.CompactFrameDetail obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::EngineMessages.CompactFrameDetail __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public short BallPosRotation(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetBallPosRotationBytes()
        {
            return null;
        }

        public short[] GetBallPosRotationArray()
        {
            return null;
        }

        public bool MutateBallPosRotation(int j, short ballPosRotation)
        {
            return false;
        }

        public sbyte Playercount(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetPlayercountBytes()
        {
            return null;
        }

        public sbyte[] GetPlayercountArray()
        {
            return null;
        }

        public bool MutatePlayercount(int j, sbyte playercount)
        {
            return false;
        }

        public short PlayerPos(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetPlayerPosBytes()
        {
            return null;
        }

        public short[] GetPlayerPosArray()
        {
            return null;
        }

        public bool MutatePlayerPos(int j, short playerPos)
        {
            return false;
        }

        public short PlayerRotation(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetPlayerRotationBytes()
        {
            return null;
        }

        public short[] GetPlayerRotationArray()
        {
            return null;
        }

        public bool MutatePlayerRotation(int j, short playerRotation)
        {
            return false;
        }

        public short OfficialPos(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetOfficialPosBytes()
        {
            return null;
        }

        public short[] GetOfficialPosArray()
        {
            return null;
        }

        public bool MutateOfficialPos(int j, short officialPos)
        {
            return false;
        }

        public short OfficialRotation(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetOfficialRotationBytes()
        {
            return null;
        }

        public short[] GetOfficialRotationArray()
        {
            return null;
        }

        public bool MutateOfficialRotation(int j, short officialRotation)
        {
            return false;
        }

        public sbyte SelectedPlayerIds(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetSelectedPlayerIdsBytes()
        {
            return null;
        }

        public sbyte[] GetSelectedPlayerIdsArray()
        {
            return null;
        }

        public bool MutateSelectedPlayerIds(int j, sbyte selectedPlayerIds)
        {
            return false;
        }

        public bool MutateMatchTime(ulong matchTime)
        {
            return false;
        }

        public float GoalNetVertices(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetGoalNetVerticesBytes()
        {
            return null;
        }

        public float[] GetGoalNetVerticesArray()
        {
            return null;
        }

        public bool MutateGoalNetVertices(int j, float goalNetVertices)
        {
            return false;
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.CompactFrameDetail> CreateCompactFrameDetail(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset ballPosRotationOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset playercountOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset playerPosOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset playerRotationOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset officialPosOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset officialRotationOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset selectedPlayerIdsOffset = default(global::FlatBuffers.VectorOffset), ulong matchTime = 0uL, global::FlatBuffers.VectorOffset goalNetVerticesOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.Offset<global::EngineMessages.ExtraFrameData> extraOffset = default(global::FlatBuffers.Offset<global::EngineMessages.ExtraFrameData>))
        {
            return default;
        }

        public static void StartCompactFrameDetail(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddBallPosRotation(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset ballPosRotationOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateBallPosRotationVector(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateBallPosRotationVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static void StartBallPosRotationVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPlayercount(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset playercountOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePlayercountVector(global::FlatBuffers.FlatBufferBuilder builder, sbyte[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePlayercountVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, sbyte[] data)
        {
            return default;
        }

        public static void StartPlayercountVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPlayerPos(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset playerPosOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerPosVector(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerPosVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static void StartPlayerPosVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPlayerRotation(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset playerRotationOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerRotationVector(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerRotationVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static void StartPlayerRotationVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddOfficialPos(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset officialPosOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialPosVector(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialPosVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static void StartOfficialPosVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddOfficialRotation(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset officialRotationOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialRotationVector(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialRotationVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, short[] data)
        {
            return default;
        }

        public static void StartOfficialRotationVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddSelectedPlayerIds(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset selectedPlayerIdsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateSelectedPlayerIdsVector(global::FlatBuffers.FlatBufferBuilder builder, sbyte[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateSelectedPlayerIdsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, sbyte[] data)
        {
            return default;
        }

        public static void StartSelectedPlayerIdsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddMatchTime(global::FlatBuffers.FlatBufferBuilder builder, ulong matchTime)
        {
        }

        public static void AddGoalNetVertices(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset goalNetVerticesOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateGoalNetVerticesVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateGoalNetVerticesVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartGoalNetVerticesVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddExtra(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.ExtraFrameData> extraOffset)
        {
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.CompactFrameDetail> EndCompactFrameDetail(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }

        public static void FinishCompactFrameDetailBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.CompactFrameDetail> offset)
        {
        }

        public static void FinishSizePrefixedCompactFrameDetailBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.CompactFrameDetail> offset)
        {
        }
    }
}