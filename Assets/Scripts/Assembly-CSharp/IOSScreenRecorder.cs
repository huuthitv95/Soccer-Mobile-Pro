public class IOSScreenRecorder : MonoSingleton<IOSScreenRecorder>
{
    public global::UnityEngine.Events.UnityAction onStartRecord;
    public global::UnityEngine.Events.UnityAction onStopRecord;
    public global::UnityEngine.Events.UnityAction OnFailed;
    public global::UnityEngine.Events.UnityAction<string> onVideoPathQuery;
    private string LastPath;
    private static void _StartRecording()
    {
    }

    private static void _StopRecording()
    {
    }

    private static void _ShareRecording(string path)
    {
    }

    protected override void Initial()
    {
    }

    public void StartRecording()
    {
    }

    public void StopRecording()
    {
    }

    public void ShareRecording(string path)
    {
    }

    public void OnStartRecordingFailed(string error)
    {
    }

    public void OnStartRecordingSucceeded()
    {
    }

    public void OnStopRecording(string path)
    {
    }
}