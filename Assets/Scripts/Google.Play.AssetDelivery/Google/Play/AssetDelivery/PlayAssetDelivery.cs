namespace Google.Play.AssetDelivery
{
	public static class PlayAssetDelivery
	{
		private static global::Google.Play.AssetDelivery.Internal.PlayAssetDeliveryInternal _instance;

		private static global::Google.Play.AssetDelivery.Internal.PlayAssetDeliveryInternal Instance => null;

		public static bool IsDownloaded(string assetPackName)
		{
			return false;
		}

		public static global::Google.Play.AssetDelivery.PlayAssetBundleRequest RetrieveAssetBundleAsync(string assetBundleName)
		{
			return null;
		}

		public static global::Google.Play.AssetDelivery.PlayAssetBundleRequest RetrieveAssetBundleAsync(string assetBundleName, bool updateIfAvailable)
		{
			return null;
		}

		public static global::Google.Play.AssetDelivery.PlayAssetPackRequest RetrieveAssetPackAsync(string assetPackName)
		{
			return null;
		}

		public static global::Google.Play.AssetDelivery.PlayAssetPackRequest RetrieveAssetPackAsync(string assetPackName, bool updateIfAvailable)
		{
			return null;
		}

		public static global::Google.Play.AssetDelivery.PlayAssetPackBatchRequest RetrieveAssetPackBatchAsync(global::System.Collections.Generic.IList<string> assetPackNames)
		{
			return null;
		}

		public static global::Google.Play.AssetDelivery.PlayAssetPackBatchRequest RetrieveAssetPackBatchAsync(global::System.Collections.Generic.IList<string> assetPackNames, bool updateIfAvailable)
		{
			return null;
		}

		public static global::Google.Play.Common.PlayAsyncOperation<long, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> GetDownloadSize(string assetPackName)
		{
			return null;
		}

		public static global::Google.Play.Common.PlayAsyncOperation<global::System.Collections.Generic.IDictionary<string, global::Google.Play.AssetDelivery.PlayAssetPackDownloadInfo>, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> GetDownloadInfo(global::System.Collections.Generic.IList<string> assetPackNames)
		{
			return null;
		}

		public static global::Google.Play.Common.PlayAsyncOperation<global::Google.Play.Common.VoidResult, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> RemoveAssetPack(string assetPackName)
		{
			return null;
		}

		public static global::Google.Play.Common.PlayAsyncOperation<global::Google.Play.AssetDelivery.ConfirmationDialogResult, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> ShowCellularDataConfirmation()
		{
			return null;
		}

		public static global::Google.Play.Common.PlayAsyncOperation<global::Google.Play.AssetDelivery.ConfirmationDialogResult, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> ShowConfirmationDialog()
		{
			return null;
		}
	}
}
