public class ReplayFrameDetailData : global::Common.IRecycleable
{
    public global::System.Collections.Generic.HashSet<OpCode> opcode;
    public int eventType;
    public int extralData;
    public void OnCreateFromPool()
    {
    }

    public void OnReleaseToPool()
    {
    }
}