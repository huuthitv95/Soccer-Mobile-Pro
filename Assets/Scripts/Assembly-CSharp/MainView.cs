public class MainView : global::UnityEngine.MonoBehaviour
{
    public enum MainViewPageType
    {
        Home = 0,
        ClubMode = 1,
        NationMode = 2,
        MiniGame = 3,
        Women = 4,
        PVP = 5,
        Count = 6
    }

    [global::System.Serializable]
    private class RedPointBindData
    {
        public global::UnityEngine.Events.UnityEvent<global::UnityEngine.GameObject> OnCheckRedPoint;
        public global::UnityEngine.GameObject redPointObj;
    }

    [global::System.Serializable]
    private class MainViewPageLoader
    {
        [global::UnityEngine.SerializeField]
        private MainViewPage page;
        [global::UnityEngine.SerializeField]
        public MainView.MainViewPageType path;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Transform pageContainer;
        private bool isFirstShow;
        public void Initialize()
        {
        }

        public void Show(bool show, MainView mainView)
        {
        }

        private void load()
        {
        }
    }

    private enum EventEntriesState
    {
        NotInit = 0,
        Initialized = 1,
        WaitForDeeplink = 2
    }

    private enum MiniGameScreenState
    {
        None = 0,
        Active = 1,
        Unobstructed = 2,
        ActiveAndUnobstructed = 3
    }

    public static readonly bool Use26WorldCupTheme;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image lowerBg;
    [global::UnityEngine.SerializeField]
    private PageView slideshow;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform leftNav;
    [global::UnityEngine.SerializeField]
    private MainView.MainViewPageLoader[] mainViewPages;
    [global::UnityEngine.SerializeField]
    private MainView.RedPointBindData[] redPointBindDatas;
    [global::UnityEngine.SerializeField]
    private MainView26WorldCupBg worldCup26Bg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject pvpTab;
    private static bool firstLoad;
    public static global::System.Action OnMainViewOpen;
    public static bool InMatch;
    [global::UnityEngine.SerializeField]
    private RTCEventEntry[] eventEntries;
    [global::UnityEngine.SerializeField]
    private GUIMomentChallengeEntry momentChallengeBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject momentChallengeToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject licensedChallengeToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject licensedChallengeBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button[] tourEventButtons;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject tourEventToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button TrainingSlideWindowBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject TrainingSlideWindowToggle;
    private bool tourEventEntryInitialized;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button[] debeyChallengeEventButtons;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject debeyChallengeEventToggle;
    private bool debeyChallengeEventEntryInitialized;
    private global::UnityEngine.UI.Button btnShop;
    private global::UnityEngine.GameObject masterLeagueNewTip;
    private global::UnityEngine.Animator hightlightEntryAnimator;
    private global::Coffee.UIEffects.UIShiny btnTrainingEffect;
    private MainView.EventEntriesState eventEntriesState;
    private float timer;
    private bool dirtyMark;
    private global::System.Lazy<ScreenTimeTracker> _screenTimeTracker;
    private MainView.MiniGameScreenState miniGameScreenState;
    private static int defaultPageIdx;
    private static MainView.MainViewPageType? requestedPageOnNextOpen;
    public static global::UnityEngine.Camera MainViewCamera { get; private set; }
    public static bool IsActive { get; private set; }

    private void CheckRedPoints()
    {
    }

    public void BindButton(global::UnityEngine.UI.Button button, MainViewLoader.MainViewButtonType type)
    {
    }

    private void InitTourEventEntry()
    {
    }

    private void UpdateTourEventEntry()
    {
    }

    private void UpdateTourEventRedPoint()
    {
    }

    private void InitDebeyChallengeEventEntry()
    {
    }

    private void UpdateDebeyChallengeEventEntry()
    {
    }

    private void UpdateDebeyChallengeEventRedPoint()
    {
    }

    private void UpdateMomentChallengeEntry()
    {
    }

    private void UpdateLicensedChallengeEntry()
    {
    }

    public void OpenTourEvent()
    {
    }

    private void ShowTourEventWelcome(global::FL.TourEvent.TourEventManager manager)
    {
    }

    private void OpenTourEventMainView(global::FL.TourEvent.TourEventManager manager)
    {
    }

    public void OpenLicensedChallenge()
    {
    }

    public void OpenDebeyChallengeEvent()
    {
    }

    private void CheckPopup()
    {
    }

    private void CheckGamePromotionPopup()
    {
    }

    private void CheckPromotionIAPPackPopup()
    {
    }

    private void RefreshEventEntries()
    {
    }

    private void InitEventEntries()
    {
    }

    private void HandleDeeplink()
    {
    }

    private void PlayCoinAnimation(object obj)
    {
    }

    private void Start()
    {
    }

    private void HandleNoIapForAmazon()
    {
    }

    public static global::System.Collections.IEnumerator delayAction(int frame, global::System.Action action)
    {
        return null;
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }

    private void CheckIngameKill()
    {
    }

    private void CheckStartupTimeSent(bool firstLoad)
    {
    }

    private void CheckLoadRemoteAssets()
    {
    }

    private void CheckCloudSaveError()
    {
    }

    private void CheckDataDataPacketLog()
    {
    }

    public static void ShowUmpWindow(global::System.Action action)
    {
    }

    private void Update()
    {
    }

    private void MarkRefreshFlag(string window)
    {
    }

    private void CheckNeedHidden(string win)
    {
    }

    private void OnSceneLoaded(global::UnityEngine.SceneManagement.Scene scene, global::UnityEngine.SceneManagement.LoadSceneMode mode)
    {
    }

    private void OnSceneUnloaded(global::UnityEngine.SceneManagement.Scene scene)
    {
    }

    private void OnActiveSceneChanged(global::UnityEngine.SceneManagement.Scene current, global::UnityEngine.SceneManagement.Scene next)
    {
    }

    private void CheckEventReward()
    {
    }

    public void OpenMasterLeague()
    {
    }

    public void OpenFriendlyMatch()
    {
    }

    public static void OpenTraining()
    {
    }

    private void InitTrainingEffect(bool isFirstLoad)
    {
    }

    private void onDeepLinkActivated(string url)
    {
    }

    private void CheckLoadRemoteStadium()
    {
    }

    public void OpenWorldCup26()
    {
    }

    public void OpenUEFAChampionship()
    {
    }

    private void CheckObstructedMiniGameScreen()
    {
    }

    public static void RequestPageOnNextOpen(MainView.MainViewPageType pageType)
    {
    }

    private void InitLeftNav()
    {
    }

    private void ChangeMainviewPage(object obj)
    {
    }

    private void SwitchToHomePage()
    {
    }

    public void CheckMomentChallengeRedPoint(global::UnityEngine.GameObject go)
    {
    }

    public void CheckLocalPVPRedPoint(global::UnityEngine.GameObject go)
    {
    }

    public void CheckTourEventRedPoint(global::UnityEngine.GameObject go)
    {
    }

    public void CheckDebeyChallengeEventRedPoint(global::UnityEngine.GameObject go)
    {
    }

    public void OpenPlayerCareer()
    {
    }

    public void OpenIapStore()
    {
    }
}