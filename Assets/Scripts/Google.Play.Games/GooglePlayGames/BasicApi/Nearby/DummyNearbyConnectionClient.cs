namespace GooglePlayGames.BasicApi.Nearby
{
    public class DummyNearbyConnectionClient : global::GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient
    {
        public int MaxUnreliableMessagePayloadLength()
        {
            return 0;
        }

        public int MaxReliableMessagePayloadLength()
        {
            return 0;
        }

        public void SendReliable(global::System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
        }

        public void SendUnreliable(global::System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
        }

        public void StartAdvertising(string name, global::System.Collections.Generic.List<string> appIdentifiers, global::System.TimeSpan? advertisingDuration, global::System.Action<global::GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, global::System.Action<global::GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback)
        {
        }

        public void StopAdvertising()
        {
        }

        public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, global::System.Action<global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, global::GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
        }

        public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, global::GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
        }

        public void StartDiscovery(string serviceId, global::System.TimeSpan? advertisingTimeout, global::GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
        {
        }

        public void StopDiscovery(string serviceId)
        {
        }

        public void RejectConnectionRequest(string requestingEndpointId)
        {
        }

        public void DisconnectFromEndpoint(string remoteEndpointId)
        {
        }

        public void StopAllConnections()
        {
        }

        public string LocalEndpointId()
        {
            return null;
        }

        public string LocalDeviceId()
        {
            return null;
        }

        public string GetAppBundleId()
        {
            return null;
        }

        public string GetServiceId()
        {
            return null;
        }
    }
}