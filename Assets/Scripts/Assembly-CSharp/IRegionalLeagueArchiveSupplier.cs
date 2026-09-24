public interface IRegionalLeagueArchiveSupplier
{
	void LoadArchive(RegionalLeague regionalLeague, string name, global::System.Action<global::FLGameProgressSetting.SeasonDataLocalArchives> onArchiveLoaded);
}
