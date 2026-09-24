namespace Unity.SharpZipLib.Zip.Compression.Streams
{
    public class InflaterInputBuffer
    {
        private int rawLength;
        private byte[] rawData;
        private int clearTextLength;
        private byte[] clearText;
        private byte[] internalClearText;
        private int available;
        private global::System.Security.Cryptography.ICryptoTransform cryptoTransform;
        private global::System.IO.Stream inputStream;
        public int Available
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::System.Security.Cryptography.ICryptoTransform CryptoTransform
        {
            set
            {
            }
        }

        public InflaterInputBuffer(global::System.IO.Stream stream, int bufferSize)
        {
        }

        public void SetInflaterInput(global::Unity.SharpZipLib.Zip.Compression.Inflater inflater)
        {
        }

        public void Fill()
        {
        }

        public int ReadRawBuffer(byte[] buffer)
        {
            return 0;
        }

        public int ReadRawBuffer(byte[] outBuffer, int offset, int length)
        {
            return 0;
        }

        public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length)
        {
            return 0;
        }

        public byte ReadLeByte()
        {
            return 0;
        }

        public int ReadLeShort()
        {
            return 0;
        }

        public int ReadLeInt()
        {
            return 0;
        }

        public long ReadLeLong()
        {
            return 0L;
        }
    }
}