namespace GooglePlayGames.Android
{
    public class AndroidNearbyConnectionClient : global::GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient
    {
        private class AdvertisingConnectionLifecycleCallbackProxy : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::GooglePlayGames.BasicApi.Nearby.AdvertisingResult> mResultCallback;
            private global::System.Action<global::GooglePlayGames.BasicApi.Nearby.ConnectionRequest> mConnectionRequestCallback;
            private global::GooglePlayGames.Android.AndroidNearbyConnectionClient mClient;
            private string mLocalEndpointName;
            public AdvertisingConnectionLifecycleCallbackProxy(global::System.Action<global::GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, global::System.Action<global::GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback, global::GooglePlayGames.Android.AndroidNearbyConnectionClient client) : base((string)null)
            {
            }

            public void onConnectionInitiated(string endpointId, global::UnityEngine.AndroidJavaObject connectionInfo)
            {
            }

            public void onConnectionResult(string endpointId, global::UnityEngine.AndroidJavaObject connectionResolution)
            {
            }

            public void onDisconnected(string endpointId)
            {
            }
        }

        private class PayloadCallback : global::UnityEngine.AndroidJavaProxy
        {
            private global::GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;
            public PayloadCallback(global::GooglePlayGames.BasicApi.Nearby.IMessageListener listener) : base((string)null)
            {
            }

            public void onPayloadReceived(string endpointId, global::UnityEngine.AndroidJavaObject payload)
            {
            }
        }

        private class DiscoveringConnectionLifecycleCallback : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action<global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse> mResponseCallback;
            private global::GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;
            private global::UnityEngine.AndroidJavaObject mClient;
            public DiscoveringConnectionLifecycleCallback(global::System.Action<global::GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, global::GooglePlayGames.BasicApi.Nearby.IMessageListener listener, global::UnityEngine.AndroidJavaObject client) : base((string)null)
            {
            }

            public void onConnectionInitiated(string endpointId, global::UnityEngine.AndroidJavaObject connectionInfo)
            {
            }

            public void onConnectionResult(string endpointId, global::UnityEngine.AndroidJavaObject connectionResolution)
            {
            }

            public void onDisconnected(string endpointId)
            {
            }
        }

        private class EndpointDiscoveryCallback : global::UnityEngine.AndroidJavaProxy
        {
            private global::GooglePlayGames.BasicApi.Nearby.IDiscoveryListener mListener;
            public EndpointDiscoveryCallback(global::GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener) : base((string)null)
            {
            }

            public void onEndpointFound(string endpointId, global::UnityEngine.AndroidJavaObject endpointInfo)
            {
            }

            public void onEndpointLost(string endpointId)
            {
            }

            private global::GooglePlayGames.BasicApi.Nearby.EndpointDetails CreateEndPointDetails(string endpointId, global::UnityEngine.AndroidJavaObject endpointInfo)
            {
                return default;
            }
        }

        private class OnGameThreadMessageListener : global::GooglePlayGames.BasicApi.Nearby.IMessageListener
        {
            private readonly global::GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;
            public OnGameThreadMessageListener(global::GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
            {
            }

            public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
            {
            }

            public void OnRemoteEndpointDisconnected(string remoteEndpointId)
            {
            }
        }

        private class OnGameThreadDiscoveryListener : global::GooglePlayGames.BasicApi.Nearby.IDiscoveryListener
        {
            private readonly global::GooglePlayGames.BasicApi.Nearby.IDiscoveryListener mListener;
            public OnGameThreadDiscoveryListener(global::GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
            {
            }

            public void OnEndpointFound(global::GooglePlayGames.BasicApi.Nearby.EndpointDetails discoveredEndpoint)
            {
            }

            public void OnEndpointLost(string lostEndpointId)
            {
            }
        }

        private global::UnityEngine.AndroidJavaObject mClient;
        private static readonly long NearbyClientId;
        private static readonly int ApplicationInfoFlags;
        private static readonly string ServiceId;
        protected global::GooglePlayGames.BasicApi.Nearby.IMessageListener mAdvertisingMessageListener;
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

        private void InternalSend(global::System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
        }

        public void StartAdvertising(string name, global::System.Collections.Generic.List<string> appIdentifiers, global::System.TimeSpan? advertisingDuration, global::System.Action<global::GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, global::System.Action<global::GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback)
        {
        }

        private global::UnityEngine.AndroidJavaObject CreateAdvertisingOptions()
        {
            return null;
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

        public void StartDiscovery(string serviceId, global::System.TimeSpan? advertisingDuration, global::GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
        {
        }

        private global::UnityEngine.AndroidJavaObject CreateDiscoveryOptions()
        {
            return null;
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

        public string GetAppBundleId()
        {
            return null;
        }

        public string GetServiceId()
        {
            return null;
        }

        private static string ReadServiceId()
        {
            return null;
        }

        private static global::System.Action<T> ToOnGameThread<T>(global::System.Action<T> toConvert)
        {
            return null;
        }

        private static global::System.Action<T1, T2> ToOnGameThread<T1, T2>(global::System.Action<T1, T2> toConvert)
        {
            return null;
        }
    }
}