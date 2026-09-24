namespace UnityEngine.InputSystem.Composites
{
	[global::System.ComponentModel.DisplayName]
	public class Vector2Composite : global::UnityEngine.InputSystem.InputBindingComposite<global::UnityEngine.Vector2>
	{
		public enum Mode
		{
			Analog = 2,
			DigitalNormalized = 0,
			Digital = 1
		}

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int up;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int down;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int left;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int right;

		[global::System.Obsolete]
		public bool normalize;

		public global::UnityEngine.InputSystem.Composites.Vector2Composite.Mode mode;

		public override global::UnityEngine.Vector2 ReadValue(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
		{
			return default;
		}

		public override float EvaluateMagnitude(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
		{
			return 0f;
		}
	}
}
