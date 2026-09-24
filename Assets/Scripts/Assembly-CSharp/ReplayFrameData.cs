public class ReplayFrameData : global::Common.IRecycleable
{
    public global::EngineMessages.FrameDetail frame;
    public ReplayFrameDetailData events;
    public void OnCreateFromPool()
    {
    }

    public void OnReleaseToPool()
    {
    }

    public void AddEvent(OpCode opCode)
    {
    }

    public void AddEvent(int eventType)
    {
    }

    public global::FlatBuffers.Offset<global::EngineMessages.CompactFrameDetail> ToProto(global::FlatBuffers.FlatBufferBuilder builder)
    {
        return default;
    }
}