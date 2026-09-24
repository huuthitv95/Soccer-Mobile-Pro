namespace Unity.SharpZipLib.Encryption
{
    internal class ZipAESTransform : global::System.Security.Cryptography.ICryptoTransform, global::System.IDisposable
    {
        private class IncrementalHash : global::System.Security.Cryptography.HMACSHA1
        {
            private bool _finalised;
            public IncrementalHash(byte[] key)
            {
            }

            public static global::Unity.SharpZipLib.Encryption.ZipAESTransform.IncrementalHash CreateHMAC(string n, byte[] key)
            {
                return null;
            }

            public void AppendData(byte[] buffer, int offset, int count)
            {
            }

            public byte[] GetHashAndReset()
            {
                return null;
            }
        }

        private static class HashAlgorithmName
        {
            public static string SHA1;
        }

        private int _blockSize;
        private readonly global::System.Security.Cryptography.ICryptoTransform _encryptor;
        private readonly byte[] _counterNonce;
        private byte[] _encryptBuffer;
        private int _encrPos;
        private byte[] _pwdVerifier;
        private global::Unity.SharpZipLib.Encryption.ZipAESTransform.IncrementalHash _hmacsha1;
        private byte[] _authCode;
        private bool _writeMode;
        public byte[] PwdVerifier => null;
        public int InputBlockSize => 0;
        public int OutputBlockSize => 0;
        public bool CanTransformMultipleBlocks => false;

        public ZipAESTransform(string key, byte[] saltBytes, int blockSize, bool writeMode)
        {
        }

        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
            return 0;
        }

        public byte[] GetAuthCode()
        {
            return null;
        }

        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
            return null;
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