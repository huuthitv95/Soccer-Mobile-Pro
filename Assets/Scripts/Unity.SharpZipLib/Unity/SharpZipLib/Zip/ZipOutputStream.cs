namespace Unity.SharpZipLib.Zip
{
    public class ZipOutputStream : global::Unity.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream
    {
        private global::System.Collections.Generic.List<global::Unity.SharpZipLib.Zip.ZipEntry> entries;
        private global::Unity.SharpZipLib.Checksum.Crc32 crc;
        private global::Unity.SharpZipLib.Zip.ZipEntry curEntry;
        private int defaultCompressionLevel;
        private global::Unity.SharpZipLib.Zip.CompressionMethod curMethod;
        private long size;
        private long offset;
        private byte[] zipComment;
        private bool patchEntryHeader;
        private long crcPatchPos;
        private long sizePatchPos;
        private global::Unity.SharpZipLib.Zip.UseZip64 useZip64_;
        private string password;
        private static global::System.Security.Cryptography.RandomNumberGenerator _aesRnd;
        public global::Unity.SharpZipLib.Zip.UseZip64 UseZip64
        {
            set
            {
            }
        }

        public global::Unity.SharpZipLib.Core.INameTransform NameTransform { get; set; }

        public string Password
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public ZipOutputStream(global::System.IO.Stream baseOutputStream) : base(null, null)
        {
        }

        public void SetLevel(int level)
        {
        }

        private void WriteLeShort(int value)
        {
        }

        private void WriteLeInt(int value)
        {
        }

        private void WriteLeLong(long value)
        {
        }

        private void TransformEntryName(global::Unity.SharpZipLib.Zip.ZipEntry entry)
        {
        }

        public void PutNextEntry(global::Unity.SharpZipLib.Zip.ZipEntry entry)
        {
        }

        public void CloseEntry()
        {
        }

        private void InitializePassword(string password)
        {
        }

        private void InitializeAESPassword(global::Unity.SharpZipLib.Zip.ZipEntry entry, string rawPassword, out byte[] salt, out byte[] pwdVerifier)
        {
            salt = null;
            pwdVerifier = null;
        }

        private void WriteEncryptionHeader(long crcValue)
        {
        }

        private static void AddExtraDataAES(global::Unity.SharpZipLib.Zip.ZipEntry entry, global::Unity.SharpZipLib.Zip.ZipExtraData extraData)
        {
        }

        private void WriteAESHeader(global::Unity.SharpZipLib.Zip.ZipEntry entry)
        {
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        private void CopyAndEncrypt(byte[] buffer, int offset, int count)
        {
        }

        public override void Finish()
        {
        }

        public override void Flush()
        {
        }
    }
}