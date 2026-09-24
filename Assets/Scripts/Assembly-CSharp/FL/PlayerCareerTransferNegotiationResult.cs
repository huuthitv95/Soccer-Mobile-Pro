namespace FL
{
	public class PlayerCareerTransferNegotiationResult
	{
		public global::FL.PlayerCareerTransferNegotiationState State { get; private set; }

		public global::Srv.PlayerCareerTransferOffer Offer { get; private set; }

		public global::Srv.PlayerCareerTransferAgreement Agreement { get; private set; }

		public static global::FL.PlayerCareerTransferNegotiationResult Invalid()
		{
			return null;
		}

		public static global::FL.PlayerCareerTransferNegotiationResult NoChance(global::Srv.PlayerCareerTransferOffer offer)
		{
			return null;
		}

		public static global::FL.PlayerCareerTransferNegotiationResult Failed(global::Srv.PlayerCareerTransferOffer offer)
		{
			return null;
		}

		public static global::FL.PlayerCareerTransferNegotiationResult Succeeded(global::Srv.PlayerCareerTransferOffer offer, global::Srv.PlayerCareerTransferAgreement agreement)
		{
			return null;
		}

		public static global::FL.PlayerCareerTransferNegotiationResult NeedReplace(global::Srv.PlayerCareerTransferOffer offer, global::Srv.PlayerCareerTransferAgreement agreement)
		{
			return null;
		}

		private static global::FL.PlayerCareerTransferNegotiationResult Create(global::FL.PlayerCareerTransferNegotiationState state, global::Srv.PlayerCareerTransferOffer offer, global::Srv.PlayerCareerTransferAgreement agreement)
		{
			return null;
		}
	}
}
