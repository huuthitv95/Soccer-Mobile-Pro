namespace UnityEngine.InputSystem.Users
{
	public struct InputUserAccountHandle : global::System.IEquatable<global::UnityEngine.InputSystem.Users.InputUserAccountHandle>
	{
		private string m_ApiName;

		private ulong m_Handle;

		public string apiName => null;

		public ulong handle => 0uL;

		public InputUserAccountHandle(string apiName, ulong handle)
		{
			m_ApiName = null;
			m_Handle = 0uL;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(global::UnityEngine.InputSystem.Users.InputUserAccountHandle other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator ==(global::UnityEngine.InputSystem.Users.InputUserAccountHandle left, global::UnityEngine.InputSystem.Users.InputUserAccountHandle right)
		{
			return false;
		}

		public static bool operator !=(global::UnityEngine.InputSystem.Users.InputUserAccountHandle left, global::UnityEngine.InputSystem.Users.InputUserAccountHandle right)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
