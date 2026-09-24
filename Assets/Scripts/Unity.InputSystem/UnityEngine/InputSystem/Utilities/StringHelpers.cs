namespace UnityEngine.InputSystem.Utilities
{
	internal static class StringHelpers
	{
		public static string Escape(this string str, string chars = "\n\t\r\\\"", string replacements = "ntr\\\"")
		{
			return null;
		}

		public static string Unescape(this string str, string chars = "ntr\\\"", string replacements = "\n\t\r\\\"")
		{
			return null;
		}

		public static bool Contains(this string str, char ch)
		{
			return false;
		}

		public static bool Contains(this string str, string text, global::System.StringComparison comparison)
		{
			return false;
		}

		public static string GetPlural(this string str)
		{
			return null;
		}

		public static string NicifyMemorySize(long numBytes)
		{
			return null;
		}

		public static bool FromNicifiedMemorySize(string text, out long result, long defaultMultiplier = 1L)
		{
			result = default;
			return false;
		}

		public static int CountOccurrences(this string str, char ch)
		{
			return 0;
		}

		public static global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.Utilities.Substring> Tokenize(this string str)
		{
			return null;
		}

		public static global::System.Collections.Generic.IEnumerable<string> Split(this string str, global::System.Func<char, bool> predicate)
		{
			return null;
		}

		public static string Join<TValue>(string separator, params TValue[] values)
		{
			return null;
		}

		public static string Join<TValue>(global::System.Collections.Generic.IEnumerable<TValue> values, string separator)
		{
			return null;
		}

		public static string MakeUniqueName<TExisting>(string baseName, global::System.Collections.Generic.IEnumerable<TExisting> existingSet, global::System.Func<TExisting, string> getNameFunc)
		{
			return null;
		}

		public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator)
		{
			return false;
		}

		public static int ParseInt(string str, int pos)
		{
			return 0;
		}

		public static bool WriteStringToBuffer(string text, global::System.IntPtr buffer, int bufferSizeInCharacters)
		{
			return false;
		}

		public static bool WriteStringToBuffer(string text, global::System.IntPtr buffer, int bufferSizeInCharacters, ref uint offset)
		{
			return false;
		}

		public static string ReadStringFromBuffer(global::System.IntPtr buffer, int bufferSize)
		{
			return null;
		}

		public static string ReadStringFromBuffer(global::System.IntPtr buffer, int bufferSize, ref uint offset)
		{
			return null;
		}

		public static bool IsPrintable(this char ch)
		{
			return false;
		}

		public static string WithAllWhitespaceStripped(this string str)
		{
			return null;
		}

		public static bool InvariantEqualsIgnoreCase(this string left, string right)
		{
			return false;
		}

		public static string ExpandTemplateString(string template, global::System.Func<string, string> mapFunc)
		{
			return null;
		}
	}
}
