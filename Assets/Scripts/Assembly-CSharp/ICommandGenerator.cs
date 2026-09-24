public interface ICommandGenerator
{
	CommentatorTrigger.CommentatorCommand GenerateCommand(OpCode code, object message, AISampleBase match);

	CommentatorTrigger.CommentatorCommand GenerateCommand(FLClientOpCode code, object message, AISampleBase match);

	void SetOwner(CommentatorTrigger owner);
}
