namespace SLLevel
{
    public struct NewRunToEntry : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::SLLevel.Area? TriggerArea => null;
        public int TriggerFrom => 0;
        public int TriggerTo => 0;
        public global::SLLevel.Vector2? TargetPosition => null;
        public int TargetDirection => 0;
        public int TargetId => 0;
        public int Velocity => 0;

        public static global::SLLevel.NewRunToEntry GetRootAsNewRunToEntry(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::SLLevel.NewRunToEntry GetRootAsNewRunToEntry(global::FlatBuffers.ByteBuffer _bb, global::SLLevel.NewRunToEntry obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::SLLevel.NewRunToEntry __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public bool MutateTriggerFrom(int TriggerFrom)
        {
            return false;
        }

        public bool MutateTriggerTo(int TriggerTo)
        {
            return false;
        }

        public bool MutateTargetDirection(int TargetDirection)
        {
            return false;
        }

        public bool MutateTargetId(int TargetId)
        {
            return false;
        }

        public bool MutateVelocity(int Velocity)
        {
            return false;
        }

        public static void StartNewRunToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddTriggerArea(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Area> TriggerAreaOffset)
        {
        }

        public static void AddTriggerFrom(global::FlatBuffers.FlatBufferBuilder builder, int TriggerFrom)
        {
        }

        public static void AddTriggerTo(global::FlatBuffers.FlatBufferBuilder builder, int TriggerTo)
        {
        }

        public static void AddTargetPosition(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::SLLevel.Vector2> TargetPositionOffset)
        {
        }

        public static void AddTargetDirection(global::FlatBuffers.FlatBufferBuilder builder, int TargetDirection)
        {
        }

        public static void AddTargetId(global::FlatBuffers.FlatBufferBuilder builder, int TargetId)
        {
        }

        public static void AddVelocity(global::FlatBuffers.FlatBufferBuilder builder, int Velocity)
        {
        }

        public static global::FlatBuffers.Offset<global::SLLevel.NewRunToEntry> EndNewRunToEntry(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}