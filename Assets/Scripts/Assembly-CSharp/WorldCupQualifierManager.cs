public class WorldCupQualifierManager : global::MultiStageTournament.IMultiStageTournamentManager, IFACupDisplayFactory
{
    private struct GroupRulesMgr
    {
        private global::System.Collections.Generic.Dictionary<string, global::MultiStageTournament.GroupRules> rules;
        private string m_tablePath;
        private string m_teamConfigDir;
        private void Load()
        {
        }

        public global::System.Collections.IEnumerable GetAllRules()
        {
            return null;
        }

        public global::MultiStageTournament.GroupRules GetRules(string type)
        {
            return null;
        }

        public GroupRulesMgr(string tablePath, string teamConfigDir)
        {
            rules = null;
            m_tablePath = null;
            m_teamConfigDir = null;
        }
    }

    private struct QualificationRulesManager
    {
        private global::System.Collections.Generic.Dictionary<string, MultiStageTournamentQualificationRules> rules;
        private string m_tablePath;
        private void Load()
        {
        }

        public MultiStageTournamentQualificationRules GetRules(string type)
        {
            return null;
        }

        public QualificationRulesManager(string tablePath)
        {
            rules = null;
            m_tablePath = null;
        }
    }

    private WorldCupQualifierManager.GroupRulesMgr m_groupRulesMgr;
    private WorldCupQualifierManager.QualificationRulesManager m_qualificationRulesManager;
    private NormalFACupReplaceTeamHandler replaceTeamHandler;
    private const string m_settBasePath = "Assets/GameData/excels/gamedata/CupMode/WorldCupQualifyingStage/";
    private global::System.Collections.Generic.Dictionary<string, global::FLDataTable.WorldCupQualifierDisplayConfig> m_displayConfig;
    public FACup CurrentCup { get; private set; }
    public int UserTeamId { get; private set; }

    public void SetCurrentCup(FACup cup)
    {
    }

    public global::MultiStageTournament.GroupRules GetRules(string type)
    {
        return null;
    }

    public void CheckCreateNextCup(global::MultiStageTournament.GroupRules currentGroupRules, in FACup.FACupSharedData sharedData)
    {
    }

    private void CheckCreateNextCupForKnockoutStage(global::MultiStageTournament.GroupRules currentGroupRules, in FACup.FACupSharedData sharedData)
    {
    }

    public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.HashSet<int>> CheckGroupPromotion(global::MultiStageTournament.GroupRules currentGroupRules, FACup sharedData)
    {
        return null;
    }

    private void CheckCreateNextCupForGroupStage(global::MultiStageTournament.GroupRules currentGroupRules, in FACup.FACupSharedData sharedData)
    {
    }

    private void CreateNextStage(string nextCupType)
    {
    }

    public void Init(string baseType, int id)
    {
    }

    public void CheckGenerateFakeQualifyingTeams(global::MultiStageTournament.GroupRules userGroup, global::System.Collections.Generic.HashSet<int> allocated)
    {
    }

    public void CreateFinalStage(FACup fACup, in FACup.FACupSharedData sharedData)
    {
    }

    public FACup CreateFirstStage(int userTeam, FACup baseCup)
    {
        return null;
    }

    public FACupDisplay Create(FACup fACup)
    {
        return null;
    }

    public bool IsUserFirstStage(int userTeam, global::MultiStageTournament.GroupRules groupRules)
    {
        return false;
    }

    private global::MultiStageTournament.GroupRules GetFirstStageGroupRules(int userTeam)
    {
        return null;
    }

    void global::MultiStageTournament.IMultiStageTournamentManager.CreateFinalStage(FACup fACup, in FACup.FACupSharedData sharedData)
    {
    }
}