namespace SLLevel
{
    public struct CollisoinShape : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::SLLevel.CollisionShapeType Type => global::SLLevel.CollisionShapeType.Box;
        public int ParametersLength => 0;
        public int TransLength => 0;

        public static global::SLLevel.CollisoinShape GetRootAsCollisoinShape(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.CollisoinShape GetRootAsCollisoinShape(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.CollisoinShape obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.CollisoinShape __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateType(global::SLLevel.CollisionShapeType type)
        {
            return false;
        }

        public float Parameters(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetParametersBytes()
        {
            return null;
        }

        public float[] GetParametersArray()
        {
            return null;
        }

        public bool MutateParameters(int j, float parameters)
        {
            return false;
        }

        public float Trans(int j)
        {
            return 0f;
        }

        public global::System.ArraySegment<byte>? GetTransBytes()
        {
            return null;
        }

        public float[] GetTransArray()
        {
            return null;
        }

        public bool MutateTrans(int j, float trans)
        {
            return false;
        }

        public static global::FlatBuffers.Offset<global::SLLevel.CollisoinShape> CreateCollisoinShape(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.CollisionShapeType type = global::SLLevel.CollisionShapeType.Box, global::FlatBuffers.VectorOffset parametersOffset = default(global::FlatBuffers.VectorOffset), global::FlatBuffers.VectorOffset transOffset = default(global::FlatBuffers.VectorOffset))
        {
            return default;
        }

        public static void StartCollisoinShape(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddType(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.CollisionShapeType type)
        {
        }

        public static void AddParameters(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset parametersOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateParametersVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateParametersVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartParametersVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static void AddTrans(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset transOffset)
        {
        }

        public static global::FlatBuffers.VectorOffset CreateTransVector(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static global::FlatBuffers.VectorOffset CreateTransVectorBlock(global::FlatBuffers.FlatBufferBuilder builder, float[] data)
        {
            return default;
        }

        public static void StartTransVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.CollisoinShape> EndCollisoinShape(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}