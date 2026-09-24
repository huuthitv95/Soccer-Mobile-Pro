namespace FL
{
    public class CustomTeamChallengeManager : global::FL.ChampionshipRoadEventControllerBase, global::FL.IChanllengeEventController
    {
        public enum SpecialPlayerState
        {
            None = 0,
            Locked = 1,
            Unlocked = 2
        }

        private global::System.Collections.Generic.List<global::FLDataTable.CustomTeamChallengeConfig> AllConfigs;
        private global::System.Lazy<global::FLDataTable.CustomTeamChallengeConfig> m_teamConfig;
        private global::System.Lazy<global::System.Collections.Generic.List<global::FLDataTable.TeamWeights>> playerPool;
        private global::Srv.CustomTeamChallengeArchive m_archive;
        private int specialPlayerTier;
        private global::System.Collections.Generic.List<global::SL.WeightRandom<global::FLDataTable.TeamWeights>> m_rdHelper;
        private global::System.Collections.Generic.List<global::SL.WeightRandom<global::FLDataTable.TeamWeights>> m_lowPriority;
        private global::System.Collections.Generic.List<Win_BuildCustomTeam.ChoosePlayerType> SubsType;
        private static global::System.Collections.Generic.HashSet<int> legendaryPlayers;
        private bool teamReset;
        public global::FL.EventSwitch EventSwitch => null;

        private global::FLDataTable.CustomTeamChallengeConfig LoadTeamConfig()
        {
            return null;
        }

        private global::System.Collections.Generic.List<global::FLDataTable.TeamWeights> LoadPlayerPool()
        {
            return null;
        }

        public CustomTeamChallengeManager(global::FL.ChampionshipRoadEvent championshipRoadEvent, global::System.Collections.Generic.List<global::FLDataTable.CustomTeamChallengeConfig> AllConfigs, global::Srv.CustomTeamChallengeArchive archive) : base(null)
        {
        }

        public void ClaimMissionReward(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, global::System.Action nextWindow, bool coinWindowCloseAbled = false)
        {
        }

        public void ClaimRoundBonus(global::System.Action nextWindow)
        {
        }

        private void HandleClaimReward(ChampionshipRoadConfig.ChallengeMissionConfig rewardConfig, global::System.Action nextWindow, bool coinWindowCloseAbled = false)
        {
        }

        public void OnChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin)
        {
        }

        public override void OpenEventMainView()
        {
        }

        public override Win_ChallengeTip OpenEventTipView()
        {
            return null;
        }

        public void MarkLoginRewardClaimed()
        {
        }

        public override bool CheckLoginReward()
        {
            return false;
        }

        private void InitWeightRandom(global::System.Collections.Generic.HashSet<FormationTool.UIRole> posSet, global::System.Collections.Generic.HashSet<FormationTool.UIRole> backupPosSet = null)
        {
        }

        private global::FL.SmallBuffer16<int> PlayerFilter(global::FL.SmallBuffer16<int> playerTier)
        {
            return default;
        }

        public global::FL.SmallBuffer16<int> RefreshPlayerPool(global::System.Collections.Generic.HashSet<FormationTool.UIRole> posSet, global::System.Collections.Generic.HashSet<FormationTool.UIRole> backupPosSet = null)
        {
            return default;
        }

        public global::FL.SmallBuffer16<int> GetPlayerPool()
        {
            return default;
        }

        public global::FL.CustomTeamChallengeManager.SpecialPlayerState GetSpecialPlayerState()
        {
            return global::FL.CustomTeamChallengeManager.SpecialPlayerState.None;
        }

        public void UnlockSpecialPlayer()
        {
        }

        public global::FL.SmallBuffer16<int> GetCaptainPool()
        {
            return default;
        }

        public global::System.Collections.Generic.List<global::SL.FormationTemplate> GetFormationTemplates()
        {
            return null;
        }

        public void SelectFormation(global::SL.FormationTemplate data)
        {
        }

        public global::SL.FormationTemplate GetSelectedFormation()
        {
            return default;
        }

        public TeamsData GetPrototypeTeam()
        {
            return null;
        }

        public void AddPlayer(int playerId, FormationTool.UIRole role, bool isCaptain)
        {
        }

        private void RefreshPlayerPool()
        {
        }

        public global::System.Collections.Generic.Dictionary<FormationTool.UIRole, int> GetStarterFormation()
        {
            return null;
        }

        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>> GetTeamFormation()
        {
            return null;
        }

        public bool HasFreeChange()
        {
            return false;
        }

        public void UseFreeChange()
        {
        }

        public void Start()
        {
        }

        public bool IsStarted()
        {
            return false;
        }

        private void Reset()
        {
        }

        private void ShowEventMainView()
        {
        }

        private Win_BuildCustomTeam.ChoosePlayerType GetCurSubType()
        {
            return Win_BuildCustomTeam.ChoosePlayerType.Captain;
        }

        public int GetTargetPlayerCount()
        {
            return 0;
        }

        private FormationTool.UIRole GetCurStartRole()
        {
            return FormationTool.UIRole.GK;
        }

        private Win_BuildCustomTeam GetOrOpenBuildCustomTeamWindow()
        {
            return null;
        }

        private bool IsFailed()
        {
            return false;
        }

        private void CheckOpenCurrentStageWindow(bool showTip = false)
        {
        }

        public static bool IsLegendaryPlayer(int playerId)
        {
            return false;
        }

        public void ResetUserTeam()
        {
        }

        public void ReDraft()
        {
        }

        public void CheckInit()
        {
        }

        public ChampionshipRoadConfig.ClassicMatchConfig CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }

        ChampionshipRoadConfig.ClassicMatchConfig global::FL.IChanllengeEventController.CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }
    }
}