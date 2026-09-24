namespace GoogleMobileAds.Api
{
	public class AdValue
	{
		public enum PrecisionType
		{
			Unknown = 0,
			Estimated = 1,
			PublisherProvided = 2,
			Precise = 3
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string CurrencyCode__BackingField;

		public global::GoogleMobileAds.Api.AdValue.PrecisionType Precision { get; set; }

		public long Value { get; set; }

		public string CurrencyCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				CurrencyCode__BackingField = value;
			}
		}
	}
}
