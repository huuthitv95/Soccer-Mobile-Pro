public class SetPieceCommentatorTrigger : CommentatorTrigger
{
	private int SetpieceMode;

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand HandleGoalKick(AISampleBase match, bool useSpecial, OpCode opCode)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand HandleConerKick(AISampleBase match, bool useSpecial, OpCode opCode)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand HandleFreeKick(AISampleBase match, bool useSpecial, OpCode opCode)
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
