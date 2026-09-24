namespace GooglePlayGames.BasicApi.Nearby
{
	public struct AdvertisingResult
	{
		private readonly global::GooglePlayGames.BasicApi.ResponseStatus mStatus;

		private readonly string mLocalEndpointName;

		public bool Succeeded => false;

		public global::GooglePlayGames.BasicApi.ResponseStatus Status => (global::GooglePlayGames.BasicApi.ResponseStatus)0;

		public string LocalEndpointName => null;

		public AdvertisingResult(global::GooglePlayGames.BasicApi.ResponseStatus status, string localEndpointName)
		{
			mStatus = (global::GooglePlayGames.BasicApi.ResponseStatus)0;
			mLocalEndpointName = null;
		}
	}
}
