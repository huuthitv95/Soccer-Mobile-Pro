namespace Google.Play.AssetDelivery.Internal
{
	internal class AssetPackState
	{
		public string Name { get; private set; }

		public long BytesDownloaded { get; private set; }

		public long TotalBytesToDownload { get; private set; }

		public int Status { get; private set; }

		public int ErrorCode { get; private set; }

		public AssetPackState(global::UnityEngine.AndroidJavaObject javaAssetPackState)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
