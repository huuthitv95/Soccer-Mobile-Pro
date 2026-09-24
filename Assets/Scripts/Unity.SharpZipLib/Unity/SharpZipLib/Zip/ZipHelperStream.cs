namespace Unity.SharpZipLib.Zip
{
    internal class ZipHelperStream : global::System.IO.Stream
    {
        private bool isOwner_;
        private global::System.IO.Stream stream_;
        public override bool CanRead => false;
        public override bool CanSeek => false;
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

        public override bool CanWrite => false;

        public ZipHelperStream(global::System.IO.Stream stream)
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

        public override int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public void WriteZip64EndOfCentralDirectory(long noOfEntries, long sizeEntries, long centralDirOffset)
        {
        }

        public void WriteEndOfCentralDirectory(long noOfEntries, long sizeEntries, long startOfCentralDirectory, byte[] comment)
        {
        }

        public int ReadLEShort()
        {
            return 0;
        }

        public int ReadLEInt()
        {
            return 0;
        }

        public void WriteLEShort(int value)
        {
        }

        public void WriteLEUshort(ushort value)
        {
        }

        public void WriteLEInt(int value)
        {
        }

        public void WriteLEUint(uint value)
        {
        }

        public void WriteLELong(long value)
        {
        }
    }
}