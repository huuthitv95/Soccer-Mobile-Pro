namespace Google.Play.AssetDelivery
{
	public enum AssetDeliveryErrorCode
	{
		NoError = 0,
		AppUnavailable = 1,
		BundleUnavailable = 2,
		NetworkError = 3,
		AccessDenied = 4,
		InsufficientStorage = 7,
		AssetBundleLoadingError = 8,
		Canceled = 9,
		InternalError = 10,
		PlayStoreNotFound = 11,
		NetworkUnrestricted = 12,
		AppNotOwned = 13,
		ConfirmationNotRequired = 14,
		UnrecognizedInstallation = 15
	}
}
