namespace Facebook.Unity
{
	internal class TournamentResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.ITournamentResult, global::Facebook.Unity.IResult
	{
		public string TournamentId { get; private set; }

		public string ContextId { get; private set; }

		public int EndTime { get; private set; }

		public string TournamentTitle { get; private set; }

		public global::System.Collections.Generic.IDictionary<string, string> Payload { get; private set; }

		internal TournamentResult(global::Facebook.Unity.ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
