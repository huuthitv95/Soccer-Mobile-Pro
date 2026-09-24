public class SelectRoleSceneManager : global::UnityEngine.MonoBehaviour
{
    private enum Node
    {
        SelectRole = 0,
        BaseInfo = 1,
        PlayerStyle = 2,
        NoPlayer = 3,
        FinishNode = 4,
        Blank = 5,
        SinglePlayer = 6,
        Count = 7
    }

    private static SelectRoleSceneManager instance;
    private static bool isLoadingScene;
    private static readonly global::System.Collections.Generic.List<global::System.Action<SelectRoleSceneManager>> pendingLoadedCallbacks;
    private const float WorldAlignmentEpsilon = 0.001f;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] nodes;
    [global::UnityEngine.SerializeField]
    private SelectRole selectRole;
    [global::UnityEngine.SerializeField]
    private global::TMPro.TextMeshProUGUI titleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image teamLogo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject finishTitle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Canvas canvas;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera m_camera;
    [global::UnityEngine.SerializeField]
    private float playerStyleLeftEdgeWorldOffset;
    private PlayerRender UserPlayer;
    private global::System.Collections.Generic.List<(SelectRoleSceneManager.Node, string)> StateStack;
    private global::UnityEngine.SceneManagement.Scene lastActiveScene;
    public global::UnityEngine.Canvas Canvas => null;

    private void Awake()
    {
    }

    public void BackToPreviousState()
    {
    }

    private void ShowNode(SelectRoleSceneManager.Node node)
    {
    }

    public void ShowBaseInfo(global::UnityEngine.GameObject playerGO, string title)
    {
    }

    public void ShowPlayerStyle(string title)
    {
    }

    public void AlignUserPlayerLeftEdgeToScreenX(float targetScreenX)
    {
    }

    public void ShowNoPlayer(string title)
    {
    }

    public void ShowFinishNode(string title, TeamsData teamData, ClubPlayer player)
    {
    }

    public void ShowSelectRole(string title, global::System.Action<int, global::UnityEngine.GameObject> onRoleSelected)
    {
    }

    public global::UnityEngine.GameObject ShowStaticPlayer(string title, int appearanceId)
    {
        return null;
    }

    public PlayerModelLoader ShowSinglePlayer(string title)
    {
        return null;
    }

    public void ShowBlank()
    {
    }

    private void ApplyTitle(SelectRoleSceneManager.Node node, string title)
    {
    }

    private bool TryGetUserPlayerWorldLeftX(out float leftX)
    {
        leftX = default;
        return false;
    }

    public static void CheckLoadScene(global::System.Action<SelectRoleSceneManager> OnLoaded)
    {
    }

    private static void OnSceneLoaded(global::UnityEngine.SceneManagement.Scene scene, global::UnityEngine.SceneManagement.LoadSceneMode mode)
    {
    }

    private static void TryBindInstanceAndDispatchCallbacks()
    {
    }

    public void UnloadScene()
    {
    }

    private void OnDestroy()
    {
    }
}