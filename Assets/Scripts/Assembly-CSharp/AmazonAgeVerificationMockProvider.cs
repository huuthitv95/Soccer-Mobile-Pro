public static class AmazonAgeVerificationMockProvider
{
	private class ScenarioData
	{
		public AmazonAgeResponseStatus ResponseStatus;

		public AmazonUserAgeStatus UserStatus;

		public int? AgeLower;

		public int? AgeUpper;

		public string UserId;

		public string MostRecentApprovalDate;
	}

	private static readonly global::System.Collections.Generic.Dictionary<int, AmazonAgeVerificationMockProvider.ScenarioData> ScenarioMap;

	public static AmazonAgeVerificationResult CreateMockResult(int scenario)
	{
		return default;
	}
}
