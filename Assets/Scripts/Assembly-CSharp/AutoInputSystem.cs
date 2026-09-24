public class AutoInputSystem : InputSystem
{
    public enum AIStrategy
    {
        A = 0,
        B = 1,
        C = 2
    }

    private class OpponentInfo
    {
        public global::UnityEngine.Vector2 position;
        public float distance;
    }

    private class TeammateInfo
    {
        public global::UnityEngine.Vector2 position;
        public float distance;
        public bool isOpen;
    }

    [global::UnityEngine.SerializeField]
    private AutoInputSystem.AIStrategy _strategy;
    public float A_D_shoot;
    public float A_D_avoid;
    public float A_Y_mid;
    public float B_D_shoot;
    public float B_D_detect;
    public float B_detect_angle;
    public float B_Y_sideline;
    public float B_inner_cut_angle;
    public int B_cut_duration;
    public float C_D_shoot;
    public float C_D_avoid;
    public float C_Y_mid;
    private AITestMode _aiTestMode;
    private global::System.Collections.Generic.Queue<global::EngineMessages.InputEvent> _pendingEvents;
    private int _frameCounter;
    private const int HEARTBEAT_INTERVAL = 200;
    private global::EngineMessages.InputFunction? _heldButton;
    private int _heldButtonReleaseFrame;
    private global::UnityEngine.Vector2 _shotDirection;
    private const int SHOT_CHARGE_FRAMES = 25;
    private int _cutFrameEndFrame;
    private global::UnityEngine.Vector2 _cutDirection;
    private global::UnityEngine.Vector2? _lastRuleBDir;
    private bool _kickoffDone;
    private global::EngineMessages.GameMode _currentSetPiece;
    private bool _setPieceDone;
    private int _setPieceFrame;
    private global::UnityEngine.Vector2 _penaltyShotDir;
    private AutoInputSystem.TeammateInfo _setPiecePassTarget;
    private bool _freeKickForceShoot;
    private bool _wasDefending;
    private int _kickoffDoneFrame;
    private global::Common.PlayerBoneHolder _lastBallCarrier;
    private global::EngineMessages.InputFunction? _lastButtonFunc;
    private int _lastButtonFrame;
    private const int BUTTON_COOLDOWN = 30;
    private const int SHOT_COOLDOWN = 60;
    private const int SETPIECE_DELAY = 30;
    private const int SETPIECE_HOLD = 10;
    private const int KICKOFF_DELAY = 50;
    private const int KICKOFF_HOLD = 10;
    private const float FREEKICK_SHOOT_DIST = 40f;
    private const int RULE_C_PASS_FRAMES = 100;
    private const int GK_CLEAR_FRAMES = 120;
    private const float BOUNDARY_MARGIN = 8f;
    private const float FIELD_HALF_X = 55f;
    private const float FIELD_HALF_Y = 36f;
    public AutoInputSystem.AIStrategy Strategy
    {
        get
        {
            return AutoInputSystem.AIStrategy.A;
        }

        set
        {
        }
    }

    public void SetAITestMode(AITestMode mode)
    {
    }

    public void OnUpdate()
    {
    }

    public void FetchEvents(ref global::EngineMessages.InputData eventList)
    {
    }

    private void DrainPending(ref global::EngineMessages.InputData eventList)
    {
    }

    private void UpdateBotLogic(int needFrameCount)
    {
    }

    private void ExecuteRuleA()
    {
    }

    private void EnqueueRuleBMove(global::UnityEngine.Vector2 P, global::UnityEngine.Vector2 rawDir, float magnitude)
    {
    }

    private void ExecuteRuleB()
    {
    }

    private void ExecuteRuleC()
    {
    }

    private void ExecuteKickOff()
    {
    }

    private void ExecuteGoalKick()
    {
    }

    private void ExecuteFreeKick()
    {
    }

    private void ExecuteThrowIn()
    {
    }

    private void ExecutePenaltyKick()
    {
    }

    private void ExecuteCornerKick()
    {
    }

    private void ExecuteSetPieceHighpass(global::UnityEngine.Vector2 direction)
    {
    }

    private AutoInputSystem.TeammateInfo FindSetPiecePassTarget(global::UnityEngine.Vector2 P)
    {
        return null;
    }

    private static global::UnityEngine.Vector2 RandomDirection2D()
    {
        return default;
    }

    private global::UnityEngine.Vector2 AttackDir2D()
    {
        return default;
    }

    private global::UnityEngine.Vector2 OpponentGoal2D()
    {
        return default;
    }

    private global::UnityEngine.Vector2 BallCarrierPos2D()
    {
        return default;
    }

    private bool HasBallControl()
    {
        return false;
    }

    private static float AngleBetween(global::UnityEngine.Vector2 a, global::UnityEngine.Vector2 b)
    {
        return 0f;
    }

    private static float AngleToGoalLine(global::UnityEngine.Vector2 P, global::UnityEngine.Vector2 G, global::UnityEngine.Vector2 attackDir)
    {
        return 0f;
    }

    private static bool IsNearCenterLine(global::UnityEngine.Vector2 P)
    {
        return false;
    }

    private static bool IsGoalkeeper(global::UnityEngine.Vector2 P, global::UnityEngine.Vector2 attackDir)
    {
        return false;
    }

    private void ExecuteGoalkeeperClear()
    {
    }

    private global::UnityEngine.Vector2 FarPostDir(global::UnityEngine.Vector2 P)
    {
        return default;
    }

    private static global::UnityEngine.Vector2 StayInBounds(global::UnityEngine.Vector2 pos, global::UnityEngine.Vector2 desiredDir)
    {
        return default;
    }

    private static global::UnityEngine.Vector2 TowardGoalWithCenterBias(global::UnityEngine.Vector2 P, global::UnityEngine.Vector2 attackDir, float magnitude)
    {
        return default;
    }

    private static global::UnityEngine.Vector2 AwayFromOpponent(global::UnityEngine.Vector2 P, global::UnityEngine.Vector2 oppPos, global::UnityEngine.Vector2 moveTargetDir, float magnitude)
    {
        return default;
    }

    private global::UnityEngine.Vector2 TowardPenaltyArc(global::UnityEngine.Vector2 P, global::UnityEngine.Vector2 G, global::UnityEngine.Vector2 attackDir)
    {
        return default;
    }

    private AutoInputSystem.OpponentInfo FindNearestOpponent(global::UnityEngine.Vector2 P, global::UnityEngine.Vector2 forwardDir, float angleHalf)
    {
        return null;
    }

    private AutoInputSystem.TeammateInfo FindBestPassTarget(global::UnityEngine.Vector2 P, global::UnityEngine.Vector2 G, global::UnityEngine.Vector2 attackDir)
    {
        return null;
    }

    private void EnqueueJoystick(float worldX, float worldZ)
    {
    }

    private void TryChargeShot(global::UnityEngine.Vector2 farPostDir)
    {
    }

    private void TryPressButton(global::EngineMessages.InputFunction func)
    {
    }

    private void HoldButton(global::EngineMessages.InputFunction func, int delay = -1)
    {
    }

    private void ReleaseButton(global::EngineMessages.InputFunction func)
    {
    }

    private void UpdateHeldButton()
    {
    }

    private void ForceReleaseButton()
    {
    }

    private void OnGUI()
    {
    }

    public void OnMatchReset()
    {
    }
}