namespace SLLevel
{
    public struct LevelPlayerData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public bool HasStartPos => false;
        public bool IsLegend => false;
        public global::SLLevel.Vector3? StartPosition => null;
        public float Angle => 0f;
        public int Role => 0;
        public global::SLLevel.Vector3? FormationPosition => null;
        public int PropertiesLength => 0;
        public int RunToListLength => 0;
        public int NewRunToListLength => 0;
        public int ForceShootListLength => 0;
        public int PassToListLength => 0;
        public int DribbleToListLength => 0;
        public int StartAnimListLength => 0;
        public int StartAnimEnumListLength => 0;
        public int StartAnimFrame => 0;
        public int SnapToListLength => 0;

        public static global::SLLevel.LevelPlayerData GetRootAsLevelPlayerData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.LevelPlayerData GetRootAsLevelPlayerData(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.LevelPlayerData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.LevelPlayerData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateHasStartPos(bool HasStartPos)
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

        public bool MutateRole(int Role)
        {
            return false;
        }

        public global::SLLevel.PropertyStruct? Properties(int j)
        {
            return null;
        }

        public global::SLLevel.RunToEntry? RunToList(int j)
        {
            return null;
        }

        public global::SLLevel.NewRunToEntry? NewRunToList(int j)
        {
            return null;
        }

        public global::SLLevel.Area? ForceShootList(int j)
        {
            return null;
        }

        public global::SLLevel.PassToEntry? PassToList(int j)
        {
            return null;
        }

        public global::SLLevel.DribbleToEntry? DribbleToList(int j)
        {
            return null;
        }

        public string StartAnimList(int j)
        {
            return null;
        }

        public int StartAnimEnumList(int j)
        {
            return 0;
        }

        public global::System.ArraySegment<byte>? GetStartAnimEnumListBytes()
        {
            return null;
        }

        public int[] GetStartAnimEnumListArray()
        {
            return null;
        }

        public bool MutateStartAnimEnumList(int j, int StartAnimEnumList)
        {
            return false;
        }

        public bool MutateStartAnimFrame(int StartAnimFrame)
        {
            return false;
        }

        public global::SLLevel.SnapToEntry? SnapToList(int j)
        {
            return null;
        }

        public static void StartLevelPlayerData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddHasStartPos(global::FlatBuffers.FlatBufferBuilder builder, bool HasStartPos)
        {
        }

        public static void AddIsLegend(global::FlatBuffers.FlatBufferBuilder builder, bool IsLegend)
        {
        }

        public static void AddStartPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> StartPositionOffset)
        {
        }

        public static void AddAngle(global::FlatBuffers.FlatBufferBuilder builder, float Angle)
        {
        }

        public static void AddRole(global::FlatBuffers.FlatBufferBuilder builder, int Role)
        {
        }

        public static void AddFormationPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> FormationPositionOffset)
        {
        }

        public static void AddProperties(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset PropertiesOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePropertiesVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.PropertyStruct>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePropertiesVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.PropertyStruct>[] data)
        {
            return default;
        }

        public static void StartPropertiesVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddRunToList(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset RunToListOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateRunToListVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.RunToEntry>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateRunToListVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.RunToEntry>[] data)
        {
            return default;
        }

        public static void StartRunToListVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddNewRunToList(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset NewRunToListOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateNewRunToListVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.NewRunToEntry>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateNewRunToListVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.NewRunToEntry>[] data)
        {
            return default;
        }

        public static void StartNewRunToListVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddForceShootList(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset ForceShootListOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateForceShootListVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Area>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateForceShootListVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Area>[] data)
        {
            return default;
        }

        public static void StartForceShootListVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddPassToList(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset PassToListOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreatePassToListVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.PassToEntry>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreatePassToListVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.PassToEntry>[] data)
        {
            return default;
        }

        public static void StartPassToListVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddDribbleToList(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset DribbleToListOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateDribbleToListVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.DribbleToEntry>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateDribbleToListVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.DribbleToEntry>[] data)
        {
            return default;
        }

        public static void StartDribbleToListVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddStartAnimList(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset StartAnimListOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateStartAnimListVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.StringOffset[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateStartAnimListVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.StringOffset[] data)
        {
            return default;
        }

        public static void StartStartAnimListVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddStartAnimEnumList(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset StartAnimEnumListOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateStartAnimEnumListVector(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateStartAnimEnumListVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, int[] data)
        {
            return default;
        }

        public static void StartStartAnimEnumListVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddStartAnimFrame(global::FlatBuffers.FlatBufferBuilder builder, int StartAnimFrame)
        {
        }

        public static void AddSnapToList(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset SnapToListOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateSnapToListVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.SnapToEntry>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateSnapToListVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.SnapToEntry>[] data)
        {
            return default;
        }

        public static void StartSnapToListVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.LevelPlayerData> EndLevelPlayerData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}