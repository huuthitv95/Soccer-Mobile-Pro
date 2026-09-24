namespace FLMessageSystem
{
	public struct IngamePlayerEventMessage
	{
		public global::FLMessageSystem.FullPlayerStatisticsType EventType { get; set; }

		public InGamePlayer Player { get; set; }

		public int Time { get; set; }

		public IngamePlayerEventMessage(global::FLMessageSystem.FullPlayerStatisticsType eventType, InGamePlayer player, int time)
		{
			EventType = global::FLMessageSystem.FullPlayerStatisticsType.SuccessfulTackle;
			Player = null;
			Time = 0;
		}
	}
}
