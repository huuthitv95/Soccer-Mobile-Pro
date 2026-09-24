namespace Facebook.Unity
{
	internal class ResultContainer
	{
		private const string CanvasResponseKey = "response";

		public string RawResult { get; private set; }

		public global::System.Collections.Generic.IDictionary<string, object> ResultDictionary { get; set; }

		public ResultContainer(global::System.Collections.Generic.IDictionary<string, object> dictionary)
		{
		}

		public ResultContainer(string result)
		{
		}

		private global::System.Collections.Generic.IDictionary<string, object> GetWebFormattedResponseDictionary(global::System.Collections.Generic.IDictionary<string, object> resultDictionary)
		{
			return null;
		}
	}
}
