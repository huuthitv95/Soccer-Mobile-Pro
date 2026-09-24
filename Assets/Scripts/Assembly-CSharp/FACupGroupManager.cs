public class FACupGroupManager : global::Common.Singleton<FACupGroupManager>
{
    public class TeamConfigs
    {
        public int id;
        public int Weight;
        public int FIFARank;
        public NationalData.eContinent tag;
        public int indexOnGroup;
        public string naiton;
    }

    private class TeamConfigsHandler
    {
        public struct TeamConfigsWeight
        {
            public int idx;
            public int weight;
            public FACupGroupManager.TeamConfigs teamConfigs;
            public TeamConfigsWeight(int idx, int weight, FACupGroupManager.TeamConfigs teamConfigs)
            {
                this.idx = 0;
                this.weight = 0;
                this.teamConfigs = null;
            }
        }

        private global::System.Collections.Generic.List<FACupGroupManager.TeamConfigs> all;
        public global::System.Collections.Generic.Dictionary<NationalData.eContinent, global::System.Collections.Generic.LinkedList<FACupGroupManager.TeamConfigsHandler.TeamConfigsWeight>> teamByTag;
        public TeamConfigsHandler(global::System.Collections.Generic.List<FACupGroupManager.TeamConfigs> all)
        {
        }

        public FACupGroupManager.TeamConfigs RandomWithWeight(global::System.Collections.Generic.LinkedList<FACupGroupManager.TeamConfigsHandler.TeamConfigsWeight> list)
        {
            return null;
        }

        public FACupGroupManager.TeamConfigs RandomWithWeight(NationalData.eContinent continents)
        {
            return null;
        }

        public FACupGroupManager.TeamConfigs RandomWithWeight(global::System.Collections.Generic.List<NationalData.eContinent> continents)
        {
            return null;
        }

        public FACupGroupManager.TeamConfigs GetConfigById(int id)
        {
            return null;
        }

        public void Remove(FACupGroupManager.TeamConfigs team)
        {
        }

        public global::System.Collections.Generic.List<FACupGroupManager.Group> Draw(global::System.Collections.Generic.List<FACupGroupManager.TeamConfigs> assigned, int groupNum, global::System.Func<FACupGroupManager.Group, FACupGroupManager.TeamConfigs, bool> CanAddToGroup)
        {
            return null;
        }
    }

    private class Group
    {
        public global::System.Collections.Generic.List<FACupGroupManager.TeamConfigs> Teams { get; set; }
    }

    private global::System.Collections.Generic.List<FACupGroupManager.TeamConfigs> loadTeamConfigs(string path, global::System.Action<global::System.Collections.Generic.List<string>, FACupGroupManager.TeamConfigs> praser = null)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> GenerateWorldCupGroup(FACupGroupManager.TeamConfigsHandler handler, global::System.Collections.Generic.List<int> seededTeam)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> GenerateWorldCup26Group(FACupGroupManager.TeamConfigsHandler handler, global::System.Collections.Generic.List<int> seededTeam)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> GenerateWorldCupGroup(FACupGroupManager.TeamConfigsHandler handler, global::System.Collections.Generic.List<int> seededTeam, int capacity, int groupCount, global::System.Collections.Generic.Dictionary<NationalData.eContinent, int> rule, global::System.Collections.Generic.List<NationalData.eContinent> remainingSlotsRule)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> GenerateEuropeanCupGroup(FACupGroupManager.TeamConfigsHandler handler, global::System.Collections.Generic.List<int> hostTeam, int groupNum, NationalData.eContinent continents)
    {
        return null;
    }

    private global::System.Collections.Generic.List<int> GenerateAsianCupGroup(FACupGroupManager.TeamConfigsHandler handler, global::System.Collections.Generic.List<int> hostTeam, int groupNum, NationalData.eContinent continents)
    {
        return null;
    }

    public global::System.Collections.Generic.List<int> GenerateGroup(FACup fACup, global::System.Collections.Generic.List<int> HostId)
    {
        return null;
    }

    public global::System.Collections.Generic.List<int> GenerateGroupForNewWorldClubCup(TeamsData host)
    {
        return null;
    }
}