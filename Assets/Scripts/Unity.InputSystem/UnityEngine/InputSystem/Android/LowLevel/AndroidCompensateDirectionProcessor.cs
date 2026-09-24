namespace UnityEngine.InputSystem.Android.LowLevel
{
	internal class AndroidCompensateDirectionProcessor : global::UnityEngine.InputSystem.Processors.CompensateDirectionProcessor
	{
		private const float kSensorStandardGravity = 9.80665f;

		private const float kAccelerationMultiplier = -0.10197162f;

		public override global::UnityEngine.Vector3 Process(global::UnityEngine.Vector3 vector, global::UnityEngine.InputSystem.InputControl control)
		{
			return default;
		}
	}
}
