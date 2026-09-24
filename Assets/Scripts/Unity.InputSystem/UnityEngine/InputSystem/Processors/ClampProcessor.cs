namespace UnityEngine.InputSystem.Processors
{
	public class ClampProcessor : global::UnityEngine.InputSystem.InputProcessor<float>
	{
		public float min;

		public float max;

		public override float Process(float value, global::UnityEngine.InputSystem.InputControl control)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
