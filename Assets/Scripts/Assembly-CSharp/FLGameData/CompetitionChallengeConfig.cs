namespace FLGameData
{
	[global::UnityEngine.CreateAssetMenu]
	public class CompetitionChallengeConfig : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public class MissionConfig
		{
			public global::FLGameData.MissionType type;

			public global::System.Collections.Generic.List<int> targetPointSet;

			public int order;

			public int id;
		}

		[global::System.Serializable]
		public class FixedMissionConfig
		{
			public int[] missions;
		}

		[global::System.Serializable]
		public class StageReward
		{
			public int unlockPoint;

			public global::FLGameData.CompetitionChallengeConfig.MissionRewardWithTimes[] reward;
		}

		[global::System.Serializable]
		public class MissionRewardWithTimes
		{
			public int times;

			public global::FLGameData.CompetitionChallengeConfig.MissionReward reward;
		}

		[global::System.Serializable]
		public class MissionReward
		{
			public global::FLGameData.MissionRewardType type;

			public int value;
		}

		public int Id;

		public int MissionCount;

		public global::FLGameData.CompetitionChallengeConfig.FixedMissionConfig[] FixedMissionByRound;

		public global::FLGameData.CompetitionChallengeConfig.FixedMissionConfig[] RandomMissionList;

		public global::FLGameData.CompetitionChallengeConfig.MissionConfig[] AllMissions;

		public global::FLGameData.CompetitionType competitionType;

		public string competitionSpecificType;

		public int competitionId;

		public global::FLGameData.CompetitionChallengeConfig.StageReward[] stageReward;

		public int[] PlayerRewardPool;

		public int UserTeamId;
	}
}
