public abstract class MatchListener : global::UnityEngine.MonoBehaviour
{
    public abstract global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode { get; }
    public virtual InputListener GetInputListener => null;
    public virtual ReplayHandler GetReplayHandler => null;

    public virtual void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public virtual void OnMatchStart(IMatch match)
    {
    }

    public virtual void OnAIReady(IMatch match)
    {
    }

    public virtual void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public virtual void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public virtual void OnUpdate(IMatch match)
    {
    }

    public virtual void OnMatchDestroy(IMatch match)
    {
    }

    public virtual void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel tol, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    public virtual void OnSaveShnapsot(global::Srv.ClientMatchSnapshot archive)
    {
    }

    public virtual void OnLoadShnapsot(global::Srv.ClientMatchSnapshot archive)
    {
    }

    public virtual void OnMatchReset(IMatch match)
    {
    }

    public virtual void BeforeInit(IMatch match)
    {
    }

    public abstract void PreDestroy(IMatch match);
}