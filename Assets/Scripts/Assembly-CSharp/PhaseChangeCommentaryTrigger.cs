public class PhaseChangeCommentaryTrigger : CommentatorTrigger
{
	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	private bool CheckGameOver(AISampleBase match)
	{
		return false;
	}
}
