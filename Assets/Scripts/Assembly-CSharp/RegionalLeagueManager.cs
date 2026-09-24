public class RegionalLeagueManager : global::Common.Singleton<RegionalLeagueManager>
{
    public CustomLeagueLoader CustomLoader;
    public RegionalLeagueLoader MasterLeagueLoader;
    private RegionalLeague lastPlayed;
    public RegionalLeagueLoader SimpleLeagueLoader;
    public RegionalLeague LastPlayed
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public void LoadCustomLeague()
    {
    }

    public void LoadMasterLeagueLoader()
    {
    }

    private void OnMasterLeagueLoaded(string name, RegionalLeague item, global::Srv.SeasonData archive)
    {
    }

    public void Load()
    {
    }

    private static RegionalLeague TryGetLastPlayerd(RegionalLeagueLoader loader, string last)
    {
        return null;
    }

    public void ResetLastPlayed()
    {
    }

    public void OnArchiveDelete(RegionalLeague regionalLeague)
    {
    }

    public float CalculatePlayerPotential(global::SL.Player proto, int adjustedPrimeAge)
    {
        return 0f;
    }

    public int GetPositionAgeAdjustment(FormationTool.UIPosition position)
    {
        return 0;
    }

    public void LoadSimpleLeague()
    {
    }
}