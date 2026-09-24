namespace FL
{
	public interface IChanllengeEventController
	{
		global::FL.EventSwitch EventSwitch { get; }

		global::FL.EventRewardHandler EventRewardHandler { get; }

		global::FL.EventLoginRewardHandler EventLoginRewardHandler { get; }

		bool IsFirstOpen { get; set; }

		void OpenEventMainView();

		Win_ChallengeTip OpenEventTipView();

		void OnChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin);

		void ClaimMissionReward(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, global::System.Action nextWindow, bool coinWindowCloseAbledf = false);

		void ClaimRoundBonus(global::System.Action nextWindow);

		bool CheckLoginReward();

		bool CheckToNextRound();

		bool NeedShowRedPoint();

		float GetMatchDifficulty(int challengeId);

		void CheckInit();

		ChampionshipRoadConfig.ClassicMatchConfig CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge);

		void MarkLoginRewardClaimed();
	}
}
