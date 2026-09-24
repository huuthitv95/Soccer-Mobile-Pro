namespace Facebook.Unity
{
	public class FBSDKEventBinding
	{
		private string pathType;

		private global::System.Collections.Generic.List<string> parameters;

		public string eventName { get; set; }

		public string eventType { get; set; }

		public string appVersion { get; set; }

		public global::System.Collections.Generic.List<global::Facebook.Unity.FBSDKCodelessPathComponent> path { get; set; }

		public FBSDKEventBinding(global::System.Collections.Generic.Dictionary<string, object> dict)
		{
		}
	}
}
