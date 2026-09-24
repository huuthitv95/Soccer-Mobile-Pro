public class StartGame : global::UnityEngine.MonoBehaviour
{
    public enum StartError
    {
        NoError = 0,
        CloudSaveInstallError = 1,
        CloudSaveVersionError = 2
    }

    [global::System.Serializable]
    public class GameDataExport
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image mark;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Button btn;
        private int counter;
        public void Init()
        {
        }
    }

    public static StartGame.StartError startError;
    private int frameDelay;
    private bool CheckCloudSaveFinish;
    private bool CheckNetworkFinish;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider _loading;
    [global::UnityEngine.SerializeField]
    private StartGame.GameDataExport gameDataExport;
    private bool switchScene;
    public static bool IsAwake;
    private void Start()
    {
    }

    private void DoNext()
    {
    }

    private void Awake()
    {
    }

    private global::System.Collections.IEnumerator CheckLoadCloudSave()
    {
        return null;
    }

    private void Update()
    {
    }
}