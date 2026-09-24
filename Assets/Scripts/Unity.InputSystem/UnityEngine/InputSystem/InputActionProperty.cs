namespace UnityEngine.InputSystem
{
	[global::System.Serializable]
	public struct InputActionProperty : global::System.IEquatable<global::UnityEngine.InputSystem.InputActionProperty>, global::System.IEquatable<global::UnityEngine.InputSystem.InputAction>, global::System.IEquatable<global::UnityEngine.InputSystem.InputActionReference>
	{
		[global::UnityEngine.SerializeField]
		private bool m_UseReference;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.InputSystem.InputAction m_Action;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.InputSystem.InputActionReference m_Reference;

		public global::UnityEngine.InputSystem.InputAction action => null;

		public global::UnityEngine.InputSystem.InputActionReference reference => null;

		internal global::UnityEngine.InputSystem.InputAction serializedAction => null;

		internal global::UnityEngine.InputSystem.InputActionReference serializedReference => null;

		public InputActionProperty(global::UnityEngine.InputSystem.InputAction action)
		{
			m_UseReference = false;
			m_Action = null;
			m_Reference = null;
		}

		public InputActionProperty(global::UnityEngine.InputSystem.InputActionReference reference)
		{
			m_UseReference = false;
			m_Action = null;
			m_Reference = null;
		}

		public bool Equals(global::UnityEngine.InputSystem.InputActionProperty other)
		{
			return false;
		}

		public bool Equals(global::UnityEngine.InputSystem.InputAction other)
		{
			return false;
		}

		public bool Equals(global::UnityEngine.InputSystem.InputActionReference other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(global::UnityEngine.InputSystem.InputActionProperty left, global::UnityEngine.InputSystem.InputActionProperty right)
		{
			return false;
		}

		public static bool operator !=(global::UnityEngine.InputSystem.InputActionProperty left, global::UnityEngine.InputSystem.InputActionProperty right)
		{
			return false;
		}
	}
}
