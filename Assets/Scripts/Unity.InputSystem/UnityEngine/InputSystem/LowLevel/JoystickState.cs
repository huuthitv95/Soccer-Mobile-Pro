namespace UnityEngine.InputSystem.LowLevel
{
	internal struct JoystickState : global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
	{
		public enum Button
		{
			HatSwitchUp = 0,
			HatSwitchDown = 1,
			HatSwitchLeft = 2,
			HatSwitchRight = 3,
			Trigger = 4
		}

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int buttons;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public global::UnityEngine.Vector2 stick;

		public static global::UnityEngine.InputSystem.Utilities.FourCC kFormat => default;

		public global::UnityEngine.InputSystem.Utilities.FourCC format => default;
	}
}
