namespace UnityEngine.InputSystem.Processors
{
	public class StickDeadzoneProcessor : global::UnityEngine.InputSystem.InputProcessor<global::UnityEngine.Vector2>
	{
		public float min;

		public float max;

		private float minOrDefault => 0f;

		private float maxOrDefault => 0f;

		public override global::UnityEngine.Vector2 Process(global::UnityEngine.Vector2 value, global::UnityEngine.InputSystem.InputControl control = null)
		{
			return default;
		}

		private float GetDeadZoneAdjustedValue(float value)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
