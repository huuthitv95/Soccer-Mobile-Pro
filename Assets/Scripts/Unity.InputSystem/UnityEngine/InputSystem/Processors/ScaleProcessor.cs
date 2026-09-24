namespace UnityEngine.InputSystem.Processors
{
	public class ScaleProcessor : global::UnityEngine.InputSystem.InputProcessor<float>
	{
		public float factor;

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
