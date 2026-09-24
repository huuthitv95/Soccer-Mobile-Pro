namespace SLLevel
{
    public struct OperatorTool : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int Id => 0;
        public global::SLLevel.Vector3? Position => null;
        public global::SLLevel.Vector3? Rotation => null;
        public float Param => 0f;
        public global::SLLevel.OperatorType OperatorType => global::SLLevel.OperatorType.Addition;
        public int OperatorValue => 0;

        public static global::SLLevel.OperatorTool GetRootAsOperatorTool(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.OperatorTool GetRootAsOperatorTool(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.OperatorTool obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.OperatorTool __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateId(int id)
        {
            return false;
        }

        public bool MutateParam(float param)
        {
            return false;
        }

        public bool MutateOperatorType(global::SLLevel.OperatorType operatorType)
        {
            return false;
        }

        public bool MutateOperatorValue(int operatorValue)
        {
            return false;
        }

        public static void StartOperatorTool(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddId(global::FlatBuffers.FlatBufferBuilder builder, int id)
        {
        }

        public static void AddPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> positionOffset)
        {
        }

        public static void AddRotation(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector3> rotationOffset)
        {
        }

        public static void AddParam(global::FlatBuffers.FlatBufferBuilder builder, float param)
        {
        }

        public static void AddOperatorType(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.OperatorType operatorType)
        {
        }

        public static void AddOperatorValue(global::FlatBuffers.FlatBufferBuilder builder, int operatorValue)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.OperatorTool> EndOperatorTool(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}