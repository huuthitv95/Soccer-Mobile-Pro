public class FoulCommentatorTrigger : CommentatorTrigger
{
	private bool yellowCard;

	private bool redCard;

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(FLClientOpCode code, object message, AISampleBase match)
	{
		return default;
	}
}
