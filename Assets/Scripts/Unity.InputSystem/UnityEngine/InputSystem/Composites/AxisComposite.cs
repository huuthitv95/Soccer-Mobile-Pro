namespace UnityEngine.InputSystem.Composites
{
	[global::System.ComponentModel.DisplayName]
	public class AxisComposite : global::UnityEngine.InputSystem.InputBindingComposite<float>
	{
		public enum WhichSideWins
		{
			Neither = 0,
			Positive = 1,
			Negative = 2
		}

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int negative;

		[global::UnityEngine.InputSystem.Layouts.InputControl]
		public int positive;

		public float minValue;

		public float maxValue;

		public global::UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWins whichSideWins;

		public float midPoint => 0f;

		public override float ReadValue(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
		{
			return 0f;
		}

		public override float EvaluateMagnitude(ref global::UnityEngine.InputSystem.InputBindingCompositeContext context)
		{
			return 0f;
		}
	}
}
