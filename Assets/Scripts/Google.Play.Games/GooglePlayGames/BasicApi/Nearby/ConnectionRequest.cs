namespace GooglePlayGames.BasicApi.Nearby
{
	public struct ConnectionRequest
	{
		private readonly global::GooglePlayGames.BasicApi.Nearby.EndpointDetails mRemoteEndpoint;

		private readonly byte[] mPayload;

		public global::GooglePlayGames.BasicApi.Nearby.EndpointDetails RemoteEndpoint => default;

		public byte[] Payload => null;

		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		{
			mRemoteEndpoint = default;
			mPayload = null;
		}
	}
}
