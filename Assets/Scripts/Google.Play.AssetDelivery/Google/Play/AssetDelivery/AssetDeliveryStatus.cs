namespace Google.Play.AssetDelivery
{
	public enum AssetDeliveryStatus
	{
		Pending = 0,
		Retrieving = 1,
		Available = 2,
		Loading = 3,
		Loaded = 4,
		Failed = 5,
		WaitingForWifi = 6,
		RequiresUserConfirmation = 7
	}
}
