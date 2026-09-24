namespace Facebook.Unity
{
	internal class PayResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IPayResult, global::Facebook.Unity.IResult
	{
		public long ErrorCode => 0L;

		internal PayResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
