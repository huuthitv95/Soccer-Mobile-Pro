namespace Google.Play.AssetDelivery.Internal
{
	internal static class PlayCoreTranslator
	{
		private static class AssetPackErrorCode
		{
			public const int NoError = 0;

			public const int AppUnavailable = -1;

			public const int PackUnavailable = -2;

			public const int InvalidRequest = -3;

			public const int DownloadNotFound = -4;

			public const int ApiNotAvailable = -5;

			public const int NetworkError = -6;

			public const int AccessDenied = -7;

			public const int InsufficientStorage = -10;

			public const int PlayStoreNotFound = -11;

			public const int NetworkUnrestricted = -12;

			public const int AppNotOwned = -13;

			public const int ConfirmationNotRequired = -14;

			public const int UnrecognizedInstallation = -15;

			public const int InternalError = -100;
		}

		public static class AssetPackStatus
		{
			public const int Unknown = 0;

			public const int Pending = 1;

			public const int Downloading = 2;

			public const int Transferring = 3;

			public const int Completed = 4;

			public const int Failed = 5;

			public const int Canceled = 6;

			public const int WaitingForWifi = 7;

			public const int NotInstalled = 8;

			public const int RequiresUserConfirmation = 9;
		}

		private static readonly global::System.Collections.Generic.Dictionary<int, global::Google.Play.AssetDelivery.AssetDeliveryErrorCode> PlayCoreToAssetDeliveryErrors;

		private static readonly global::System.Collections.Generic.Dictionary<int, global::Google.Play.AssetDelivery.AssetDeliveryStatus> PlayCoreToAssetDeliveryStatuses;

		public static global::Google.Play.AssetDelivery.AssetDeliveryErrorCode TranslatePlayCoreErrorCode(int assetPackErrorCode)
		{
			return global::Google.Play.AssetDelivery.AssetDeliveryErrorCode.NoError;
		}

		public static global::Google.Play.AssetDelivery.AssetDeliveryStatus TranslatePlayCorePackStatus(int assetPackStatus)
		{
			return global::Google.Play.AssetDelivery.AssetDeliveryStatus.Pending;
		}
	}
}
