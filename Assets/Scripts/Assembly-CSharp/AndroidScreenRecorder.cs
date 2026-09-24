public class AndroidScreenRecorder : MonoSingleton<AndroidScreenRecorder>
{
    private const float SCREEN_WIDTH = 720f;
    private const string VIDEO_NAME = "Record";
    private const string GALLERY_PATH = "/../../../../DCIM/VideoRecorders";
    public global::UnityEngine.Events.UnityAction onStartRecord;
    public global::UnityEngine.Events.UnityAction onStopRecord;
    public static global::UnityEngine.Events.UnityAction onAllowCallback;
    public static global::UnityEngine.Events.UnityAction onDenyCallback;
    public static global::UnityEngine.Events.UnityAction onDenyAndNeverAskAgainCallback;
    public global::UnityEngine.Events.UnityAction OnFailed;
    public global::UnityEngine.Events.UnityAction<string> onVideoPathQuery;
    private global::UnityEngine.AndroidJavaObject androidRecorder;
    private void Start()
    {
    }

    public void StartRecording()
    {
    }

    public void StopRecording()
    {
    }

    public void VideoRecorderCallback(string message)
    {
    }

    private void OnAllow()
    {
    }

    private void OnDeny()
    {
    }

    private void OnCancel()
    {
    }

    private void OnDenyAndNeverAskAgain()
    {
    }

    private void ResetAllCallBacks()
    {
    }

    public static bool IsPermitted(AndroidPermission permission)
    {
        return false;
    }

    public static void RequestPermission(AndroidPermission permission, global::UnityEngine.Events.UnityAction onAllow = null, global::UnityEngine.Events.UnityAction onDeny = null, global::UnityEngine.Events.UnityAction onDenyAndNeverAskAgain = null)
    {
    }

    private static string GetPermissionStrr(AndroidPermission permission)
    {
        return null;
    }

    public static void ShowToast(string message)
    {
    }

    public void OnVideoPathQuery(string path)
    {
    }

    public void ShareVideo()
    {
    }

    public static void ShareAndroid(string body, string subject, string url, string filePath, string mimeType, bool chooser, string chooserText)
    {
    }
}