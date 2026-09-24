namespace Unity.SharpZipLib.Zip
{
    public class ZipInputStream : global::Unity.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
    {
        private delegate int ReadDataHandler(byte[] b, int offset, int length);
        private global::Unity.SharpZipLib.Zip.ZipInputStream.ReadDataHandler internalReader;
        private global::Unity.SharpZipLib.Checksum.Crc32 crc;
        private global::Unity.SharpZipLib.Zip.ZipEntry entry;
        private long size;
        private global::Unity.SharpZipLib.Zip.CompressionMethod method;
        private int flags;
        private string password;
        public string Password
        {
            set
            {
            }
        }

        public bool CanDecompressEntry => false;
        public override long Length => 0L;

        public ZipInputStream(global::System.IO.Stream baseInputStream) : base(null, null)
        {
        }

        private static bool IsEntryCompressionMethodSupported(global::Unity.SharpZipLib.Zip.ZipEntry entry)
        {
            return false;
        }

        public global::Unity.SharpZipLib.Zip.ZipEntry GetNextEntry()
        {
            return null;
        }

        private void ReadDataDescriptor()
        {
        }

        private void CompleteCloseEntry(bool testCrc)
        {
        }

        public void CloseEntry()
        {
        }

        public override int ReadByte()
        {
            return 0;
        }

        private int ReadingNotAvailable(byte[] destination, int offset, int count)
        {
            return 0;
        }

        private int ReadingNotSupported(byte[] destination, int offset, int count)
        {
            return 0;
        }

        private int StoredDescriptorEntry(byte[] destination, int offset, int count)
        {
            return 0;
        }

        private int InitialRead(byte[] destination, int offset, int count)
        {
            return 0;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }

        private int BodyRead(byte[] buffer, int offset, int count)
        {
            return 0;
        }

        protected override void Dispose(bool disposing)
        {
        }
    }
}