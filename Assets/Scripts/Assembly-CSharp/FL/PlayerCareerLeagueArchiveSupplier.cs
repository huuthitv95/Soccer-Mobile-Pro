namespace FL
{
    public class PlayerCareerLeagueArchiveSupplier : IRegionalLeagueArchiveSupplier
    {
        private global::FLGameProgressSetting.SeasonDataLocalArchives archive;
        public PlayerCareerLeagueArchiveSupplier(global::FLGameProgressSetting.SeasonDataLocalArchives archive)
        {
        }

        public void LoadArchive(RegionalLeague regionalLeague, string name, global::System.Action<global::FLGameProgressSetting.SeasonDataLocalArchives> onArchiveLoaded)
        {
        }

        private void OnArchiveLoaded(RegionalLeague item)
        {
        }
    }
}