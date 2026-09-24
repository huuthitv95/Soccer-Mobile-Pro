public class ShootCommentatorTrigger : CommentatorTrigger
{
	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand HandleShoot(AISampleBase match, bool useSpecial)
	{
		return default;
	}
}
