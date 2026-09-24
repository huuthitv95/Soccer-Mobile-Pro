public class MomentChallengeConfigManager
{
	public class ChallengeInfo
	{
		public int UserTeam;

		public int OpponentTeam;

		public global::FLDataTable.MomentChallengeLevelConfig levelConfig;

		public int difficultyPoints;

		public int TargetTime;

		public global::UnityEngine.Vector3 BallPos;
	}

	private string configDir;

	private string randomRulesPath;

	private string clubConfigPath;

	private string nationalConfigPath;

	private string levelConfigPath => null;

	public MomentChallengeConfigManager.ChallengeInfo DrawChallengeInfo(bool isClub, int playerLevelValue, int matchCount, int lastId)
	{
		return null;
	}

	public global::FLDataTable.MomentChallengeLevelConfig GetLevelConfig(int id)
	{
		return null;
	}

	public int GetDifficultyPoints(global::FL.MomentChallenge.DifficultyLevel difficulty)
	{
		return 0;
	}

	public MomentChallengeConfigManager(string configDir)
	{
	}
}
