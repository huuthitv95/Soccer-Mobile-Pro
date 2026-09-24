[global::System.Serializable]
public struct AmazonAgeVerificationRequest
{
	public AmazonAgeQueryEnvironment Environment;

	public int TestScenario;

	public static AmazonAgeVerificationRequest CreateProduction()
	{
		return default;
	}

	public static AmazonAgeVerificationRequest CreateTest(int scenario = 1)
	{
		return default;
	}

	public AmazonAgeVerificationRequest EnsureValid()
	{
		return default;
	}
}
