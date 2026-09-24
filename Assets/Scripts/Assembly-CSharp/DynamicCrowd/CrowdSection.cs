namespace DynamicCrowd
{
    public struct CrowdSection : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public string Name => null;
        public global::SLLevel.Vector3? PositionOffset => null;
        public global::SLLevel.Vector3? PositionScale => null;
        public int RowsLength => 0;
        public float Density => 0f;
        public short Side => 0;
        public short FriendlySide => 0;
        public short SeatsCount => 0;

        public static global::DynamicCrowd.CrowdSection GetRootAsCrowdSection(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::DynamicCrowd.CrowdSection GetRootAsCrowdSection(global::FlatBuffers.ByteBuffer _bb, global::DynamicCrowd.CrowdSection obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::DynamicCrowd.CrowdSection __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
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

        public global::DynamicCrowd.CrowdRow? Rows(int j)
        {
            return null;
        }

        public static void StartCrowdSection(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddName(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.StringOffset nameOffset)
        {
        }

        public static void AddPositionOffset(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> positionOffsetOffset)
        {
        }

        public static void AddPositionScale(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> positionScaleOffset)
        {
        }

        public static void AddRows(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset rowsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateRowsVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::DynamicCrowd.CrowdRow>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateRowsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::DynamicCrowd.CrowdRow>[] data)
        {
            return default;
        }

        public static void StartRowsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddDensity(global::FlatBuffers.FlatBufferBuilder builder, float density)
        {
        }

        public static void AddSide(global::FlatBuffers.FlatBufferBuilder builder, short side)
        {
        }

        public static void AddFriendlySide(global::FlatBuffers.FlatBufferBuilder builder, short friendlySide)
        {
        }

        public static void AddSeatsCount(global::FlatBuffers.FlatBufferBuilder builder, short seatsCount)
        {
        }

        public static global::FlatBuffers.Offset<global::DynamicCrowd.CrowdSection> EndCrowdSection(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}