namespace FLDataTable
{
	public class GamepadConfigs
	{
		public global::FL.GamepadButtons KeyType;

		public global::UnityEngine.KeyCode PCKeyCod;

		public global::UnityEngine.KeyCode AndroidKeyCode;

		public global::EngineMessages.InputFunction DefaultOffensiveAction;

		public global::EngineMessages.InputFunction DefaultDefensiveAction;

		private const string _bytesPath = "Assets/GameData/excels/gamedata/ControllerSetting/XBox.bytes";

		public static global::System.Collections.Generic.Dictionary<global::FL.GamepadButtons, global::FLDataTable.GamepadConfigs> DeserializeTable(byte[] bytes, global::System.IO.BinaryReader reader)
		{
			return null;
		}

		public static global::System.Collections.Generic.Dictionary<global::FL.GamepadButtons, global::FLDataTable.GamepadConfigs> LoadTable(string path = "Assets/GameData/excels/gamedata/ControllerSetting/XBox.bytes")
		{
			return null;
		}

		public static global::FLDataTable.GamepadConfigs Deserialize(global::System.IO.BinaryReader reader)
		{
			return null;
		}
	}
}
