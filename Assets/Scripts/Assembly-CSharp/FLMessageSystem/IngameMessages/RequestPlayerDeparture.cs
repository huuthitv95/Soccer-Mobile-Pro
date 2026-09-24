namespace FLMessageSystem.IngameMessages
{
	public struct RequestPlayerDeparture
	{
		public int PlayerId;

		public bool ValidateRequest;

		public RequestPlayerDeparture(int playerId, bool validateRequest)
		{
			PlayerId = 0;
			ValidateRequest = false;
		}
	}
}
