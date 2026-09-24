public class TeamFilter
{
    private global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<TeamsData>>> allTeams;
    private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<TeamsData>> currentTeams;
    private global::System.Func<TeamsData, string> keyFunc;
    private global::System.Func<global::System.Collections.Generic.List<TeamsData>, bool> onUpdate;
    private int hashCode;
    private string currentCondition;
    private global::System.Comparison<string> sortFunc;
    private global::System.Collections.Generic.List<string> conditions;
    public string currentConditionName => null;

    public TeamFilter(global::System.Func<TeamsData, string> keyFunc, string defaultCondition, global::System.Comparison<string> sortFunc = null)
    {
    }

    public void SetInitialCondition(string condition)
    {
    }

    public bool ChangeCondition(string condition)
    {
        return false;
    }

    public global::System.Collections.Generic.IList<string> GetConditions()
    {
        return null;
    }

    public bool Init(global::System.Collections.Generic.List<TeamsData> teams)
    {
        return false;
    }

    public void AddUpdateListener(global::System.Func<global::System.Collections.Generic.List<TeamsData>, bool> action)
    {
    }

    public static bool NationTeamFilter(TeamsData team)
    {
        return false;
    }

    public static bool ClubTeamFilter(TeamsData team)
    {
        return false;
    }

    public static bool LegendaryTeamFilter(TeamsData team)
    {
        return false;
    }

    public static bool LegendaryNationalTeamFilter(TeamsData team)
    {
        return false;
    }

    public static bool LegendaryClubTeamFilter(TeamsData team)
    {
        return false;
    }

    public static bool WomenTeamFilter(TeamsData team)
    {
        return false;
    }

    public static string GetContinentKey(TeamsData team)
    {
        return null;
    }

    public static string GetNationKey(TeamsData team)
    {
        return null;
    }

    public static int NationKeySortFunc(string a, string b)
    {
        return 0;
    }

    private static int ContinentPriority(NationalData.eContinent continent)
    {
        return 0;
    }

    public static int ContinentKeySortFunc(string a, string b)
    {
        return 0;
    }

    public static string GetGenderKey(TeamsData team)
    {
        return null;
    }

    public static int GenderKeySortFunc(string a, string b)
    {
        return 0;
    }
}