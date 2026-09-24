namespace Gadsme
{
	[global::System.Serializable]
	public class GadsmeImpressionData
	{
		public string placementId;

		public string gameId;

		public string countryCode;

		public string currency;

		public double netRevenue;

		public string lineItemType;

		public string platform;

		public global::Gadsme.GadsmeAdFormat adFormat;

		public GadsmeImpressionData(string placementId, string gameId, string countryCode, string currency, double netRevenue, string lineItemType, string platform, global::Gadsme.GadsmeAdFormat adFormat)
		{
		}
	}
}
