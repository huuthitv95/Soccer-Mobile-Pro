namespace Google.Play.AssetDelivery.Internal
{
	internal class UpdateAvailabilityTranslator
	{
		private static class PlayCoreAssetPackUpdateAvailability
		{
			public const int Unknown = 0;

			public const int UpdateNotAvailable = 1;

			public const int UpdateAvailable = 2;
		}

		private static readonly global::System.Collections.Generic.Dictionary<int, global::Google.Play.AssetDelivery.AssetPackUpdateAvailability> PlayCoreToAssetPackUpdateAvailability;

		public static global::Google.Play.AssetDelivery.AssetPackUpdateAvailability TranslatePlayCoreUpdateAvailability(int assetPackUpdateAvailability)
		{
			return global::Google.Play.AssetDelivery.AssetPackUpdateAvailability.Unknown;
		}
	}
}
