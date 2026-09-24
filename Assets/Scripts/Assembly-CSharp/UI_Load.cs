public class UI_Load : global::UnityEngine.MonoBehaviour
{
    private struct WaitABTest
    {
        private float timer;
        private const float waitTime = 5f;
        public bool CanGotoMainView()
        {
            return false;
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider _loading;
    [global::UnityEngine.SerializeField]
    private StartGame.GameDataExport gameDataExport;
    private bool resMangerInit;
    private bool loadingAnimReady;
    private bool loadingOver;
    private global::UnityEngine.Coroutine waitSoundBundleCoroutine;
    private global::UnityEngine.Rect selectExcelsFolderButtonRect;
    private global::UnityEngine.Rect startButtonRect;
    private global::UnityEngine.Rect avatarTest2ButtonRect;
    private global::UnityEngine.Rect avataTestButtonRect;
    private global::UnityEngine.Rect deleteUserInfoButtonRect;
    private bool pressStart;
    private ScreenTimeTracker screenTimeTracker;
    public static float adaptedHeight;
    public static float navigationbarHeight;
    private bool notchInited;
    private UI_Load.WaitABTest waitABTest;
    private global::System.Collections.IEnumerator fakeLoadingBar()
    {
        return null;
    }

    private void OnGUI()
    {
    }

    private void Awake()
    {
    }

    private global::System.Collections.IEnumerator WaitSoundBundleReadyAndPlayBgm()
    {
        return null;
    }

    public static string GetEngineParameters()
    {
        return null;
    }

    private void Start()
    {
    }

    private void Init()
    {
    }

    private void clearSave()
    {
    }

    private void OnDestroy()
    {
    }

    private void StartInit()
    {
    }

    private void Update()
    {
    }
}