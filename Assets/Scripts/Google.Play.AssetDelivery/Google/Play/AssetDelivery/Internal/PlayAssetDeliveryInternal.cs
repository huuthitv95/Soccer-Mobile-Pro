namespace Google.Play.AssetDelivery.Internal
{
    internal class PlayAssetDeliveryInternal
    {
        private const string AssetPackFolderName = "assetpack";
        private readonly global::Google.Play.AssetDelivery.Internal.AssetPackManager _assetPackManager;
        private readonly global::Google.Play.AssetDelivery.Internal.AssetDeliveryUpdateHandler _updateHandler;
        private readonly global::Google.Play.AssetDelivery.Internal.PlayRequestRepository _requestRepository;
        internal PlayAssetDeliveryInternal()
        {
        }

        internal bool IsDownloaded(string assetBundleName)
        {
            return false;
        }

        internal global::Google.Play.AssetDelivery.PlayAssetBundleRequest RetrieveAssetBundleAsyncInternal(string assetBundleName)
        {
            return null;
        }

        internal global::Google.Play.AssetDelivery.PlayAssetBundleRequest RetrieveAssetBundleAsyncInternal(string assetBundleName, bool updateIfAvailable)
        {
            return null;
        }

        private global::Google.Play.AssetDelivery.Internal.PlayAssetBundleRequestImpl InitializeAssetBundleRequest(string assetBundleName)
        {
            return null;
        }

        internal global::Google.Play.AssetDelivery.PlayAssetPackRequest RetrieveAssetPackAsyncInternal(string assetPackName)
        {
            return null;
        }

        internal global::Google.Play.AssetDelivery.PlayAssetPackRequest RetrieveAssetPackAsyncInternal(string assetPackName, bool updateIfAvailable)
        {
            return null;
        }

        internal global::Google.Play.AssetDelivery.PlayAssetPackBatchRequest RetrieveAssetPackBatchAsyncInternal(global::System.Collections.Generic.IList<string> assetPackNames)
        {
            return null;
        }

        internal global::Google.Play.AssetDelivery.PlayAssetPackBatchRequest RetrieveAssetPackBatchAsyncInternal(global::System.Collections.Generic.IList<string> assetPackNames, bool updateIfAvailable)
        {
            return null;
        }

        private global::Google.Play.AssetDelivery.PlayAssetPackBatchRequest CreateAndInitiateBatchRequest(global::System.Collections.Generic.IList<string> assetPackNames, global::System.Func<string, bool> isPackAvailable)
        {
            return null;
        }

        internal global::Google.Play.Common.PlayAsyncOperation<global::Google.Play.AssetDelivery.ConfirmationDialogResult, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> ShowCellularDataConfirmationInternal()
        {
            return null;
        }

        internal global::Google.Play.Common.PlayAsyncOperation<global::Google.Play.AssetDelivery.ConfirmationDialogResult, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> ShowConfirmationDialogInternal()
        {
            return null;
        }

        internal global::Google.Play.Common.PlayAsyncOperation<long, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> GetDownloadSizeInternal(string assetBundleName)
        {
            return null;
        }

        internal global::Google.Play.Common.PlayAsyncOperation<global::System.Collections.Generic.IDictionary<string, global::Google.Play.AssetDelivery.PlayAssetPackDownloadInfo>, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> GetDownloadInfoInternal(global::System.Collections.Generic.IList<string> assetPackNames)
        {
            return null;
        }

        internal global::Google.Play.Common.PlayAsyncOperation<global::Google.Play.Common.VoidResult, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> RemoveAssetPackInternal(string assetBundleName)
        {
            return null;
        }

        private global::Google.Play.AssetDelivery.AssetLocation GetAssetLocation(string assetBundleName)
        {
            return null;
        }

        private global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl GetExistingAssetPackRequest(string assetPackName)
        {
            return null;
        }

        private global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl InitializeAssetPackRequest(string assetPackName)
        {
            return null;
        }

        private global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl CreateAssetPackRequest(string assetPackName)
        {
            return null;
        }

        private global::Google.Play.AssetDelivery.Internal.PlayAssetBundleRequestImpl CreateAssetBundleRequest(string assetBundleName)
        {
            return null;
        }

        private void InitiateRequest(global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl request)
        {
        }

        private void InitiateRequest(global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl request, bool updateIfAvailable)
        {
        }

        private bool IsCurrentVersionGoodEnough(string assetPackName, bool wantNewerVersion)
        {
            return false;
        }

        private void StartRequest(global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl request, bool isAvailable)
        {
        }

        private void ProcessPackStateUpdate(global::Google.Play.AssetDelivery.Internal.AssetPackState newState)
        {
        }

        private void UpdateRequest(global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl request, global::Google.Play.AssetDelivery.Internal.AssetPackState newState, int errorCode)
        {
        }

        private bool IsInstallTimeAssetBundle(string assetBundleName)
        {
            return false;
        }

        private global::Google.Play.AssetDelivery.ConfirmationDialogResult ConvertToConfirmationDialogResult(int resultCode)
        {
            return global::Google.Play.AssetDelivery.ConfirmationDialogResult.Unknown;
        }
    }
}