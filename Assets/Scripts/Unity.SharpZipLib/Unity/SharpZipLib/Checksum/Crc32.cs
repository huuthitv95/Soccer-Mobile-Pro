namespace Unity.SharpZipLib.Checksum
{
    public sealed class Crc32
    {
        private static readonly uint crcInit;
        private static readonly uint crcXor;
        private static readonly uint[] crcTable;
        private uint checkValue;
        public long Value => 0L;

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static uint ComputeCrc32(uint oldCrc, byte bval)
        {
            return 0u;
        }

        public void Reset()
        {
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Update(int bval)
        {
        }

        public void Update(global::System.ArraySegment<byte> segment)
        {
        }

        private void Update(byte[] data, int offset, int count)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        private void SlowUpdateLoop(byte[] data, int offset, int end)
        {
        }
    }
}