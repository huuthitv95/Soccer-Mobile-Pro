public class SimplePlayCommandGenerator : ICommandGenerator
{
    private global::SL.RandomList<AllCommentaryIds.CommentaryID> ids;
    private CommentatorTrigger owner;
    public CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
    {
        return default;
    }

    public CommentatorTrigger.CommentatorCommand GenerateCommand(FLClientOpCode code, object message, AISampleBase match)
    {
        return default;
    }

    public SimplePlayCommandGenerator(global::SL.RandomList<AllCommentaryIds.CommentaryID> ids)
    {
    }

    public void SetOwner(CommentatorTrigger owner)
    {
    }
}