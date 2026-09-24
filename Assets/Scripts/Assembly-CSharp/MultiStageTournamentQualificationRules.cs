public class MultiStageTournamentQualificationRules
{
	public class SeatsRules
	{
		public global::System.Collections.Generic.KeyValuePair<int, int>[] seatsByRank;

		public string nextStage;
	}

	public global::System.Collections.Generic.List<MultiStageTournamentQualificationRules.SeatsRules> seatsRules;

	public MultiStageTournamentQualificationRules(global::FLDataTable.MultiStageTournamentQualificationConfig config)
	{
	}
}
