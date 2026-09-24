namespace Facebook.Unity
{
	internal class MediaUploadResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IMediaUploadResult, global::Facebook.Unity.IResult
	{
		public string MediaId { get; private set; }

		internal MediaUploadResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
