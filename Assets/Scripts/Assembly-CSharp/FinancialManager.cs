public class FinancialManager : RegionalLeagueEventListener, CompetitionFinshListener
{
    public enum GainCoinOption
    {
        GainOnly = 1,
        KeepAccountsOnly = 2,
        GainAndKeepAccounts = 3
    }

    private global::Srv.FinancialArchive archive;
    public OnCoinChangeEvent OnCoinNumChange;
    private FinancialConfig Configs;
    private global::FLGameProgressSetting.LocalArchives storer;
    private FinancialReminder Reminder;
    private static global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>> transferBargainExtraRate;
    public RegionalLeague RegionalLeague { get; private set; }

    public bool DeficitTipFlag
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool InDeficitFlag
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public int CalculateContractBudget()
    {
        return 0;
    }

    public FinancialManager(RegionalLeague regionalLeague, FinancialConfig config, global::FLGameProgressSetting.LocalArchives storer)
    {
    }

    void RegionalLeagueEventListener.OnChooseTeam()
    {
    }

    void RegionalLeagueEventListener.OnInitialize()
    {
    }

    void RegionalLeagueEventListener.OnRest()
    {
    }

    void RegionalLeagueEventListener.OnUpdateRound()
    {
    }

    void RegionalLeagueEventListener.OnUpdateSeason()
    {
    }

    private void OnStartNewSeason()
    {
    }

    void RegionalLeagueEventListener.OnMatchFinish(CupMatchBase.MatchSettlementData match)
    {
    }

    public FinancialReminder FlushMatchBonusReminder()
    {
        return default;
    }

    public void GainCoin(IncomeType incomeType, int count, FinancialManager.GainCoinOption op = FinancialManager.GainCoinOption.GainAndKeepAccounts, RewardVideoIncome rewardVideoIncome = RewardVideoIncome.None)
    {
    }

    public void ConsumeCoin(ExpenseType expenseType, int count, FinancialManager.GainCoinOption op = FinancialManager.GainCoinOption.GainAndKeepAccounts)
    {
    }

    void CompetitionFinshListener.OnCompetitionFinish(IMatchManager competition)
    {
    }

    public int GetCurrentCoinNumber()
    {
        return 0;
    }

    void RegionalLeagueEventListener.OnFinishSeason()
    {
    }

    private void SaveSeasonBonusDetailInfo(global::System.Collections.Generic.Dictionary<SeasonBonusDetailType, int> info, bool isLeague, global::SL.CupRules.DetailType detailType)
    {
    }

    public global::System.Collections.Generic.Dictionary<SeasonBonusDetailType, int> GetSeasonBonusWithDetailType(bool clearArchive)
    {
        return null;
    }

    public int GetIncomeItemByType(IncomeType type)
    {
        return 0;
    }

    public int GetExpenseItemByType(ExpenseType type)
    {
        return 0;
    }

    public bool PaySalary()
    {
        return false;
    }

    public int GetSalary(bool forceCalulate = false)
    {
        return 0;
    }

    public bool CheckSeasonBonus()
    {
        return false;
    }

    public int GetRewardVideoCoinCount()
    {
        return 0;
    }

    public void GainRewardVideoCoin()
    {
    }

    public static int GetTransferBargainCoin(int playerId, int fee, int bargainIndex, bool isSale, int sessionSeed)
    {
        return 0;
    }

    public static int CalculateBargainedFee(int playerId, int displayBaseFee, int bargainCoinFee, int bargainIndex, bool isSale, int sessionSeed)
    {
        return 0;
    }
}