namespace FLGameProgressSetting
{
	public class StaticLocalArchives : global::FLGameProgressSetting.LocalArchives
	{
		public global::Srv.StaticArchive Data;

		public global::Srv.ClassicTeamMatchChallengeArchive ClassicTeamMatchChallengeArchive => null;

		public global::Srv.ClassicTeamMatchChallengeArchive ClassicTeamMatchChallengeArchive2 => null;

		public global::Srv.CompetitionChallengeArchive CompetitionChallengeArchive => null;

		public global::Srv.RTC_CustomTeamChallengeArchive CustomTeamChallengeArchive => null;

		public global::Srv.MirroredMatchChallengeArchive MirroredChallengeArchive => null;

		public global::Srv.EraFinaleChallengeArchive EraFinaleChallengeArchive => null;

		public global::Srv.TourEventArchive TourEventArchive => null;

		public global::Srv.DebeyChallengeEventArchive DebeyChallengeEventArchive => null;

		public global::Srv.LastDanceChallengeArchive LastDanceChallengeArchive => null;

		protected override global::Google.Protobuf.IMessage Setting => null;

		public StaticLocalArchives(string fileName)
			: base(null, global::FLGameProgressSetting.LocalArchives.ArchiveType.Friendly)
		{
		}

		public int GetNationStringID(string nation)
		{
			return 0;
		}

		public string GetNationStringById(int id)
		{
			return null;
		}

		public int GetCurrentGlobalCupId()
		{
			return 0;
		}

		public int GetCurrentGlobalLeagueId()
		{
			return 0;
		}
	}
}
