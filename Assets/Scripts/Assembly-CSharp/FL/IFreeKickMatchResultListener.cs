namespace FL
{
	public interface IFreeKickMatchResultListener
	{
		void OnFreeKickChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin, int goalNum);
	}
}
