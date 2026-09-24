public class FullPlayerStatisticsChecker
{
    private struct EventCausalityChecker
    {
        public CommentatorTrigger.BallBehaviorHandler ballChecker;
        public InGamePlayer lastPlayer;
        public void MarkTimeout()
        {
        }

        public void RecordBallPos(AISampleBase match, CommentatorTrigger.DelayedActionId actionId)
        {
        }

        public bool TimeOut()
        {
            return false;
        }
    }

    private struct FreekickGoalChecker
    {
        private int shotFlag;
        private bool passFlag;
        private float shotTime;
        public void Reset()
        {
        }

        public void RecordShot()
        {
        }

        public void RecordPass()
        {
        }

        public bool Check()
        {
            return false;
        }
    }

    private class FormationMovementChecker
    {
        private enum PositionState
        {
            InPosition = 0,
            OutOfPosition = 1,
            CriticalPosition = 2,
            PrepareState = 3,
            HoldBallState = 4
        }

        private InGamePlayer player;
        private global::UnityEngine.Transform playerTransform;
        private FullPlayerStatisticsChecker.FormationMovementChecker.PositionState currentState;
        private float lastStateChangeTime;
        private global::UnityEngine.Vector3 targetPosition;
        public bool IsPreparing => false;

        public FormationMovementChecker(InGamePlayer player)
        {
        }

        public void UpdateTargetPosition(global::UnityEngine.Vector3 targetPosition)
        {
        }

        public void Check(InGamePlayer currentBallHolder, bool isMatchActive)
        {
        }
    }

    private AISampleBase aiSample;
    private FullPlayerStatisticsChecker.EventCausalityChecker passChecker;
    private FullPlayerStatisticsChecker.EventCausalityChecker shotChecker;
    private FullPlayerStatisticsChecker.FreekickGoalChecker freekickGoalChecker;
    private FullPlayerStatisticsChecker.FreekickGoalChecker penaltyGoalChecker;
    public static float InPositionDistanceThresholdSqr;
    public static float OutOfPositionDistanceThresholdSqr;
    public static float InPositionEventThreshold;
    public static float OutOfPositionEventThreshold;
    public static float PositionResetPrepareTime;
    private global::System.Collections.Generic.Dictionary<int, FullPlayerStatisticsChecker.FormationMovementChecker> formationMovementCheckers;
    private float lastCheckTime;
    public FullPlayerStatisticsChecker(AISampleBase aiSample)
    {
    }

    private void UpdatePlayerStatistics(global::EngineMessages.PlayerStatistics aiData)
    {
    }

    private void ResetEventCausalityChecker()
    {
    }

    private void HandlePassFail()
    {
    }

    private void HandleDribbleFail(int teamId, InGamePlayer player)
    {
    }

    public bool PlayerFormationPreparingSate(int id)
    {
        return false;
    }

    internal void HandleMessage(AISampleBase.MessageBuffer message)
    {
    }

    private void OnGameOver(object message)
    {
    }

    public static float Rating(FormationTool.UIPosition role, PlayerStatistics playerStatistics, bool clamp = true)
    {
        return 0f;
    }

    public static float Rating(FormationTool.UIPosition role, global::FLMessageSystem.FullPlayerStatisticsType statisticsType, int eventCount = 1)
    {
        return 0f;
    }

    private static float GetWeight(FormationTool.UIPosition role, global::FLDataTable.PlayerIngameRatingRules table)
    {
        return 0f;
    }
}