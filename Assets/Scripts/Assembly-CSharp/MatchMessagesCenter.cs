[global::System.Serializable]
public class MatchMessagesCenter
{
    public delegate void OnFullFrames(global::EngineMessages.FrameDetail f);
    [global::UnityEngine.SerializeField]
    public MatchListener[] matchListeners;
    private global::System.Collections.Generic.List<InputListener> inputListener;
    private global::System.Collections.Generic.Dictionary<OpCode, global::System.Collections.Generic.List<MatchListener>> registrar;
    private global::System.Collections.Generic.List<ReplayHandler> replayHandlers;
    public global::Common.Event<AISampleBase> OnAIReadyEvent;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private MatchMessagesCenter.OnFullFrames m_DelegateFullFrame;
    public event MatchMessagesCenter.OnFullFrames DelegateFullFrame
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public void AddListener(MatchListener listener)
    {
    }

    public void RemoveAllListeners()
    {
    }

    public void RemoveListener(global::System.Type listener)
    {
    }

    public void Init(IMatch match)
    {
    }

    public void OnMatchStart(IMatch match)
    {
    }

    public void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public void OnAIReady(IMatch match)
    {
    }

    public void OnMatchReset(IMatch match)
    {
    }

    public void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public void OnUpdate(IMatch match)
    {
    }

    public void OnMatchDestroy(IMatch match)
    {
    }

    public void PreDestroy(IMatch match)
    {
    }

    public void HandleInput(global::EngineMessages.InputData inputData)
    {
    }

    public void OnReplayStart()
    {
    }

    public void OnReplayReset()
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

    public void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel to, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    internal void UpdateAllFrame(global::EngineMessages.FrameDetail frameDetail)
    {
    }

    public void OnSaveShnapsot(global::Srv.ClientMatchSnapshot archive)
    {
    }

    public void OnLoadShnapsot(global::Srv.ClientMatchSnapshot archive)
    {
    }
}