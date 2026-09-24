namespace Unity.SharpZipLib.Zip
{
    public class ZipEntry
    {
        [global::System.Flags]
        private enum Known : byte
        {
            None = 0,
            Size = 1,
            CompressedSize = 2,
            Crc = 4,
            Time = 8,
            ExternalAttributes = 0x10
        }

        private global::Unity.SharpZipLib.Zip.ZipEntry.Known known;
        private int externalFileAttributes;
        private ushort versionMadeBy;
        private string name;
        private ulong size;
        private ulong compressedSize;
        private ushort versionToExtract;
        private uint crc;
        private global::System.DateTime dateTime;
        private global::Unity.SharpZipLib.Zip.CompressionMethod method;
        private byte[] extra;
        private string comment;
        private int flags;
        private long zipFileIndex;
        private long offset;
        private bool forceZip64_;
        private byte cryptoCheckValue_;
        private int _aesVer;
        private int _aesEncryptionStrength;
        public bool HasCrc => false;

        public bool IsCrypted
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool IsUnicodeText
        {
            set
            {
            }
        }

        internal byte CryptoCheckValue
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int Flags
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public long Offset
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        public int ExternalFileAttributes
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int VersionMadeBy => 0;
        public int HostSystem => 0;
        public int Version => 0;
        public bool CanDecompress => false;
        public bool LocalHeaderRequiresZip64 => false;
        public bool CentralHeaderRequiresZip64 => false;

        public long DosTime
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        public global::System.DateTime DateTime
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public string Name
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        public long Size
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        public long CompressedSize
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        public long Crc
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        public global::Unity.SharpZipLib.Zip.CompressionMethod CompressionMethod
        {
            get
            {
                return global::Unity.SharpZipLib.Zip.CompressionMethod.Stored;
            }

            set
            {
            }
        }

        internal global::Unity.SharpZipLib.Zip.CompressionMethod CompressionMethodForHeader => global::Unity.SharpZipLib.Zip.CompressionMethod.Stored;

        public byte[] ExtraData
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public int AESKeySize
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        internal byte AESEncryptionStrength => 0;
        internal int AESSaltLen => 0;
        internal int AESOverheadSize => 0;
        internal int EncryptionOverheadSize => 0;
        public string Comment => null;
        public bool IsDirectory => false;
        public bool IsFile => false;

        public ZipEntry(string name)
        {
        }

        internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, global::Unity.SharpZipLib.Zip.CompressionMethod method)
        {
        }

        private bool HasDosAttributes(int attributes)
        {
            return false;
        }

        public void ForceZip64()
        {
        }

        public bool IsZip64Forced()
        {
            return false;
        }

        internal void ProcessExtraData(bool localHeader)
        {
        }

        private static global::System.DateTime? GetDateTime(global::Unity.SharpZipLib.Zip.ZipExtraData extraData)
        {
            return null;
        }

        private void ProcessAESExtraData(global::Unity.SharpZipLib.Zip.ZipExtraData extraData)
        {
        }

        public bool IsCompressionMethodSupported()
        {
            return false;
        }

        public override string ToString()
        {
            return null;
        }

        public static bool IsCompressionMethodSupported(global::Unity.SharpZipLib.Zip.CompressionMethod method)
        {
            return false;
        }
    }
}