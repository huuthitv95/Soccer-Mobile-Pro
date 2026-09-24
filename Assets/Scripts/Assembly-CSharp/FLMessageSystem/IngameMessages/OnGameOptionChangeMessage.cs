namespace FLMessageSystem.IngameMessages
{
	public struct OnGameOptionChangeMessage
	{
		public enum GameOptionType
		{
			Radar = 0,
			GamepadConfig = 1
		}

		public global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage.GameOptionType type;

		public bool BoolValue;

		public float FloatValue;

		public int IntValue;

		public string StringValue;

		public object ObjectValue;

		public static global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage CreateMessage(bool value, global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage.GameOptionType type)
		{
			return default;
		}

		public static global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage CreateMessage(float value, global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage.GameOptionType type)
		{
			return default;
		}

		public static global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage CreateMessage(int value, global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage.GameOptionType type)
		{
			return default;
		}

		public static global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage CreateMessage(string value, global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage.GameOptionType type)
		{
			return default;
		}

		public static global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage CreateMessage(object value, global::FLMessageSystem.IngameMessages.OnGameOptionChangeMessage.GameOptionType type)
		{
			return default;
		}
	}
}
