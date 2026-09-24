namespace Common
{
    public class ByteBuffer : global::System.IO.Stream, global::Common.IRecycleable
    {
        private global::System.IO.MemoryStream _stream;
        private bool _autoExpand;
        private long _bookmark;
        public bool AutoExpand
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public int Capacity => 0;

        public int Limit
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int Remaining => 0;
        public bool HasRemaining => false;
        public long Bookmark => 0L;

        // C# has no syntax for parameterized property 'Item'.
        public byte this[int index]
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public override bool CanRead => false;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => 0L;

        public override long Position
        {
            get
            {
                return 0L;
            }

            set
            {
            }
        }

        public ByteBuffer(global::System.IO.MemoryStream stream)
        {
        }

        public ByteBuffer()
        {
        }

        public static global::Common.ByteBuffer Allocate(int capacity)
        {
            return null;
        }

        public static global::Common.ByteBuffer Wrap(byte[] array, int offset, int length)
        {
            return null;
        }

        public static global::Common.ByteBuffer Wrap(byte[] array)
        {
            return null;
        }

        public long Mark()
        {
            return 0L;
        }

        public void ClearBookmark()
        {
        }

        public void Reset()
        {
        }

        public void Clear()
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public void Flip()
        {
        }

        public void Rewind()
        {
        }

        public void Put(byte value)
        {
        }

        public void Put(byte[] src, int offset, int length)
        {
        }

        public void Put(byte[] src)
        {
        }

        public void Append(byte[] src)
        {
        }

        public void Append(byte[] src, int offset, int length)
        {
        }

        public void Put(global::Common.ByteBuffer src)
        {
        }

        public void Put(global::Common.ByteBuffer src, int count)
        {
        }

        public void Put(int index, byte value)
        {
        }

        public byte Get()
        {
            return 0;
        }

        public int GetInt()
        {
            return 0;
        }

        public short GetShort()
        {
            return 0;
        }

        public byte Get(int index)
        {
            return 0;
        }

        public byte[] ToArray()
        {
            return null;
        }

        public byte[] GetBuffer()
        {
            return null;
        }

        public void Compact()
        {
        }

        public void Skip(int size)
        {
        }

        public void Fill(byte value, int count)
        {
        }

        public override void Close()
        {
        }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }

        public int Read(byte[] buffer)
        {
            return 0;
        }

        public override int ReadByte()
        {
            return 0;
        }

        public override long Seek(long offset, global::System.IO.SeekOrigin origin)
        {
            return 0L;
        }

        public override void SetLength(long value)
        {
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
        }

        public override void WriteByte(byte value)
        {
        }

        public byte[] ReadBytes(int count)
        {
            return null;
        }

        public void WriteMediumInt(int value)
        {
        }

        public void WriteReverseInt(int value)
        {
        }

        private void WriteBigEndian(byte[] bytes)
        {
        }

        private void WriteBigEndian(int index, byte[] bytes)
        {
        }

        private void WriteBytes(int index, byte[] bytes)
        {
        }

        public void PutShort(short value)
        {
        }

        public void PutInt(int value)
        {
        }

        public void PutInt(int index, int value)
        {
        }

        public void Put(int index, uint value)
        {
        }

        public void Put(int index, ushort value)
        {
        }

        public int ReadUInt24()
        {
            return 0;
        }

        public int ReadReverseInt()
        {
            return 0;
        }

        public static int Put(global::Common.ByteBuffer output, global::Common.ByteBuffer input, int numBytesMax)
        {
            return 0;
        }

        public void Dump(string file)
        {
        }

        public void OnCreateFromPool()
        {
        }

        public void OnReleaseToPool()
        {
        }

        public static byte[] LittleEndian(byte[] value)
        {
            return null;
        }
    }
}