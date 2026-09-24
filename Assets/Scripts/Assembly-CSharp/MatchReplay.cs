public class MatchReplay
{
    private global::EngineMessages.MatchConfig _config;
    public global::System.Collections.Generic.Queue<global::EngineMessages.InputData> inputs;
    public string path => null;

    public global::EngineMessages.MatchConfig config
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public bool replaying { get; set; }

    public void Write<T>(T message, global::System.IO.FileMode mode)
        where T : global::Google.Protobuf.IMessage
    {
    }

    public T Read<T>(byte[] data, ref int offset)
        where T : global::Google.Protobuf.IMessage
    {
        return default;
    }

    public bool Load()
    {
        return false;
    }

    public bool FetchInput(ref global::EngineMessages.InputData eventList)
    {
        return false;
    }

    public void AppendInput(global::EngineMessages.InputData eventList)
    {
    }
}