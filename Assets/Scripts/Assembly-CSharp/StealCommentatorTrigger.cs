public class StealCommentatorTrigger : CommentatorTrigger
{
	private bool goal;

	public override float GetDelayTime(CommentatorTrigger.DelayedActionId actionId)
	{
		return 0f;
	}

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand PlayInterfere()
	{
		return default;
	}

	public override CommentatorTrigger.CommentatorCommand OnDelayInvoke(CommentatorTrigger.CommentatorCommand action, AISampleBase match)
	{
		return default;
	}

	private CommentatorTrigger.CommentatorCommand PlayCommonSteal()
	{
		return default;
	}
}
