public class SceneSetting
{
	public struct StadiumInfo
	{
		public enum StadiumType
		{
			Day = 0,
			Night = 1,
			Dawn = 2,
			Rain = 3
		}

		public string AbName;

		public string Day;

		public string Night;

		public string Dawn;

		public string Rain;

		public string crowdConfig_Day;

		public string crowdConfig_Night;

		public string crowdConfig_Dawn;

		public string crowdConfig_Rain;

		public string Name;

		public int BuildYear;

		public int Capacity;

		public global::FLGameData.RewardType PaidItem;

		public string GetStadiumPath(SceneSetting.StadiumInfo.StadiumType type)
		{
			return null;
		}

		public (string, string) GetCrowdConfig(SceneSetting.StadiumInfo.StadiumType type)
		{
			return default;
		}

		public bool IsLoaded()
		{
			return false;
		}

		public bool IsPaid()
		{
			return false;
		}

		public bool IsBanned()
		{
			return false;
		}
	}

	public static readonly int DefaultStadiumIndex;

	public static SceneSetting.StadiumInfo[] stadiumInfos;

	private static global::System.Collections.Generic.Dictionary<global::FLGameData.RewardType, int> StadiumRewardTypeToIndex;

	private static SceneSetting.StadiumInfo trainingScene;

	private static SceneSetting.StadiumInfo PenaltyScene;

	private static SceneSetting.StadiumInfo FreekickScene;

	public static string currentStadiumName;

	public static (string, string) currentCrowdConfig;

	public static string currentStadiumCommonName;

	public static SceneSetting.StadiumInfo GetStadiumInfoByRewardType(global::FLGameData.RewardType rewardType)
	{
		return default;
	}

	public static bool IsDownloadedStadium(global::FLGameData.RewardType rewardType)
	{
		return false;
	}

	public static int GetStadiumIndexByMatch(CupMatchBase matchBase)
	{
		return 0;
	}

	private static int GetRandomStadiumIndex(int randomSeed, int minInclusive, int maxExclusive)
	{
		return 0;
	}

	private static SceneSetting.StadiumInfo ChooseStadiumByMath(CupMatchBase matchBase)
	{
		return default;
	}

	public static string GetStadiumPath(CupMatchBase match)
	{
		return null;
	}
}
