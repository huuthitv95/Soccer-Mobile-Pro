public class ChampionsLeagueConfigs : global::Common.Singleton<ChampionsLeagueConfigs>
{
    public enum ChampionsLeagueTeamClassification
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3
    }

    public class ChampionsConfigs
    {
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<ChampionsLeagueConfigs.ChampionsLeagueTeamClassification>> seededTeamByNation;
        public ChampionsLeagueConfigs.ChampionsLeagueTeamClassification[][] groups;
    }

    public class TeamConfigs
    {
        public int id;
        public int AWeight;
        public int BWeight;
        public int CWeight;
        public int DWeight;
        public string nation;
        public string tag;
    }

    private class TeamConfigsHandler
    {
        public struct TeamConfigsWeight
        {
            public int idx;
            public int weight;
            public ChampionsLeagueConfigs.TeamConfigs teamConfigs;
            public TeamConfigsWeight(int idx, int weight, ChampionsLeagueConfigs.TeamConfigs teamConfigs)
            {
                this.idx = 0;
                this.weight = 0;
                this.teamConfigs = null;
            }
        }

        private global::System.Collections.Generic.List<ChampionsLeagueConfigs.TeamConfigs> all;
        private global::System.Collections.Generic.List<bool> LowPriorityMark;
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight>> A_teamByNation;
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight>> B_teamByNation;
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight>> C_teamByNation;
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight>> D_teamByNation;
        public global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight> a_team;
        public global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight> b_team;
        public global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight> c_team;
        public global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight> d_team;
        public void RemoveTeams(string nation)
        {
        }

        public void MarkLowPriority(string nation)
        {
        }

        public global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight> GetTargetTeams(string nation, ChampionsLeagueConfigs.ChampionsLeagueTeamClassification type)
        {
            return null;
        }

        public global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight> GetTargetTeams(ChampionsLeagueConfigs.ChampionsLeagueTeamClassification type)
        {
            return null;
        }

        public TeamConfigsHandler(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<ChampionsLeagueConfigs.TeamConfigs>> teamConfigs)
        {
        }

        public ChampionsLeagueConfigs.TeamConfigs RandomWithWeight(global::System.Collections.Generic.LinkedList<ChampionsLeagueConfigs.TeamConfigsHandler.TeamConfigsWeight> list, global::System.Func<ChampionsLeagueConfigs.TeamConfigs, bool> excluedRule = null)
        {
            return null;
        }

        public global::System.Collections.Generic.KeyValuePair<int, int> RandomGetGroupIdx(global::System.Collections.Generic.KeyValuePair<ChampionsLeagueConfigs.TeamConfigs, ChampionsLeagueConfigs.ChampionsLeagueTeamClassification>[][] group, ChampionsLeagueConfigs.ChampionsLeagueTeamClassification targetTeamType, global::System.Collections.Generic.List<int> excluedGroupIdx = null, bool additive = true, ChampionsLeagueConfigs.ChampionsLeagueTeamClassification? originalTeamType = null)
        {
            return default;
        }
    }

    public struct TeamType
    {
        public int nationHash;
        public bool isSeeded;
        public ChampionsLeagueConfigs.ChampionsLeagueTeamClassification type;
        public int extraData;
    }

    private global::System.Collections.Generic.List<string> competitions;
    private global::System.Collections.Generic.Dictionary<string, ChampionsLeagueConfigs.ChampionsConfigs> configs;
    private global::System.Collections.Generic.Dictionary<string, char> countryCategory;
    private global::System.Collections.Generic.Dictionary<char, string> countryCategoryMap;
    public global::System.Collections.Generic.Dictionary<string, (string, string)> RuleVariations;
    private global::System.Collections.Generic.Dictionary<int, ChampionsLeagueConfigs.TeamType> TeamInfo;
    public global::System.Collections.Generic.IEnumerable<string> Competitions => null;

    public string GetCountryCategory(string nation)
    {
        return null;
    }

    private void LoadCountryCategory()
    {
    }

    public void Load()
    {
    }

    public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<ChampionsLeagueConfigs.TeamConfigs>> GetTeamConfigs(string target)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> GenerateEurpeanChampionshipGroup(ChampionsLeagueConfigs.TeamConfigsHandler handler, global::System.Collections.Generic.KeyValuePair<ChampionsLeagueConfigs.TeamConfigs, ChampionsLeagueConfigs.ChampionsLeagueTeamClassification>[][] groupInfo, ChampionsLeagueConfigs.ChampionsConfigs config)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> GenerateAsianChampionshipGroup(ChampionsLeagueConfigs.TeamConfigsHandler handler, global::System.Collections.Generic.KeyValuePair<ChampionsLeagueConfigs.TeamConfigs, ChampionsLeagueConfigs.ChampionsLeagueTeamClassification>[][] groupInfo, ChampionsLeagueConfigs.ChampionsConfigs config, int groupCount)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> GenerateSouthAmericanChampionshipCupGroup(ChampionsLeagueConfigs.TeamConfigsHandler handler, global::System.Collections.Generic.KeyValuePair<ChampionsLeagueConfigs.TeamConfigs, ChampionsLeagueConfigs.ChampionsLeagueTeamClassification>[][] groupInfo, ChampionsLeagueConfigs.ChampionsConfigs config)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> GenerateClubWorldCupGroup(ChampionsLeagueConfigs.TeamConfigsHandler handler, global::System.Collections.Generic.KeyValuePair<ChampionsLeagueConfigs.TeamConfigs, ChampionsLeagueConfigs.ChampionsLeagueTeamClassification>[][] groupInfo, ChampionsLeagueConfigs.ChampionsConfigs config)
    {
        return null;
    }

    public ChampionsLeagueConfigs.TeamType GetTeamInfo(TeamsData team, int[][] gropu = null)
    {
        return default;
    }

    public global::System.Collections.Generic.List<int> GenerateGroup(FACup fACup)
    {
        return null;
    }
}