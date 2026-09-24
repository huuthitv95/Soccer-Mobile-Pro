namespace UnityEngine.InputSystem.Composites
{
	[global::System.ComponentModel.DisplayName]
	public class Vector3Composite : global::UnityEngine.InputSystem.InputBindingComposite<global::UnityEngine.Vector3>
	{
		public enum Mode
		{
			Analog = 0,
			DigitalNormalized = 1,
			Digital = 2
		}

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int up;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int down;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int left;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int right;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int forward;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int backward;

		public global::UnityEngine.InputSystem.Composites.Vector3Composite.Mode mode;

		public override global::UnityEngine.Vector3 ReadValue(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
		{
			return default;
		}

		public override float EvaluateMagnitude(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
		{
			return 0f;
		}
	}
}
