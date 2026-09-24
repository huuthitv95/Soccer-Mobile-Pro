namespace GoogleMobileAds.Api
{
	[global::System.Serializable]
	public class AdRequest
	{
		public global::System.Collections.Generic.Dictionary<string, string> CustomTargeting;

		public global::System.Collections.Generic.HashSet<string> Keywords;

		public global::System.Collections.Generic.Dictionary<string, string> Extras;

		public long PlacementID;

		public global::System.Collections.Generic.List<global::GoogleMobileAds.Api.Mediation.MediationExtras> MediationExtras;

		public static string Version { get; private set; }

		static AdRequest()
		{
		}

		internal static string BuildVersionString(string nativePluginVersion = null)
		{
			return null;
		}
	}
}
