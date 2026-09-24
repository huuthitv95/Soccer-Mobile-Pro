namespace FL
{
    public sealed class NormalChampionshipRoadEventController : global::FL.ChampionshipRoadEventControllerBase, global::FL.IChampionshipRoadEventController, global::FL.IChanllengeEventController, global::FL.ISpecialFootballSupplier, global::FL.IRewardRevealSupport
    {
        private string mainViewID;
        private string tipID;
        private string welcomeID;
        private global::FL.ChampionshipRoadEventManager.SpecialEquipInfo specialEquip;
        public global::FL.EventSwitch EventSwitch => null;

        public NormalChampionshipRoadEventController(global::FL.ChampionshipRoadEvent championshipRoadEvent, string mainViewID, string tipID, string welcomeID, global::FL.ChampionshipRoadEventManager.SpecialEquipInfo specialEquip = null) : base(null)
        {
        }

        public override void OpenEventMainView()
        {
        }

        public void CheckInit()
        {
        }

        public override Win_ChallengeTip OpenEventTipView()
        {
            return null;
        }

        public void ClaimMissionReward(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, global::System.Action nextWindow, bool coinWindowCloseAbled = false)
        {
        }

        private void HandleClaimReward(ChampionshipRoadConfig.ChallengeMissionConfig rewardConfig, global::System.Action nextWindow, bool coinWindowCloseAbled = false)
        {
        }

        public void ClaimRoundBonus(global::System.Action nextWindow)
        {
        }

        public void OnChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin)
        {
        }

        public Win_RTCChallengeWelcome OpenWelcomeView()
        {
            return null;
        }

        public override bool CheckLoginReward()
        {
            return false;
        }

        public void MarkLoginRewardClaimed()
        {
        }

        public int GetSpecialFootballId()
        {
            return 0;
        }

        public bool UseSpecialFootball()
        {
            return false;
        }

        public int GetSpecialJerseyId()
        {
            return 0;
        }

        public bool UseSpecialJersey()
        {
            return false;
        }

        public ChampionshipRoadConfig.ClassicMatchConfig CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }

        public bool IsRewardRevealed(int id)
        {
            return false;
        }

        public void RevealReward(int id)
        {
        }

        ChampionshipRoadConfig.ClassicMatchConfig global::FL.IChanllengeEventController.CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }
    }
}