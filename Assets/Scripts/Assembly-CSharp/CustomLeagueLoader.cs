public class CustomLeagueLoader : RegionalLeagueLoader
{
    private global::System.Collections.Generic.Dictionary<string, int> nameIdMap;
    public CustomLeagueLoader() : base(null, isMaster: false, null, null, ConfigVariantID.None, null, null, null, null)
    {
    }

    protected override void CheckUnload(string name)
    {
    }

    protected override void UnLoadArchive(RegionalLeagueWrap wrap)
    {
    }

    public new void Load()
    {
    }

    private void CreateLeagueFromTemplate(global::Srv.CustomLeagueTemplate template)
    {
    }

    public void LoadArchive(RegionalLeague regionalLeague, string name, global::System.Action<global::FLGameProgressSetting.SeasonDataLocalArchives> onLoaded, global::Srv.CustomLeagueTemplate template)
    {
    }

    public override void LoadArchive(RegionalLeague regionalLeague, string name, global::System.Action<global::FLGameProgressSetting.SeasonDataLocalArchives> onLoaded)
    {
    }

    private string GetThumbnailKey(RegionalLeague regionalLeague)
    {
        return null;
    }

    public void CreateTemplates(global::Srv.CustomLeagueTemplate template)
    {
    }

    private void MoveFile(string src, string target)
    {
    }

    public RegionalLeagueWrap GetLeagueByTemplate(global::Srv.CustomLeagueTemplate template)
    {
        return null;
    }

    public RegionalLeagueWrap DeleteTemplate(global::Srv.CustomLeagueTemplate template)
    {
        return null;
    }
}