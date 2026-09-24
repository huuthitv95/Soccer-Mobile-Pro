namespace UnityEngine.InputSystem
{
	public class InputValue
	{
		internal global::UnityEngine.InputSystem.InputAction.CallbackContext? m_Context;

		public bool isPressed => false;

		public object Get()
		{
			return null;
		}

		public TValue Get<TValue>() where TValue : struct
		{
			return default;
		}
	}
}
