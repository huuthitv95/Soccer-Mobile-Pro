namespace Unity.SharpZipLib.Zip.Compression.Streams
{
    public class InflaterInputStream : global::System.IO.Stream
    {
        protected global::Unity.SharpZipLib.Zip.Compression.Inflater inf;
        protected global::Unity.SharpZipLib.Zip.Compression.Streams.InflaterInputBuffer inputBuffer;
        private global::System.IO.Stream baseInputStream;
        protected long csize;
        private bool isClosed;
        public bool IsStreamOwner { get; }
        public override bool CanRead => false;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => 0L;

        public override long Position
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        public InflaterInputStream(global::System.IO.Stream baseInputStream, global::Unity.SharpZipLib.Zip.Compression.Inflater inf)
        {
        }

        public InflaterInputStream(global::System.IO.Stream baseInputStream, global::Unity.SharpZipLib.Zip.Compression.Inflater inflater, int bufferSize)
        {
        }

        public long Skip(long count)
        {
            return 0L;
        }

        protected void StopDecrypting()
        {
        }

        protected void Fill()
        {
        }

        public override void Flush()
        {
        }

        public override long Seek(long offset, global::System.IO.SeekOrigin origin)
        {
            return 0L;
        }

        public override void SetLength(long value)
        {
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        public override void WriteByte(byte value)
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }
    }
}