namespace GooglePlayGames.BasicApi.Nearby
{
	public struct NearbyConnectionConfiguration
	{
		public const int MaxUnreliableMessagePayloadLength = 1168;

		public const int MaxReliableMessagePayloadLength = 4096;

		private readonly global::System.Action<global::GooglePlayGames.BasicApi.Nearby.InitializationStatus> mInitializationCallback;

		private readonly long mLocalClientId;

		public long LocalClientId => 0L;

		public global::System.Action<global::GooglePlayGames.BasicApi.Nearby.InitializationStatus> InitializationCallback => null;

		public NearbyConnectionConfiguration(global::System.Action<global::GooglePlayGames.BasicApi.Nearby.InitializationStatus> callback, long localClientId)
		{
			mInitializationCallback = null;
			mLocalClientId = 0L;
		}
	}
}
