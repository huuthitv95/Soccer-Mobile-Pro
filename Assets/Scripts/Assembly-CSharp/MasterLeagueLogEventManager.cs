public class MasterLeagueLogEventManager : RegionalLeagueEventListener
{
    private RegionalLeague RegionalLeague;
    private global::Srv.MasterLeagueLogEvent archive;
    private global::FLGameProgressSetting.LocalArchives storer;
    public MasterLeagueLogEventManager(RegionalLeague regionalLeague, global::FLGameProgressSetting.LocalArchives storer)
    {
    }

    void RegionalLeagueEventListener.OnChooseTeam()
    {
    }

    public void LogGainCoin(int count, IncomeType incomeType, RewardVideoIncome rewardVideoIncome)
    {
    }

    public void LogConsumeCoin(int count, ExpenseType expenseType)
    {
    }

    public void LogSignPlayer(ClubPlayer clubPlayer)
    {
    }

    public void LogRefreshScout()
    {
    }

    public void LogReleasePlayer(ClubPlayer player)
    {
    }

    void RegionalLeagueEventListener.OnFinishSeason()
    {
    }

    void RegionalLeagueEventListener.OnInitialize()
    {
    }

    void RegionalLeagueEventListener.OnMatchFinish(CupMatchBase.MatchSettlementData match)
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
}