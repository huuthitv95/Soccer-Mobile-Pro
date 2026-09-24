namespace FLMessageSystem.IngameMessages
{
	public struct PlayerIconPopup
	{
		public int PlayerIdx;

		public int IconType;

		public int Offset;

		public PlayerIconPopup(int playerIdx, int iconType, int offset)
		{
			PlayerIdx = 0;
			IconType = 0;
			Offset = 0;
		}
	}
}
