namespace TMPro
{
	internal static class SetPropertyUtility
	{
		public static bool SetColor(ref global::UnityEngine.Color currentValue, global::UnityEngine.Color newValue)
		{
			return false;
		}

		public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) where T : global::System.IEquatable<T>
		{
			return false;
		}

		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return false;
		}

		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return false;
		}
	}
}
