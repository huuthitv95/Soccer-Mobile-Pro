namespace FLGameProgressSetting
{
	public abstract class CompetitionLocalArchives : global::FLGameProgressSetting.LocalArchives
	{
		public abstract PlayerManager PlayerManager { get; }

		public abstract TeamDataManager TeamDataManager { get; }

		protected CompetitionLocalArchives(string fileName, global::FLGameProgressSetting.LocalArchives.ArchiveType archiveType)
			: base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
		{
		}
	}
}
