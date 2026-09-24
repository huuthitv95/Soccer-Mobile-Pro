public class TeamDataManager
{
    private class TeamDataComparer : global::SL.TeamsProto, global::System.Collections.Generic.IComparer<global::SL.TeamsProto>
    {
        public int Id
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int Compare(global::SL.TeamsProto x, global::SL.TeamsProto y)
        {
            return 0;
        }
    }

    public enum TeamType
    {
        NationalTeam = 0,
        Club = 1,
        System = 2,
        All = 3
    }

    private static TeamDataManager.TeamDataComparer teamSeachHelper;
    public ExternalDataAgent EditableAchiveAgent;
    private PlayerManager PlayerManager;
    private global::System.Func<int, PlayerManager> PlayerManagerSupplier;
    public static global::System.Collections.Generic.List<global::SL.TeamsProto> AllProtos;
    private global::Srv.ClubTeamDatabase archives;
    private global::System.Collections.Generic.Dictionary<int, TeamsData> TeamDatasMap;
    private global::System.Collections.Generic.List<TeamsData> AllTeamDatas;
    private TeamsData systemTeam;
    private TeamsData marketTeam;
    private TeamsData legendTeam;
    private global::FLGameProgressSetting.LocalArchives Store;
    private static global::System.Collections.Generic.Dictionary<int, TeamDataManager> AllTeamManager;
    private static TeamDataManager _commonTeamMatnager;
    public static global::System.Collections.Generic.SortedSet<int> banList;
    public int Id { get; private set; }
    public TeamsData SystemTeam => null;
    public TeamsData MarketTeam => null;
    public TeamsData LegendTeam => null;
    public static TeamDataManager CommonTeamMatnager => null;

    public void SetPlayerManagerSupplier(global::System.Func<int, PlayerManager> PlayerManagerSupplier)
    {
    }

    public void CheckLegendaryPlayers(RegionalLeague ml, global::System.Action<ClubPlayer> handleExistingPlayer = null)
    {
    }

    public TeamsData GetTeamIfLoaded(int id)
    {
        return null;
    }

    public TeamsData LoadTeamDataById(int id)
    {
        return null;
    }

    public void LoadAllArchives()
    {
    }

    public static TeamDataManager.TeamType GetTeamType(int id)
    {
        return TeamDataManager.TeamType.NationalTeam;
    }

    public global::System.Collections.Generic.List<TeamsData> GetTeamsByType(TeamDataManager.TeamType type)
    {
        return null;
    }

    public global::System.Collections.Generic.List<int> FilterClubs(int type)
    {
        return null;
    }

    public TeamsData GetTeamDataById(int id)
    {
        return null;
    }

    public global::System.Collections.Generic.List<TeamsData> GetTeamsByNation(string nation, TeamDataManager.TeamType type, bool excludeFemale = false)
    {
        return null;
    }

    public global::System.Collections.Generic.List<TeamsData> GetTeamsByContinents(string continent, TeamDataManager.TeamType type, bool excludeFemale = false)
    {
        return null;
    }

    public static void Initialize()
    {
    }

    public TeamsData GetSpecificTeam(int id)
    {
        return null;
    }

    public void MarkDirty()
    {
    }

    public TeamDataManager(PlayerManager playerManager, global::Srv.ClubTeamDatabase archives, global::FLGameProgressSetting.LocalArchives Storer)
    {
    }

    public static global::SL.TeamsProto GetProto(int id)
    {
        return null;
    }

    public static global::SL.TeamsProto GetProtoByNameStrKey(string strKey)
    {
        return null;
    }

    public void Reset(bool resetPlayer)
    {
    }
}