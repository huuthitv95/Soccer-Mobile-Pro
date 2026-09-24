namespace FLGameProgressSetting
{
	internal readonly struct ArchiveMatchId : global::System.IEquatable<global::FLGameProgressSetting.ArchiveMatchId>
	{
		internal int DataScope { get; }

		internal int CompetitionId { get; }

		internal int MatchId { get; }

		internal ArchiveMatchId(int dataScope, int competitionId, int matchId)
		{
			DataScope = 0;
			CompetitionId = 0;
			MatchId = 0;
		}

		public bool Equals(global::FLGameProgressSetting.ArchiveMatchId other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
