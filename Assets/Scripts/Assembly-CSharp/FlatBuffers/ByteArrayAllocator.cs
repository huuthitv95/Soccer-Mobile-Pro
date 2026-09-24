namespace FlatBuffers
{
    public sealed class ByteArrayAllocator : global::FlatBuffers.ByteBufferAllocator
    {
        private byte[] _buffer;
        public ByteArrayAllocator(byte[] buffer)
        {
        }

        public override void GrowFront(int newSize)
        {
        }

        private void InitBuffer()
        {
        }
    }
}