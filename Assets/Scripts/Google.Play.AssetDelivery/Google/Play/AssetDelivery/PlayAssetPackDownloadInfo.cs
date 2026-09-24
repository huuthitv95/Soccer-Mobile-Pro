namespace Google.Play.AssetDelivery
{
	public abstract class PlayAssetPackDownloadInfo
	{
		public long DownloadSize { get; protected set; }

		public global::Google.Play.AssetDelivery.AssetPackUpdateAvailability UpdateAvailability { get; protected set; }

		public string AvailableVersionTag { get; protected set; }

		public string InstalledVersionTag { get; protected set; }
	}
}
