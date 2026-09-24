namespace Facebook.Unity
{
	internal static class Utilities
	{
		public delegate void Callback<T>(T obj);

		public static bool TryGetValue<T>(this global::System.Collections.Generic.IDictionary<string, object> dictionary, string key, out T value)
		{
			value = default;
			return false;
		}

		public static long TotalSeconds(this global::System.DateTime dateTime)
		{
			return 0L;
		}

		public static T GetValueOrDefault<T>(this global::System.Collections.Generic.IDictionary<string, object> dictionary, string key, bool logWarning = true)
		{
			return default;
		}

		public static string ToCommaSeparateList(this global::System.Collections.Generic.IEnumerable<string> list)
		{
			return null;
		}

		public static string AbsoluteUrlOrEmptyString(this global::System.Uri uri)
		{
			return null;
		}

		public static string GetUserAgent(string productName, string productVersion)
		{
			return null;
		}

		public static string ToJson(this global::System.Collections.Generic.IDictionary<string, object> dictionary)
		{
			return null;
		}

		public static global::Facebook.Unity.AccessToken ParseAccessTokenFromResult(global::System.Collections.Generic.IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static global::Facebook.Unity.AuthenticationToken ParseAuthenticationTokenFromResult(global::System.Collections.Generic.IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static string ToStringNullOk(this object obj)
		{
			return null;
		}

		public static string FormatToString(string baseString, string className, global::System.Collections.Generic.IDictionary<string, string> propertiesAndValues)
		{
			return null;
		}

		private static global::System.DateTime ParseExpirationDateFromResult(global::System.Collections.Generic.IDictionary<string, object> resultDictionary)
		{
			return default;
		}

		private static global::System.DateTime? ParseLastRefreshFromResult(global::System.Collections.Generic.IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		private static global::System.Collections.Generic.ICollection<string> ParsePermissionFromResult(global::System.Collections.Generic.IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static global::System.Collections.Generic.IList<global::Facebook.Unity.Product> ParseCatalogFromResult(global::System.Collections.Generic.IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static global::System.Collections.Generic.IList<global::Facebook.Unity.Purchase> ParsePurchasesFromResult(global::System.Collections.Generic.IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static global::Facebook.Unity.Purchase ParsePurchaseFromResult(global::System.Collections.Generic.IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static global::System.Collections.Generic.IDictionary<string, string> ParseStringDictionaryFromString(string input)
		{
			return null;
		}

		public static global::System.Collections.Generic.IDictionary<string, string> ParseInnerStringDictionary(global::System.Collections.Generic.IDictionary<string, object> resultDictionary, string key)
		{
			return null;
		}

		public static global::System.DateTime FromTimestamp(int timestamp)
		{
			return default;
		}
	}
}
