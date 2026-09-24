namespace Unity.SharpZipLib.Zip
{
    public sealed class ZipExtraData : global::System.IDisposable
    {
        private int _index;
        private int _readValueStart;
        private int _readValueLength;
        private global::System.IO.MemoryStream _newEntry;
        private byte[] _data;
        public int Length => 0;
        public int ValueLength => 0;
        public int CurrentReadIndex => 0;

        public ZipExtraData(byte[] data)
        {
        }

        public byte[] GetEntryData()
        {
            return null;
        }

        public T GetData<T>()
            where T : class, global::Unity.SharpZipLib.Zip.ITaggedData, new()
        {
            return null;
        }

        public bool Find(int headerID)
        {
            return false;
        }

        public void AddEntry(int headerID, byte[] fieldData)
        {
        }

        public void StartNewEntry()
        {
        }

        public void AddNewEntry(int headerID)
        {
        }

        public void AddData(byte data)
        {
        }

        public void AddLeShort(int toAdd)
        {
        }

        public void AddLeInt(int toAdd)
        {
        }

        public void AddLeLong(long toAdd)
        {
        }

        public bool Delete(int headerID)
        {
            return false;
        }

        public long ReadLong()
        {
            return 0L;
        }

        public int ReadInt()
        {
            return 0;
        }

        public int ReadShort()
        {
            return 0;
        }

        public int ReadByte()
        {
            return 0;
        }

        private void ReadCheck(int length)
        {
        }

        private int ReadShortInternal()
        {
            return 0;
        }

        private void SetShort(ref int index, int source)
        {
        }

        public void Dispose()
        {
        }
    }
}