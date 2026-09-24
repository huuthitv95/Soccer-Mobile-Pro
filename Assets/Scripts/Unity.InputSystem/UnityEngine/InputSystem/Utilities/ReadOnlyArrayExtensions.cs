namespace UnityEngine.InputSystem.Utilities
{
	public static class ReadOnlyArrayExtensions
	{
		public static bool Contains<TValue>(this global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) where TValue : global::System.IComparable<TValue>
		{
			return false;
		}

		public static bool ContainsReference<TValue>(this global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) where TValue : class
		{
			return false;
		}

		public static int IndexOfReference<TValue>(this global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) where TValue : class
		{
			return 0;
		}

		internal static bool HaveEqualReferences<TValue>(this global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array1, global::System.Collections.Generic.IReadOnlyList<TValue> array2, int count = int.MaxValue)
		{
			return false;
		}
	}
}
