namespace DynamicCrowd
{
    public struct CrowdData : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int SectionsLength => 0;

        public static global::DynamicCrowd.CrowdData GetRootAsCrowdData(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::DynamicCrowd.CrowdData GetRootAsCrowdData(global::FlatBuffers.ByteBuffer _bb, global::DynamicCrowd.CrowdData obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::DynamicCrowd.CrowdData __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public global::DynamicCrowd.CrowdSection? Sections(int j)
        {
            return null;
        }

        public static global::FlatBuffers.Offset<global::DynamicCrowd.CrowdData> CreateCrowdData(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset sectionsOffset = default(global::FlatBuffers.VectorOffset))
        {
            return default;
        }

        public static void StartCrowdData(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddSections(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset sectionsOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateSectionsVector(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::DynamicCrowd.CrowdSection>[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateSectionsVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::DynamicCrowd.CrowdSection>[] data)
        {
            return default;
        }

        public static void StartSectionsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static global::FlatBuffers.Offset<global::DynamicCrowd.CrowdData> EndCrowdData(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }

        public static void FinishCrowdDataBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::DynamicCrowd.CrowdData> offset)
        {
        }

        public static void FinishSizePrefixedCrowdDataBuffer(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::DynamicCrowd.CrowdData> offset)
        {
        }
    }
}