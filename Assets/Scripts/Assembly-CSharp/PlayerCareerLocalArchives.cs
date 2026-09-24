public class PlayerCareerLocalArchives : global::FLGameProgressSetting.CompetitionLocalArchives
{
    public global::Srv.PlayerCareerArchive Data;
    private PlayerManager playerManager;
    private TeamDataManager teamDataManager;
    public override PlayerManager PlayerManager => null;
    public override TeamDataManager TeamDataManager => null;
    protected override global::Google.Protobuf.IMessage Setting => null;
    public global::FLGameProgressSetting.SeasonDataLocalArchives SeasonDataLocalArchives { get; private set; }

    public PlayerCareerLocalArchives(string name, global::Srv.PlayerCareerArchive data, bool createNew) : base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
    {
    }

    public override void CheckDirtyFlag()
    {
    }

    public override void Delete()
    {
    }

    public void OnCreateNewCareer()
    {
    }

    public void ResetSeasonDataForRebirth()
    {
    }

    private void InitializeSeasonData()
    {
    }
}