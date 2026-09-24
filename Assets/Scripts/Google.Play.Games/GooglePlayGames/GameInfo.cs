namespace GooglePlayGames
{
	public static class GameInfo
	{
		private const string UnescapedApplicationId = "APP_ID";

		private const string UnescapedIosClientId = "IOS_CLIENTID";

		private const string UnescapedWebClientId = "WEB_CLIENTID";

		private const string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";

		public const string ApplicationId = "725369338500";

		public const string IosClientId = "__IOS_CLIENTID__";

		public const string WebClientId = "";

		public const string NearbyConnectionServiceId = "";

		public static bool ApplicationIdInitialized()
		{
			return false;
		}

		public static bool IosClientIdInitialized()
		{
			return false;
		}

		public static bool WebClientIdInitialized()
		{
			return false;
		}

		public static bool NearbyConnectionsInitialized()
		{
			return false;
		}

		private static string ToEscapedToken(string token)
		{
			return null;
		}
	}
}
