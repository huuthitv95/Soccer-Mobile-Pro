public class ScreenRecorder : global::Common.Singleton<ScreenRecorder>
{
    public bool IsEnable()
    {
        return false;
    }

    public void Init()
    {
    }

    public void StartRecording(global::UnityEngine.Events.UnityAction OnStartRecord, global::UnityEngine.Events.UnityAction OnFailed)
    {
    }

    public void StopRecording(global::UnityEngine.Events.UnityAction OnStopRecord, global::UnityEngine.Events.UnityAction<string> OnPathQuery)
    {
    }

    public void ShareVideo()
    {
    }
}