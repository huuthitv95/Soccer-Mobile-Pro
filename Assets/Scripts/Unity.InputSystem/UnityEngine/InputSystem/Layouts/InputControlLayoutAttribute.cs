namespace UnityEngine.InputSystem.Layouts
{
	public sealed class InputControlLayoutAttribute : global::System.Attribute
	{
		internal bool? canRunInBackgroundInternal;

		internal bool? updateBeforeRenderInternal;

		public global::System.Type stateType { get; set; }

		public string stateFormat { get; set; }

		public string[] commonUsages { get; set; }

		public string variants { get; set; }

		public bool isNoisy { get; set; }

		public bool canRunInBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool updateBeforeRender
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isGenericTypeOfDevice { get; set; }

		public string displayName { get; set; }

		public string description { get; set; }

		public bool hideInUI { get; set; }
	}
}
