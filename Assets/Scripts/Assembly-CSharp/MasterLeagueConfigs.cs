public class MasterLeagueConfigs : global::Common.Singleton<MasterLeagueConfigs>
{
    private const int RemainingAmount = 3;
    public global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> AllClub;
    public string LeagueVariantPath1_0;
    public string CupRulesConfigPath1_0;
    private void loadAllClub()
    {
    }

    public void Load()
    {
    }

    public global::System.Collections.Generic.List<ClubPlayer> GetRemainingPlayers(TeamsData team)
    {
        return null;
    }
}