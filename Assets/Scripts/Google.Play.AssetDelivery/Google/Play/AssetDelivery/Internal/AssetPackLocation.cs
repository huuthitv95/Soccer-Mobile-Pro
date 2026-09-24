namespace Google.Play.AssetDelivery.Internal
{
	internal class AssetPackLocation
	{
		public string Path { get; private set; }

		public global::Google.Play.AssetDelivery.Internal.AssetPackStorageMethod PackStorageMethod { get; private set; }

		public AssetPackLocation(global::UnityEngine.AndroidJavaObject packLocation)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
