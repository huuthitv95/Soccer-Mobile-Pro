public class SimpleStopCommandGenerator : ICommandGenerator
{
    private CommentatorTrigger owner;
    public CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
    {
        return default;
    }

    public CommentatorTrigger.CommentatorCommand GenerateCommand(FLClientOpCode code, object message, AISampleBase match)
    {
        return default;
    }

    public void SetOwner(CommentatorTrigger owner)
    {
    }
}