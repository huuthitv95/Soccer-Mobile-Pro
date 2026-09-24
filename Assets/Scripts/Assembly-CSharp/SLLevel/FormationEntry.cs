namespace SLLevel
{
    public struct FormationEntry : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Struct __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::SLLevel.PlayerRole Role => global::SLLevel.PlayerRole.GK;
        public global::SLLevel.Vector2 Position => default;

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.FormationEntry __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public void MutateRole(global::SLLevel.PlayerRole Role)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.FormationEntry> CreateFormationEntry(global::FlatBuffers.FlatBufferBuilder builder, global::SLLevel.PlayerRole Role, float Position_X, float Position_Y)
        {
            return default;
        }
    }
}