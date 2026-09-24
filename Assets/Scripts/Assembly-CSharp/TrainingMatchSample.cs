public class TrainingMatchSample : global::UnityEngine.MonoBehaviour, IMatch, ReplayHandler, ITrainingMissionsHelper
{
    [global::UnityEngine.SerializeField]
    private AISampleBase agnet;
    [global::UnityEngine.SerializeField]
    private DrawTrainingArea limitareas;
    [global::UnityEngine.SerializeField]
    private DrawTrainingArea destinations;
    [global::UnityEngine.SerializeField]
    private DrawTrainingArea promptArea;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform Tutorial;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text missionInfo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text timer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject timerGo;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text failText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera uiCamera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera gameCamera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject arrow;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_exit;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform tips;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_skip;
    private bool quit;
    private global::System.Collections.Generic.List<AIMatchConfigurer.TrainingLevel> trainingTypes;
    private int[] subLevels;
    private bool isPerfect;
    private bool useAdvancedLevel;
    private int levelIndex;
    private int subLevelIndex;
    private TrainingMissions missions;
    public AISampleBase aiSample => null;
    private CupMatchBase matchData => null;
    public GamePlayType gamePlayType => GamePlayType.Normal;
    public global::UnityEngine.Transform TutorialUI => null;
    public TouchInputSystem inputSystem => null;
    public bool IsSingleLevel => false;
    public bool IsAlive => false;

    internal void FilterInput(global::EngineMessages.InputData input)
    {
    }

    private void Awake()
    {
    }

    private void SendActiveEvent()
    {
    }

    private void Start()
    {
    }

    private void OnDestroy()
    {
    }

    private void Filter(global::System.Collections.Generic.List<ClubPlayer> players, global::System.Collections.Generic.List<FormationTool.UIPosition> positions)
    {
    }

    public void RegroupPlayers(AIMatchConfigurer.TrainingConfigure trainingConfig)
    {
    }

    private void StartMatch()
    {
    }

    public void DrawLimitArea(AIMatchConfigurer.TrainingConfigure config, int step)
    {
    }

    private void ResetConfig()
    {
    }

    private void StopMatch(global::System.Action callback)
    {
    }

    private void HandleMessage(AISampleBase.MessageBuffer message)
    {
    }

    public void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel to, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    public void ShowMissionInfo(string info)
    {
    }

    public void ShowMissionTips(bool show, string title, string content)
    {
    }

    private void CreateMission()
    {
    }

    public void DoNext()
    {
    }

    public void ResetCurrentStep(global::System.Action callback)
    {
    }

    public void Restart(global::System.Action callback)
    {
    }

    public void OnReplayEnd()
    {
    }

    public void OnReplayStart()
    {
    }

    public void UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail)
    {
    }

    public void ShowTimer(bool show)
    {
    }

    public void UpdateTimer(float time)
    {
    }

    private void FollowPlayer(global::UnityEngine.Transform target, global::UnityEngine.Vector3 playerPos)
    {
    }

    public void ShowFail(string text, global::System.Action callBack)
    {
    }

    public void ShowSuccess(global::System.Action callBack)
    {
    }

    public void ShowInput(bool show)
    {
    }

    public void EnableJoystickInput(bool enable)
    {
    }

    public void ShowSkipBtn(bool show)
    {
    }

    public void OnReplayReset()
    {
    }
}