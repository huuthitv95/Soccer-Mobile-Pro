namespace Unity.SharpZipLib.Zip.Compression
{
    public class DeflaterHuffman
    {
        private class Tree
        {
            public short[] freqs;
            public byte[] length;
            public int minNumCodes;
            public int numCodes;
            private short[] codes;
            private readonly int[] bl_counts;
            private readonly int maxLength;
            private global::Unity.SharpZipLib.Zip.Compression.DeflaterHuffman dh;
            public Tree(global::Unity.SharpZipLib.Zip.Compression.DeflaterHuffman dh, int elems, int minCodes, int maxLength)
            {
            }

            public void Reset()
            {
            }

            public void WriteSymbol(int code)
            {
            }

            public void SetStaticCodes(short[] staticCodes, byte[] staticLengths)
            {
            }

            public void BuildCodes()
            {
            }

            public void BuildTree()
            {
            }

            public int GetEncodedLength()
            {
                return 0;
            }

            public void CalcBLFreq(global::Unity.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree)
            {
            }

            public void WriteTree(global::Unity.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree)
            {
            }

            private void BuildLength(int[] childs)
            {
            }
        }

        private static readonly int[] BL_ORDER;
        private static readonly byte[] bit4Reverse;
        private static short[] staticLCodes;
        private static byte[] staticLLength;
        private static short[] staticDCodes;
        private static byte[] staticDLength;
        public global::Unity.SharpZipLib.Zip.Compression.DeflaterPending pending;
        private global::Unity.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree literalTree;
        private global::Unity.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree distTree;
        private global::Unity.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree;
        private short[] d_buf;
        private byte[] l_buf;
        private int last_lit;
        private int extra_bits;
        static DeflaterHuffman()
        {
        }

        public DeflaterHuffman(global::Unity.SharpZipLib.Zip.Compression.DeflaterPending pending)
        {
        }

        public void Reset()
        {
        }

        public void SendAllTrees(int blTreeCodes)
        {
        }

        public void CompressBlock()
        {
        }

        public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
        {
        }

        public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
        {
        }

        public bool IsFull()
        {
            return false;
        }

        public bool TallyLit(int literal)
        {
            return false;
        }

        public bool TallyDist(int distance, int length)
        {
            return false;
        }

        public static short BitReverse(int toReverse)
        {
            return 0;
        }

        private static int Lcode(int length)
        {
            return 0;
        }

        private static int Dcode(int distance)
        {
            return 0;
        }
    }
}