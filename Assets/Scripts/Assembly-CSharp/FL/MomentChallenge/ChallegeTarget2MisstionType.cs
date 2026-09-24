namespace FL.MomentChallenge
{
	public static class ChallegeTarget2MisstionType
	{
		public static (global::FLGameData.MissionType, int) ToMissionType(this global::FL.MomentChallenge.ChallegeTarget target)
		{
			return default;
		}

		public static bool IsCompleted(this global::FL.MomentChallenge.ChallegeTarget target, in MatchMissionPointChecker checkPoint)
		{
			return false;
		}

		private static bool CheckGoalCountWithVictory(in MatchMissionPointChecker checkPoint, int requiredGoalCount)
		{
			return false;
		}
	}
}
