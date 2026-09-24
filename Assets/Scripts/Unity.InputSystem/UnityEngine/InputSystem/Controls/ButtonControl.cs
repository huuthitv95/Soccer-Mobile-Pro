namespace UnityEngine.InputSystem.Controls
{
	public class ButtonControl : global::UnityEngine.InputSystem.Controls.AxisControl
	{
		public float pressPoint;

		internal static float s_GlobalDefaultButtonPressPoint;

		internal static float s_GlobalDefaultButtonReleaseThreshold;

		internal const float kMinButtonPressPoint = 0.0001f;

		public float pressPointOrDefault => 0f;

		public bool isPressed => false;

		public bool wasPressedThisFrame => false;

		public bool wasReleasedThisFrame => false;

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public new bool IsValueConsideredPressed(float value)
		{
			return false;
		}
	}
}
