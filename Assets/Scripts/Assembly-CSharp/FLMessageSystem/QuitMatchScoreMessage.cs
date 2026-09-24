namespace FLMessageSystem
{
	public struct QuitMatchScoreMessage
	{
		public global::FLGameData.GameMode competitionType { get; private set; }

		public int GoalDifference { get; private set; }

		public QuitMatchScoreMessage(global::FLGameData.GameMode competitionType, int goalDifference)
		{
			this.competitionType = global::FLGameData.GameMode.Friendly;
			GoalDifference = 0;
		}
	}
}
