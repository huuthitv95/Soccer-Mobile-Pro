namespace Google.Play.AssetDelivery.Internal
{
    internal class PlayRequestRepository
    {
        private global::System.Collections.Generic.Dictionary<string, global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl> _requestsByName;
        private global::System.Collections.Generic.Dictionary<string, global::Google.Play.AssetDelivery.Internal.PlayAssetBundleRequestImpl> _assetBundleRequestsByName;
        public void AddAssetBundleRequest(global::Google.Play.AssetDelivery.Internal.PlayAssetBundleRequestImpl assetBundleRequest)
        {
        }

        public void AddRequest(global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl request)
        {
        }

        public void RemoveRequest(string name)
        {
        }

        public bool TryGetAssetBundleRequest(string name, out global::Google.Play.AssetDelivery.Internal.PlayAssetBundleRequestImpl assetBundleRequest)
        {
            assetBundleRequest = null;
            return false;
        }

        public bool TryGetRequest(string name, out global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl request)
        {
            request = null;
            return false;
        }

        public global::System.Collections.Generic.IList<global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl> GetRequestsWithStatus(global::Google.Play.AssetDelivery.AssetDeliveryStatus status)
        {
            return null;
        }

        public string[] GetActiveAssetPackNames()
        {
            return null;
        }

        public bool ContainsAssetBundleRequest(string name)
        {
            return false;
        }

        public bool ContainsRequest(string name)
        {
            return false;
        }
    }
}