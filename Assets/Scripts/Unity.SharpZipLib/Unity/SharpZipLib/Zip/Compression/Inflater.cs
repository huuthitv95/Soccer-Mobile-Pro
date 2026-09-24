namespace Unity.SharpZipLib.Zip.Compression
{
    public class Inflater
    {
        private static readonly int[] CPLENS;
        private static readonly int[] CPLEXT;
        private static readonly int[] CPDIST;
        private static readonly int[] CPDEXT;
        private int mode;
        private int readAdler;
        private int neededBits;
        private int repLength;
        private int repDist;
        private int uncomprLen;
        private bool isLastBlock;
        private long totalOut;
        private long totalIn;
        private bool noHeader;
        private readonly global::Unity.SharpZipLib.Zip.Compression.Streams.StreamManipulator input;
        private global::Unity.SharpZipLib.Zip.Compression.Streams.OutputWindow outputWindow;
        private global::Unity.SharpZipLib.Zip.Compression.InflaterDynHeader dynHeader;
        private global::Unity.SharpZipLib.Zip.Compression.InflaterHuffmanTree litlenTree;
        private global::Unity.SharpZipLib.Zip.Compression.InflaterHuffmanTree distTree;
        private global::Unity.SharpZipLib.Checksum.Adler32 adler;
        public bool IsNeedingInput => false;
        public bool IsNeedingDictionary => false;
        public bool IsFinished => false;
        public long TotalOut => 0L;
        public long TotalIn => 0L;
        public int RemainingInput => 0;

        public Inflater(bool noHeader)
        {
        }

        public void Reset()
        {
        }

        private bool DecodeHeader()
        {
            return false;
        }

        private bool DecodeDict()
        {
            return false;
        }

        private bool DecodeHuffman()
        {
            return false;
        }

        private bool DecodeChksum()
        {
            return false;
        }

        private bool Decode()
        {
            return false;
        }

        public void SetInput(byte[] buffer, int index, int count)
        {
        }

        public int Inflate(byte[] buffer, int offset, int count)
        {
            return 0;
        }
    }
}