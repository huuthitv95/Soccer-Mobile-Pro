public class ShootResultCommentatorTrigger : CommentatorTrigger
{
	private bool penalty;

	private bool placeKick;

	private bool goal;

	private bool touchNet;

	private bool touchGoalpost;

	private int lastGoalTime;

	private int tmpLastGoalTime;

	private global::System.Collections.Generic.Dictionary<int, int> goalRecord;

	public override float GetDelayTime(CommentatorTrigger.DelayedActionId actionId)
	{
		return 0f;
	}

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	public override CommentatorTrigger.CommentatorCommand OnDelayInvoke(CommentatorTrigger.CommentatorCommand action, AISampleBase match)
	{
		return default;
	}

	private bool SustainedPressure(AISampleBase match, int team)
	{
		return false;
	}
}
