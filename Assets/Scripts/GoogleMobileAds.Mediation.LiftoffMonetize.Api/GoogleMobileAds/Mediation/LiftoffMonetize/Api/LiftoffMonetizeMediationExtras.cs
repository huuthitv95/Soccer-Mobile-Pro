namespace GoogleMobileAds.Mediation.LiftoffMonetize.Api
{
    public abstract class LiftoffMonetizeMediationExtras : global::GoogleMobileAds.Api.Mediation.MediationExtras
    {
        public const string UserIdKey = "user_id";
        public override string IOSMediationExtraBuilderClassName => null;

        public LiftoffMonetizeMediationExtras()
        {
        }

        public void SetUserId(string userId)
        {
        }
    }
}