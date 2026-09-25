using Soccer.Recovery.Boot;

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
            // Still unrecovered. Boot copies do not bind the original debug-export UI.
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

    // Nonserialized recovery state; original names, fields and GUID are preserved.
    private int recoveryCallbackGeneration;
    private IBootCloudSaveAdapter recoveryCloudSave;
    private bool recoveryActive;

    private void Start()
    {
        if (!recoveryActive) return;
        // 0xD42494: optional GameDataExport.Init call. Callee remains a stub.
        if (gameDataExport != null) gameDataExport.Init();
    }

    private void DoNext()
    {
        // 0xD42518..0xD42544: both gates, guard BEFORE loading.
        if (!recoveryActive || switchScene || !CheckCloudSaveFinish || !CheckNetworkFinish) return;
        switchScene = true;
        BootRecoveryTrace.Record(BootRecoveryEvent.TransitionRequested);
        // 0xD42570..0xD425F8: LoadScenes([Start, Launch], [], null).
        // Recovery substitutes editor scene loading, ending at BootStart.
        if (!BootRecoveryServices.TryLoadRecoveryStart())
            BootRecoveryTrace.Record(BootRecoveryEvent.NoRecoveryNavigator);
    }

    private void Awake()
    {
        // Opt in only on the object owning the recovery adapter. Original scenes
        // retain stub behavior; no unverified engine/SDK bootstrap executes.
        recoveryCloudSave = GetComponent<OfflineBootCloudSaveAdapter>();
        if (recoveryCloudSave == null) return;
        recoveryActive = true;
        recoveryCallbackGeneration++;
        var profile = recoveryCloudSave.Profile;
        startError = (StartError)profile.InitialError; // recovery session isolation
        IsAwake = true; // native 0xD4296C
        // 0xD427E0..0xD42834: missing _CheckNetwrok key calls CheckNetwork,
        // writes key=1 and delay=60. I/O effects are replaced with profile inputs.
        frameDelay = profile.NetworkProbePreviouslyRecorded ? 0 : 60;
        BootRecoveryTrace.Record(BootRecoveryEvent.Awake);
        StartCoroutine(CheckLoadCloudSave());
    }

    private global::System.Collections.IEnumerator CheckLoadCloudSave()
    {
        int generation = recoveryCallbackGeneration;
        // MoveNext 0xC5699C..0xC56AB0, predicate 0xC567FC: wait for nonempty
        // PlayerSetting.Savepath, then yield GameDataPacker.CheckLoadCloudSave.
        // Readiness is synthetic; no original save path is touched.
        if (!recoveryCloudSave.Profile.SaveRootReady)
        {
            BootRecoveryTrace.Record(BootRecoveryEvent.WaitingForSaveRoot);
            yield return new global::UnityEngine.WaitUntil(() =>
                !recoveryActive || recoveryCloudSave.Profile.SaveRootReady);
        }
        if (!recoveryActive || generation != recoveryCallbackGeneration) yield break;
        bool callbackConsumed = false;
        yield return recoveryCloudSave.CheckLoad(
            success =>
            {
                if (!recoveryActive || generation != recoveryCallbackGeneration) return;
                if (callbackConsumed)
                {
                    BootRecoveryTrace.Record(BootRecoveryEvent.LateOrDuplicateCallbackIgnored);
                    return;
                }
                callbackConsumed = true;
                // 0xD42B54..0xD42B7C preserves earlier errors; 0xD42BB8 sets
                // cloud gate on BOTH success and failure, then calls DoNext.
                if (!success && startError == StartError.NoError) startError = StartError.CloudSaveInstallError;
                CheckCloudSaveFinish = true;
                BootRecoveryTrace.Record(success ? BootRecoveryEvent.CloudSaveSucceeded : BootRecoveryEvent.CloudSaveFailed);
                DoNext();
            },
            percent =>
            {
                if (!recoveryActive || generation != recoveryCallbackGeneration || callbackConsumed) return;
                // 0xD42BD0: float constants 100.0f, 0.15f and virtual Slider.value setter.
                if (_loading != null) _loading.value = percent / 100f * 0.15f;
            });
    }

    private void Update()
    {
        if (!recoveryActive || CheckNetworkFinish) return;
        // Exact branches 0xD42A38..0xD42A84, including final decrement.
        if (frameDelay > 0)
        {
            if (recoveryCloudSave.Profile.SimulatedInternetReachable) frameDelay = 0;
            else frameDelay--;
        }
        if (frameDelay != 0) return;
        CheckNetworkFinish = true;
        BootRecoveryTrace.Record(BootRecoveryEvent.NetworkGateSatisfied);
        DoNext();
        frameDelay--;
    }

    // Recovery lifecycle protection, not a claimed native method body.
    private void OnDisable()
    {
        if (!recoveryActive) return;
        recoveryActive = false;
        recoveryCallbackGeneration++;
        StopAllCoroutines();
        recoveryCloudSave.Cancel();
        IsAwake = false;
        BootRecoveryTrace.Record(BootRecoveryEvent.Cancelled);
    }
}
