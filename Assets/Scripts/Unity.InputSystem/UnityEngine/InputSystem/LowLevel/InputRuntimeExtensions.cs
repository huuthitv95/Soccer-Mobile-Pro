namespace UnityEngine.InputSystem.LowLevel
{
	internal static class InputRuntimeExtensions
	{
		public static long DeviceCommand<TCommand>(this global::UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, int deviceId, ref TCommand command) where TCommand : struct, global::UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
		{
			return 0L;
		}
	}
}
