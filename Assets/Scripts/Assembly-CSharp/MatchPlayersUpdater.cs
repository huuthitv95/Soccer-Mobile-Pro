public class MatchPlayersUpdater : MatchListener, ReplayHandler
{
    private const float BallRadius = 0.11f;
    private const float AiFrameDt = 0.01f;
    private const float MaxWoodworkSimTime = 2f;
    private const float NearGoalMinAbsX = 45f;
    private const float NearGoalMaxAbsZ = 12f;
    private const float MinSpeedSq = 0.25f;
    private static readonly global::UnityEngine.RaycastHit[] WoodworkRayHits;
    private static readonly global::System.Collections.Generic.List<global::UnityEngine.Collider> WoodworkColliders;
    private global::UnityEngine.Rigidbody _ballRigidbody;
    private global::UnityEngine.Vector3 _ballVelocity;
    private bool _replayPlayback;
    private GoalNet[] _goalNets;
    private GoalNet[] _cachedGoalNetsForColliders;
    private global::System.Collections.Generic.List<global::Common.PlayerBoneHolder> needSkip;
    private global::System.Collections.Generic.Dictionary<global::Common.PlayerBoneHolder, global::UnityEngine.Vector3> lastPos;
    [global::UnityEngine.SerializeField]
    private bool Pause;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;
    public override ReplayHandler GetReplayHandler => null;

    public void TakeOverBallWithPhysics(bool useUnityPhysics)
    {
    }

    private bool WouldHitGoalWoodwork()
    {
        return false;
    }

    private void EnsureWoodworkColliders()
    {
    }

    private bool TryHitWoodwork(global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 dir, float dist)
    {
        return false;
    }

    public void MarkSkipUpdate(global::Common.PlayerBoneHolder playerBone)
    {
    }

    public void ResetSkipMark()
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    private unsafe void UpdatePlayerTransform(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, byte* rotatePtr, byte* posPtr)
    {
    }

    private unsafe void UpdatePlayerTransform(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match, byte* rotatePtr, byte* posPtr)
    {
    }

    public void UpdateFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public override void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void OnReplayStart()
    {
    }

    public unsafe static float ExtractFloat(byte* ptr, int idx)
    {
        return 0f;
    }

    public unsafe static short ExtractShort(byte* ptr, int idx)
    {
        return 0;
    }

    public unsafe static byte ExtractByte(byte* ptr, int idx)
    {
        return 0;
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

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public void OnReplayReset()
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }
}