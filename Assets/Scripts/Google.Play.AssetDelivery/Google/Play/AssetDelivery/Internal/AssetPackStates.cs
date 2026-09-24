namespace Google.Play.AssetDelivery.Internal
{
	internal class AssetPackStates
	{
		public long TotalBytes { get; private set; }

		public global::System.Collections.Generic.Dictionary<string, global::Google.Play.AssetDelivery.Internal.AssetPackState> PackStates { get; private set; }

		public AssetPackStates(global::UnityEngine.AndroidJavaObject packStates)
		{
		}

		private global::System.Collections.Generic.Dictionary<string, global::Google.Play.AssetDelivery.Internal.AssetPackState> ConvertPackStatesJavaMapToDictionary(global::UnityEngine.AndroidJavaObject packStates)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
