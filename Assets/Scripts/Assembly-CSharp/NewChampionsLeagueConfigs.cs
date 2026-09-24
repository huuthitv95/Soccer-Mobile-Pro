public class NewChampionsLeagueConfigs : global::Common.Singleton<NewChampionsLeagueConfigs>
{
    public class TeamConfigs
    {
        public int id;
        public NationalData.eNation nation;
        public int rating;
        public int qualificationWeight;
        public char type1;
        public char type2;
    }

    public class SeatAllocationRules
    {
        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<NationalData.eNation, int>> seedSet;
        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<char, int>> type1SharedSet;
        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<char, int>> type2SharedSet;
        public global::System.Collections.Generic.Dictionary<int, NewChampionsLeagueConfigs.TeamConfigs> allTeams;
    }

    private global::System.Collections.Generic.Dictionary<string, NewChampionsLeagueConfigs.SeatAllocationRules> SeatAllocationRulesDict;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> PairPlayOffGroupRule;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> KnockoutGroupRule;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> KnockoutGroupRule2;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> KnockoutGroupRule_asian;
    private NewChampionsLeagueConfigs.SeatAllocationRules GetSeatAllocationRules(string key)
    {
        return null;
    }

    public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>>> GetMatchs(string type, global::FLDataTable.NewChampionsLeagueRules rule)
    {
        return null;
    }

    public int FindAlternativeTeams(string type, global::System.Collections.Generic.IEnumerable<int> group, TeamsData targetTeam, global::System.Func<NewChampionsLeagueConfigs.TeamConfigs, bool> condition = null, NewChampionsLeagueConfigs.SeatAllocationRules seatAllocationRules = null)
    {
        return 0;
    }

    public void FindAlternativeTeams(string type, global::System.Collections.Generic.List<int> seats, global::System.Collections.Generic.List<int> finalGroups, TeamDataManager manager)
    {
    }

    public global::System.Collections.Generic.List<TeamsData> PairPlayOffTeams(global::System.Collections.Generic.List<TeamsData> rankOrder)
    {
        return null;
    }

    public global::System.Collections.Generic.List<TeamsData> PairKnockoutTeams_UEFA(global::System.Collections.Generic.List<TeamsData> rankOrder, global::System.Collections.Generic.List<TeamsData> opponents)
    {
        return null;
    }

    public void PayoffWinningTeamsSorter_UEFA(global::System.Collections.Generic.List<TeamsData> winningTeams)
    {
    }

    public global::System.Collections.Generic.List<TeamsData> PairKnockoutTeams_Asian(global::System.Collections.Generic.List<TeamsData> eastAsia, global::System.Collections.Generic.List<TeamsData> westAsia)
    {
        return null;
    }

    public void PayoffWinningTeamsSorter_Asian(global::System.Collections.Generic.List<TeamsData> winningTeams)
    {
    }

    public global::System.Collections.Generic.List<TeamsData> PairKnockoutTeams(global::System.Collections.Generic.List<TeamsData> rankOrder, global::System.Collections.Generic.List<TeamsData> opponents)
    {
        return null;
    }
}