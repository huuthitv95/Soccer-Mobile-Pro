namespace UnityEngine.InputSystem
{
	public static class InputControlPath
	{
		[global::System.Flags]
		public enum HumanReadableStringOptions
		{
			None = 0,
			OmitDevice = 2,
			UseShortNames = 4
		}

		private enum PathComponentType
		{
			Name = 0,
			DisplayName = 1,
			Usage = 2,
			Layout = 3
		}

		public struct ParsedPathComponent
		{
			internal global::UnityEngine.InputSystem.Utilities.Substring m_Layout;

			internal global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.Utilities.Substring> m_Usages;

			internal global::UnityEngine.InputSystem.Utilities.Substring m_Name;

			internal global::UnityEngine.InputSystem.Utilities.Substring m_DisplayName;

			public string layout => null;

			public global::System.Collections.Generic.IEnumerable<string> usages => null;

			public string name => null;

			public string displayName => null;

			internal bool isWildcard => false;

			internal bool isDoubleWildcard => false;

			internal string ToHumanReadableString(string parentLayoutName, string parentControlPath, out string referencedLayoutName, out string controlPath, global::UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options)
			{
				referencedLayoutName = null;
				controlPath = null;
				return null;
			}

			private static string ToHumanReadableString(global::UnityEngine.InputSystem.Utilities.Substring substring)
			{
				return null;
			}

			public bool Matches(global::UnityEngine.InputSystem.InputControl control)
			{
				return false;
			}

			private static bool ComparePathElementToString(global::UnityEngine.InputSystem.Utilities.Substring pathElement, string element)
			{
				return false;
			}
		}

		private struct PathParser
		{
			private string path;

			private int length;

			private int leftIndexInPath;

			private int rightIndexInPath;

			public global::UnityEngine.InputSystem.InputControlPath.ParsedPathComponent current;

			public bool isAtEnd => false;

			public PathParser(string path)
			{
				this.path = null;
				length = 0;
				leftIndexInPath = 0;
				rightIndexInPath = 0;
				current = default;
			}

			public bool MoveToNextComponent()
			{
				return false;
			}

			private global::UnityEngine.InputSystem.Utilities.Substring ParseComponentPart(char terminator)
			{
				return default;
			}
		}

		public const string Wildcard = "*";

		public const string DoubleWildcard = "**";

		public const char Separator = '/';

		internal const char SeparatorReplacement = ' ';

		internal static string CleanSlashes(this string pathComponent)
		{
			return null;
		}

		public static string Combine(global::UnityEngine.InputSystem.InputControl parent, string path)
		{
			return null;
		}

		public static string ToHumanReadableString(string path, global::UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options = global::UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions.None, global::UnityEngine.InputSystem.InputControl control = null)
		{
			return null;
		}

		public static string ToHumanReadableString(string path, out string deviceLayoutName, out string controlPath, global::UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options = global::UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions.None, global::UnityEngine.InputSystem.InputControl control = null)
		{
			deviceLayoutName = null;
			controlPath = null;
			return null;
		}

		public static string[] TryGetDeviceUsages(string path)
		{
			return null;
		}

		public static string TryGetDeviceLayout(string path)
		{
			return null;
		}

		public static string TryGetControlLayout(string path)
		{
			return null;
		}

		private static string FindControlLayoutRecursive(ref global::UnityEngine.InputSystem.InputControlPath.PathParser parser, string layoutName)
		{
			return null;
		}

		private static string FindControlLayoutRecursive(ref global::UnityEngine.InputSystem.InputControlPath.PathParser parser, global::UnityEngine.InputSystem.Layouts.InputControlLayout layout)
		{
			return null;
		}

		private static bool ControlLayoutMatchesPathComponent(ref global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, ref global::UnityEngine.InputSystem.InputControlPath.PathParser parser)
		{
			return false;
		}

		private static bool StringMatches(global::UnityEngine.InputSystem.Utilities.Substring str, global::UnityEngine.InputSystem.Utilities.InternedString matchTo)
		{
			return false;
		}

		public static global::UnityEngine.InputSystem.InputControl TryFindControl(global::UnityEngine.InputSystem.InputControl control, string path, int indexInPath = 0)
		{
			return null;
		}

		public static global::UnityEngine.InputSystem.InputControl[] TryFindControls(global::UnityEngine.InputSystem.InputControl control, string path, int indexInPath = 0)
		{
			return null;
		}

		public static int TryFindControls(global::UnityEngine.InputSystem.InputControl control, string path, ref global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> matches, int indexInPath = 0)
		{
			return 0;
		}

		public static TControl TryFindControl<TControl>(global::UnityEngine.InputSystem.InputControl control, string path, int indexInPath = 0) where TControl : global::UnityEngine.InputSystem.InputControl
		{
			return null;
		}

		public static int TryFindControls<TControl>(global::UnityEngine.InputSystem.InputControl control, string path, int indexInPath, ref global::UnityEngine.InputSystem.InputControlList<TControl> matches) where TControl : global::UnityEngine.InputSystem.InputControl
		{
			return 0;
		}

		public static global::UnityEngine.InputSystem.InputControl TryFindChild(global::UnityEngine.InputSystem.InputControl control, string path, int indexInPath = 0)
		{
			return null;
		}

		public static TControl TryFindChild<TControl>(global::UnityEngine.InputSystem.InputControl control, string path, int indexInPath = 0) where TControl : global::UnityEngine.InputSystem.InputControl
		{
			return null;
		}

		public static bool Matches(string expected, global::UnityEngine.InputSystem.InputControl control)
		{
			return false;
		}

		internal static bool MatchControlComponent(ref global::UnityEngine.InputSystem.InputControlPath.ParsedPathComponent expectedControlComponent, ref global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, bool matchAlias = false)
		{
			return false;
		}

		public static bool MatchesPrefix(string expected, global::UnityEngine.InputSystem.InputControl control)
		{
			return false;
		}

		private static bool MatchesRecursive(ref global::UnityEngine.InputSystem.InputControlPath.PathParser parser, global::UnityEngine.InputSystem.InputControl currentControl, bool prefixOnly = false)
		{
			return false;
		}

		private static TControl MatchControlsRecursive<TControl>(global::UnityEngine.InputSystem.InputControl control, string path, int indexInPath, ref global::UnityEngine.InputSystem.InputControlList<TControl> matches, bool matchMultiple) where TControl : global::UnityEngine.InputSystem.InputControl
		{
			return null;
		}

		private static TControl MatchByUsageAtDeviceRootRecursive<TControl>(global::UnityEngine.InputSystem.InputDevice device, string path, int indexInPath, ref global::UnityEngine.InputSystem.InputControlList<TControl> matches, bool matchMultiple) where TControl : global::UnityEngine.InputSystem.InputControl
		{
			return null;
		}

		private static TControl MatchChildrenRecursive<TControl>(global::UnityEngine.InputSystem.InputControl control, string path, int indexInPath, ref global::UnityEngine.InputSystem.InputControlList<TControl> matches, bool matchMultiple) where TControl : global::UnityEngine.InputSystem.InputControl
		{
			return null;
		}

		private static bool MatchPathComponent(string component, string path, ref int indexInPath, global::UnityEngine.InputSystem.InputControlPath.PathComponentType componentType, int startIndexInComponent = 0)
		{
			return false;
		}

		private static bool PathComponentCanYieldMultipleMatches(string path, int indexInPath)
		{
			return false;
		}

		public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> Parse(string path)
		{
			return null;
		}
	}
}
