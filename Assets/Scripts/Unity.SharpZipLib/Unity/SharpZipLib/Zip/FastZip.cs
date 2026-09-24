namespace Unity.SharpZipLib.Zip
{
    public class FastZip
    {
        private bool continueRunning_;
        private byte[] buffer_;
        private global::Unity.SharpZipLib.Zip.ZipOutputStream outputStream_;
        private string sourceDirectory_;
        private bool createEmptyDirectories_;
        private global::Unity.SharpZipLib.Zip.FastZipEvents events_;
        private global::Unity.SharpZipLib.Zip.IEntryFactory entryFactory_;
        private global::Unity.SharpZipLib.Zip.UseZip64 useZip64_;
        private global::Unity.SharpZipLib.Zip.Compression.Deflater.CompressionLevel compressionLevel_;
        private string password_;
        public bool CreateEmptyDirectories => false;
        public string Password => null;
        public global::Unity.SharpZipLib.Zip.ZipEncryptionMethod EntryEncryptionMethod { get; }

        public global::Unity.SharpZipLib.Core.INameTransform NameTransform
        {
            set
            {
            }
        }

        public global::Unity.SharpZipLib.Zip.UseZip64 UseZip64 => global::Unity.SharpZipLib.Zip.UseZip64.Off;
        public global::Unity.SharpZipLib.Zip.Compression.Deflater.CompressionLevel CompressionLevel => global::Unity.SharpZipLib.Zip.Compression.Deflater.CompressionLevel.NO_COMPRESSION;

        public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter)
        {
        }

        public void CreateZip(global::System.IO.Stream outputStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
        {
        }

        public void CreateZip(global::System.IO.Stream outputStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter, bool leaveOpen)
        {
        }

        private void CreateZip(global::System.IO.Stream outputStream, string sourceDirectory, bool recurse, global::Unity.SharpZipLib.Core.FileSystemScanner scanner, bool leaveOpen)
        {
        }

        private void ProcessDirectory(object sender, global::Unity.SharpZipLib.Core.DirectoryEventArgs e)
        {
        }

        private void ProcessFile(object sender, global::Unity.SharpZipLib.Core.ScanEventArgs e)
        {
        }

        private void ConfigureEntryEncryption(global::Unity.SharpZipLib.Zip.ZipEntry entry)
        {
        }

        private void AddFileContents(string name, global::System.IO.Stream stream)
        {
        }
    }
}