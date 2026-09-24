public class CustomADDisplayManager : global::UnityEngine.MonoBehaviour
{
    private static CustomADDisplayManager instance;
    private global::System.Collections.Generic.Dictionary<int, int> groupVisibleCount;
    private global::System.Collections.Generic.Dictionary<int, float> groupVisibleTime;
    private float lastReportTime;
    private const float REPORT_INTERVAL = 60f;
    public static void Init(global::UnityEngine.GameObject host)
    {
    }

    public static void AddVisible(int groupId)
    {
    }

    public static void RemoveVisible(int groupId)
    {
    }

    private void OnEnable()
    {
    }

    private void OnDestroy()
    {
    }

    private void Update()
    {
    }

    private void ReportAndClear()
    {
    }
}