namespace UnityEngine.InputSystem.LowLevel
{
	internal struct AccelerometerState : global::UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
	{
		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public global::UnityEngine.Vector3 acceleration;

		public static global::UnityEngine.InputSystem.Utilities.FourCC kFormat => default;

		public global::UnityEngine.InputSystem.Utilities.FourCC format => default;
	}
}
