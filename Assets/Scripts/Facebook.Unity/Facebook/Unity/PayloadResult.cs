namespace Facebook.Unity
{
	internal class PayloadResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IPayloadResult, global::Facebook.Unity.IResult
	{
		public global::System.Collections.Generic.IDictionary<string, string> Payload { get; private set; }

		public PayloadResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
