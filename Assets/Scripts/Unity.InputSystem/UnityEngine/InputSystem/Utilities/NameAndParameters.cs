namespace UnityEngine.InputSystem.Utilities
{
	public struct NameAndParameters
	{
		public string name { get; set; }

		public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Utilities.NamedValue> parameters { get; set; }

		public override string ToString()
		{
			return null;
		}

		public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.Utilities.NameAndParameters> ParseMultiple(string text)
		{
			return null;
		}

		internal static bool ParseMultiple(string text, ref global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Utilities.NameAndParameters> list)
		{
			return false;
		}

		internal static string ParseName(string text)
		{
			return null;
		}

		public static global::UnityEngine.InputSystem.Utilities.NameAndParameters Parse(string text)
		{
			return default;
		}

		private static global::UnityEngine.InputSystem.Utilities.NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false)
		{
			return default;
		}
	}
}
