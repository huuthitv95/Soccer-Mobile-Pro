namespace UnityEngine.InputSystem.Processors
{
	public class InvertVector3Processor : global::UnityEngine.InputSystem.InputProcessor<global::UnityEngine.Vector3>
	{
		public bool invertX;

		public bool invertY;

		public bool invertZ;

		public override global::UnityEngine.Vector3 Process(global::UnityEngine.Vector3 value, global::UnityEngine.InputSystem.InputControl control)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
