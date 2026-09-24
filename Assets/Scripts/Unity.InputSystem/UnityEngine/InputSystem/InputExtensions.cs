namespace UnityEngine.InputSystem
{
	public static class InputExtensions
	{
		public static bool IsInProgress(this global::UnityEngine.InputSystem.InputActionPhase phase)
		{
			return false;
		}

		public static bool IsEndedOrCanceled(this global::UnityEngine.InputSystem.TouchPhase phase)
		{
			return false;
		}

		public static bool IsActive(this global::UnityEngine.InputSystem.TouchPhase phase)
		{
			return false;
		}

		public static bool IsModifierKey(this global::UnityEngine.InputSystem.Key key)
		{
			return false;
		}

		public static bool IsTextInputKey(this global::UnityEngine.InputSystem.Key key)
		{
			return false;
		}
	}
}
