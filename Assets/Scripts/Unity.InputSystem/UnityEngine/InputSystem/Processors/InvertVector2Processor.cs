namespace UnityEngine.InputSystem.Processors
{
	public class InvertVector2Processor : global::UnityEngine.InputSystem.InputProcessor<global::UnityEngine.Vector2>
	{
		public bool invertX;

		public bool invertY;

		public override global::UnityEngine.Vector2 Process(global::UnityEngine.Vector2 value, global::UnityEngine.InputSystem.InputControl control)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
