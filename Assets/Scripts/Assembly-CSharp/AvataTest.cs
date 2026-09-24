public class AvataTest : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField team;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.InputField player;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage texture;
    private TeamDataManager TeamManager;
    private PlayerManager playerManager;
    private readonly global::System.Text.StringBuilder invalidReport;
    private global::UnityEngine.Vector2 reportScroll;
    private bool showReportWindow;
    private bool scanFinished;
    private int errorCount;
    private string statusText;
    private void Start()
    {
    }

    public void Apply()
    {
    }

    public void CheckAllAvatar()
    {
    }

    private void AppendError(string line)
    {
    }

    private global::System.Collections.IEnumerator DoAction(string[] allFiles, global::Common.PlayerBoneHolder[] _officials)
    {
        return null;
    }

    private void OnGUI()
    {
    }

    private void DrawReportWindow(int id)
    {
    }
}