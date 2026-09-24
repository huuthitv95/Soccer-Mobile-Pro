public struct AmazonAgeVerificationResult
{
	public AmazonAgeResponseStatus ResponseStatus { get; }

	public AmazonUserAgeStatus UserStatus { get; }

	public int? AgeLower { get; }

	public int? AgeUpper { get; }

	public string UserId { get; }

	public string MostRecentApprovalDate { get; }

	public AmazonAgeQueryEnvironment Environment { get; }

	public string ErrorMessage { get; }

	public string RawResponseStatus { get; }

	public string RawUserStatus { get; }

	public bool IsSuccess => false;

	public bool HasAnyConsent => false;

	public bool IsAdult => false;

	public bool IsTeen => false;

	public bool IsChild => false;

	public bool ShouldRetry => false;

	public bool IsFeatureAvailable => false;

	internal AmazonAgeVerificationResult(AmazonAgeResponseStatus responseStatus, AmazonUserAgeStatus userStatus, int? ageLower, int? ageUpper, string userId, string mostRecentApprovalDate, AmazonAgeQueryEnvironment environment, string errorMessage, string rawResponseStatus, string rawUserStatus)
	{
		ResponseStatus = AmazonAgeResponseStatus.Success;
		UserStatus = AmazonUserAgeStatus.Unknown;
		AgeLower = null;
		AgeUpper = null;
		UserId = null;
		MostRecentApprovalDate = null;
		Environment = AmazonAgeQueryEnvironment.Production;
		ErrorMessage = null;
		RawResponseStatus = null;
		RawUserStatus = null;
	}
}
