namespace EngineMessages
{
    public struct FrameDetail : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int BallPosRotationLength => 0;
        public int PlayercountLength => 0;
        public int PlayerPosLength => 0;
        public int PlayerRotationLength => 0;
        public int PlayerAnimFrameLength => 0;
        public int OfficialPosLength => 0;
        public int OfficialRotationLength => 0;
        public int SelectedPlayerIdsLength => 0;
        public ulong MatchTime => 0uL;
        public int GoalNetVerticesLength => 0;
        public int FrameCount => 0;
        public bool BallTouchNet => false;
        public global::EngineMessages.DebugInfo? DebugInfo => null;
        public int DebugsLength => 0;
        public int PhysicsObjsLength => 0;

        public static global::EngineMessages.FrameDetail GetRootAsFrameDetail(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::EngineMessages.FrameDetail GetRootAsFrameDetail(global::FlatBuffers.ByteBuffer _bb, global::EngineMessages.FrameDetail obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::EngineMessages.FrameDetail __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public float BallPosRotation(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetBallPosRotationBytes()
        {
            return null;
        }

        public float[] GetBallPosRotationArray()
        {
            return null;
        }

        public bool MutateBallPosRotation(int j, float ballPosRotation)
        {
            return false;
        }

        public int Playercount(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetPlayercountBytes()
        {
            return null;
        }

        public int[] GetPlayercountArray()
        {
            return null;
        }

        public bool MutatePlayercount(int j, int playercount)
        {
            return false;
        }

        public float PlayerPos(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetPlayerPosBytes()
        {
            return null;
        }

        public float[] GetPlayerPosArray()
        {
            return null;
        }

        public bool MutatePlayerPos(int j, float playerPos)
        {
            return false;
        }

        public float PlayerRotation(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetPlayerRotationBytes()
        {
            return null;
        }

        public float[] GetPlayerRotationArray()
        {
            return null;
        }

        public bool MutatePlayerRotation(int j, float playerRotation)
        {
            return false;
        }

        public int PlayerAnimFrame(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetPlayerAnimFrameBytes()
        {
            return null;
        }

        public int[] GetPlayerAnimFrameArray()
        {
            return null;
        }

        public bool MutatePlayerAnimFrame(int j, int playerAnimFrame)
        {
            return false;
        }

        public float OfficialPos(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetOfficialPosBytes()
        {
            return null;
        }

        public float[] GetOfficialPosArray()
        {
            return null;
        }

        public bool MutateOfficialPos(int j, float officialPos)
        {
            return false;
        }

        public float OfficialRotation(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetOfficialRotationBytes()
        {
            return null;
        }

        public float[] GetOfficialRotationArray()
        {
            return null;
        }

        public bool MutateOfficialRotation(int j, float officialRotation)
        {
            return false;
        }

        public int SelectedPlayerIds(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetSelectedPlayerIdsBytes()
        {
            return null;
        }

        public int[] GetSelectedPlayerIdsArray()
        {
            return null;
        }

        public bool MutateSelectedPlayerIds(int j, int selectedPlayerIds)
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

        public bool MutateFrameCount(int frameCount)
        {
            return false;
        }

        public bool MutateBallTouchNet(bool ballTouchNet)
        {
            return false;
        }

        public global::EngineMessages.KeyValuePair? Debugs(int j)
        {
            return null;
        }

        public global::EngineMessages.PhysicsObject? PhysicsObjs(int j)
        {
            return null;
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.FrameDetail> CreateFrameDetail(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset ballPosRotationOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset playercountOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset playerPosOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset playerRotationOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset playerAnimFrameOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset officialPosOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset officialRotationOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset selectedPlayerIdsOffset = default(global::FlatBuffers.VectorOffset), ulong matchTime = 0uL, global::FlatBuffers.VectorOffset goalNetVerticesOffset = default(global::FlatBuffers.VectorOffset), int frameCount = 0, bool ballTouchNet = false, global::FlatBuffers.Offset<global::EngineMessages.DebugInfo> debugInfoOffset = default(global::FlatBuffers.Offset<global::EngineMessages.DebugInfo>), global::FlatBuffers.VectorOffset debugsOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset physicsObjsOffset = default(global::FlatBuffers.VectorOffset))
        {
            return default;
        }

        public static void StartFrameDetail(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddBallPosRotation(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset ballPosRotationOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateBallPosRotationVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateBallPosRotationVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartBallPosRotationVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPlayercount(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset playercountOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePlayercountVector(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePlayercountVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static void StartPlayercountVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPlayerPos(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset playerPosOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerPosVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerPosVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartPlayerPosVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPlayerRotation(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset playerRotationOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerRotationVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerRotationVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartPlayerRotationVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPlayerAnimFrame(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset playerAnimFrameOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerAnimFrameVector(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePlayerAnimFrameVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static void StartPlayerAnimFrameVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddOfficialPos(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset officialPosOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialPosVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialPosVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartOfficialPosVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddOfficialRotation(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset officialRotationOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialRotationVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateOfficialRotationVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartOfficialRotationVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddSelectedPlayerIds(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset selectedPlayerIdsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateSelectedPlayerIdsVector(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateSelectedPlayerIdsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
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

        public static void AddFrameCount(global::FlatBuffers.FlatBufferBuilder builder, int frameCount)
        {
        }

        public static void AddBallTouchNet(global::FlatBuffers.FlatBufferBuilder builder, bool ballTouchNet)
        {
        }

        public static void AddDebugInfo(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.DebugInfo> debugInfoOffset)
        {
        }

        public static void AddDebugs(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset debugsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateDebugsVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.KeyValuePair>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateDebugsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.KeyValuePair>[] data)
        {
            return default;
        }

        public static void StartDebugsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPhysicsObjs(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset physicsObjsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePhysicsObjsVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.PhysicsObject>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePhysicsObjsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.PhysicsObject>[] data)
        {
            return default;
        }

        public static void StartPhysicsObjsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static global::FlatBuffers.Offset<global::EngineMessages.FrameDetail> EndFrameDetail(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }

        public static void FinishFrameDetailBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.FrameDetail> offset)
        {
        }

        public static void FinishSizePrefixedFrameDetailBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::EngineMessages.FrameDetail> offset)
        {
        }
    }
}