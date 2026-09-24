public class FinancialConfig
{
    private struct SeasonIncome
    {
        private global::System.Collections.Generic.Dictionary<IncomeType, int> IncomeItem;
        private global::System.Collections.Generic.Dictionary<IncomeType, int> ExtraIncome;
        private int extraIncomeEnableSeason;
        private int extraIncomeDisableSeason;
        public SeasonIncome(int sponsor, int membership, int advertisement)
        {
            IncomeItem = null;
            ExtraIncome = null;
            extraIncomeEnableSeason = 0;
            extraIncomeDisableSeason = 0;
        }

        public void SetExtraIncome(int sponsor, int membership, int advertisement, int enableSeason, int disableSeason)
        {
        }

        public int GetIncome(IncomeType type, int season)
        {
            return 0;
        }

        public global::System.Collections.Generic.IEnumerable<IncomeType> GetIncomeTypes()
        {
            return null;
        }
    }

    private struct MatchBonus
    {
        public int WinBonus;
        public int DrawBonus;
        public int LoseBonus;
        public int champion;
        public int second;
        public int playerGoalRank;
        public int playerAssistRank;
        public int BonusForOnGoal;
        public int MaxGoalBonus;
        public int CleanSheetBonus;
        public int HomeTeamEarnings;
        public int HatTrickBonus;
        public bool HasExtraBonus => false;
    }

    private struct ContractBudget
    {
        public float coefficient;
        public int superLeagueRenewalCount;
        public int BLeagueRenewalCount;
        public int CLeagueRenewalCount;
        public int superLeagueTenMatchsEarnings;
        public int BLeagueTenMatchsEarnings;
        public int CLeagueTenMatchsEarnings;
        public int CalculateContractBudget(int level, float averageWage)
        {
            return 0;
        }
    }

    private static class FinancialConfigProtos
    {
        private class Config
        {
            private global::System.Collections.Generic.List<FinancialConfig.MatchBonus> LeagueBonusByLevel;
            private global::System.Collections.Generic.Dictionary<global::SL.CupRules.DetailType, FinancialConfig.MatchBonus> CupBonusByType;
            private global::System.Collections.Generic.List<FinancialConfig.SeasonIncome> seasonIncomes;
            private FinancialConfig.ContractBudget contractBudget;
            private bool isLoaded;
            private string MatchBonusPath;
            private string SeasonIncomePath;
            private string contractBudgetPath;
            public FinancialConfig.ContractBudget GetContractBudget => default;

            public Config(string path, string seasonIncomePath, string contractBudgetPath)
            {
            }

            private void Load()
            {
            }

            private void CheckLoaded()
            {
            }

            public global::System.Collections.Generic.List<FinancialConfig.MatchBonus> GetLeagueBonusByLevel()
            {
                return null;
            }

            public global::System.Collections.Generic.Dictionary<global::SL.CupRules.DetailType, FinancialConfig.MatchBonus> GetCupBonusByType()
            {
                return null;
            }

            public global::System.Collections.Generic.List<FinancialConfig.SeasonIncome> GetSeasonIncomes()
            {
                return null;
            }
        }

        private static FinancialConfig.FinancialConfigProtos.Config _25Plan;
        private static FinancialConfig.FinancialConfigProtos.Config _261Plan;
        private static global::System.Collections.Generic.List<FinancialConfig.MatchBonus> LeagueBonusByLevel;
        private static global::System.Collections.Generic.Dictionary<global::SL.CupRules.DetailType, FinancialConfig.MatchBonus> CupBonusByType;
        private static global::System.Collections.Generic.List<FinancialConfig.SeasonIncome> seasonIncomes;
        private static int plan;
        private static FinancialConfig.ContractBudget contractBudget;
        public static int CalculateContractBudget(int level, float averageWage)
        {
            return 0;
        }

        private static void CheckLoaded()
        {
        }

        public static global::System.Collections.Generic.List<FinancialConfig.MatchBonus> GetLeagueBonusByLevel()
        {
            return null;
        }

        public static global::System.Collections.Generic.Dictionary<global::SL.CupRules.DetailType, FinancialConfig.MatchBonus> GetCupBonusByType()
        {
            return null;
        }

        public static global::System.Collections.Generic.List<FinancialConfig.SeasonIncome> GetSeasonIncomes()
        {
            return null;
        }
    }

    private FinancialManager manager;
    private global::System.Collections.Generic.List<FinancialConfig.SeasonIncome> seasonIncomes => null;
    private global::System.Collections.Generic.List<FinancialConfig.MatchBonus> LeagueBonusByLevel => null;
    private global::System.Collections.Generic.Dictionary<global::SL.CupRules.DetailType, FinancialConfig.MatchBonus> CupBonusByType => null;

    public int CalculateContractBudget(int level, float averageWage)
    {
        return 0;
    }

    public void OnStartNewSeason(RegionalLeague league)
    {
    }

    private bool GetMatchBonus(IMatchManager match, RegionalLeague league, out FinancialConfig.MatchBonus matchBonus)
    {
        matchBonus = default;
        return false;
    }

    public void OnMatchFinish(CupMatchBase.MatchSettlementData settlementData, RegionalLeague league, global::System.Action<FinancialReminder> NotifyDetailInfo)
    {
    }

    public void CheckSeasonBonus(IMatchManager match, RegionalLeague league, FinancialManager.GainCoinOption gainCoinOption, global::System.Action<global::System.Collections.Generic.Dictionary<SeasonBonusDetailType, int>, bool, global::SL.CupRules.DetailType> notifyDetailInfo)
    {
    }

    public void Load(FinancialManager manager)
    {
    }
}