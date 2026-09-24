public class NewChampionLeagueDisplay : FACupDisplayBase
{
	private global::FLDataTable.NewChampionsLeagueRules m_rules;

	public override bool HasPlayoff => false;

	public override int RelegationTipRank => 0;

	public NewChampionLeagueDisplay(global::FLDataTable.NewChampionsLeagueRules rules)
	{
	}

	public override global::System.Collections.Generic.List<int> CalculatePromotionTipRank()
	{
		return null;
	}

	protected override string GroupStageRoundName(int round, global::SL.FACupGroupsData CupProto)
	{
		return null;
	}

	protected override string KnockoutStageRoundName(int round, global::SL.FACupGroupsData CupProto)
	{
		return null;
	}
}
