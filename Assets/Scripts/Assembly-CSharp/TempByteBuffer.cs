public class TempByteBuffer : global::Common.Singleton<TempByteBuffer>
{
    private byte[] buffer1;
    private byte[] buffer2;
    private bool buffer1InUse;
    private bool buffer2InUse;
    public bool HasIdleBuffer()
    {
        return false;
    }

    public byte[] GetIdleBuffer(int size)
    {
        return null;
    }

    public void ReleaseBuffer(byte[] buffer)
    {
    }
}