namespace UnityEngine.InputSystem.LowLevel
{
	internal struct PointerState : global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
	{
		private uint pointerId;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public global::UnityEngine.Vector2 position;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public global::UnityEngine.Vector2 delta;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public float pressure;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public global::UnityEngine.Vector2 radius;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public ushort buttons;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public ushort displayIndex;

		public static global::UnityEngine.InputSystem.Utilities.FourCC kFormat => default;

		public global::UnityEngine.InputSystem.Utilities.FourCC format => default;
	}
}
