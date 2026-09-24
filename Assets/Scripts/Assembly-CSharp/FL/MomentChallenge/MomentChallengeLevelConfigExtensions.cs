namespace FL.MomentChallenge
{
	public static class MomentChallengeLevelConfigExtensions
	{
		public static int GetDifficultyLevel(this global::FLDataTable.MomentChallengeLevelConfig levelConfig)
		{
			return 0;
		}

		public static string GetMatchTimeString(this MomentChallengeConfigManager.ChallengeInfo levelConfig)
		{
			return null;
		}

		public static WeatherConfigs.Weather GetMatchWeather(this global::FLDataTable.MomentChallengeLevelConfig levelConfig)
		{
			return WeatherConfigs.Weather.None;
		}

		public static SceneSetting.StadiumInfo.StadiumType GetStadiumType(this global::FLDataTable.MomentChallengeLevelConfig levelConfig)
		{
			return SceneSetting.StadiumInfo.StadiumType.Day;
		}
	}
}
