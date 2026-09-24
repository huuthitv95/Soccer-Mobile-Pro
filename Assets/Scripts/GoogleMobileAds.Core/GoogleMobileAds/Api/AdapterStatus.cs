namespace GoogleMobileAds.Api
{
	public class AdapterStatus
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::GoogleMobileAds.Api.AdapterState InitializationState__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string Description__BackingField;

		private global::GoogleMobileAds.Api.AdapterState InitializationState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				InitializationState__BackingField = value;
			}
		}

		private string Description
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				Description__BackingField = value;
			}
		}

		public int Latency { get; private set; }

		internal AdapterStatus(global::GoogleMobileAds.Api.AdapterState state, string description, int latency)
		{
		}
	}
}
