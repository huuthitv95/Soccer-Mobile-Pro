public class AmazonAgeVerificationManager : global::Common.Singleton<AmazonAgeVerificationManager>
{
    private const string UnityPlayerClass = "com.unity3d.player.UnityPlayer";
    private const string UriClass = "android.net.Uri";
    private const string ProductionUri = "content://amzn_appstore/getUserAgeData";
    private const string TestUriFormat = "content://amzn_test_appstore/getUserAgeData?testOption={0}";
    private const string ColumnResponseStatus = "responseStatus";
    private const string ColumnUserStatus = "userStatus";
    private const string ColumnAgeLower = "ageLower";
    private const string ColumnAgeUpper = "ageUpper";
    private const string ColumnUserId = "userId";
    private const string ColumnApprovalDate = "mostRecentApprovalDate";
    private static readonly string[] CursorProjection;
    private AmazonAgeVerificationRequest currentRequest;
    public AmazonAgeVerificationRequest CurrentRequest => default;

    public void Configure(AmazonAgeQueryEnvironment environment, int testScenario = 1)
    {
    }

    public void Configure(AmazonAgeVerificationRequest request)
    {
    }

    public AmazonAgeVerificationResult QueryUserAgeData()
    {
        return default;
    }

    public AmazonAgeVerificationResult QueryMockUserAgeData(int scenario = 1)
    {
        return default;
    }

    public AmazonAgeVerificationResult QueryUserAgeDataWithMockFallback(int scenario = 1)
    {
        return default;
    }

    public AmazonAgeVerificationResult QueryUserAgeData(AmazonAgeVerificationRequest customRequest)
    {
        return default;
    }

    private static global::UnityEngine.AndroidJavaObject BuildRequestUri(AmazonAgeVerificationRequest request)
    {
        return null;
    }

    private AmazonAgeVerificationResult BuildResultFromCursor(global::UnityEngine.AndroidJavaObject cursor, AmazonAgeQueryEnvironment environment)
    {
        return default;
    }

    private static string GetString(global::UnityEngine.AndroidJavaObject cursor, string columnName)
    {
        return null;
    }

    private static int? GetNullableInt(global::UnityEngine.AndroidJavaObject cursor, string columnName)
    {
        return null;
    }

    private static AmazonAgeResponseStatus ParseResponseStatus(string rawStatus)
    {
        return AmazonAgeResponseStatus.Success;
    }

    private static AmazonUserAgeStatus ParseUserStatus(string rawStatus)
    {
        return AmazonUserAgeStatus.Unknown;
    }

    private AmazonAgeVerificationResult CreateErrorResult(AmazonAgeResponseStatus status, string errorMessage, AmazonAgeQueryEnvironment environment)
    {
        return default;
    }
}