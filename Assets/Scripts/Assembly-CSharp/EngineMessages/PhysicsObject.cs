namespace EngineMessages
{
    public struct PhysicsObject : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public int Id => 0;
        public int TransLength => 0;

        public static global::EngineMessages.PhysicsObject GetRootAsPhysicsObject(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::EngineMessages.PhysicsObject GetRootAsPhysicsObject(global::FlatBuffers.ByteBuffer _bb, global::EngineMessages.PhysicsObject obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::EngineMessages.PhysicsObject __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateId(int id)
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

        public static global::FlatBuffers.Offset<global::EngineMessages.PhysicsObject> CreatePhysicsObject(global::FlatBuffers.FlatBufferBuilder builder, int id = 0, global::FlatBuffers.VectorOffset transOffset = default(global::FlatBuffers.VectorOffset))
        {
            return default;
        }

        public static void StartPhysicsObject(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddId(global::FlatBuffers.FlatBufferBuilder builder, int id)
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

        public static global::FlatBuffers.Offset<global::EngineMessages.PhysicsObject> EndPhysicsObject(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}