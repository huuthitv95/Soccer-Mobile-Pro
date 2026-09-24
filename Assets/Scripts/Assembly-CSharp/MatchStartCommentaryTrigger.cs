public class MatchStartCommentaryTrigger : CommentatorTrigger
{
	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(FLClientOpCode code, object message, AISampleBase match)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand HandleMatchStartTimelineStart(FLClientOpCode code, object message, AISampleBase match)
	{
		return default;
	}
}
