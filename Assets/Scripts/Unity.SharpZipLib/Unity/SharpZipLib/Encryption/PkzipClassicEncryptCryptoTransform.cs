namespace Unity.SharpZipLib.Encryption
{
    internal class PkzipClassicEncryptCryptoTransform : global::Unity.SharpZipLib.Encryption.PkzipClassicCryptoBase, global::System.Security.Cryptography.ICryptoTransform, global::System.IDisposable
    {
        public int InputBlockSize => 0;
        public int OutputBlockSize => 0;
        public bool CanTransformMultipleBlocks => false;

        internal PkzipClassicEncryptCryptoTransform(byte[] keyBlock)
        {
        }

        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
            return null;
        }

        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
            return 0;
        }

        public void Dispose()
        {
        }

        bool global::System.Security.Cryptography.ICryptoTransform.CanReuseTransform
        {
            get
            {
                return false;
            }
        }
    }
}