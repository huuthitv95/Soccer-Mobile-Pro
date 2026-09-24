namespace Google.Play.AssetDelivery.Internal
{
    internal class PlayAssetPackRequestImpl : global::Google.Play.AssetDelivery.PlayAssetPackRequest
    {
        public readonly string AssetPackName;
        private const string AssetPackFolderName = "assetpack";
        private readonly global::Google.Play.AssetDelivery.Internal.AssetPackManager _assetPackManager;
        private bool _initializedInPlayCore;
        private readonly global::Google.Play.AssetDelivery.Internal.PlayRequestRepository _requestRepository;
        private global::System.Action _onInitializedInPlayCore;
        public override event global::System.Action<global::Google.Play.AssetDelivery.PlayAssetPackRequest> Completed
        {
            add
            {
            }

            remove
            {
            }
        }

        public PlayAssetPackRequestImpl(string assetPackName, global::Google.Play.AssetDelivery.Internal.AssetPackManager assetPackManager, global::Google.Play.AssetDelivery.Internal.PlayRequestRepository requestRepository)
        {
        }

        public void UpdateState(global::Google.Play.AssetDelivery.AssetDeliveryStatus status, long bytesDownloaded, long totalBytesToDownload)
        {
        }

        public void OnInitializedInPlayCore()
        {
        }

        public void OnPackAvailable()
        {
        }

        public void OnErrorOccured(global::Google.Play.AssetDelivery.AssetDeliveryErrorCode errorCode)
        {
        }

        public override global::UnityEngine.AssetBundleCreateRequest LoadAssetBundleAsync(string assetBundlePath)
        {
            return null;
        }

        public override global::Google.Play.AssetDelivery.AssetLocation GetAssetLocation(string assetPath)
        {
            return null;
        }

        public override void AttemptCancel()
        {
        }

        private void CancelPlayCore()
        {
        }

        private void DeferCancelPlayCore()
        {
        }
    }
}