namespace Unity.SharpZipLib.Checksum
{
    public sealed class Adler32
    {
        private static readonly uint BASE;
        private uint checkValue;
        public long Value => 0L;

        public void Reset()
        {
        }

        public void Update(global::System.ArraySegment<byte> segment)
        {
        }
    }
}