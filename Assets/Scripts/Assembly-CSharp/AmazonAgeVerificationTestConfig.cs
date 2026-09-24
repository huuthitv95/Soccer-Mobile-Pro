public static class AmazonAgeVerificationTestConfig
{
    private const string PrefKeyUseTestEnv = "AmazonAgeVerification_UseTestEnv";
    private const string PrefKeyUseMock = "AmazonAgeVerification_UseMock";
    private const string PrefKeyTestScenario = "AmazonAgeVerification_TestScenario";
    private const int DefaultScenario = 1;
    private static bool isLoaded;
    private static bool useTestEnvironment;
    private static bool useMockProvider;
    private static int testScenario;
    public static bool UseTestEnvironment
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public static bool UseMockProvider
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public static int TestScenario
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public static AmazonAgeVerificationRequest GetRequest()
    {
        return default;
    }

    public static void ResetToProduction()
    {
    }

    private static void EnsureLoaded()
    {
    }

    private static void Persist()
    {
    }
}