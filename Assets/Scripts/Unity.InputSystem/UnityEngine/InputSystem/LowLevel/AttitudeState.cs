namespace UnityEngine.InputSystem.LowLevel
{
	internal struct AttitudeState : global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
	{
		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public global::UnityEngine.Quaternion attitude;

		public static global::UnityEngine.InputSystem.Utilities.FourCC kFormat => default;

		public global::UnityEngine.InputSystem.Utilities.FourCC format => default;
	}
}
