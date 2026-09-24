namespace Google.Play.AssetDelivery.Internal
{
    internal class PlayAssetBundleRequestImpl : global::Google.Play.AssetDelivery.PlayAssetBundleRequest
    {
        internal readonly global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl PackRequest;
        private readonly global::Google.Play.AssetDelivery.Internal.AssetDeliveryUpdateHandler _updateHandler;
        private global::Google.Play.AssetDelivery.AssetDeliveryStatus _loadingStatus;
        private global::Google.Play.AssetDelivery.AssetDeliveryErrorCode _loadingError;
        public override float DownloadProgress => 0f;
        public override global::Google.Play.AssetDelivery.AssetDeliveryStatus Status => global::Google.Play.AssetDelivery.AssetDeliveryStatus.Pending;
        public override global::Google.Play.AssetDelivery.AssetDeliveryErrorCode Error => global::Google.Play.AssetDelivery.AssetDeliveryErrorCode.NoError;

        public override event global::System.Action<global::Google.Play.AssetDelivery.PlayAssetBundleRequest> Completed
        {
            add
            {
            }

            remove
            {
            }
        }

        public PlayAssetBundleRequestImpl(global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl packRequest, global::Google.Play.AssetDelivery.Internal.AssetDeliveryUpdateHandler updateHandler)
        {
        }

        private void OnLoadingErrorOccurred(global::Google.Play.AssetDelivery.AssetDeliveryErrorCode errorCode)
        {
        }

        private void OnLoadingFinished(global::UnityEngine.AssetBundle loadedAssetBundle)
        {
        }

        private void OnPackRequestCompleted(global::Google.Play.AssetDelivery.PlayAssetPackRequest packRequest)
        {
        }

        private void StartLoadingAssetBundle()
        {
        }

        private global::System.Collections.IEnumerator CoLoadAssetBundle()
        {
            return null;
        }

        public override void AttemptCancel()
        {
        }
    }
}