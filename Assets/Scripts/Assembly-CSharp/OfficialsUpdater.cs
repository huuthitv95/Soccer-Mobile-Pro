public class OfficialsUpdater : MatchListener, ReplayHandler
{
    private global::Common.PlayerBoneHolder[] _officials;
    public bool SkipAIUpdate;
    public global::Common.PlayerBoneHolder Referee => null;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;
    public override ReplayHandler GetReplayHandler => null;

    public void Show(bool show = true)
    {
    }

    public void HideLinesman()
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public override void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void UpdateFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public override void OnUpdate(IMatch match)
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }

    public void OnReplayStart()
    {
    }

    public void UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail)
    {
    }

    public void UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void OnReplayEnd()
    {
    }

    public void OnReplayReset()
    {
    }
}