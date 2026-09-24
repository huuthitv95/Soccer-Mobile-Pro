public class MatchManagerHelper : IMatchManager
{
    private global::System.Func<int> RoundGeter;
    private MatchManagerType type;
    private global::System.Collections.Generic.List<CupMatchBase> matchs;
    private global::UnityEngine.Events.UnityEvent onMatchDataUpdate;
    private TeamsData userTeamData;
    public global::System.Collections.Generic.List<CupMatchBase> Matchs => null;
    public global::UnityEngine.Events.UnityEvent OnMatchDataUpdate => null;

    public TeamsData UserTeamData
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public int Round => 0;
    public MatchManagerType Type => MatchManagerType.FACup;

    public int DifficultySetting
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int MaxRound => 0;
    public PlayerManager PlayerManager => null;
    public TeamDataManager TeamDataManager => null;
    public float EnergyConsumptionPerMinutes => 0f;
    public float EnergyRecoveryPerRound => 0f;
    public RegionalLeague RegionalLeague => null;
    public string Name => null;
    public int GlobalId => 0;
    public MatchSnapshot MatchSnapshot => null;
    public PlayerDisciplineDatabase DisciplineDatabase => null;

    public MatchManagerHelper(global::System.Func<int> RoundGeter, MatchManagerType type)
    {
    }

    public void ArrangeUserTeam(int id)
    {
    }

    public void ChangeUserForamtion(string foramtion)
    {
    }

    public void CreateNewCup()
    {
    }

    public float Difficulty()
    {
        return 0f;
    }

    public global::System.Collections.Generic.List<CupMatchBase> GetMatchByRound(int round)
    {
        return null;
    }

    public CupMatchBase GetNextMatch()
    {
        return null;
    }

    public CupMatchBase GetUserMatchByRound(int round)
    {
        return null;
    }

    public void RecordUserMatch(int homeScore, int awayScore)
    {
    }

    public void ResetCup()
    {
    }

    public void ResetCurrentRound()
    {
    }

    public string RoundName(int round = -1)
    {
        return null;
    }

    public void UpdateToNextRound()
    {
    }

    public void GenerateGroupMatchs(global::SL.LeagueProto.MatchFormat format, global::System.Collections.Generic.List<int> teams, global::UnityEngine.Events.UnityAction<global::Srv.MatchData> OnGenerate)
    {
    }

    public void RecordStatistics(CupMatchBase.MatchSettlementData data)
    {
    }

    public static void SettlePlayerInfo(CupMatchBase.MatchSettlementData data, float costPerFullFatigues)
    {
    }

    public static void SettlePlayerInfo(CupMatchBase.MatchSettlementData data, IMatchManager mgr)
    {
    }

    public void FinishCurrentRound()
    {
    }

    public void MarkArchiveDirty()
    {
    }

    public void SyncAppearanceProfile()
    {
    }

    public void SyncAppearanceProfile(int ball, int jersey)
    {
    }

    public void GetAppearanceProfile(out int ball, out int jersey)
    {
        ball = default;
        jersey = default;
    }

    public bool NextMatchIsImportant()
    {
        return false;
    }
}