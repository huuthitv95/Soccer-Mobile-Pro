public class Win_MatchRecorder : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text time;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage playerIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnCamera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPlay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnRestart;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSave;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform operationUI;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Video.VideoPlayer videoPlayer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnShare;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject recordingIcon;
    private HighlightSingleCycle highlightPlayer;
    private bool IsRecording;
    private int cameraMode;
    private bool playerCareerCamera;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    public void Fill(HighlightArchive.GoalReplay data, TestSample aiSample)
    {
    }

    private void Record()
    {
    }

    private void UpdateBtnPlayUI(bool playing)
    {
    }

    public void UpdateToNextCameraMode()
    {
    }

    private void UpdateCameraUI()
    {
    }

    public void OnQuitAction()
    {
    }

    public void OnCycleOver()
    {
    }

    private void OnPathQuery(string path)
    {
    }

    public void OnFirstFrame()
    {
    }
}