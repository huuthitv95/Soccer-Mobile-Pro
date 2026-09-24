internal class MatchThumbnail : MatchListener
{
    private static string _savekey;
    private bool _record;
    private float _lastTime;
    private float _frameinterval;
    private const float CourtHalfLength = 55f;
    private const float CourtHalfWidth = 36f;
    private const float MaxBallHeight = 40f;
    private byte[] _framebuf;
    private const int playercount = 11;
    private const int framebufLength = 47;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;

    public override void OnMatchStart(IMatch match)
    {
    }

    public override void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    private unsafe void UpdatePlayerTransform(global::EngineMessages.FrameDetail frameDetail, byte* posPtr, int bufstart)
    {
    }

    private byte Float2Byte(float v, float max)
    {
        return 0;
    }

    public override void PreDestroy(IMatch match)
    {
    }
}