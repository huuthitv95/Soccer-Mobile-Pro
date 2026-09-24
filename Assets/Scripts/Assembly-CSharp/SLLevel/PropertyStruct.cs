namespace SLLevel
{
    public struct PropertyStruct : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::SLLevel.PlayerProperty Key => global::SLLevel.PlayerProperty.physical_balance;
        public float Value => 0f;

        public static global::SLLevel.PropertyStruct GetRootAsPropertyStruct(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.PropertyStruct GetRootAsPropertyStruct(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.PropertyStruct obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.PropertyStruct __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateKey(global::SLLevel.PlayerProperty Key)
        {
            return false;
        }

        public bool MutateValue(float Value)
        {
            return false;
        }

        public static global::FlatBuffers.Offset<global::SLLevel.PropertyStruct> CreatePropertyStruct(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.PlayerProperty Key = global::SLLevel.PlayerProperty.physical_balance, float Value = 0f)
        {
            return default;
        }

        public static void StartPropertyStruct(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddKey(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.PlayerProperty Key)
        {
        }

        public static void AddValue(global::FlatBuffers.FlatBufferBuilder builder, float Value)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.PropertyStruct> EndPropertyStruct(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}