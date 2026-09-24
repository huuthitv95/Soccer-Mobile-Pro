public class AITestFrameRenderer
{
    private readonly global::UnityEngine.Transform _ball;
    private readonly GoalNet[] _goalNets;
    private readonly global::Common.PlayerBoneHolder[, ] _players;
    private readonly int _starterPlayerCount;
    private global::UnityEngine.Rigidbody _ballRigidbody;
    private global::UnityEngine.Vector3 _ballVelocity;
    public global::UnityEngine.Vector3 BallVelocity => default;

    public AITestFrameRenderer(global::Common.PlayerBoneHolder[, ] players, global::UnityEngine.Transform ball, GoalNet[] goalNets, int starterPlayerCount)
    {
    }

    public void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerpT, float deltaTime)
    {
    }

    public unsafe static float ExtractFloat(byte* ptr, int idx)
    {
        return 0f;
    }

    private void UpdateBall(global::EngineMessages.FrameDetail frameDetail, float lerpT)
    {
    }

    private void UpdateGoalNets(global::EngineMessages.FrameDetail frameDetail)
    {
    }

    private unsafe void UpdatePlayerTransform(global::EngineMessages.FrameDetail frameDetail, float lerpT, float deltaTime, byte* rotatePtr, byte* posPtr)
    {
    }
}