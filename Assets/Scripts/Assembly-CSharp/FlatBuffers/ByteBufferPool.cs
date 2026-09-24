namespace FlatBuffers
{
    public class ByteBufferPool
    {
        private static global::System.Collections.Generic.Queue<global::FlatBuffers.ByteBuffer> buffers;
        private static int maxSize;
        public static void Reserve(int count)
        {
        }

        public static global::FlatBuffers.ByteBuffer Create(int length)
        {
            return null;
        }

        public static void Release(global::FlatBuffers.ByteBuffer buff)
        {
        }
    }
}