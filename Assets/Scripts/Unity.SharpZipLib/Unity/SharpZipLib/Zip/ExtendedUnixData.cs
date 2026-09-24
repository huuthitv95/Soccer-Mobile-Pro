namespace Unity.SharpZipLib.Zip
{
    public class ExtendedUnixData : global::Unity.SharpZipLib.Zip.ITaggedData
    {
        [global::System.Flags]
        public enum Flags : byte
        {
            ModificationTime = 1,
            AccessTime = 2,
            CreateTime = 4
        }

        private global::Unity.SharpZipLib.Zip.ExtendedUnixData.Flags _flags;
        private global::System.DateTime _modificationTime;
        private global::System.DateTime _lastAccessTime;
        private global::System.DateTime _createTime;
        public short TagID => 0;
        public global::System.DateTime ModificationTime => default;
        public global::Unity.SharpZipLib.Zip.ExtendedUnixData.Flags Include => (global::Unity.SharpZipLib.Zip.ExtendedUnixData.Flags)0;

        public void SetData(byte[] data, int index, int count)
        {
        }
    }
}