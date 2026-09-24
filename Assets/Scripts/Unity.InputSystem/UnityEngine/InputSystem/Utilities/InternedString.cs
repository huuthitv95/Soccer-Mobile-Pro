namespace UnityEngine.InputSystem.Utilities
{
	public struct InternedString : global::System.IEquatable<global::UnityEngine.InputSystem.Utilities.InternedString>, global::System.IComparable<global::UnityEngine.InputSystem.Utilities.InternedString>
	{
		private readonly string m_StringOriginalCase;

		private readonly string m_StringLowerCase;

		public int length => 0;

		public InternedString(string text)
		{
			m_StringOriginalCase = null;
			m_StringLowerCase = null;
		}

		public bool IsEmpty()
		{
			return false;
		}

		public string ToLower()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(global::UnityEngine.InputSystem.Utilities.InternedString other)
		{
			return false;
		}

		public int CompareTo(global::UnityEngine.InputSystem.Utilities.InternedString other)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(global::UnityEngine.InputSystem.Utilities.InternedString a, global::UnityEngine.InputSystem.Utilities.InternedString b)
		{
			return false;
		}

		public static bool operator !=(global::UnityEngine.InputSystem.Utilities.InternedString a, global::UnityEngine.InputSystem.Utilities.InternedString b)
		{
			return false;
		}

		public static bool operator ==(global::UnityEngine.InputSystem.Utilities.InternedString a, string b)
		{
			return false;
		}

		public static bool operator !=(global::UnityEngine.InputSystem.Utilities.InternedString a, string b)
		{
			return false;
		}

		public static bool operator ==(string a, global::UnityEngine.InputSystem.Utilities.InternedString b)
		{
			return false;
		}

		public static bool operator !=(string a, global::UnityEngine.InputSystem.Utilities.InternedString b)
		{
			return false;
		}

		public static bool operator <(global::UnityEngine.InputSystem.Utilities.InternedString left, global::UnityEngine.InputSystem.Utilities.InternedString right)
		{
			return false;
		}

		public static bool operator >(global::UnityEngine.InputSystem.Utilities.InternedString left, global::UnityEngine.InputSystem.Utilities.InternedString right)
		{
			return false;
		}

		public static implicit operator string(global::UnityEngine.InputSystem.Utilities.InternedString str)
		{
			return null;
		}
	}
}
