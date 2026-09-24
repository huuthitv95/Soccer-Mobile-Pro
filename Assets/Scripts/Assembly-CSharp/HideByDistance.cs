public class HideByDistance : MatchListener, ReplayHandler, IFLHandler
{
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.Renderer[] hideWhenOccluded;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Renderer[] transparentizeWhenOccluded;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera camera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.BoxCollider[] colliders;
    private global::UnityEngine.Plane[] planes;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] hideInGameView;
    private float timer;
    public bool HandleHighlight;
    public override ReplayHandler GetReplayHandler => null;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;

    public void SetActiveCamera(global::UnityEngine.Camera camera)
    {
    }

    private void UpdateHideInGameViewGO(bool isGameView)
    {
    }

    private bool CheckShouldHide(global::UnityEngine.Renderer target, global::UnityEngine.Vector3 ballPosition, global::UnityEngine.Vector3 cameraPos, global::UnityEngine.Vector3 cameraToBall, float cameraToBallSqrDist)
    {
        return false;
    }

    private bool CheckShouldHide(global::UnityEngine.BoxCollider target, global::UnityEngine.Vector3 ballPosition, global::UnityEngine.Vector3 cameraPos, global::UnityEngine.Vector3 cameraToBall, float cameraToBallSqrDist)
    {
        return false;
    }

    private global::UnityEngine.Vector3 GetClosestPointToCamera(global::UnityEngine.Bounds bounds, global::UnityEngine.Vector3 cameraPos, global::UnityEngine.Vector3 ballPosition)
    {
        return default;
    }

    private void CheckFrustumCulling(IMatch match)
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public void ResetAll()
    {
    }

    public override void OnUpdate(IMatch match)
    {
    }

    public override void OnMatchReset(IMatch match)
    {
    }

    public void OnReplayStart()
    {
    }

    public void UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail)
    {
    }

    public void OnReplayEnd()
    {
    }

    public void UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void OnReplayReset()
    {
    }

    public void OnFLClientMessage(FLClientOpCode opCode, object content)
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }
}