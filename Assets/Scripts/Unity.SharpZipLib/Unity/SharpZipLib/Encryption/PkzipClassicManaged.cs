namespace Unity.SharpZipLib.Encryption
{
    public sealed class PkzipClassicManaged : global::Unity.SharpZipLib.Encryption.PkzipClassic
    {
        private byte[] key_;
        public override int BlockSize
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public override global::System.Security.Cryptography.KeySizes[] LegalKeySizes => null;

        public override byte[] Key
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override void GenerateIV()
        {
        }

        public override void GenerateKey()
        {
        }

        public override global::System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
        {
            return null;
        }

        public override global::System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
        {
            return null;
        }
    }
}