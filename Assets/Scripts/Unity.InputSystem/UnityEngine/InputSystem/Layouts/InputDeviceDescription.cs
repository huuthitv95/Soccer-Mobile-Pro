namespace UnityEngine.InputSystem.Layouts
{
	[global::System.Serializable]
	public struct InputDeviceDescription : global::System.IEquatable<global::UnityEngine.InputSystem.Layouts.InputDeviceDescription>
	{
		private struct DeviceDescriptionJson
		{
			public string @interface;

			public string type;

			public string product;

			public string serial;

			public string version;

			public string manufacturer;

			public string capabilities;
		}

		[global::UnityEngine.SerializeField]
		private string m_InterfaceName;

		[global::UnityEngine.SerializeField]
		private string m_DeviceClass;

		[global::UnityEngine.SerializeField]
		private string m_Manufacturer;

		[global::UnityEngine.SerializeField]
		private string m_Product;

		[global::UnityEngine.SerializeField]
		private string m_Serial;

		[global::UnityEngine.SerializeField]
		private string m_Version;

		[global::UnityEngine.SerializeField]
		private string m_Capabilities;

		public string interfaceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string deviceClass
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string manufacturer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string product
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string serial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string capabilities
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool empty => false;

		public override string ToString()
		{
			return null;
		}

		public bool Equals(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription other)
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

		public static bool operator ==(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription left, global::UnityEngine.InputSystem.Layouts.InputDeviceDescription right)
		{
			return false;
		}

		public static bool operator !=(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription left, global::UnityEngine.InputSystem.Layouts.InputDeviceDescription right)
		{
			return false;
		}

		public string ToJson()
		{
			return null;
		}

		public static global::UnityEngine.InputSystem.Layouts.InputDeviceDescription FromJson(string json)
		{
			return default;
		}

		internal static bool ComparePropertyToDeviceDescriptor(string propertyName, string propertyValue, string deviceDescriptor)
		{
			return false;
		}
	}
}
