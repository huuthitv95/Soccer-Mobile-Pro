namespace FL
{
	public abstract class ChampionshipRoadEventControllerBase
	{
		protected global::FL.ChampionshipRoadEvent m_event;

		public bool IsFirstOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::FL.EventRewardHandler EventRewardHandler => null;

		public global::FL.ChampionshipRoadEvent Event => null;

		public global::FL.EventLoginRewardHandler EventLoginRewardHandler => null;

		public bool NeedShowRedPoint()
		{
			return false;
		}

		public ChampionshipRoadEventControllerBase(global::FL.ChampionshipRoadEvent championshipRoadEvent)
		{
		}

		public abstract void OpenEventMainView();

		public abstract Win_ChallengeTip OpenEventTipView();

		public virtual bool CheckLoginReward()
		{
			return false;
		}

		public virtual bool CheckToNextRound()
		{
			return false;
		}

		public float GetMatchDifficulty(int challengeId)
		{
			return 0f;
		}
	}
}
