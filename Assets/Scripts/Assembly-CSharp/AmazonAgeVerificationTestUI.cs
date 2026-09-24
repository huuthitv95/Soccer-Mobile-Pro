public class AmazonAgeVerificationTestUI : global::UnityEngine.MonoBehaviour
{
    private struct ScenarioOption
    {
        public readonly int Value;
        public readonly string Title;
        public readonly string Description;
        public ScenarioOption(int value, string title, string description)
        {
            Value = 0;
            Title = null;
            Description = null;
        }
    }

    private const float WindowWidth = 460f;
    private const float WindowHeight = 360f;
    private static readonly AmazonAgeVerificationTestUI.ScenarioOption[] ScenarioOptions;
    private static AmazonAgeVerificationTestUI instance;
    private global::UnityEngine.Rect windowRect;
    private bool showScenarioDropdown;
    private global::UnityEngine.Vector2 scenarioScrollPosition;
    private global::UnityEngine.Vector2 resultScrollPosition;
    private string lastQuerySummary;
    private AmazonAgeVerificationResult? lastResult;
    public static AmazonAgeVerificationTestUI Instance => null;

    public static AmazonAgeVerificationTestUI Show()
    {
        return null;
    }

    public static void Hide()
    {
    }

    public static AmazonAgeVerificationRequest GetConfiguredRequest()
    {
        return default;
    }

    private void Awake()
    {
    }

    private void OnDestroy()
    {
    }

    private void OnGUI()
    {
    }

    private void DrawWindow(int id)
    {
    }

    private static void ApplyConfigToManager()
    {
    }

    private void DrawScenarioDropdown()
    {
    }

    private void DrawQuerySection()
    {
    }

    private void ExecuteAgeQuery()
    {
    }

    private void GenerateMockResult()
    {
    }

    private static string BuildResultSummary(AmazonAgeVerificationResult result)
    {
        return null;
    }

    private static string BuildActionHint(AmazonAgeVerificationResult result)
    {
        return null;
    }

    private static AmazonAgeVerificationTestUI.ScenarioOption FindScenario(int value)
    {
        return default;
    }
}