public class DribbleCommentatorTrigger : CommentatorTrigger
{
    private int playerId;
    private float lastEventTime;
    private bool canPlay;
    private int cleanPlayer;
    private float DribbleLowPriorityDelay;
    public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
    {
        return default;
    }

    public override void NotifyPlay()
    {
    }
}