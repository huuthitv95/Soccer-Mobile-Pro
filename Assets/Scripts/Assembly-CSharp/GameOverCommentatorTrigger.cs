public class GameOverCommentatorTrigger : CommentatorTrigger
{
	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(FLClientOpCode code, object message, AISampleBase match)
	{
		return default;
	}
}
