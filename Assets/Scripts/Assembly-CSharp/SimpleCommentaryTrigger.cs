public class SimpleCommentaryTrigger : CommentatorTrigger
{
	private new global::System.Collections.Generic.Dictionary<FLClientOpCode, ICommandGenerator> _focusClientCodes;

	private new global::System.Collections.Generic.Dictionary<OpCode, ICommandGenerator> _focusCodes;

	private global::System.Func<AISampleBase, bool> skipCondition;

	public override global::System.Collections.Generic.IEnumerable<FLClientOpCode> FocusClientOpcode()
	{
		return null;
	}

	public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode()
	{
		return null;
	}

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match)
	{
		return default;
	}

	public override CommentatorTrigger.CommentatorCommand GenerateCommand(FLClientOpCode code, object message, AISampleBase match)
	{
		return default;
	}

	public SimpleCommentaryTrigger(global::System.Collections.Generic.Dictionary<FLClientOpCode, ICommandGenerator> clientCodeHandlers, global::System.Collections.Generic.Dictionary<OpCode, ICommandGenerator> codeHandlers)
	{
	}

	public SimpleCommentaryTrigger((FLClientOpCode, ICommandGenerator) clientCodeHandler, (OpCode, ICommandGenerator) codeHandler)
	{
	}

	public SimpleCommentaryTrigger(FLClientOpCode clientCode, global::SL.RandomList<AllCommentaryIds.CommentaryID> ids, bool stop = false)
	{
	}

	public SimpleCommentaryTrigger(OpCode code, global::SL.RandomList<AllCommentaryIds.CommentaryID> ids, bool stop = false, global::System.Func<AISampleBase, bool> skipCondition = null)
	{
	}

	public SimpleCommentaryTrigger((FLClientOpCode, global::SL.RandomList<AllCommentaryIds.CommentaryID>) play, FLClientOpCode stop)
	{
	}
}
