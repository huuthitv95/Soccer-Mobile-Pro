namespace Google.Play.AssetDelivery
{
	public abstract class AssetLocation
	{
		public string Path { get; protected set; }

		public ulong Offset { get; protected set; }

		public ulong Size { get; protected set; }
	}
}
