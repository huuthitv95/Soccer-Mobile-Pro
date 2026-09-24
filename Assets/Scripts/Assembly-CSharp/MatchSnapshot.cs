public class MatchSnapshot
{
    private global::Srv.ClientMatchSnapshot clientSnapshot;
    private global::EngineMessages.MatchTimestamp aiSnapshot;
    private bool loaded;
    private string subPath;
    private byte[] lenghtArr;
    private byte[] placeholder;
    public bool Enable { get; private set; }
    private string dir => null;
    private string SavePath => null;
    public bool HasSnapshot => false;

    public global::Srv.ClientMatchSnapshot ClientSnapshot
    {
        get
        {
            return null;
        }

        private set
        {
        }
    }

    public global::EngineMessages.MatchTimestamp AiSnapshot
    {
        get
        {
            return null;
        }

        private set
        {
        }
    }

    public MatchSnapshot(bool enable, string subPath)
    {
    }

    private void Load()
    {
    }

    public void Delete()
    {
    }

    public void Save(byte[] aiData)
    {
    }

    private static void ConvertInt2Bytes(byte[] rw_buf, int value, int length)
    {
    }
}