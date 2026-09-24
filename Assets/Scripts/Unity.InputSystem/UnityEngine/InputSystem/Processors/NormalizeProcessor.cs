namespace UnityEngine.InputSystem.Processors
{
	public class NormalizeProcessor : global::UnityEngine.InputSystem.InputProcessor<float>
	{
		public float min;

		public float max;

		public float zero;

		public override float Process(float value, global::UnityEngine.InputSystem.InputControl control)
		{
			return 0f;
		}

		public static float Normalize(float value, float min, float max, float zero)
		{
			return 0f;
		}

		internal static float Denormalize(float value, float min, float max, float zero)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
