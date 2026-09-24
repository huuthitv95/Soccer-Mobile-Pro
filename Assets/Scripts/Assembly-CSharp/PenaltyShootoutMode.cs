public class PenaltyShootoutMode : global::UnityEngine.MonoBehaviour, IMatch, ReplayHandler
{
    [global::UnityEngine.SerializeField]
    private AISampleBase agnet;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text leftTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text rightTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text homeScore;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text awayScore;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform homeMarks;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform awayMarks;
    private bool Pause;
    private global::System.Collections.Generic.List<int> homePenaltyScore;
    private global::System.Collections.Generic.List<int> awayPenaltyScore;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<bool, int>> homePlayerShootResult;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<bool, int>> awayPlayerShootResult;
    private bool needShowAd;
    private string adPosition;
    private AdsManager.InterstitialMode interstitialMode;
    private int playerId;
    private bool skipSplash;
    public GamePlayType gamePlayType => GamePlayType.Normal;
    public AISampleBase aiSample => null;
    private CupMatchBase matchData => null;

    private void Awake()
    {
    }

    private void CheckAudioAD()
    {
    }

    private void OnDestroy()
    {
    }

    private void Start()
    {
    }

    private void SendActiveEvent()
    {
    }

    private global::System.Collections.IEnumerator OnInit()
    {
        return null;
    }

    private void StartMatch()
    {
    }

    private void UpdateScoreboard()
    {
    }

    private void HandleMessage(AISampleBase.MessageBuffer message)
    {
    }

    private void UpdateSocreUI()
    {
    }

    public void OnReplayEnd()
    {
    }

    public void OnReplayReset()
    {
    }

    public void OnReplayStart()
    {
    }

    public void OnSwitchCameraModel(InGameCameraModel from, InGameCameraModel to, bool faceLeft, global::UnityEngine.Vector3 ballPos, bool isMy, int takerid)
    {
    }

    public void UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail)
    {
    }
}