public class RegionalLeagueWrap
{
	public RegionalLeague regionalLeague;

	private global::FLGameProgressSetting.SeasonDataThumbnailArchives thumbnailDatabase;

	private string thumbnailKey;

	public bool IsStarted => false;

	public long RecordTime => 0L;

	public string DisplayName => null;

	public string CurrentYear => null;

	public string RoundName => null;

	public int TeamId => 0;

	public int TeamRating => 0;

	public RegionalLeagueWrap(RegionalLeague regionalLeague, global::FLGameProgressSetting.SeasonDataThumbnailArchives thumbnailDatabase, string thumbnailKey)
	{
	}
}
