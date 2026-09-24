namespace UnityEngine.InputSystem.Android.LowLevel
{
	[global::System.Serializable]
	internal struct AndroidDeviceCapabilities
	{
		public string deviceDescriptor;

		public int productId;

		public int vendorId;

		public bool isVirtual;

		public global::UnityEngine.InputSystem.Android.LowLevel.AndroidAxis[] motionAxes;

		public global::UnityEngine.InputSystem.Android.LowLevel.AndroidInputSource inputSources;

		public string ToJson()
		{
			return null;
		}

		public static global::UnityEngine.InputSystem.Android.LowLevel.AndroidDeviceCapabilities FromJson(string json)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
