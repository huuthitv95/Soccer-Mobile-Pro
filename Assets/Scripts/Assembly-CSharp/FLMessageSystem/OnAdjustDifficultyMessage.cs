namespace FLMessageSystem
{
	public struct OnAdjustDifficultyMessage
	{
		public enum DifficultyAdjustReason : sbyte
		{
			Popup = 0,
			Manual = 1
		}

		public sbyte LastDifficulty { get; private set; }

		public sbyte CurrentDifficulty { get; private set; }

		public global::FLGameData.DifficultySettingsGroup DifficultySettingsGroup { get; private set; }

		public global::FLMessageSystem.OnAdjustDifficultyMessage.DifficultyAdjustReason reason { get; private set; }

		public OnAdjustDifficultyMessage(sbyte lastDifficulty, sbyte currentDifficulty, global::FLGameData.DifficultySettingsGroup difficultySettingsGroup, global::FLMessageSystem.OnAdjustDifficultyMessage.DifficultyAdjustReason reason)
		{
			LastDifficulty = 0;
			CurrentDifficulty = 0;
			DifficultySettingsGroup = global::FLGameData.DifficultySettingsGroup.Friendly;
			this.reason = global::FLMessageSystem.OnAdjustDifficultyMessage.DifficultyAdjustReason.Popup;
		}
	}
}
