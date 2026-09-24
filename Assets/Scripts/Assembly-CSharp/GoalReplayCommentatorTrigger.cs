public class GoalReplayCommentatorTrigger : CommentatorTrigger
{
    private bool canRetry;
    public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
    {
        return default;
    }

    public override CommentatorTrigger.CommentatorCommand GenerateCommand(FLClientOpCode code, object message, AISampleBase match)
    {
        return default;
    }

    public override void NotifyPlay()
    {
    }

    public override void NotifySkip(global::UnityEngine.MonoBehaviour mono, IMatch match, global::System.Func<CommentatorTrigger.CommentatorCommand, IMatch, bool> handleCmd)
    {
    }

    public override float GetDelayTime(CommentatorTrigger.DelayedActionId actionId)
    {
        return 0f;
    }

    public override CommentatorTrigger.CommentatorCommand OnDelayInvoke(CommentatorTrigger.CommentatorCommand action, AISampleBase match)
    {
        return default;
    }
}