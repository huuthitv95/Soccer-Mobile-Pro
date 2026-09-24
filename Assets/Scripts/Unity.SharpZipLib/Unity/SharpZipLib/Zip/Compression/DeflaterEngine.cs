namespace Unity.SharpZipLib.Zip.Compression
{
    public class DeflaterEngine
    {
        private int ins_h;
        private short[] head;
        private short[] prev;
        private int matchStart;
        private int matchLen;
        private bool prevAvailable;
        private int blockStart;
        private int strstart;
        private int lookahead;
        private byte[] window;
        private global::Unity.SharpZipLib.Zip.Compression.DeflateStrategy strategy;
        private int max_chain;
        private int max_lazy;
        private int niceLength;
        private int goodLength;
        private int compressionFunction;
        private byte[] inputBuf;
        private long totalIn;
        private int inputOff;
        private int inputEnd;
        private global::Unity.SharpZipLib.Zip.Compression.DeflaterPending pending;
        private global::Unity.SharpZipLib.Zip.Compression.DeflaterHuffman huffman;
        private global::Unity.SharpZipLib.Checksum.Adler32 adler;
        public int Adler => 0;

        public global::Unity.SharpZipLib.Zip.Compression.DeflateStrategy Strategy
        {
            set
            {
            }
        }

        public DeflaterEngine(global::Unity.SharpZipLib.Zip.Compression.DeflaterPending pending, bool noAdlerCalculation)
        {
        }

        public bool Deflate(bool flush, bool finish)
        {
            return false;
        }

        public void SetInput(byte[] buffer, int offset, int count)
        {
        }

        public bool NeedsInput()
        {
            return false;
        }

        public void Reset()
        {
        }

        public void ResetAdler()
        {
        }

        public void SetLevel(int level)
        {
        }

        public void FillWindow()
        {
        }

        private void UpdateHash()
        {
        }

        private int InsertString()
        {
            return 0;
        }

        private void SlideWindow()
        {
        }

        private bool FindLongestMatch(int curMatch)
        {
            return false;
        }

        private bool DeflateStored(bool flush, bool finish)
        {
            return false;
        }

        private bool DeflateFast(bool flush, bool finish)
        {
            return false;
        }

        private bool DeflateSlow(bool flush, bool finish)
        {
            return false;
        }
    }
}