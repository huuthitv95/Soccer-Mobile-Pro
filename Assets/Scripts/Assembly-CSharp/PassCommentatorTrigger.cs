public class PassCommentatorTrigger : CommentatorTrigger
{
	private bool throughpassFlag;

	private int BallHoldingTeam;

	private const float CheckPassResultDelay = 0.5f;

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand HandleShortPass(AISampleBase match, bool useSpecial)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand HandleLongPass(AISampleBase match, bool useSpecial)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand HandleThroughPass(AISampleBase match, bool useSpecial)
	{
		return default;
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
