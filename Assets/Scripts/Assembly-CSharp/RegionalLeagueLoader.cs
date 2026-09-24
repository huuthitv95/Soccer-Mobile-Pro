public class RegionalLeagueLoader : IRegionalLeagueArchiveSupplier
{
    public global::System.Collections.Generic.List<RegionalLeagueWrap> all;
    private string ConfigPath;
    private bool IsMaster;
    private global::System.Func<string, global::FLGameProgressSetting.SeasonDataLocalArchives> NewArchiveGeter;
    private global::System.Action<string> UnLoadArchiveData;
    private global::System.Action<string, RegionalLeague, global::Srv.SeasonData> OnUpdater;
    private ConfigVariantID variantID;
    private string FixturesConfigPath;
    private global::FLGameProgressSetting.SeasonDataThumbnailArchives thumbnailDatabase;
    private global::System.Func<RegionalLeague, string> GetThumbnailKey;
    protected global::System.Collections.Generic.List<RegionalLeagueWrap> menLeagues;
    protected global::System.Collections.Generic.List<RegionalLeagueWrap> womenLeagues;
    protected global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> rows;
    public global::System.Collections.Generic.List<RegionalLeagueWrap> MenLeagues => null;
    public global::System.Collections.Generic.List<RegionalLeagueWrap> WomenLeagues => null;

    public int IndexOf(RegionalLeague regionalLeague)
    {
        return 0;
    }

    public RegionalLeagueLoader(string configPath, bool isMaster, global::System.Func<string, global::FLGameProgressSetting.SeasonDataLocalArchives> newArchiveGeter, global::System.Action<string, RegionalLeague, global::Srv.SeasonData> onUpdater, ConfigVariantID variantID, string FixturesConfigPath, global::FLGameProgressSetting.SeasonDataThumbnailArchives thumbnailDatabase, global::System.Func<RegionalLeague, string> GetThumbnailKey, global::System.Action<string> UnLoadArchiveData)
    {
    }

    public bool HasValidMenArchive()
    {
        return false;
    }

    public bool HasValidWomenArchive()
    {
        return false;
    }

    public bool HasValidWomenArchive(string leagueName)
    {
        return false;
    }

    protected virtual void UnLoadArchive(RegionalLeagueWrap wrap)
    {
    }

    protected virtual void CheckUnload(string exclude)
    {
    }

    public virtual void LoadArchive(RegionalLeague regionalLeague, string name, global::System.Action<global::FLGameProgressSetting.SeasonDataLocalArchives> onArchiveLoaded)
    {
    }

    public static RegionalLeague Deserialization(global::System.Collections.Generic.List<string> row, ConfigVariantID variantID, string FixturesConfigPath, IRegionalLeagueArchiveSupplier loader)
    {
        return null;
    }

    private RegionalLeague Deserialization(global::System.Collections.Generic.List<string> row)
    {
        return null;
    }

    public void Load()
    {
    }
}