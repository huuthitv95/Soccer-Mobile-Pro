namespace DynamicCrowd
{
    public struct CrowdRow : global::FlatBuffers.IFlatbufferObject
    {
        private global::FlatBuffers.Table __p;
        public global::FlatBuffers.ByteBuffer ByteBuffer => null;
        public global::DynamicCrowd.Vector3Short? Normal => null;
        public global::DynamicCrowd.Vector3Short? Up => null;
        public int SeatsLength => 0;

        public static global::DynamicCrowd.CrowdRow GetRootAsCrowdRow(global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public static global::DynamicCrowd.CrowdRow GetRootAsCrowdRow(global::FlatBuffers.ByteBuffer _bb, global::DynamicCrowd.CrowdRow obj)
        {
            return default;
        }

        public void __init(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
        }

        public global::DynamicCrowd.CrowdRow __assign(int _i, global::FlatBuffers.ByteBuffer _bb)
        {
            return default;
        }

        public global::DynamicCrowd.CrowdSeat? Seats(int j)
        {
            return null;
        }

        public static void StartCrowdRow(global::FlatBuffers.FlatBufferBuilder builder)
        {
        }

        public static void AddNormal(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::DynamicCrowd.Vector3Short> normalOffset)
        {
        }

        public static void AddUp(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.Offset<global::DynamicCrowd.Vector3Short> upOffset)
        {
        }

        public static void AddSeats(global::FlatBuffers.FlatBufferBuilder builder, global::FlatBuffers.VectorOffset seatsOffset)
        {
        }

        public static void StartSeatsVector(global::FlatBuffers.FlatBufferBuilder builder, int numElems)
        {
        }

        public static global::FlatBuffers.Offset<global::DynamicCrowd.CrowdRow> EndCrowdRow(global::FlatBuffers.FlatBufferBuilder builder)
        {
            return default;
        }
    }
}