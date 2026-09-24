namespace Common
{
	public interface IMessageReceiver
	{
		void ReceiveMessage(global::Common.GameMessage message);
	}
}
