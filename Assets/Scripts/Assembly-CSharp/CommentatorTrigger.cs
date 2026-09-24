public abstract class CommentatorTrigger
{
    public enum DribbleFalgType
    {
        Clearances_Interceptions = 0,
        Header_Shot = 1,
        Count = 2
    }

    public enum CommandType
    {
        None = 0,
        Play = 1,
        Break = 2,
        DelayedInvoke = 3
    }

    public enum DelayedActionId
    {
        None = 0,
        ShortPassChecker = 1,
        LongPassChecker = 2,
        ThroughPassChecker = 3,
        CheckPassResult = 4,
        ThroughPassTimeOutChecker = 5,
        ClearanceChecker = 6,
        InterfereChecker = 7,
        WoodworkChecker = 8,
        GoalReplayChecker = 9,
        CornerLongPassChecker = 10,
        GoalMissedChecker = 11
    }

    public struct CommentatorCommand
    {
        public CommentatorTrigger.CommandType type;
        public AllCommentaryIds.CommentaryID id;
        public CommentatorTrigger owner;
        public CommentatorTrigger.DelayedActionId actionId;
        public CommentatorTrigger.DelayedActionId extraId;
        public float time;
        public int extraData;
        public CommentatorCommand(CommentatorTrigger.CommandType type, AllCommentaryIds.CommentaryID id, CommentatorTrigger owner)
        {
            this.type = CommentatorTrigger.CommandType.None;
            this.id = null;
            this.owner = null;
            actionId = CommentatorTrigger.DelayedActionId.None;
            extraId = CommentatorTrigger.DelayedActionId.None;
            time = 0f;
            extraData = 0;
        }

        public CommentatorCommand(CommentatorTrigger owner)
        {
            type = CommentatorTrigger.CommandType.None;
            id = null;
            this.owner = null;
            actionId = CommentatorTrigger.DelayedActionId.None;
            extraId = CommentatorTrigger.DelayedActionId.None;
            time = 0f;
            extraData = 0;
        }

        public static CommentatorTrigger.CommentatorCommand CreateDelayInvokeCommand(CommentatorTrigger owner, CommentatorTrigger.DelayedActionId extraId)
        {
            return default;
        }
    }

    public struct BallBehaviorHandler
    {
        public enum PassDirection
        {
            Forward = 0,
            Backward = 1,
            Horizontal = 2
        }

        public enum FieldHorizontalArea
        {
            Left = 0,
            Right = 1,
            Center = 2
        }

        private const float MinCrossPassDistance = 15f;
        public global::UnityEngine.Vector2 attackDir;
        public global::UnityEngine.Vector2 ballPos { get; private set; }
        public int ballholdingPlayerId { get; private set; }
        public float recordTime { get; private set; }
        public CommentatorTrigger.DelayedActionId actionId { get; set; }

        public bool TimeOut()
        {
            return false;
        }

        public void MarkTimeOut()
        {
        }

        public void RecordBallPos(AISampleBase match, CommentatorTrigger.DelayedActionId actionId)
        {
        }

        public global::UnityEngine.Vector2 CalculateBallDirection(AISampleBase match)
        {
            return default;
        }

        public CommentatorTrigger.BallBehaviorHandler.PassDirection CheckPassDirection(AISampleBase match)
        {
            return CommentatorTrigger.BallBehaviorHandler.PassDirection.Forward;
        }

        public static CommentatorTrigger.BallBehaviorHandler.PassDirection CheckPassDirection(global::UnityEngine.Vector2 ballDir, global::UnityEngine.Vector2 attackDir)
        {
            return CommentatorTrigger.BallBehaviorHandler.PassDirection.Forward;
        }

        public static CommentatorTrigger.BallBehaviorHandler.FieldHorizontalArea CheckFieldArea(global::UnityEngine.Vector2 ballPos, global::UnityEngine.Vector2 attackDir)
        {
            return CommentatorTrigger.BallBehaviorHandler.FieldHorizontalArea.Left;
        }

        public CommentatorTrigger.BallBehaviorHandler.FieldHorizontalArea CheckFieldArea(AISampleBase match)
        {
            return CommentatorTrigger.BallBehaviorHandler.FieldHorizontalArea.Left;
        }

        public static bool CheckCrossPass(global::UnityEngine.Vector2 ballStartPos, global::UnityEngine.Vector2 ballEndPos, global::UnityEngine.Vector2 attackDir)
        {
            return false;
        }

        public static bool CheckCornerKickToPenalty(global::UnityEngine.Vector2 ballPos, global::UnityEngine.Vector2 ballDir, global::UnityEngine.Vector2 attackDir)
        {
            return false;
        }

        public bool CheckCrossPass(AISampleBase match)
        {
            return false;
        }

        public bool IsInPenaltyArea(AISampleBase match)
        {
            return false;
        }

        public static bool IsInPenaltyArea(global::UnityEngine.Vector2 pos, global::UnityEngine.Vector2 attackDir)
        {
            return false;
        }

        public static bool IsInPenaltyXArea(global::UnityEngine.Vector2 pos, global::UnityEngine.Vector2 attackDir)
        {
            return false;
        }

        public static bool IsInFrontArea(global::UnityEngine.Vector2 pos, global::UnityEngine.Vector2 attackDir)
        {
            return false;
        }

        public static bool IsInFrontCenterArea(global::UnityEngine.Vector2 pos, global::UnityEngine.Vector2 attackDir)
        {
            return false;
        }

        public static bool IsInCenterArea(global::UnityEngine.Vector2 pos, global::UnityEngine.Vector2 attackDir)
        {
            return false;
        }
    }

    protected static bool placekickFlag;
    protected static bool[] dribbleFalg;
    protected static global::System.Random RandomCreator;
    protected static CommentatorTrigger.BallBehaviorHandler commonPassHandler;
    protected virtual global::System.Collections.Generic.List<OpCode> _focusCodes { get; set; }
    protected virtual global::System.Collections.Generic.List<FLClientOpCode> _focusClientCodes { get; set; }

    public virtual global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode()
    {
        return null;
    }

    public virtual global::System.Collections.Generic.IEnumerable<FLClientOpCode> FocusClientOpcode()
    {
        return null;
    }

    public abstract CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match);
    public virtual CommentatorTrigger.CommentatorCommand GenerateCommand(FLClientOpCode code, object message, AISampleBase match)
    {
        return default;
    }

    public virtual float GetDelayTime(CommentatorTrigger.DelayedActionId actionId)
    {
        return 0f;
    }

    public virtual CommentatorTrigger.CommentatorCommand OnDelayInvoke(CommentatorTrigger.CommentatorCommand action, AISampleBase match)
    {
        return default;
    }

    public virtual void NotifyPlay()
    {
    }

    public virtual void NotifySkip(global::UnityEngine.MonoBehaviour mono, IMatch match, global::System.Func<CommentatorTrigger.CommentatorCommand, IMatch, bool> handleCmd)
    {
    }

    public static void RestRandomSeed()
    {
    }

    protected bool RollForSpecialCommentary()
    {
        return false;
    }
}