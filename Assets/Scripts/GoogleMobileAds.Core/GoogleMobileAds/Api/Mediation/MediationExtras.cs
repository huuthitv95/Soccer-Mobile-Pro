namespace GoogleMobileAds.Api.Mediation
{
	public abstract class MediationExtras
	{
		public global::System.Collections.Generic.Dictionary<string, string> Extras { get; protected set; }

		public abstract string AndroidMediationExtraBuilderClassName { get; }

		public abstract string IOSMediationExtraBuilderClassName { get; }

		public MediationExtras()
		{
		}
	}
}
