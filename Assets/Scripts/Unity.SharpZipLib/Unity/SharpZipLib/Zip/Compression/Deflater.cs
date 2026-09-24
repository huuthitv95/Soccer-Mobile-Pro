namespace Unity.SharpZipLib.Zip.Compression
{
    public class Deflater
    {
        public enum CompressionLevel
        {
            BEST_COMPRESSION = 9,
            BEST_SPEED = 1,
            DEFAULT_COMPRESSION = -1,
            NO_COMPRESSION = 0,
            DEFLATED = 8
        }

        private int level;
        private bool noZlibHeaderOrFooter;
        private int state;
        private long totalOut;
        private global::Unity.SharpZipLib.Zip.Compression.DeflaterPending pending;
        private global::Unity.SharpZipLib.Zip.Compression.DeflaterEngine engine;
        public long TotalOut => 0L;
        public bool IsFinished => false;
        public bool IsNeedingInput => false;

        public Deflater(int level, bool noZlibHeaderOrFooter)
        {
        }

        public void Reset()
        {
        }

        public void Flush()
        {
        }

        public void Finish()
        {
        }

        public void SetInput(byte[] input, int offset, int count)
        {
        }

        public void SetLevel(int level)
        {
        }

        public void SetStrategy(global::Unity.SharpZipLib.Zip.Compression.DeflateStrategy strategy)
        {
        }

        public int Deflate(byte[] output, int offset, int length)
        {
            return 0;
        }
    }
}