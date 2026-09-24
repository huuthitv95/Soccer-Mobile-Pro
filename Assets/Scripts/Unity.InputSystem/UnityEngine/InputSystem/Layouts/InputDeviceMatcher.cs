namespace UnityEngine.InputSystem.Layouts
{
	public struct InputDeviceMatcher : global::System.IEquatable<global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher>
	{
		[global::System.Serializable]
		internal struct MatcherJson
		{
			public struct Capability
			{
				public string path;

				public string value;
			}

			public string @interface;

			public string[] interfaces;

			public string deviceClass;

			public string[] deviceClasses;

			public string manufacturer;

			public string[] manufacturers;

			public string product;

			public string[] products;

			public string version;

			public string[] versions;

			public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson.Capability[] capabilities;

			public static global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson FromMatcher(global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
			{
				return default;
			}

			public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher ToMatcher()
			{
				return default;
			}
		}

		private global::System.Collections.Generic.KeyValuePair<global::UnityEngine.InputSystem.Utilities.InternedString, object>[] m_Patterns;

		private static readonly global::UnityEngine.InputSystem.Utilities.InternedString kInterfaceKey;

		private static readonly global::UnityEngine.InputSystem.Utilities.InternedString kDeviceClassKey;

		private static readonly global::UnityEngine.InputSystem.Utilities.InternedString kManufacturerKey;

		private static readonly global::UnityEngine.InputSystem.Utilities.InternedString kProductKey;

		private static readonly global::UnityEngine.InputSystem.Utilities.InternedString kVersionKey;

		public bool empty => false;

		public global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> patterns => null;

		public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithInterface(string pattern, bool supportRegex = true)
		{
			return default;
		}

		public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = true)
		{
			return default;
		}

		public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = true)
		{
			return default;
		}

		public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithProduct(string pattern, bool supportRegex = true)
		{
			return default;
		}

		public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithVersion(string pattern, bool supportRegex = true)
		{
			return default;
		}

		public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithCapability<TValue>(string path, TValue value)
		{
			return default;
		}

		private global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher With(global::UnityEngine.InputSystem.Utilities.InternedString key, object value, bool supportRegex = true)
		{
			return default;
		}

		public float MatchPercentage(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription)
		{
			return 0f;
		}

		private static bool MatchSingleProperty(object pattern, string value)
		{
			return false;
		}

		private static int GetNumPropertiesIn(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription description)
		{
			return 0;
		}

		public static global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher FromDeviceDescription(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator ==(global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher right)
		{
			return false;
		}

		public static bool operator !=(global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher right)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
