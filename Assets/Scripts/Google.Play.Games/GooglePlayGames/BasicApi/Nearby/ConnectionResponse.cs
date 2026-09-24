namespace GooglePlayGames.BasicApi.Nearby
{
	public struct ConnectionResponse
	{
		public enum Status
		{
			Accepted = 0,
			Rejected = 1,
			ErrorInternal = 2,
			ErrorNetworkNotConnected = 3,
			ErrorEndpointNotConnected = 4,
			ErrorAlreadyConnected = 5
		}

		private static readonly byte[] EmptyPayload;

		private readonly long mLocalClientId;

		private readonly string mRemoteEndpointId;

		private readonly global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status mResponseStatus;

		private readonly byte[] mPayload;

		public long LocalClientId => 0L;

		public string RemoteEndpointId => null;

		public global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status ResponseStatus => global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status.Accepted;

		public byte[] Payload => null;

		private ConnectionResponse(long localClientId, string remoteEndpointId, global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status code, byte[] payload)
		{
			mLocalClientId = 0L;
			mRemoteEndpointId = null;
			mResponseStatus = global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status.Accepted;
			mPayload = null;
		}

		public static global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
		{
			return default;
		}

		public static global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
		{
			return default;
		}

		public static global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
		{
			return default;
		}

		public static global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
		{
			return default;
		}

		public static global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
		{
			return default;
		}

		public static global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
		{
			return default;
		}
	}
}
