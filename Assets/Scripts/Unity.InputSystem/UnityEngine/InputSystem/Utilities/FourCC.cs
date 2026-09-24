namespace UnityEngine.InputSystem.Utilities
{
	public struct FourCC : global::System.IEquatable<global::UnityEngine.InputSystem.Utilities.FourCC>
	{
		private int m_Code;

		public FourCC(int code)
		{
			m_Code = 0;
		}

		public FourCC(char a, char b = ' ', char c = ' ', char d = ' ')
		{
			m_Code = 0;
		}

		public FourCC(string str)
		{
			m_Code = 0;
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static implicit operator int(global::UnityEngine.InputSystem.Utilities.FourCC fourCC)
		{
			return 0;
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static implicit operator global::UnityEngine.InputSystem.Utilities.FourCC(int i)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool Equals(global::UnityEngine.InputSystem.Utilities.FourCC other)
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

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(global::UnityEngine.InputSystem.Utilities.FourCC left, global::UnityEngine.InputSystem.Utilities.FourCC right)
		{
			return false;
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(global::UnityEngine.InputSystem.Utilities.FourCC left, global::UnityEngine.InputSystem.Utilities.FourCC right)
		{
			return false;
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::UnityEngine.InputSystem.Utilities.FourCC FromInt32(int i)
		{
			return default;
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static int ToInt32(global::UnityEngine.InputSystem.Utilities.FourCC fourCC)
		{
			return 0;
		}
	}
}
